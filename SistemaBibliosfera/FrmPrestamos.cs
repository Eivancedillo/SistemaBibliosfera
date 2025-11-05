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
    public partial class FrmPrestamos : Form
    {
        ManejadorPrestamo Mp;
        int columna = 0, fila = 0;
        public static Prestamo prestamo = new Prestamo(0, 0, 0, 0, DateTime.MinValue, DateTime.MinValue, DateTime.MinValue, "");
        public FrmPrestamos()
        {
            InitializeComponent();

            Mp = new ManejadorPrestamo();

            CmbEstado.Items.Add("Todos");
            CmbEstado.Items.Add("Activos");
            CmbEstado.Items.Add("Cancelados");
            CmbEstado.Items.Add("Finalizados");
            CmbEstado.Items.Add("Adeudados");

            CmbEstado.SelectedIndex = 0;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (CmbEstado.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un filtro para buscar.", "Estado no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (CmbEstado.SelectedItem.ToString().Equals("Todos"))
                Mp.Mostrar($"SELECT * FROM v_prestamos WHERE Nombre LIKE '%{TxtBuscar.Text}%' OR NumeroControl LIKE '%{TxtBuscar.Text}%'", DtgDatos, "v_prestamos");
            else if (CmbEstado.SelectedItem.ToString().Equals("Activos"))
                Mp.Mostrar($"SELECT * FROM v_prestamos WHERE (Nombre LIKE '%{TxtBuscar.Text}%' OR NumeroControl LIKE '%{TxtBuscar.Text}%') AND EstadoPrestamo = 'Activo'", DtgDatos, "v_prestamos");
            else if (CmbEstado.SelectedItem.ToString().Equals("Cancelados"))
                Mp.Mostrar($"SELECT * FROM v_prestamos WHERE (Nombre LIKE '%{TxtBuscar.Text}%' OR NumeroControl LIKE '%{TxtBuscar.Text}%') AND EstadoPrestamo = 'Cancelado'", DtgDatos, "v_prestamos");
            else if (CmbEstado.SelectedItem.ToString().Equals("Finalizados"))
                Mp.Mostrar($"SELECT * FROM v_prestamos WHERE (Nombre LIKE '%{TxtBuscar.Text}%' OR NumeroControl LIKE '%{TxtBuscar.Text}%') AND EstadoPrestamo = 'Finalizado'", DtgDatos, "v_prestamos");
            else if (CmbEstado.SelectedItem.ToString().Equals("Adeudados"))
                Mp.Mostrar($"SELECT * FROM v_prestamos WHERE (Nombre LIKE '%{TxtBuscar.Text}%' OR NumeroControl LIKE '%{TxtBuscar.Text}%') AND EstadoPrestamo = 'Adeudado'", DtgDatos, "v_prestamos");
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            // Limpiar entidad

            FrmDatosPrestamos frm = new FrmDatosPrestamos();
            frm.ShowDialog();
            DtgDatos.Columns.Clear();
        }

        private void DtgDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            prestamo.IdPrestamo = Convert.ToInt32(DtgDatos.Rows[e.RowIndex].Cells["IdPrestamo"].Value);
            prestamo.NumeroControl = Convert.ToInt32(DtgDatos.Rows[e.RowIndex].Cells["NumeroControl"].Value);
            prestamo.IdEjemplar = Convert.ToInt32(DtgDatos.Rows[e.RowIndex].Cells["IdEjemplar"].Value);
            prestamo.IdLibro = Convert.ToInt32(DtgDatos.Rows[e.RowIndex].Cells["IdLibro"].Value);
            prestamo.FechaPrestamo = Convert.ToDateTime(DtgDatos.Rows[e.RowIndex].Cells["FechaPrestamo"].Value);
            prestamo.FechaDevolucionPrevista = Convert.ToDateTime(DtgDatos.Rows[e.RowIndex].Cells["FechaDevolucionPrevista"].Value);
            prestamo.EstadoPrestamo = DtgDatos.Rows[e.RowIndex].Cells["EstadoPrestamo"].Value.ToString();

            switch (columna)
            {
                case 11:
                    {
                        //Editar
                        FrmDatosPrestamos datosPrestamo = new FrmDatosPrestamos();
                        datosPrestamo.ShowDialog();
                        DtgDatos.Columns.Clear();
                    }
                    ; break;

                case 12:
                    {
                        if (prestamo.EstadoPrestamo.Equals("Activo"))
                        {   //Cancelar
                            var rs = MessageBox.Show("¿Está seguro de que desea cancelar este préstamo? Esta acción no se puede deshacer.", "Confirmar cancelación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                            if (rs == DialogResult.Yes)
                                Mp.Cancelar(prestamo);

                            DtgDatos.Columns.Clear();
                        }

                        if(prestamo.EstadoPrestamo.Equals("Adeudado"))
                        {   //Pagar
                            // Se abrira otro menu para pagar el prestamo
                            var rs = MessageBox.Show("¿Desea marcar este préstamo como pagado?", "Confirmar pago", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (rs == DialogResult.Yes)
                                Mp.Pagar(prestamo);
                        }
                    }
                    ; break;
                case 13:
                    {
                        if (prestamo.EstadoPrestamo.Equals("Activo"))
                        {   //Finalizar
                            var rs = MessageBox.Show("¿Está seguro de que desea finalizar este préstamo? Esta acción no se puede deshacer.", "Confirmar finalización", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                            if (rs == DialogResult.Yes)
                                Mp.Finalizar(prestamo);

                            DtgDatos.Columns.Clear();
                        }
                    }; break;
            }
        }

        private void DtgDatos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            columna = e.ColumnIndex; fila = e.RowIndex;
        }
    }
}
