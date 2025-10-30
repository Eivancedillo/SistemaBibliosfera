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
        ManejadorAsistencia Ma;
        public FrmAsistencias()
        {
            InitializeComponent();

            Ma = new ManejadorAsistencia();

            BtnRegistrar.Enabled = false;
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
                Ma.Mostrar(TxtNumControl, TxtNombre, TxtApellido, TxtEmail, TxtTelefono, BtnBuscar, BtnRegistrar);
            }
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            TxtNumControl.Text = "";
            TxtNombre.Text = "";
            TxtApellido.Text = "";
            TxtEmail.Text = "";
            TxtTelefono.Text = "";

            if(!BtnBuscar.Enabled)
                BtnBuscar.Enabled = true;
            if (BtnRegistrar.Enabled)
                BtnRegistrar.Enabled = false;
            if(!TxtNumControl.Enabled)
                TxtNumControl.Enabled = true;
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            Ma.Registrar(int.Parse(TxtNumControl.Text));

            TxtNumControl.Text = "";
            TxtNombre.Text = "";
            TxtApellido.Text = "";
            TxtEmail.Text = "";
            TxtTelefono.Text = "";

            if (!BtnBuscar.Enabled)
                BtnBuscar.Enabled = true;
            if (BtnRegistrar.Enabled)
                BtnRegistrar.Enabled = false;
            if (!TxtNumControl.Enabled)
                TxtNumControl.Enabled = true;

            MessageBox.Show("Asistencia registrada correctamente.", "Asistencia registrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
