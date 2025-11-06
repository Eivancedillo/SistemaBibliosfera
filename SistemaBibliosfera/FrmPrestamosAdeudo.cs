using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manejadores;
using Entidades;

namespace SistemaBibliosfera
{
    public partial class FrmPrestamosAdeudo : Form
    {
        ManejadorPrestamo Mp;
        int IdMulta = 0, IdEjemplar = 0, IdPrestamo = 0;
        public FrmPrestamosAdeudo(int prestamo)
        {
            InitializeComponent();

            Mp = new ManejadorPrestamo();

            TxtMonto.Enabled = false; TxtFecha.Enabled = false; TxtLibro.Enabled = false; TxtCodigo.Enabled = false;

            IdPrestamo = prestamo;
            Mp.MostrarAdeudo(prestamo, out IdMulta, out IdEjemplar, TxtLibro, TxtCodigo, TxtFecha, TxtMonto);
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnPagar_Click(object sender, EventArgs e)
        {
            Mp.PagarAdeudos(IdMulta, IdEjemplar, IdPrestamo);
            Close();
        }
    }
}
