using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Prestamo
    {
        public Prestamo(int idPrestamo, int numeroControl, int idEjemplar, int idLibro, DateTime fechaPrestamo, DateTime fechaDevolucionPrevista, DateTime fechaDevolucionReal, string estadoPrestamo)
        {
            IdPrestamo = idPrestamo;
            NumeroControl = numeroControl;
            IdEjemplar = idEjemplar;
            IdLibro = idLibro;
            FechaPrestamo = fechaPrestamo;
            FechaDevolucionPrevista = fechaDevolucionPrevista;
            FechaDevolucionReal = fechaDevolucionReal;
            EstadoPrestamo = estadoPrestamo;
        }

        public int IdPrestamo { get; set; }
        public int NumeroControl { get; set; }
        public int IdEjemplar { get; set; }
        public int IdLibro { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public DateTime FechaDevolucionPrevista { get; set; }
        public DateTime FechaDevolucionReal { get; set; }
        public string EstadoPrestamo { get; set; }
    }
}
