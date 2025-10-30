using AccesoDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Manejadores
{
    public class ManejadorAsistencia
    {
        Base b = new Base();

        public void Registrar(int NumeroControl)
        {
            b.Comando($"call p_insertar_asistencia({NumeroControl})");
        }

        public void Mostrar(TextBox NumeroControl, TextBox Nombre, TextBox Apellido, TextBox Email, TextBox Telefono, Button Borrar, Button Registro)
        {
            DataSet ds = b.Consultar($"SELECT Nombre, Apellidos, Email, Telefono FROM v_mostrar_miembro WHERE NumeroControl = {int.Parse(NumeroControl.Text)}", "v_mostrar_miembro");

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];

                Nombre.Text = dr["Nombre"].ToString();
                Apellido.Text = dr["Apellidos"].ToString();
                Email.Text = dr["Email"].ToString();
                Telefono.Text = dr["Telefono"].ToString();

                NumeroControl.Enabled = false;
                Borrar.Enabled = false;
                Registro.Enabled = true;
            }
            else
            {
                MessageBox.Show($"No se encontró ningún miembro con el Número de Control {int.Parse(NumeroControl.Text)}.", "Numero de control no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Nombre.Text = "";
                Apellido.Text = "";
                Email.Text = "";
                Telefono.Text = "";
            }
        }
    }
}
