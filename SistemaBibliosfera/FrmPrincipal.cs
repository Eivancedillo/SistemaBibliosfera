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

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            FrmDashboard frmDashboard = new FrmDashboard();
            
            frmDashboard.Show();
        }

        private void BtnCatalogo_Click(object sender, EventArgs e)
        {
            FrmCatalogo frmCatalogo = new FrmCatalogo();
            //frmCatalogo.MdiParent = this;
            frmCatalogo.Show();
        }

        private void BtnPrestamos_Click(object sender, EventArgs e)
        {
            FrmPrestamos frmPrestamos = new FrmPrestamos();
            //frmPrestamos.MdiParent = this;
            frmPrestamos.Show();
        }

        private void BtnAdquisiciones_Click(object sender, EventArgs e)
        {
            FrmAdquisiciones frmAdquisiciones = new FrmAdquisiciones(); 
            //frmAdquisiciones.MdiParent = this;
            frmAdquisiciones.Show();
        }

        private void BtnMiembros_Click(object sender, EventArgs e)
        {
            FrmMiembros frmMiembros = new FrmMiembros();
            //frmMiembros.MdiParent = this;
            frmMiembros.Show();
        }

        private void BtnBibliotecarios_Click(object sender, EventArgs e)
        {
            FrmAdministradores frmAdministradores = new FrmAdministradores();
            //frmAdministradores.MdiParent = this;
            frmAdministradores.Show();
        }

        private void BtnAsistencia_Click(object sender, EventArgs e)
        {
            FrmAsistencias frmAsistencias = new FrmAsistencias();
            //frmAsistencias.MdiParent = this;
            frmAsistencias.Show();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
