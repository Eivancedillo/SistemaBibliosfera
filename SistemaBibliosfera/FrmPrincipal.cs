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


        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            FrmDashboard dashboard = new FrmDashboard();
            dashboard.MdiParent = this;
            dashboard.Show();
        }

        private void BtnCatalogo_Click(object sender, EventArgs e)
        {
            FrmCatalogo catalogo = new FrmCatalogo();
            catalogo.MdiParent = this;
            catalogo.Show();
        }

        private void BtnPrestamos_Click(object sender, EventArgs e)
        {
            FrmPrestamos prestamos = new FrmPrestamos();
            prestamos.MdiParent = this;
            prestamos.Show();
        }

        private void BtnAdquisiciones_Click(object sender, EventArgs e)
        {
            FrmAdquisiciones adquisiciones = new FrmAdquisiciones();
            adquisiciones.MdiParent = this;
            adquisiciones.Show();
        }

        private void BtnBibliotecarios_Click(object sender, EventArgs e)
        {
            FrmMiembros miembros = new FrmMiembros();
            miembros.MdiParent = this;
            miembros.Show();
        }

        private void BtnMiembros_Click(object sender, EventArgs e)
        {
            FrmAdministradores administradores = new FrmAdministradores();
            administradores.MdiParent = this;
            administradores.Show();
        }

        private void BtnAsistencia_Click(object sender, EventArgs e)
        {
            FrmAsistencias asistencias = new FrmAsistencias();
            asistencias.MdiParent = this;
            asistencias.Show();
        }

        private void Boton (object senderBoton)
        {
            Color colorSeleccionado = Color.FromArgb(205, 173, )
        }
    }
}
