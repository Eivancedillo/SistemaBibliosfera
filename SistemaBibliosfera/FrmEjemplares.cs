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
    public partial class FrmEjemplares : Form
    {
        int fila = 0, columna = 0, IdLibro = 0;
        ManejadorEjemplares Me;
        public static Ejemplar ejemplar = new Ejemplar(0, 0, 0, "", "");
        public FrmEjemplares(int IdLibrotraido)
        {
            InitializeComponent();

            Me = new ManejadorEjemplares();

            Me.MostrarNombreEjemplar(IdLibrotraido, LblEjemplar);

            CmbEstado.Items.Clear();
            CmbEstado.Items.Add("Activos");
            CmbEstado.Items.Add("Inactivos");

            CmbEstado.SelectedIndex = 0;

            IdLibro = IdLibrotraido;
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (CmbEstado.SelectedItem == null)
                MessageBox.Show("Seleccione un estado para buscar.", "Estado no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (CmbEstado.Text.Equals("Activos"))
                    Me.Mostrar($"select * from Ejemplares where Activo = 1 and Codigo LIKE '%{TxtBuscar.Text}%'", DtgDatos, "Ejemplares");
                else
                    Me.Mostrar($"select * from Ejemplares where Activo = 0 and Codigo LIKE '%{TxtBuscar.Text}%'", DtgDatos, "Ejemplares");
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            // Vaciar datos para nuevo ejemplar
            ejemplar.IdEjemplar = 0;
            ejemplar.IdLibro = IdLibro;
            ejemplar.Codigo = 0;
            ejemplar.Estado = "";
            ejemplar.Ubicacion = "";

            FrmDatosEjemplares frm = new FrmDatosEjemplares();
            frm.ShowDialog();
            DtgDatos.Columns.Clear();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DtgDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ejemplar.IdEjemplar = Convert.ToInt32(DtgDatos.Rows[fila].Cells["IdEjemplar"].Value);
            ejemplar.IdLibro = IdLibro;
            ejemplar.Codigo = Convert.ToInt32(DtgDatos.Rows[fila].Cells["Codigo"].Value);
            ejemplar.Estado = DtgDatos.Rows[fila].Cells["Estado"].Value.ToString();
            ejemplar.Ubicacion = DtgDatos.Rows[fila].Cells["Ubicacion"].Value.ToString();

            switch (columna)
            {
                case 5:
                    {
                        FrmDatosEjemplares frm = new FrmDatosEjemplares();
                        frm.ShowDialog();
                        DtgDatos.Columns.Clear();
                    }
                    ; break;
                case 6:
                    {
                        bool activo = Convert.ToBoolean(DtgDatos.Rows[fila].Cells["Activo"].Value);
                        if (activo)
                        {
                            Me.DesactivarEjemplar(ejemplar.IdEjemplar);
                            DtgDatos.Columns.Clear();
                        }
                        else
                        {
                            Me.ActivarEjemplar(ejemplar.IdEjemplar);
                            DtgDatos.Columns.Clear();
                        }
                    }
                    ; break;
            }
        }

        private void DtgDatos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex; columna = e.ColumnIndex;
        }
    }
}
