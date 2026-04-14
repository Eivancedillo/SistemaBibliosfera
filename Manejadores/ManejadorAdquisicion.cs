using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos;
using Entidades;
using ZstdSharp.Unsafe;

namespace Manejadores
{
    public class ManejadorAdquisicion
    {
        private Base b = new Base();

        #region GUARDAR CATEGORIA

        public void GuardarC(Categoria categoria)
        {
            b.Comando($"CALL p_insertar_categorias('{categoria.Nombre}')");
        }

        #endregion GUARDAR CATEGORIA

        #region MODIFICAR CATEGORIA

        public void ModificarC(Categoria categoria)
        {
            b.Comando($"CALL p_editar_categorias('{categoria.Nombre}', {categoria.IdCategoria})");
        }

        #endregion MODIFICAR CATEGORIA

        #region DESACTIVAR CATEGORIA

        public void DesactivarC(Categoria categoria)
        {
            var rs = MessageBox.Show($"¿Está seguro de desactivar la categoría {categoria.Nombre}?",
                "Confirmar desactivación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                b.Comando($"CALL p_desactivar_categorias({categoria.IdCategoria})");
            }
        }

        #endregion DESACTIVAR CATEGORIA

        #region ACTIVAR CATEGORIA

        public void ActivarC(Categoria categoria)
        {
            var rs = MessageBox.Show($"¿Está seguro de activar la categoría {categoria.Nombre}?",
                "Confirmar desactivación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rs == DialogResult.Yes)
                b.Comando($"CALL p_activar_categorias({categoria.IdCategoria})");
        }

        #endregion ACTIVAR CATEGORIA

        #region GUARDAR EDITORIAL

        public void GuardarE(Editorial editorial)
        {
            b.Comando($"CALL p_insertar_editoriales('{editorial.Nombre}')");
        }

        #endregion GUARDAR EDITORIAL

        #region MODIFICAR EDITORIAL

        public void ModificarE(Editorial editorial)
        {
            b.Comando($"CALL p_editar_editoriales('{editorial.Nombre}', {editorial.IdEditorial})");
        }

        #endregion MODIFICAR EDITORIAL

        #region DESACTIVAR EDITORIAL

        public void DesactivarE(Editorial editorial)
        {
            var rs = MessageBox.Show($"¿Está seguro de desactivar la editorial {editorial.Nombre}?",
                "Confirmar desactivación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                b.Comando($"CALL p_desactivar_editoriales({editorial.IdEditorial})");
            }
        }

        #endregion DESACTIVAR EDITORIAL

        #region ACTIVAR EDITORIAL

        public void ActivarE(Editorial editorial)
        {
            var rs = MessageBox.Show($"¿Está seguro de activar la editorial {editorial.Nombre}?",
                "Confirmar desactivación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
                b.Comando($"CALL p_activar_editoriales({editorial.IdEditorial})");
        }

        #endregion ACTIVAR EDITORIAL

        #region GUARDAR AUTORES

        public void GuardarA(Autor autor)
        {
            b.Comando($"CALL p_insertar_autores('{autor.Nombre}')");
        }

        #endregion GUARDAR AUTORES

        #region MODIFICAR AUTORES

        public void ModificarA(Autor autor)
        {
            b.Comando($"CALL p_editar_autores('{autor.Nombre}', {autor.IdAutor})");
        }

        #endregion MODIFICAR AUTORES

        #region DESACTIVAR AUTORES

        public void DesactivarA(Autor autor)
        {
            var rs = MessageBox.Show($"¿Está seguro de desactivar el autor {autor.Nombre}?",
                "Confirmar desactivación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                b.Comando($"CALL p_desactivar_autores({autor.IdAutor})");
            }
        }

        #endregion DESACTIVAR AUTORES

        #region ACTIVAR AUTORES

        public void ActivarA(Autor autor)
        {
            var rs = MessageBox.Show($"¿Está seguro de activar el autor {autor.Nombre}?",
                "Confirmar desactivación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
                b.Comando($"CALL p_activar_autores({autor.IdAutor})");
        }

        #endregion ACTIVAR AUTORES

        #region DATOS QUE SE MOSTRARAN EN EL DTG

        public void Mostrar(string consulta, DataGridView tabla, string datos)
        {
            int posboton = 2;

            tabla.Columns.Clear();
            tabla.DataSource = b.Consultar(consulta, datos).Tables[0];

            // =========================================================================
            // INICIO REDISEÑO VISUAL DEL DATAGRIDVIEW
            // =========================================================================
            tabla.BackgroundColor = Color.White;
            tabla.BorderStyle = BorderStyle.None;
            tabla.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            tabla.GridColor = ColorTranslator.FromHtml("#E0D8C8");
            tabla.RowHeadersVisible = false;
            tabla.EnableHeadersVisualStyles = false;

            // Estilo de los encabezados
            tabla.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            tabla.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#6B261F");
            tabla.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            tabla.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            tabla.ColumnHeadersHeight = 45;

            // Estilo de las filas
            tabla.DefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Regular);
            tabla.RowTemplate.Height = 40;
            tabla.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#D8C3A5");
            tabla.DefaultCellStyle.SelectionForeColor = Color.Black;

            // Efecto Cebra
            tabla.AlternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#F8F5F0");
            // =========================================================================
            // FIN REDISEÑO VISUAL
            // =========================================================================

            if (tabla.Columns.Contains("IdCategoria")) tabla.Columns["IdCategoria"].Visible = false;
            if (tabla.Columns.Contains("IdEditorial")) tabla.Columns["IdEditorial"].Visible = false;
            if (tabla.Columns.Contains("IdAutor")) tabla.Columns["IdAutor"].Visible = false;
            if (tabla.Columns.Contains("Activo")) tabla.Columns["Activo"].Visible = false;
            if (tabla.Columns.Contains("created_at")) tabla.Columns["created_at"].Visible = false;
            if (tabla.Columns.Contains("updated_at")) tabla.Columns["updated_at"].Visible = false;

            if (tabla.Rows.Count > 0)
            {
                bool estado = Convert.ToBoolean(tabla.Rows[0].Cells["Activo"].Value);
                if (estado)
                {
                    tabla.Columns.Insert(posboton, Boton("Seleccionar", ColorTranslator.FromHtml("#B68D40"))); // Dorado opaco
                    posboton++;
                }

                tabla.Columns.Insert(posboton, Boton("Editar", ColorTranslator.FromHtml("#5C7457"))); // Verde olivo
                posboton++;

                if (estado)
                {
                    tabla.Columns.Insert(posboton, Boton("Desactivar", ColorTranslator.FromHtml("#9C4A3D"))); // Rojo terracota
                }
                else
                {
                    tabla.Columns.Insert(posboton, Boton("Activar", ColorTranslator.FromHtml("#4A6572"))); // Azul acero
                }
            }

            tabla.AutoResizeColumns();
            tabla.AutoResizeRows();

            // TRUCO PARA EVITAR QUE EL EFECTO CEBRA SOBREESCRIBA LOS BOTONES
            foreach (DataGridViewRow row in tabla.Rows)
            {
                for (int i = 0; i < tabla.Columns.Count; i++)
                {
                    if (tabla.Columns[i] is DataGridViewButtonColumn)
                    {
                        row.Cells[i].Style.BackColor = tabla.Columns[i].DefaultCellStyle.BackColor;
                        row.Cells[i].Style.ForeColor = Color.White;
                        row.Cells[i].Style.SelectionBackColor = tabla.Columns[i].DefaultCellStyle.BackColor;
                    }
                }
            }
        }

        #endregion DATOS QUE SE MOSTRARAN EN EL DTG

        public void GuardarLibro(Libro libro)
        {
            b.Comando($"CALL p_insertar_libro('{libro.ISBN}', '{libro.Titulo}', {libro.IdEditorial}, {libro.AnioPublicacion});");

            foreach (var autor in libro.LibroAutores)
            {
                b.Comando($"CALL p_insertar_libroautores('{libro.ISBN}', {autor.IdAutor});");
            }
            foreach (var categoria in libro.LibroCategoria)
            {
                b.Comando($"CALL p_insertar_librocategorias('{libro.ISBN}', {categoria.IdCategoria});");
            }
        }

        public string MostrarE(int IdEditorial)
        {
            var rs = b.Consultar($"select Nombre from v_mostrar_editorial where IdEditorial = {IdEditorial};", "v_mostrar_editorial");

            if (rs != null)
                return rs.Tables[0].Rows[0].Field<string>("Nombre");
            else
                return "";
        }

        #region BOTONES

        public static DataGridViewButtonColumn Boton(string titulo, Color fondo)
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Name = titulo;
            btn.Text = titulo;
            btn.UseColumnTextForButtonValue = true;
            btn.FlatStyle = FlatStyle.Flat;

            btn.DefaultCellStyle.BackColor = fondo;
            btn.DefaultCellStyle.ForeColor = Color.White;
            btn.DefaultCellStyle.SelectionBackColor = fondo;
            btn.DefaultCellStyle.SelectionForeColor = Color.White;

            return btn;
        }

        #endregion BOTONES
    }
}