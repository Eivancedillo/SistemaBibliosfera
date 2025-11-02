using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBibliosfera
{
    public partial class FrmAdquisiciones : Form
    {
        public FrmAdquisiciones()
        {
            InitializeComponent();
        }

        private void BtnVerCategorias_Click(object sender, EventArgs e)
        {
            FrmCatagorias frm = new FrmCatagorias();
            frm.ShowDialog();
        }

        private void BtnVerEditoriales_Click(object sender, EventArgs e)
        {
            FrmEditoriales frm = new FrmEditoriales();
            frm.ShowDialog();
        }

        private void BtnVerAutores_Click(object sender, EventArgs e)
        {
            FrmAutores frm = new FrmAutores();
            frm.ShowDialog();
        }
    }
}
