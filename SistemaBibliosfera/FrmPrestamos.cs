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
        ManejadorPermisos permisos;
        int columna = 0, fila = 0;
        public static Prestamo prestamo = new Prestamo(0, 0, 0, 0, DateTime.MinValue, DateTime.MinValue, DateTime.MinValue, "");
        public FrmPrestamos()
        {
            InitializeComponent();

            Mp = new ManejadorPrestamo();
            permisos = new ManejadorPermisos();

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

        private void DtgDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) 
                return;

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
                        if (prestamo.EstadoPrestamo.Equals("Adeudo"))
                        {   //Pagar
                            // Se abrira otro menu para pagar el prestamo
                            FrmPrestamosAdeudo frm = new FrmPrestamosAdeudo(prestamo.IdPrestamo);
                            frm.ShowDialog();
                            DtgDatos.Columns.Clear();
                        }
                        else
                        {
                            //Editar
                            if(!permisos.ComprobarPermiso(2, 3, FrmPrincipal.IdAdministrador))
                            {
                                MessageBox.Show("No tienes permiso para realizar esta acción.", "Permiso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }

                            FrmDatosPrestamos datosPrestamo = new FrmDatosPrestamos();
                            datosPrestamo.ShowDialog();
                            DtgDatos.Columns.Clear();
                        }
                    }
                    ; break;

                case 12:
                    {
                        if (!permisos.ComprobarPermiso(2, 4, FrmPrincipal.IdAdministrador))
                        {
                            MessageBox.Show("No tienes permiso para realizar esta acción.", "Permiso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        if (prestamo.EstadoPrestamo.Equals("Activo"))
                        {   //Cancelar
                            Mp.Cancelar(prestamo);

                            DtgDatos.Columns.Clear();
                        }
                    }
                    ; break;
                case 13:
                    {
                        if (!permisos.ComprobarPermiso(2, 4, FrmPrincipal.IdAdministrador))
                        {
                            MessageBox.Show("No tienes permiso para realizar esta acción.", "Permiso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        if (prestamo.EstadoPrestamo.Equals("Activo"))
                        {   //Finalizar
                            Mp.Finalizar(prestamo);

                            DtgDatos.Columns.Clear();
                        }
                    }; break;
            }
        }

        private void BtnBuscarr_Click(object sender, EventArgs e)
        {
            if(!permisos.ComprobarPermiso(2, 1, FrmPrincipal.IdAdministrador))
            {
                MessageBox.Show("No tienes permiso para realizar esta acción.", "Permiso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (CmbEstado.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un filtro para buscar.", "Estado no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (CmbEstado.SelectedItem.ToString().Equals("Activos"))
                Mp.Mostrar($"SELECT * FROM v_prestamos WHERE (Nombre LIKE '%{TxtBuscar.Text}%' OR NumeroControl LIKE '%{TxtBuscar.Text}%') AND EstadoPrestamo = 'Activo'", DtgDatos, "v_prestamos");
            else if (CmbEstado.SelectedItem.ToString().Equals("Cancelados"))
                Mp.Mostrar($"SELECT * FROM v_prestamos WHERE (Nombre LIKE '%{TxtBuscar.Text}%' OR NumeroControl LIKE '%{TxtBuscar.Text}%') AND EstadoPrestamo = 'Cancelado'", DtgDatos, "v_prestamos");
            else if (CmbEstado.SelectedItem.ToString().Equals("Finalizados"))
                Mp.Mostrar($"SELECT * FROM v_prestamos WHERE (Nombre LIKE '%{TxtBuscar.Text}%' OR NumeroControl LIKE '%{TxtBuscar.Text}%') AND EstadoPrestamo = 'Finalizado'", DtgDatos, "v_prestamos");
            else if (CmbEstado.SelectedItem.ToString().Equals("Adeudados"))
                Mp.Mostrar($"SELECT * FROM v_prestamos WHERE (Nombre LIKE '%{TxtBuscar.Text}%' OR NumeroControl LIKE '%{TxtBuscar.Text}%') AND EstadoPrestamo = 'Adeudo'", DtgDatos, "v_prestamos");
        }

        private void BtnAgregarr_Click(object sender, EventArgs e)
        {
            if(!permisos.ComprobarPermiso(2, 2, FrmPrincipal.IdAdministrador))
            {
                MessageBox.Show("No tienes permiso para realizar esta acción.", "Permiso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Limpiar entidad
            prestamo.IdPrestamo = 0;
            prestamo.NumeroControl = 0;
            prestamo.IdEjemplar = 0;
            prestamo.IdLibro = 0;
            prestamo.FechaPrestamo = DateTime.MinValue;
            prestamo.FechaDevolucionPrevista = DateTime.MinValue;
            prestamo.EstadoPrestamo = "";

            FrmDatosPrestamos frm = new FrmDatosPrestamos();
            frm.ShowDialog();
            DtgDatos.Columns.Clear();
        }

        private void DtgDatos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            columna = e.ColumnIndex; fila = e.RowIndex;
        }
    }
}
