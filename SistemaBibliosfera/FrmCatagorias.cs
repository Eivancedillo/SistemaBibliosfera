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
    public partial class FrmCatagorias : Form
    {
        ManejadorAdquisicion mad;
        public static Categoria categoria = new Categoria(0, "");
        Libro libroBorrador;
        int fila = 0, columna = 0;
        public FrmCatagorias(Libro libro)
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
            categoria.IdCategoria = 0;
            categoria.Nombre = "";

            FrmDatosCategorias frm = new FrmDatosCategorias();
            frm.ShowDialog();
            DtgDatos.Columns.Clear();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (CmbEstado.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un estado para buscar.", "Estado no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (CmbEstado.Text.Equals("Activos"))
                mad.Mostrar($"SELECT * FROM Categorias WHERE Nombre LIKE '%{TxtBuscar.Text}%' AND Activo = 1", DtgDatos, "Categorias");
            else
                mad.Mostrar($"SELECT * FROM Categorias WHERE Nombre LIKE '%{TxtBuscar.Text}%' AND Activo = 0", DtgDatos, "Categorias");

            foreach (DataGridViewRow row in DtgDatos.Rows)
            {
                int idGrid = int.Parse(row.Cells["IdCategoria"].Value.ToString());

                // Compara el ID del grid con la lista del libro
                if (libroBorrador.LibroCategoria.Any(c => c.IdCategoria == idGrid))
                {
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                }
            }
        }

        private void DtgDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            categoria.IdCategoria = int.Parse(DtgDatos.Rows[fila].Cells["IdCategoria"].Value.ToString());
            categoria.Nombre = DtgDatos.Rows[fila].Cells["Nombre"].Value.ToString();

            // Obtener la fila actual
            DataGridViewRow filaActual = DtgDatos.Rows[e.RowIndex];

            switch (columna)
            {
                case 2: // "Seleccionar"
                    {
                        Categoria catSeleccionada = new Categoria(
                            int.Parse(filaActual.Cells["IdCategoria"].Value.ToString()),
                            filaActual.Cells["Nombre"].Value.ToString()
                        );

                        // Buscamos si el objeto (por ID) YA ESTÁ en la lista del libro
                        //    Usamos 'FirstOrDefault' para encontrar el objeto EXACTO en la lista
                        Categoria objetoEnLista = libroBorrador.LibroCategoria
                            .FirstOrDefault(c => c.IdCategoria == catSeleccionada.IdCategoria);

                        if (objetoEnLista != null) // <-- Si es diferente de null, SÍ existe
                        {
                            libroBorrador.LibroCategoria.Remove(objetoEnLista);

                            filaActual.DefaultCellStyle.BackColor = Color.Empty;
                        }
                        else
                        {
                            libroBorrador.LibroCategoria.Add(catSeleccionada);

                            filaActual.DefaultCellStyle.BackColor = Color.LightGreen;
                        }
                    }; break;
                case 3:
                    {
                        //Editar
                        FrmDatosCategorias datosCategoria = new FrmDatosCategorias();
                        datosCategoria.ShowDialog();
                        DtgDatos.Columns.Clear();
                    }
                    ; break;
                case 4:
                    {
                        // Activar / Desactivar
                        bool estado = Convert.ToBoolean(DtgDatos.Rows[0].Cells["Activo"].Value);
                        if (estado)
                            mad.DesactivarC(categoria);
                        else
                            mad.ActivarC(categoria);

                        DtgDatos.Columns.Clear();
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
