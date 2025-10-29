using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Administrador
    {
        public Administrador(int idAdministrador, string nombre, string password)
        {
            IdAdministrador = idAdministrador;
            Nombre = nombre;
            Password = password;
        }

        public int IdAdministrador { get; set; }
        public string Nombre { get; set; }
        public string Password { get; set; }
    }
}
