using AccesoDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manejadores
{
    public class ManejadorCatalogo
    {
        Base b = new Base();

        public void LlenarEntidad(Libro libro, DataGridView tabla)
        {
            libro.LibroAutores.Clear();
            libro.LibroCategoria.Clear();

            libro.IdLibro = Convert.ToInt32(tabla.Rows[tabla.CurrentRow.Index].Cells["IdLibro"].Value);
            libro.ISBN = tabla.Rows[tabla.CurrentRow.Index].Cells["ISBN"].Value.ToString();
            libro.Titulo = tabla.Rows[tabla.CurrentRow.Index].Cells["Titulo"].Value.ToString();
            libro.IdEditorial = Convert.ToInt32(tabla.Rows[tabla.CurrentRow.Index].Cells["IdEditorial"].Value);
            libro.AnioPublicacion = Convert.ToInt32(tabla.Rows[tabla.CurrentRow.Index].Cells["Año"].Value);

            // Obtener autores
            string consultaAutores = $"SELECT IdAutor, Autor FROM v_librosautores WHERE IdLibro = {libro.IdLibro}";
            DataTable dtAutores = b.Consultar(consultaAutores, "v_librosautores").Tables[0];
            foreach (DataRow row in dtAutores.Rows)
            {
                libro.LibroAutores.Add(new Autor(Convert.ToInt32(row["IdAutor"]), row["Autor"].ToString()));
            }

            // Obtener categorías
            string consultaCategorias = $"SELECT IdCategoria, Categoria FROM v_libroscategorias WHERE IdLibro = {libro.IdLibro}";
            DataTable dtCategorias = b.Consultar(consultaCategorias, "v_libroscategorias").Tables[0];
            foreach (DataRow row in dtCategorias.Rows)
            {
                libro.LibroCategoria.Add(new Categoria(Convert.ToInt32(row["IdCategoria"]), row["Categoria"].ToString()));
            }
        }

        public void LlenarCmbs(ComboBox cmbEstado, ComboBox cmbFiltro, ComboBox cmbOrdenar)
        {
            // Limpiarlos antes de llenarlos
            cmbEstado.Items.Clear();
            cmbFiltro.Items.Clear();
            cmbOrdenar.Items.Clear();

            // Llenar cmbEstado
            cmbEstado.Items.Add("Activos");
            cmbEstado.Items.Add("Inactivos");

            // Llenar cmbFiltro
            cmbFiltro.Items.Add("Titulo");
            cmbFiltro.Items.Add("Editorial");
            cmbFiltro.Items.Add("Autor");
            cmbFiltro.Items.Add("Categoria");
            cmbFiltro.Items.Add("Año");

            // Llenar cmbOrdenar
            cmbOrdenar.Items.Add("Ascendente");
            cmbOrdenar.Items.Add("Descendente");

            // Valores por defecto
            cmbEstado.SelectedIndex = 0;
            cmbFiltro.SelectedIndex = 0;
            cmbOrdenar.SelectedIndex = 0;
        }

        public void EditarLibro(Libro libro)
        {
            b.Comando($"call p_editar_libro({libro.IdLibro}, '{libro.ISBN}', '{libro.Titulo}', {libro.IdEditorial}, {libro.AnioPublicacion});");
        }

        public void DesactivarLibro(Libro libro)
        {
            // Verificar que todos los ejemplares del libro esten disponibles para poder desactivar el libro
            string consulta = $"SELECT COUNT(*) FROM Ejemplares WHERE IdLibro = {libro.IdLibro} AND Estado <> 'Disponible';";
            int ejemplaresPrestados = Convert.ToInt32(b.Consultar(consulta, "Ejemplares").Tables[0].Rows[0][0]);

            if (ejemplaresPrestados > 0)
            {
                MessageBox.Show("No se puede desactivar este libro, todos sus ejemplares deben estar disponibles.", "Desactivación no permitida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var rs = MessageBox.Show("¿Está seguro de desactivar este libro?", "Confirmar desactivación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rs == DialogResult.Yes)
            {
                b.Comando($"call p_desactivar_libro({libro.IdLibro})");
            }
        }

        public void Mostrar(DataGridView tabla, TextBox Buscar, ComboBox estadocmb ,ComboBox filtro, ComboBox Orden)
        {
            tabla.Columns.Clear();

            // Construir las partes de la consulta
            string estadoSql = estadocmb.Text.Equals("Activos") ? "Activo = 1" : "Activo = 0";
            string filtroSql = "";
            string ordenSql = "";
            string buscarTexto = Buscar.Text;

            // Definir el FILTRO
            if (filtro.Text.Equals("Titulo"))
            {
                filtroSql = $"AND Titulo LIKE '%{buscarTexto}%'";
                ordenSql = Orden.Text.Equals("Ascendente") ? "ORDER BY Titulo ASC" : "ORDER BY Titulo DESC";
            }
            else if (filtro.Text.Equals("Autor"))
            {
                // Usamos la vista de autores para filtrar
                filtroSql = $"AND IdLibro IN (SELECT IdLibro FROM v_librosautores WHERE Autor LIKE '%{buscarTexto}%')";
                ordenSql = Orden.Text.Equals("Ascendente") ? "ORDER BY Autores ASC" : "ORDER BY Autores DESC";
            }
            else if (filtro.Text.Equals("Categoria"))
            {
                // Usamos la vista de categorías para filtrar
                filtroSql = $"AND IdLibro IN (SELECT IdLibro FROM v_libroscategorias WHERE Categoria LIKE '%{buscarTexto}%')";
                ordenSql = Orden.Text.Equals("Ascendente") ? "ORDER BY Categorias ASC" : "ORDER BY Categorias DESC";
            }
            else if (filtro.Text.Equals("Editorial"))
            {
                // Filtrado por editorial
                filtroSql = $"AND Editorial LIKE '%{buscarTexto}%'";
                ordenSql = Orden.Text.Equals("Ascendente") ? "ORDER BY Editorial ASC" : "ORDER BY Editorial DESC";
            }
            else
            {
                // Caso por defecto (sin filtro)
                filtroSql = $"AND Titulo LIKE '%{buscarTexto}%'";
                ordenSql = Orden.Text.Equals("Ascendente") ? "ORDER BY Titulo ASC" : "ORDER BY Titulo DESC";
             }

                // Armar la consulta final
                string consultaFinal = $"SELECT * FROM v_catalogo WHERE {estadoSql} {filtroSql} {ordenSql}";

                // Ejecutar
                DataTable dt = b.Consultar(consultaFinal, "v_catalogo").Tables[0];
                tabla.DataSource = dt;

                if (tabla.Rows.Count > 0)
                {
                    tabla.Columns["IdLibro"].Visible = false;
                    tabla.Columns["TotalEjemplares"].Visible = false;
                    tabla.Columns["Activo"].Visible = false;
                    tabla.Columns["IdEditorial"].Visible = false;
                }

                tabla.Columns.Insert(10, Boton("Editar", Color.Green));

                // Verificar el estado del primer registro para decidir qué botón agregar
                if (tabla.Rows.Count > 0)
                {
                    if (estadocmb.Text.Equals("Activos"))
                    {
                        tabla.Columns.Insert(11, Boton("Desasctivar", Color.Red));
                    }
                    else
                    {
                        tabla.Columns.Insert(11, Boton("Activar", Color.Blue));
                    }
                }

                tabla.AutoResizeColumns();
                tabla.AutoResizeRows();
            }

        public static DataGridViewButtonColumn Boton(string titulo, Color color)
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Text = titulo;
            btn.UseColumnTextForButtonValue = true;
            btn.FlatStyle = FlatStyle.Popup;
            btn.DefaultCellStyle.BackColor = color;
            btn.DefaultCellStyle.ForeColor = Color.White;
            return btn;
        }
    }
}
