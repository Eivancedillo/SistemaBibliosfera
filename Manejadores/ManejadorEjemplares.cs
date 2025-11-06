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
        Base b = new Base();

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
            tabla.Columns["IdEjemplar"].Visible = false;
            tabla.Columns["IdLibro"].Visible = false;
            tabla.Columns["Activo"].Visible = false;
            tabla.Columns["created_at"].Visible = false;
            tabla.Columns["updated_at"].Visible = false;

            if (tabla.Rows.Count > 0)
            {
                if (!prestamo)
                {
                    tabla.Columns.Insert(5, Boton("Editar", Color.Green));

                    bool estado = Convert.ToBoolean(tabla.Rows[0].Cells["Activo"].Value);
                    if (estado)
                    {
                        tabla.Columns.Insert(6, Boton("Desasctivar", Color.Red));
                    }
                    else
                    {
                        tabla.Columns.Insert(6, Boton("Activar", Color.Blue));
                    }
                }
                else
                {
                    tabla.Columns.Insert(6, Boton("Seleccionar", Color.Orange));
                }
            }
            tabla.AutoResizeColumns();
            tabla.AutoResizeRows();

        }

        public static DataGridViewButtonColumn Boton(string titulo, Color fondo)
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Text = titulo;
            btn.UseColumnTextForButtonValue = true;
            btn.FlatStyle = FlatStyle.Popup;
            btn.DefaultCellStyle.BackColor = fondo;
            btn.DefaultCellStyle.ForeColor = Color.Black;
            return btn;
        }
    }
}
