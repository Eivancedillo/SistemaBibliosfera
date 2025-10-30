using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace AccesoDatos
{
    public class Base
    {
        MySqlConnection con;
        public Base()
        {
            con = new MySqlConnection($"server=localhost; port=3309; user=root; password=12345; database=db_Bibliosfera;");
        }

        public void Comando(string query, bool mantenerConexion = false)
        {
            try
            {
                if (con.State != ConnectionState.Open)
                    con.Open();

                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.ExecuteNonQuery();

                if (!mantenerConexion)
                    con.Close();
            }
            catch (Exception ex)
            {
                if (con.State == ConnectionState.Open)
                    con.Close();

                throw;
            }
        }

        public DataSet Consultar(string query, string table, bool mantenerConexion = false)
        {
            DataSet ds = new DataSet();
            try
            {
                if (con.State != ConnectionState.Open)
                    con.Open();

                MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                da.Fill(ds, table);

                if (!mantenerConexion)
                    con.Close();
            }
            catch (Exception ex)
            {
                if (con.State == ConnectionState.Open)
                    con.Close();

                throw;
            }

            return ds;
        }
    }
}