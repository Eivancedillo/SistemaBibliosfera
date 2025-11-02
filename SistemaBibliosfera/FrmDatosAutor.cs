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
    public partial class FrmDatosAutor : Form
    {
        ManejadorAdquisicion mad;
        public FrmDatosAutor()
        {
            InitializeComponent();
            mad = new ManejadorAdquisicion();
            if (FrmAutores.autor.IdAutor > 0)
            {
                TxtNombreAutor.Text = FrmAutores.autor.Nombre;
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (FrmAutores.autor.IdAutor == 0)
            {
                mad.GuardarA(new Autor(0, TxtNombreAutor.Text));
                MessageBox.Show("Autor guardado correctamente", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                mad.ModificarA(new Autor(FrmAutores.autor.IdAutor, TxtNombreAutor.Text));
                MessageBox.Show("Autor modificada correctamente", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
