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
    public partial class FrmEditoriales : Form
    {
        ManejadorAdquisicion mad;
        public static Editorial editorial = new Editorial(0, "");
        Libro libroBorrador;
        int fila = 0, columna = 0;
        public FrmEditoriales(Libro libro)
        {
            InitializeComponent();

            mad = new ManejadorAdquisicion();
            libroBorrador = libro;
            CmbEstado.Items.Add("Activos");
            CmbEstado.Items.Add("Inactivos");
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            editorial.IdEditorial = 0;
            editorial.Nombre = "";

            FrmDatosEditoriales frm = new FrmDatosEditoriales();
            frm.ShowDialog();
            DtgDatos.Columns.Clear();
        }

        private void DtgDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            editorial.IdEditorial = int.Parse(DtgDatos.Rows[fila].Cells["IdEditorial"].Value.ToString());
            editorial.Nombre = DtgDatos.Rows[fila].Cells["Nombre"].Value.ToString();

            DataGridViewRow filaActual = DtgDatos.Rows[e.RowIndex];

            switch (columna)
            {
                case 2:
                    {
                        // Seleccionar
                        Editorial ediSeleccionado = new Editorial(
                            int.Parse(filaActual.Cells["IdEditorial"].Value.ToString()),
                            filaActual.Cells["Nombre"].Value.ToString()
                        );

                        // Si el usuario está deseleccionando la editorial actual
                        if (libroBorrador.IdEditorial == ediSeleccionado.IdEditorial)
                        {
                            libroBorrador.IdEditorial = 0;

                            filaActual.DefaultCellStyle.BackColor = Color.Empty;
                        }
                        else
                        {
                            // Si el usuario está seleccionando una NUEVA editorial
                            foreach (DataGridViewRow row in DtgDatos.Rows)
                            {
                                int idGrid = int.Parse(row.Cells["IdEditorial"].Value.ToString());
                                if (idGrid == libroBorrador.IdEditorial) // <-- El ID viejo
                                {
                                    row.DefaultCellStyle.BackColor = Color.Empty;
                                    break;
                                }
                            }
                        }
                            libroBorrador.IdEditorial = ediSeleccionado.IdEditorial;

                            filaActual.DefaultCellStyle.BackColor = Color.LightGreen;
                        }
                        ; break;
                case 3:
                    {
                        //Editar
                        FrmDatosEditoriales datosEditoriales = new FrmDatosEditoriales();
                        datosEditoriales.ShowDialog();
                        DtgDatos.Columns.Clear();
                    }
                                ; break;
                case 4:
                    {
                        // Activar / Desactivar
                        bool estado = Convert.ToBoolean(DtgDatos.Rows[0].Cells["Activo"].Value);
                        if (estado)
                            mad.DesactivarE(editorial);
                        else
                            mad.ActivarE(editorial);

                        DtgDatos.Columns.Clear();
                    }
                                ; break;
            }
        }

        private void DtgDatos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            columna = e.ColumnIndex;
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (CmbEstado.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un estado para buscar.", "Estado no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (CmbEstado.Text.Equals("Activos"))
                mad.Mostrar($"SELECT * FROM Editoriales WHERE Nombre LIKE '%{TxtBuscar.Text}%' AND Activo = 1", DtgDatos, "Editoriales");
            else
                mad.Mostrar($"SELECT * FROM Editoriales WHERE Nombre LIKE '%{TxtBuscar.Text}%' AND Activo = 0", DtgDatos, "Editoriales");

            foreach (DataGridViewRow row in DtgDatos.Rows)
            {
                int idGrid = int.Parse(row.Cells["IdEditorial"].Value.ToString());

                // Compara el ID del grid con IdEditorial
                if (libroBorrador.IdEditorial == idGrid)
                {
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                }
            }
        }
    }
}
