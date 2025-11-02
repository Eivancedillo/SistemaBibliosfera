using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Libro
    {
        public Libro(int idLibro, string iSBN, string titulo, int idEditorial, DateTime anioPublicacion)
        {
            IdLibro = idLibro;
            ISBN = iSBN;
            Titulo = titulo;
            IdEditorial = idEditorial;
            AnioPublicacion = anioPublicacion;
        }

        public int IdLibro { get; set; }
        public string ISBN { get; set; }
        public string Titulo { get; set; }
        public int IdEditorial { get; set; }
        public DateTime AnioPublicacion { get; set; }

    }
}
