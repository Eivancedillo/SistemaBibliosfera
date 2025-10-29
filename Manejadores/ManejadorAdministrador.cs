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
            b.Comando($"insert into Administradores values" +
                $"(null,'{administradorr.Nombre}',SHA1('{administradorr.Password}'))");
        }
        public void Borrar(Administrador administradorr)
        {
            var rs = MessageBox.Show($"Esta seguro de eliminar al administrador {administradorr.Nombre}", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                b.Comando($"delete from Administradores where IdAdministrador={administradorr.IdAdministrador}");
            }
        }
        public void Modificar(Administrador administradorr)
        {
            b.Comando($"update Administradores set Nombre ='{administradorr.Nombre}', Password= SHA1('{administradorr.Password}')" +
                $" where IdAdministrador ={administradorr.IdAdministrador}");
        }
        public void Mostar(string consulta, DataGridView tabla, string datos)
        {
            tabla.Columns.Clear();
            tabla.DataSource = b.Consultar(consulta, datos).Tables[0];
            tabla.Columns["IdAdministrador"].Visible = false;
            tabla.Columns["Password"].Visible = false; //preguntar si quieren que se vea o no
            tabla.Columns.Insert(2, Boton("Modificar clave", Color.Tan));
            tabla.Columns.Insert(3, Boton("Modificar usuario", Color.DarkGray));
            tabla.Columns.Insert(4, Boton("Borrar", Color.Red));
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

