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
        ManejadorPermisos permisos;
        private ToolStripButton botonActivoActual = null;

        public FrmPrincipal(int IdAdministradortraido)
        {
            InitializeComponent();
            mp = new ManejadorPrestamo();
            permisos = new ManejadorPermisos();
            mp.AdeudarLibros();

            Task.Run(() =>
            {
                // Esto ocurre en un hilo separado para no trabar la pantalla
                mp.EnviarRecordatoriosAutomaticos();
            });

            IdAdministrador = IdAdministradortraido;
            
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            MdiClient mdiClient = null;

            foreach (Control control in this.Controls)
            {
                if (control is MdiClient)
                {
                    mdiClient = (MdiClient)control;
                    break;
                }
            }

            if (mdiClient != null)
            {
                mdiClient.BackColor = Color.White;

            }
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
            if(permisos.ComprobarAcceso(1, IdAdministrador))
            {
                Boton(sender);
                FrmCatalogo catalogo = new FrmCatalogo();
                catalogo.MdiParent = this;
                catalogo.Show();
            }
            else
            {
                MessageBox.Show("No tienes permiso para acceder a esta sección.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnPrestamos_Click(object sender, EventArgs e)
        {
            if(permisos.ComprobarAcceso(2, IdAdministrador))
            {
                Boton(sender);
                FrmPrestamos prestamos = new FrmPrestamos();
                prestamos.MdiParent = this;
                prestamos.Show();
            }
            else
            {
                MessageBox.Show("No tienes permiso para acceder a esta sección.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnAdquisiciones_Click(object sender, EventArgs e)
        {
            if (permisos.ComprobarAcceso(3, IdAdministrador))
            {
                Boton(sender);
                FrmAdquisiciones adquisiciones = new FrmAdquisiciones();
                adquisiciones.MdiParent = this;
                adquisiciones.Show();
            }
            else
            {
                MessageBox.Show("No tienes permiso para acceder a esta sección.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnBibliotecarios_Click(object sender, EventArgs e)
        {
            if(permisos.ComprobarAcceso(4, IdAdministrador))
            {
                Boton(sender);
                FrmMiembros miembros = new FrmMiembros();
                miembros.MdiParent = this;
                miembros.Show();
            }
            else
            {
                MessageBox.Show("No tienes permiso para acceder a esta sección.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnMiembros_Click(object sender, EventArgs e)
        {
            if(permisos.ComprobarAcceso(5, IdAdministrador))
            {
                Boton(sender);
                FrmAdministradores administradores = new FrmAdministradores();
                administradores.MdiParent = this;
                administradores.Show();
            }
            else
            {
                MessageBox.Show("No tienes permiso para acceder a esta sección.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnAsistencia_Click(object sender, EventArgs e)
        {
            if(permisos.ComprobarAcceso(6, IdAdministrador))
            {
                Boton(sender);
                FrmAsistencias asistencias = new FrmAsistencias();
                asistencias.MdiParent = this;
                asistencias.Show();
            }
            else
            {
                MessageBox.Show("No tienes permiso para acceder a esta sección.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnDashboard_MouseEnter(object sender, EventArgs e)
        {
            Color colorHover = Color.FromArgb(205, 173, 143);
            ToolStripButton botonFlotante = (ToolStripButton) sender;

            botonFlotante.BackColor = colorHover;
        }

        private void BtnDashboard_MouseLeave(object sender, EventArgs e)
        {
            Color colorNormal = Color.FromArgb(242, 242, 242);
            ToolStripButton botonFlotante = (ToolStripButton)sender;

            if (botonFlotante != botonActivoActual)
            {
                botonFlotante.BackColor = colorNormal;
            }
        }

        private void BtnCatalogo_MouseEnter(object sender, EventArgs e)
        {
            Color colorHover = Color.FromArgb(205, 173, 143);
            ToolStripButton botonFlotante = (ToolStripButton)sender;

            botonFlotante.BackColor = colorHover;

        }

        private void BtnCatalogo_MouseLeave(object sender, EventArgs e)
        {
            Color colorNormal = Color.FromArgb(242, 242, 242);
            ToolStripButton botonFlotante = (ToolStripButton)sender;

            if (botonFlotante != botonActivoActual)
            {
                botonFlotante.BackColor = colorNormal;
            }
        }

        private void BtnPrestamos_MouseEnter(object sender, EventArgs e)
        {
            Color colorHover = Color.FromArgb(205, 173, 143);
            ToolStripButton botonFlotante = (ToolStripButton)sender;

            botonFlotante.BackColor = colorHover;
        }

        private void BtnPrestamos_MouseLeave(object sender, EventArgs e)
        {
            Color colorNormal = Color.FromArgb(242, 242, 242);
            ToolStripButton botonFlotante = (ToolStripButton)sender;

            if (botonFlotante != botonActivoActual)
            {
                botonFlotante.BackColor = colorNormal;
            }
        }

        private void BtnAdquisiciones_MouseEnter(object sender, EventArgs e)
        {
            Color colorHover = Color.FromArgb(205, 173, 143);
            ToolStripButton botonFlotante = (ToolStripButton)sender;

            botonFlotante.BackColor = colorHover;
        }

        private void BtnAdquisiciones_MouseLeave(object sender, EventArgs e)
        {
            Color colorNormal = Color.FromArgb(242, 242, 242);
            ToolStripButton botonFlotante = (ToolStripButton)sender;

            if (botonFlotante != botonActivoActual)
            {
                botonFlotante.BackColor = colorNormal;
            }
        }

        private void BtnBibliotecarios_MouseEnter(object sender, EventArgs e)
        {
            Color colorHover = Color.FromArgb(205, 173, 143);
            ToolStripButton botonFlotante = (ToolStripButton)sender;

            botonFlotante.BackColor = colorHover;
        }

        private void BtnBibliotecarios_MouseLeave(object sender, EventArgs e)
        {
            Color colorNormal = Color.FromArgb(242, 242, 242);
            ToolStripButton botonFlotante = (ToolStripButton)sender;

            if (botonFlotante != botonActivoActual)
            {
                botonFlotante.BackColor = colorNormal;
            }
        }

        private void BtnMiembros_MouseEnter(object sender, EventArgs e)
        {
            Color colorHover = Color.FromArgb(205, 173, 143);
            ToolStripButton botonFlotante = (ToolStripButton)sender;

            botonFlotante.BackColor = colorHover;
        }

        private void BtnMiembros_MouseLeave(object sender, EventArgs e)
        {
            Color colorNormal = Color.FromArgb(242, 242, 242);
            ToolStripButton botonFlotante = (ToolStripButton)sender;

            if (botonFlotante != botonActivoActual)
            {
                botonFlotante.BackColor = colorNormal;
            }
        }

        private void BtnAsistencia_MouseEnter(object sender, EventArgs e)
        {
            Color colorHover = Color.FromArgb(205, 173, 143);
            ToolStripButton botonFlotante = (ToolStripButton)sender;

            botonFlotante.BackColor = colorHover;
        }

        private void BtnAsistencia_MouseLeave(object sender, EventArgs e)
        {
            Color colorNormal = Color.FromArgb(242, 242, 242);
            ToolStripButton botonFlotante = (ToolStripButton)sender;

            if (botonFlotante != botonActivoActual)
            {
                botonFlotante.BackColor = colorNormal;
            }
        }

        private void Boton(object senderBoton)
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
                botonActivoActual = boton;
            }
        }
    }
}
