using AccesoDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manejadores
{
    public class ManejadorEjemplares
    {
        private Base b = new Base();

        public void EditarEjemplar(Ejemplar ejemplar)
        {
            b.Comando($"CALL p_editar_ejemplares({ejemplar.IdEjemplar}, {ejemplar.Codigo}, '{ejemplar.Estado}', '{ejemplar.Ubicacion}');");
        }

        public void DesactivarEjemplar(int IdEjemplar)
        {
            var rs = MessageBox.Show($"¿Esta seguro de desactivar al ejemplar?", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                b.Comando($"CALL p_desactivar_ejemplares({IdEjemplar});");
            }
        }

        public void ActivarEjemplar(int IdEjemplar)
        {
            var rs = MessageBox.Show($"¿Esta seguro de activar al ejemplar?", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                b.Comando($"CALL p_activar_ejemplares({IdEjemplar});");
            }
        }

        public void InsertarEjemplar(Ejemplar ejemplar)
        {
            b.Comando($"CALL p_insertar_ejemplares({ejemplar.IdLibro}, {ejemplar.Codigo}, '{ejemplar.Estado}', '{ejemplar.Ubicacion}');");
        }

        public void MostrarNombreEjemplar(int IdLibro, Label label)
        {
            label.Text = b.Consultar($"select Titulo from Libros where IdLibro = {IdLibro}", "Libros").Tables[0].Rows[0]["Titulo"].ToString();
        }

        public void Mostrar(string consulta, DataGridView tabla, string datos, bool prestamo = false)
        {
            tabla.Columns.Clear();
            tabla.DataSource = b.Consultar(consulta, datos).Tables[0];

            // =========================================================================
            // INICIO REDISEÑO VISUAL DEL DATAGRIDVIEW (PALETA BIBLIOSFERA)
            // =========================================================================
            tabla.BackgroundColor = ColorTranslator.FromHtml("#F7F4D5"); // Beige
            tabla.BorderStyle = BorderStyle.None;
            tabla.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            tabla.GridColor = ColorTranslator.FromHtml("#105666"); // Midnight green claro
            tabla.RowHeadersVisible = false;
            tabla.EnableHeadersVisualStyles = false;

            // Estilo de los encabezados
            tabla.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            tabla.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#105666");
            tabla.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            tabla.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            tabla.ColumnHeadersHeight = 45;

            // Estilo de las filas
            tabla.DefaultCellStyle.BackColor = Color.White;
            tabla.DefaultCellStyle.ForeColor = ColorTranslator.FromHtml("#0A3323");
            tabla.DefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Regular);
            tabla.RowTemplate.Height = 40;
            tabla.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#839958"); 
            tabla.DefaultCellStyle.SelectionForeColor = Color.White;

            // Efecto Cebra
            tabla.AlternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#FEFDF7"); 
            tabla.Columns["IdEjemplar"].Visible = false;
            tabla.Columns["IdLibro"].Visible = false;
            tabla.Columns["Activo"].Visible = false;
            tabla.Columns["created_at"].Visible = false;
            tabla.Columns["updated_at"].Visible = false;

            if (tabla.Rows.Count > 0)
            {
                if (!prestamo)
                {
                    // Paleta de colores nueva para botones
                    tabla.Columns.Insert(5, Boton("Editar", ColorTranslator.FromHtml("#105666")));

                    bool estado = Convert.ToBoolean(tabla.Rows[0].Cells["Activo"].Value);
                    if (estado)
                    {
                        tabla.Columns.Insert(6, Boton("Desactivar", ColorTranslator.FromHtml("#D3968C")));
                    }
                    else
                    {
                        tabla.Columns.Insert(6, Boton("Activar", ColorTranslator.FromHtml("#839958"))); 
                    }
                }
                else
                {
                    tabla.Columns.Insert(6, Boton("Seleccionar", ColorTranslator.FromHtml("#839958"))); 
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

        public static DataGridViewButtonColumn Boton(string titulo, Color fondo)
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Name = titulo;
            btn.Text = titulo;
            btn.UseColumnTextForButtonValue = true;
            btn.FlatStyle = FlatStyle.Flat; // Cambio a diseño plano

            // Asignación estricta de colores
            btn.DefaultCellStyle.BackColor = fondo;
            btn.DefaultCellStyle.ForeColor = Color.White;
            btn.DefaultCellStyle.SelectionBackColor = fondo;
            btn.DefaultCellStyle.SelectionForeColor = Color.White;

            return btn;
        }
    }
}