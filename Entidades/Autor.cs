using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Autor
    {
        public Autor(int idAutor, string nombre)
        {
            IdAutor = idAutor;
            Nombre = nombre;
        }

        public int IdAutor { get; set; }
        public string Nombre { get; set; }

    }
}
