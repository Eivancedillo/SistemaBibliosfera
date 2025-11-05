using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ejemplar
    {
        public Ejemplar(int idEjemplar, int idLibro, int codigo, string estado, string ubicacion)
        {
            IdEjemplar = idEjemplar;
            IdLibro = idLibro;
            Codigo = codigo;
            Estado = estado;
            Ubicacion = ubicacion;
        }

        public int IdEjemplar { get; set; }
        public int IdLibro { get; set; }
        public int Codigo { get; set; }
        public string Estado { get; set; }
        public string Ubicacion { get; set; }
    }
}
