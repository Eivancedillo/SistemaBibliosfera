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
        Base b = new Base();

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

        public void Mostrar(string query, DataGridView tabla, string datos)
        {
            tabla.Columns.Clear();
            tabla.DataSource = b.Consultar(query, datos).Tables[0];
            tabla.Columns["Estado"].Visible = false;
            tabla.Columns["created_at"].Visible = false;
            tabla.Columns["updated_at"].Visible = false;

            tabla.Columns.Insert(5, Boton("Editar", Color.Green));

            // Verificar el estado del primer registro para decidir qué botón agregar
            if (tabla.Rows.Count > 0)
            {
                bool estado = Convert.ToBoolean(tabla.Rows[0].Cells["Estado"].Value);
                if (estado)
                {
                    tabla.Columns.Insert(6, Boton("Desasctivar", Color.Red));
                }
                else
                {
                    tabla.Columns.Insert(6, Boton("Activar", Color.Blue));
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
