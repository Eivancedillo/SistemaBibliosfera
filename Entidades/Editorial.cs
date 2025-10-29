using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Editorial
    {
        public Editorial(int idEditorial, string nombre)
        {
            IdEditorial = idEditorial;
            Nombre = nombre;
        }

        public int IdEditorial { get; set; }
        public string Nombre { get; set; }
    }
}
