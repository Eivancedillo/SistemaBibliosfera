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
    public class ManejadorAdministrador
    {
        Base b = new Base();
        public void Guardar(Administrador administradorr)
        {
            b.Comando($"CALL p_InsertarAdministrador('{administradorr.Nombre}', '{administradorr.Password}')");
        }
        public void Modificar(Administrador administradorr)
        {
            b.Comando($"CALL p_EditarAdministrador({administradorr.IdAdministrador}, '{administradorr.Nombre}', '{administradorr.Password}')");
        }
        public void Borrar(Administrador administradorr)
        {
            var rs = MessageBox.Show($"Esta seguro de eliminar al administrador {administradorr.Nombre}", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                b.Comando($"CALL p_BorrarAdministrador({administradorr.IdAdministrador})");
            }
        }
        public void Mostar(string consulta, DataGridView tabla, string datos)
        {
            tabla.Columns.Clear();
            tabla.DataSource = b.Consultar(consulta, datos).Tables[0];
            tabla.Columns["IdAdministrador"].Visible = false;
            tabla.Columns["Password"].Visible = false;
            tabla.Columns.Insert(2, Boton("Editar", Color.Tan));
            tabla.Columns.Insert(3, Boton("Eliminar", Color.Red));
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
            btn.DefaultCellStyle.ForeColor = Color.White;
            return btn;

        }
    }
}

