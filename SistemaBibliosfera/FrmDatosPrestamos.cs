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
    public partial class FrmDatosPrestamos : Form
    {
        ManejadorPrestamo Mp;
        public static Miembro miembroprestamo = new Miembro(0, "", "", "", "", true);
        public static Ejemplar ejemplarprestamo = new Ejemplar(0, 0, 0, "", "");
        public static Libro libroejemplar = new Libro(0, "", "", 0, 0, new List<Autor>(), new List<Categoria>());

        public FrmDatosPrestamos()
        {
            InitializeComponent();

            Mp = new ManejadorPrestamo();

            CmbEstado.Items.Add("Activo");
            CmbEstado.Items.Add("Cancelado");
            CmbEstado.Items.Add("Finalizado");
            CmbEstado.Items.Add("Adeudado");

            CmbEstado.SelectedIndex = 0;

            TxtNumControl.Enabled = false; TxtLibro.Enabled = false; TxtEjemplar.Enabled = false; CmbEstado.Enabled = false; TxtNombre.Enabled = false;

            if (FrmPrestamos.prestamo.IdPrestamo > 0)
            {
                // Cargar los datos del préstamo existente
                TxtNumControl.Text = FrmPrestamos.prestamo.NumeroControl.ToString();
                Mp.MostrarNombreMiembro(FrmPrestamos.prestamo.NumeroControl, TxtNombre);
                Mp.MostrarNombreLibro(FrmPrestamos.prestamo.IdLibro, TxtLibro);
                Mp.MostrarCodigoEjemplar(FrmPrestamos.prestamo.IdEjemplar, TxtEjemplar);
                DtpFechaDevolucion.Value = FrmPrestamos.prestamo.FechaDevolucionPrevista;

                // Deshabilitar los campos que no se deben editar
                BtnBuscarNumControl.Enabled = false; BtnBuscarEjemplar.Enabled = false;

                // Habilitar el estado del préstamo
                CmbEstado.Enabled = true;

                CmbEstado.SelectedItem = FrmPrestamos.prestamo.EstadoPrestamo;
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            string numControl = TxtNumControl.Text;

            if (string.IsNullOrWhiteSpace(TxtNumControl.Text) || string.IsNullOrWhiteSpace(TxtLibro.Text) || string.IsNullOrWhiteSpace(TxtEjemplar.Text) || string.IsNullOrWhiteSpace(TxtNombre.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos antes de continuar.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Mp.TieneAdeudosPendientes(int.Parse(numControl)))
            {
                MessageBox.Show($"El miembro con número de control '{numControl}' tiene adeudos pendientes.\n\nDebe cubrirlos antes de poder solicitar un nuevo préstamo.",
                                "Préstamo Denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (FrmPrestamos.prestamo.IdPrestamo == 0)
            {
                // Insertar nuevo préstamo
                Mp.Insertar(new Prestamo(0, miembroprestamo.NumeroControl, ejemplarprestamo.IdEjemplar, ejemplarprestamo.IdLibro, DateTime.Now, DtpFechaDevolucion.Value, DateTime.MinValue, "Activo"));
                // Cambiar el estado del ejemplar a prestado
                Mp.Prestar(new Prestamo(0, miembroprestamo.NumeroControl, ejemplarprestamo.IdEjemplar, ejemplarprestamo.IdLibro, DateTime.Now, DtpFechaDevolucion.Value, DateTime.MinValue, "Activo"));
            }
            else
            {
                // Editar préstamo existente
                Mp.Editar(new Prestamo(FrmPrestamos.prestamo.IdPrestamo, FrmPrestamos.prestamo.NumeroControl, FrmPrestamos.prestamo.IdEjemplar, FrmPrestamos.prestamo.IdLibro, FrmPrestamos.prestamo.FechaPrestamo, DtpFechaDevolucion.Value, FrmPrestamos.prestamo.FechaDevolucionReal, CmbEstado.SelectedItem.ToString()));
            }

            Close();
        }

        private void BtnBuscarNumControl_Click(object sender, EventArgs e)
        {
            TxtNumControl.Text = "";
            // Abriremos frmMiembros para seleccionar un miembro
            FrmMiembros frm = new FrmMiembros(true);
            frm.ShowDialog();

            // Comprobar si se seleccionó un miembro
            if (miembroprestamo.NumeroControl == 0)
                return;

            TxtNumControl.Text = miembroprestamo.NumeroControl.ToString();
            TxtNombre.Text = miembroprestamo.Nombre + " " + miembroprestamo.Apellidos;
        }

        private void BtnBuscarEjemplar_Click(object sender, EventArgs e)
        {
            TxtLibro.Text = ""; TxtEjemplar.Text = "";
            // Abrimos frmCatalogo para seleccionar un libro
            FrmCatalogo frm = new FrmCatalogo(true);
            frm.ShowDialog();

            // Comprobar si se seleccionó un libro
            if (libroejemplar.IdLibro == 0)
                return;

            // Abrimos frmEjemplares para seleccionar un ejemplar
            FrmEjemplares frmejem = new FrmEjemplares(true, libroejemplar.IdLibro);
            frmejem.ShowDialog();

            // Comprobar si se seleccionó un ejemplar
            if (ejemplarprestamo.IdEjemplar == 0)
                return;

            TxtLibro.Text = ejemplarprestamo.IdLibro.ToString();
            TxtEjemplar.Text = ejemplarprestamo.Codigo.ToString("D3");
        }
    }
}
