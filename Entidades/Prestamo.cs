using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Prestamo
    {
        public int IdPrestamo { get; set; }
        public int NumeroControl { get; set; }
        public int IdEjemplar { get; set; }
        public string FechaPrestamo { get; set; }
        public string FechaDevolucionPrevista { get; set; }
        public string FechaDevolucionReal { get; set; }
        public string EstadoPrestamo { get; set; }
    }
}
