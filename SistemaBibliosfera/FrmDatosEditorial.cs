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
    public partial class FrmDatosEditorial : Form
    {
        ManejadorAdquisicion mad;
        public FrmDatosEditorial()
        {
            InitializeComponent();
            mad = new ManejadorAdquisicion();
            if (FrmEditoriales.editorial.IdEditorial> 0)
            {
                TxtNombreEditorial.Text = FrmEditoriales.editorial.Nombre;
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (FrmEditoriales.editorial.IdEditorial == 0)
            {
                mad.GuardarE(new Editorial(0, TxtNombreEditorial.Text));
                MessageBox.Show("Editorial guardada correctamente", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                mad.ModificarE(new Editorial(FrmEditoriales.editorial.IdEditorial, TxtNombreEditorial.Text));
                MessageBox.Show("Editorial modificada correctamente", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
