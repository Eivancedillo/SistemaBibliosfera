using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Autor
    {
        public Autor(int idAutor, string nombreAutor)
        {
            IdAutor = idAutor;
            NombreAutor = nombreAutor;
        }

        public int IdAutor { get; set; }
        public string NombreAutor { get; set; }

    }
}
