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
            Boton(sender);
            FrmDashboard dashboard = new FrmDashboard();
            dashboard.MdiParent = this;
            dashboard.Show();
        }

        private void BtnCatalogo_Click(object sender, EventArgs e)
        {
            Boton(sender);
            FrmCatalogo catalogo = new FrmCatalogo();
            catalogo.MdiParent = this;
            catalogo.Show();
        }

        private void BtnPrestamos_Click(object sender, EventArgs e)
        {
            Boton(sender);
            FrmPrestamos prestamos = new FrmPrestamos();
            prestamos.MdiParent = this;
            prestamos.Show();
        }

        private void BtnAdquisiciones_Click(object sender, EventArgs e)
        {
            Boton(sender);
            FrmAdquisiciones adquisiciones = new FrmAdquisiciones();
            adquisiciones.MdiParent = this;
            adquisiciones.Show();
        }

        private void BtnBibliotecarios_Click(object sender, EventArgs e)
        {
            Boton(sender);
            FrmMiembros miembros = new FrmMiembros();
            miembros.MdiParent = this;
            miembros.Show();
        }

        private void BtnMiembros_Click(object sender, EventArgs e)
        {
            Boton(sender);
            FrmAdministradores administradores = new FrmAdministradores();
            administradores.MdiParent = this;
            administradores.Show();
        }

        private void BtnAsistencia_Click(object sender, EventArgs e)
        {
            Boton(sender);
            FrmAsistencias asistencias = new FrmAsistencias();
            asistencias.MdiParent = this;
            asistencias.Show();
        }

        private void Boton (object senderBoton)
        {
            Color colorSeleccionado = Color.FromArgb(205, 173, 143);
            Color colorTool = Color.FromArgb(242, 242, 242);

            foreach (ToolStripItem item in toolStrip1.Items)
            {
                if (item is ToolStripButton)
                {
                    item.BackColor = colorTool;
                }
            }

            if (senderBoton is ToolStripButton boton)
            {
                boton.BackColor = colorSeleccionado;
            }
        }
    }
}
