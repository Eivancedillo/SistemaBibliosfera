using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using AccesoDatos;
using System.Windows.Forms;
using System.Drawing;
using MySql.Data.MySqlClient;

namespace Manejadores
{
    public class ManejadorMiembros
    {
        private Base b = new Base();

        public void Insertar(Miembro miembro)
        {
            try
            {
                b.Comando($"call p_insertar_miembro({miembro.NumeroControl}, '{miembro.Nombre}', '{miembro.Apellidos}', '{miembro.Email}', '{miembro.Telefono}');");
            }
            catch (MySqlException myEx)
            {
                if (myEx.Number == 1062)
                    MessageBox.Show($"El Número de Control '{miembro.NumeroControl}' ya existe.", "Error de Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Editar(Miembro miembro)
        {
            b.Comando($"call p_editar_miembro({miembro.NumeroControl}, '{miembro.Nombre}', '{miembro.Apellidos}', '{miembro.Email}', '{miembro.Telefono}');");
        }

        public void Desactivar(Miembro miembro)
        {
            var rs = MessageBox.Show($"¿Está seguro de que desea desactivar a {miembro.Nombre}", "Confirmar desactivar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (rs == DialogResult.Yes)
                b.Comando($"call p_desactivar_miembro({miembro.NumeroControl});");
        }

        public void Activar(Miembro miembro)
        {
            var rs = MessageBox.Show($"¿Está seguro de que desea activar a {miembro.Nombre}", "Confirmar activar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (rs == DialogResult.Yes)
                b.Comando($"call p_activar_miembro({miembro.NumeroControl});");
        }

        public void Mostrar(string query, DataGridView tabla, string datos, bool prestamo = false)
        {
            tabla.Columns.Clear();
            tabla.DataSource = b.Consultar(query, datos).Tables[0];

            // =========================================================================
            // INICIO REDISEÑO VISUAL DEL DATAGRIDVIEW (PALETA BIBLIOSFERA)
            // =========================================================================
            tabla.BackgroundColor = ColorTranslator.FromHtml("#F7F4D5"); // Beige para el fondo
            tabla.BorderStyle = BorderStyle.None;
            tabla.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            tabla.GridColor = ColorTranslator.FromHtml("#105666"); // Midnight green claro (líneas sutiles)
            tabla.RowHeadersVisible = false;
            tabla.EnableHeadersVisualStyles = false;

            // Estilo de los encabezados
            tabla.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            tabla.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#105666"); // Midnight green
            tabla.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            tabla.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            tabla.ColumnHeadersHeight = 45;

            // Estilo de las filas
            tabla.DefaultCellStyle.BackColor = Color.White;
            tabla.DefaultCellStyle.ForeColor = ColorTranslator.FromHtml("#0A3323"); // Dark green para el texto
            tabla.DefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Regular);
            tabla.RowTemplate.Height = 40;
            tabla.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#839958"); // Moss green
            tabla.DefaultCellStyle.SelectionForeColor = Color.White;

            // Efecto Cebra
            tabla.AlternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#FEFDF7"); // Beige súper claro
                                                                                                   // =========================================================================
                                                                                                   // FIN REDISEÑO VISUAL
                                                                                                   // =========================================================================

            tabla.Columns["Estado"].Visible = false;
            tabla.Columns["created_at"].Visible = false;
            tabla.Columns["updated_at"].Visible = false;

            // Verificar el estado del primer registro para decidir qué botón agregar
            if (tabla.Rows.Count > 0)
            {
                if (!prestamo)
                {
                    // Colores de la nueva paleta (Botones Sólidos)
                    tabla.Columns.Insert(5, Boton("Editar", ColorTranslator.FromHtml("#105666"))); // Midnight green

                    bool estado = Convert.ToBoolean(tabla.Rows[0].Cells["Estado"].Value);
                    if (estado)
                    {
                        tabla.Columns.Insert(6, Boton("Desactivar", ColorTranslator.FromHtml("#D3968C"))); // Rosy brown (Rojo/Rosa cálido)
                    }
                    else
                    {
                        tabla.Columns.Insert(6, Boton("Activar", ColorTranslator.FromHtml("#839958"))); // Moss green (Verde acción positiva)
                    }
                }
                else
                {
                    tabla.Columns.Insert(6, Boton("Seleccionar", ColorTranslator.FromHtml("#839958"))); // Moss green
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

        public static DataGridViewButtonColumn Boton(string titulo, Color color)
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Name = titulo;
            btn.Text = titulo;
            btn.UseColumnTextForButtonValue = true;
            btn.FlatStyle = FlatStyle.Flat;

            btn.DefaultCellStyle.BackColor = color;
            btn.DefaultCellStyle.ForeColor = Color.White;
            btn.DefaultCellStyle.SelectionBackColor = color;
            btn.DefaultCellStyle.SelectionForeColor = Color.White;

            return btn;
        }
    }
}