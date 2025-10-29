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
            b.Comando($"CALL p_Insertar_Administrador('{administradorr.Nombre}', '{administradorr.Password}')");
        }
        public void Editar(Administrador administradorr)
        {
            b.Comando($"CALL p_Editar_Administrador({administradorr.IdAdministrador}, '{administradorr.Nombre}', '{administradorr.Password}')");
        }
        public void Desactivar(Administrador administradorr)
        {
            var rs = MessageBox.Show($"Esta seguro de desactivar al administrador {administradorr.Nombre}", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                b.Comando($"CALL p_Desactivar_Administrador({administradorr.IdAdministrador})");
            }
        }
        public void Activar(Administrador administradorr)
        {
            var rs = MessageBox.Show($"Esta seguro de activar al administrador {administradorr.Nombre}", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                b.Comando($"CALL p_Activar_Administrador({administradorr.IdAdministrador})");
            }
        }
        public void Mostrar(string consulta, DataGridView tabla, string datos)
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

