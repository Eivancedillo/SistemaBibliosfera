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
    public partial class FrmDatosEditoriales : Form
    {
        ManejadorAdquisicion mad;
        public FrmDatosEditoriales()
        {
            InitializeComponent();
            mad = new ManejadorAdquisicion();

            if (FrmEditoriales.editorial.IdEditorial > 0)
            {
                TxtNombre.Text = FrmEditoriales.editorial.Nombre;
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (TxtNombre.Text == "")
            {
                MessageBox.Show("El nombre de la editorial no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (FrmEditoriales.editorial.IdEditorial == 0)
            {
                mad.GuardarE(new Editorial(0, TxtNombre.Text));
            }
            else
            {
                mad.ModificarE(new Editorial(FrmEditoriales.editorial.IdEditorial, TxtNombre.Text));
            }

            Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

		private void FrmDatosEditoriales_Load(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}
	}
}
