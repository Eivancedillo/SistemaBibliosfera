using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manejadores;

namespace SistemaBibliosfera
{
    public partial class FrmLogin : Form
    {
        ManejadorLogin Ml;
        int contador = 0;
        int IdAdministrador = 0;
        public FrmLogin()
        {
            InitializeComponent();
            Ml = new ManejadorLogin();
        }

        private void BtnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtUsuario.Text) || string.IsNullOrWhiteSpace(TxtContrasena.Text))
            {
                MessageBox.Show("¡Rellene todos los campos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Ml.Validar(TxtUsuario, TxtContrasena))
            {
                IdAdministrador = int.Parse(Ml.ConseguirIdAdministrador(TxtUsuario.Text));

                FrmPrincipal ia = new FrmPrincipal(IdAdministrador);
                ia.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Error de credenciales..");
                contador++;
                if (contador >= 2)
                {
                    MessageBox.Show("Sus credenciales se han bloqueado, espere 3 segundos");
                    TxtUsuario.Enabled = false;
                    TxtContrasena.Enabled = false;
                    Thread.Sleep(3000);//dormir el hilo principal
                    //despues de tipo habilitarlos
                    MessageBox.Show("Ahora puede continuar..");
                    TxtUsuario.Enabled = true;
                    TxtContrasena.Enabled = true;
                    contador = 0;

                }
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TxtUsuario_Click(object sender, EventArgs e)
        {
            TxtUsuario.Clear();
        }

        private void TxtContrasena_Enter(object sender, EventArgs e)
        {
            // Limpia el contenido del TextBox
            TxtContrasena.Clear();

            // Establece el carácter de máscara (PasswordChar)
            TxtContrasena.PasswordChar = '*';
        }
    }
}
