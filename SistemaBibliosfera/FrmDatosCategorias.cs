using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Manejadores;

namespace SistemaBibliosfera
{
    public partial class FrmDatosCategorias : Form
    {
        ManejadorAdquisicion mad;
        public FrmDatosCategorias()
        {
            InitializeComponent();

            mad = new ManejadorAdquisicion();
            if (FrmCatagorias.categoria.IdCategoria > 0)
            {
                TxtNombre.Text = FrmCatagorias.categoria.Nombre;
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (TxtNombre.Text == "")
            {
                MessageBox.Show("El nombre de la categoría no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (FrmCatagorias.categoria.IdCategoria == 0)
            {
                mad.GuardarC(new Categoria(0, TxtNombre.Text));
            }
            else
            {
                mad.ModificarC(new Categoria(FrmCatagorias.categoria.IdCategoria, TxtNombre.Text));
            }

            Close();
        }
    }
}
