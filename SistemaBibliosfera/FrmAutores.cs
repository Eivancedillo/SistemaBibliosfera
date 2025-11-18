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
    public partial class FrmAutores : Form
    {
        ManejadorAdquisicion mad;
        public static Autor autor = new Autor(0, "");
        Libro libroBorrador;
        int fila = 0, columna = 0;

        public FrmAutores(Libro libro)
        {
            InitializeComponent();

            mad = new ManejadorAdquisicion();
            libroBorrador = libro;

            CmbEstado.Items.Add("Activos");
            CmbEstado.Items.Add("Inactivos");

            CmbEstado.SelectedIndex = 0;
        }

        private void DtgDatos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex; columna = e.ColumnIndex;
        }

        private void DtgDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            autor.IdAutor = int.Parse(DtgDatos.Rows[fila].Cells["IdAutor"].Value.ToString());
            autor.Nombre = DtgDatos.Rows[fila].Cells["Autor"].Value.ToString();

            // Obtener la fila actual
            DataGridViewRow filaActual = DtgDatos.Rows[e.RowIndex];

            switch (columna)
            {
                case 2:
                    {

                        Autor autSeleccionado = new Autor(
                            int.Parse(filaActual.Cells["IdAutor"].Value.ToString()),
                            filaActual.Cells["Autor"].Value.ToString()
                        );

                        // 2. Buscamos si el objeto (por ID) YA ESTÁ en la lista del libro
                        //    Usamos 'FirstOrDefault' para encontrar el objeto EXACTO en la lista
                        Autor objetoEnLista = libroBorrador.LibroAutores
                            .FirstOrDefault(c => c.IdAutor == autSeleccionado.IdAutor);


                        if (objetoEnLista != null) // <-- Si es diferente de null, SÍ existe
                        {
                            libroBorrador.LibroAutores.Remove(objetoEnLista);

                            filaActual.DefaultCellStyle.BackColor = Color.Empty;
                        }
                        else
                        {
                            libroBorrador.LibroAutores.Add(autSeleccionado);

                            filaActual.DefaultCellStyle.BackColor = Color.LightGreen;
                        }
                    }
                    ; break;
                case 3:
                    {
                        //Editar
                        FrmDatosAutores datosAutor = new FrmDatosAutores();
                        datosAutor.ShowDialog();
                        DtgDatos.Columns.Clear();
                    }
                    ; break;
                case 4:
                    {
                        // Activar / Desactivar
                        bool estado = Convert.ToBoolean(DtgDatos.Rows[0].Cells["Activo"].Value);
                        if (estado)
                            mad.DesactivarA(autor);
                        else
                            mad.ActivarA(autor);

                        DtgDatos.Columns.Clear();
                    }
                    ; break;
            }
        }

        private void BtnBuscarr_Click(object sender, EventArgs e)
        {
            if (CmbEstado.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un estado para buscar.", "Estado no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (CmbEstado.Text.Equals("Activos"))
                mad.Mostrar($"SELECT * FROM Autores WHERE Autor LIKE '%{TxtBuscar.Text}%' AND Activo = 1", DtgDatos, "Autores");
            else
                mad.Mostrar($"SELECT * FROM Autores WHERE Autor LIKE '%{TxtBuscar.Text}%' AND Activo = 0", DtgDatos, "Autores");

            foreach (DataGridViewRow row in DtgDatos.Rows)
            {
                int idGrid = int.Parse(row.Cells["IdAutor"].Value.ToString());

                // Compara el ID del grid con la lista del libro
                if (libroBorrador.LibroAutores.Any(c => c.IdAutor == idGrid))
                {
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                }
            }
        }

        private void BtnAgregarr_Click(object sender, EventArgs e)
        {
            autor.IdAutor = 0;
            autor.Nombre = "";
            FrmDatosAutores datosAutor = new FrmDatosAutores();
            datosAutor.ShowDialog();
            DtgDatos.Columns.Clear();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
