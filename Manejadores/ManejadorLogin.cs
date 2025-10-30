using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos;

namespace Manejadores
{
    public class ManejadorLogin
    {
        Base b = new Base();

        public bool Validar(TextBox usuario, TextBox clave)
        {
            DataTable dt = b.Consultar($"call validar('{usuario.Text}','{Sha1(clave.Text)}')", "usuarios").Tables[0];
            DataRow dr = dt.Rows[0];
            if (dr["rs"].ToString().Equals("Ac3ptad0"))
                return true;
            else
                return false;
        }

        public static string Sha1(string texto)
        {
            SHA1 sha1 = SHA1CryptoServiceProvider.Create();
            Byte[] textOriginal = ASCIIEncoding.Default.GetBytes(texto);
            Byte[] hash = sha1.ComputeHash(textOriginal);
            StringBuilder cadena = new StringBuilder();
            foreach (byte i in hash)
            {
                cadena.AppendFormat("{0:x2}", i);
            }
            return cadena.ToString();
        }
    }
}
