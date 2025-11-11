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
    public partial class FrmDatosAutores : Form
    {
        ManejadorAdquisicion mad;
        public FrmDatosAutores()
        {
            InitializeComponent();

            mad = new ManejadorAdquisicion();
            if (FrmAutores.autor.IdAutor > 0)
            {
                TxtNombreAutor.Text = FrmAutores.autor.Nombre;
            }

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if(TxtNombreAutor.Text == "")
            {
                MessageBox.Show("El nombre del autor no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (FrmAutores.autor.IdAutor == 0)
            {
                mad.GuardarA(new Autor(0, TxtNombreAutor.Text));
            }
            else
            {
                mad.ModificarA(new Autor(FrmAutores.autor.IdAutor, TxtNombreAutor.Text));
            }

            Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

		private void label2_Click(object sender, EventArgs e)
		{

		}
	}
}
