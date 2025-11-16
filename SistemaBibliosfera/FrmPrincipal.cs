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

namespace SistemaBibliosfera
{
    public partial class FrmPrincipal : Form
    {
        public static int IdAdministrador = 0;
        ManejadorPrestamo mp;
        public FrmPrincipal(int IdAdministradortraido)
        {
            InitializeComponent();
            mp = new ManejadorPrestamo();
            mp.AdeudarLibros();

            IdAdministrador = IdAdministradortraido;
        }

        private void BtnSalir_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
