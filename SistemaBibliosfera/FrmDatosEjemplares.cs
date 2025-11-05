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
using Entidades;

namespace SistemaBibliosfera
{
    public partial class FrmDatosEjemplares : Form
    {
        ManejadorEjemplares Me;
        public FrmDatosEjemplares()
        {
            InitializeComponent();

            Me = new ManejadorEjemplares();

            CmbEstado.Items.Add("Disponible");
            CmbEstado.Items.Add("Prestado");
            CmbEstado.Items.Add("Reparacion");
            CmbEstado.Items.Add("Perdido");

            if (FrmEjemplares.ejemplar.IdEjemplar > 0)
            {
                TxtCodigo.Text = FrmEjemplares.ejemplar.Codigo.ToString();
                CmbEstado.SelectedItem = FrmEjemplares.ejemplar.Estado;
                TxtUbicacion.Text = FrmEjemplares.ejemplar.Ubicacion;
            }
            else
            {
                CmbEstado.SelectedIndex = 0;
                CmbEstado.Enabled = false;
            }

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtCodigo.Text) || string.IsNullOrWhiteSpace(CmbEstado.Text) ||
                string.IsNullOrWhiteSpace(TxtUbicacion.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (TxtCodigo.Text.Any(x => !char.IsDigit(x)))
            {
                MessageBox.Show("El Código debe ser un valor numérico.", "Valor no numérico", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (FrmEjemplares.ejemplar.IdEjemplar == 0)
            {
                Me.InsertarEjemplar(new Ejemplar(0, FrmEjemplares.ejemplar.IdLibro, int.Parse(TxtCodigo.Text),
                    CmbEstado.Text, TxtUbicacion.Text));
            }
            else
            {
                Me.EditarEjemplar(new Ejemplar(FrmEjemplares.ejemplar.IdEjemplar, FrmEjemplares.ejemplar.IdLibro,
                    int.Parse(TxtCodigo.Text), CmbEstado.Text, TxtUbicacion.Text));
            }

            Close();
        }
    }
}
