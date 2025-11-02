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
    public partial class FrmDatosCategoria : Form
    {
        ManejadorAdquisicion mad;
        public FrmDatosCategoria()
        {
            InitializeComponent();
            mad = new ManejadorAdquisicion();
            if (FrmCategorias.categoria.IdCategoria > 0)
            {
                TxtNombreCategoria.Text = FrmCategorias.categoria.Nombre;
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (FrmCategorias.categoria.IdCategoria == 0)
            {
                mad.GuardarC(new Categoria(0,TxtNombreCategoria.Text));
                MessageBox.Show("Categoría guardada correctamente", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                mad.ModificarC(new Categoria(FrmCategorias.categoria.IdCategoria, TxtNombreCategoria.Text));
                MessageBox.Show("Categoría modificada correctamente", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
