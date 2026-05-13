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
    public partial class FrmAsistencias : Form
    {
        private ManejadorAsistencia Ma;
        private ManejadorPermisos permisos;

        public FrmAsistencias()
        {
            InitializeComponent();

            Ma = new ManejadorAsistencia();
            permisos = new ManejadorPermisos();

            // ---> CAMBIO 1: En lugar de Enabled = false, usamos nuestro método
            EstadoBtnRegistrar(false);
        }

        // ---> CAMBIO 2: Creamos este método para controlar el color y estado del botón
        private void EstadoBtnRegistrar(bool activo)
        {
            if (activo)
            {
                BtnRegistrar.Tag = "Activo";
                BtnRegistrar.BackColor = Color.FromArgb(131, 153, 88); // Pon tu color verde normal aquí
                BtnRegistrar.ForeColor = Color.White; // Color de letra normal
                BtnRegistrar.Cursor = Cursors.Hand;
            }
            else
            {
                BtnRegistrar.Tag = "Deshabilitado";
                BtnRegistrar.BackColor = Color.LightGray; // Color de fondo inactivo
                BtnRegistrar.ForeColor = Color.DarkGray; // Color de letra inactivo (¡Cámbialo a tu gusto!)
                BtnRegistrar.Cursor = Cursors.Default;
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (TxtNumControl.Text.Equals(""))
            {
                MessageBox.Show("Por favor, coloque un numero de control.", "Numero de control vacio", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                TxtNombre.Text = "";
                TxtApellido.Text = "";
                TxtEmail.Text = "";
                TxtTelefono.Text = "";
            }
            else
            {
                // ---> ¡OJO AQUÍ! Lee la nota importante debajo del código sobre esta línea
                Ma.Mostrar(TxtNumControl, TxtNombre, TxtApellido, TxtEmail, TxtTelefono, BtnBuscar, BtnRegistrar);

                EstadoBtnRegistrar(true); // Activamos el botón "Registrar" después de una búsqueda exitosa
            }
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            TxtNumControl.Text = "";
            TxtNombre.Text = "";
            TxtApellido.Text = "";
            TxtEmail.Text = "";
            TxtTelefono.Text = "";

            if (!BtnBuscar.Enabled)
                BtnBuscar.Enabled = true;

            // ---> CAMBIO 3: Actualizamos la forma en que "apagamos" el botón
            EstadoBtnRegistrar(false);

            if (!TxtNumControl.Enabled)
                TxtNumControl.Enabled = true;
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            // ---> CAMBIO 4: Si el botón está "falsamente deshabilitado", ignoramos el clic
            if (BtnRegistrar.Tag != null && BtnRegistrar.Tag.ToString() == "Deshabilitado")
            {
                return;
            }

            if (!permisos.ComprobarPermiso(6, 2, FrmPrincipal.IdAdministrador))
            {
                MessageBox.Show("No tienes permiso para realizar esta accion.", "Permiso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Ma.Registrar(int.Parse(TxtNumControl.Text));

            TxtNumControl.Text = "";
            TxtNombre.Text = "";
            TxtApellido.Text = "";
            TxtEmail.Text = "";
            TxtTelefono.Text = "";

            if (!BtnBuscar.Enabled)
                BtnBuscar.Enabled = true;

            // ---> CAMBIO 5: Actualizamos la forma en que "apagamos" el botón
            EstadoBtnRegistrar(false);

            if (!TxtNumControl.Enabled)
                TxtNumControl.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}