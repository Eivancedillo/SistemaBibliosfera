using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Manejadores;

namespace SistemaBibliosfera
{
    public partial class FrmDatosMiembro : Form
    {
        ManejadorMiembros Mm;
        public FrmDatosMiembro()
        {
            InitializeComponent();
            Mm = new ManejadorMiembros();

            if (FrmMiembros.miembro.NumeroControl > 0)
            {
                TxtNumControl.Text = FrmMiembros.miembro.NumeroControl.ToString();
                TxtNombre.Text = FrmMiembros.miembro.Nombre.ToString();
                TxtApellido.Text = FrmMiembros.miembro.Apellidos.ToString();
                TxtEmail.Text = FrmMiembros.miembro.Email.ToString();
                TxtTelefono.Text = FrmMiembros.miembro.Telefono.ToString();

                TxtNumControl.Enabled = false;
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtNumControl.Text) || string.IsNullOrWhiteSpace(TxtNombre.Text) ||
                string.IsNullOrWhiteSpace(TxtApellido.Text) || string.IsNullOrWhiteSpace(TxtEmail.Text) ||
                string.IsNullOrWhiteSpace(TxtTelefono.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(TxtNumControl.Text.Any(x => !char.IsDigit(x)))
            {
                MessageBox.Show("El Número de Control debe ser un valor numérico.", "Valor no numérico", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (FrmMiembros.miembro.NumeroControl == 0)
            {
                Mm.Insertar(new Miembro(int.Parse(TxtNumControl.Text), TxtNombre.Text, TxtApellido.Text, 
                    TxtEmail.Text, TxtTelefono.Text, true));
            }
            else
            {
                Mm.Editar(new Miembro(FrmMiembros.miembro.NumeroControl, TxtNombre.Text, TxtApellido.Text,
                    TxtEmail.Text, TxtTelefono.Text, true));
            }

            Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
