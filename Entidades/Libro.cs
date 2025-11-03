using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Libro
    {
        public Libro(int idLibro, string iSBN, string titulo, int idEditorial, int anioPublicacion, List<Autor> libroAutores, List<Categoria> libroCategoria)
        {
            IdLibro = idLibro;
            ISBN = iSBN;
            Titulo = titulo;
            IdEditorial = idEditorial;
            AnioPublicacion = anioPublicacion;
            LibroAutores = libroAutores;
            LibroCategoria = libroCategoria;
        }

        public int IdLibro { get; set; }
        public string ISBN { get; set; }
        public string Titulo { get; set; }
        public int IdEditorial { get; set; }
        public int AnioPublicacion { get; set; }

        public List<Autor> LibroAutores { get; set; }
        public List<Categoria> LibroCategoria { get; set; }

    }
}
