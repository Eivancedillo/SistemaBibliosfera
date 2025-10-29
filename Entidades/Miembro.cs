using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Miembro
    {
        public Miembro(int numeroControl, string nombre, string apellidos, string email, string telefono, bool estado)
        {
            NumeroControl = numeroControl;
            Nombre = nombre;
            Apellidos = apellidos;
            Email = email;
            Telefono = telefono;
            Estado = estado;
        }

        public int NumeroControl { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public bool Estado { get; set; }
    }
}
