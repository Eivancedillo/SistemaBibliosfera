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
    public class ManejadorAdministrador
    {
        Base b = new Base();
        public void Guardar(Administrador administradorr)
        {
            b.Comando($"CALL p_Insertar_Administrador('{administradorr.Nombre}', '{administradorr.Password}')");
        }

        public void Editar(Administrador administradorr, bool estado)
        {
                if (estado)
                {
                    b.Comando($"CALL p_Editar_Administrador({administradorr.IdAdministrador}, '{administradorr.Nombre}', '{administradorr.Password}')");
                }
                else
                {
                    b.Comando($"UPDATE Administradores SET Nombre = '{administradorr.Nombre}' WHERE IdAdministrador = {administradorr.IdAdministrador};");
                }
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
            var rs = MessageBox.Show($"Esta seguro de activar a {administradorr.Nombre}", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                b.Comando($"CALL p_Activar_Administrador({administradorr.IdAdministrador})");
            }
        }

        // Apartado para gestion de permisos
        public void GuardarPermiso(int acceso, int permiso, int administrador)
        {
            b.Comando($"call p_insertar_permiso({acceso}, {permiso}, {administrador})", true);
        }

        public void BorrarPermiso(int acceso, int permiso, int administrador)
        {
            b.Comando($"call p_eliminar_permiso({acceso}, {permiso}, {administrador})", true);
        }

        public void LlenarAccesos(ComboBox combo)
        {
            combo.DataSource = b.Consultar("select IdAcceso, Acceso from AdministradoresAccesos", "AdministradoresAccesos").Tables[0];
            combo.DisplayMember = "Acceso";
            combo.ValueMember = "IdAcceso";
        }

        public void LlenarPermisos(int idacceso, int idadministrador, CheckBox c1, CheckBox c2, CheckBox c3, CheckBox c4)
        {
            int idpermiso = 1;

            // select para saber si el usuario tiene el permiso y marcar el checkbox
            var dr1 = b.Consultar($"call p_consultar_permiso({idacceso}, {idpermiso}, {idadministrador})", "permisos", true).Tables[0].Rows[0];
            if (dr1["rs"].ToString().Equals("Aceptado"))
                c1.Checked = true;
            else
                c1.Checked = false;

            var dr2 = b.Consultar($"call p_consultar_permiso({idacceso}, {idpermiso + 1}, {idadministrador})", "permisos", true).Tables[0].Rows[0];
            if (dr2["rs"].ToString().Equals("Aceptado"))
                c2.Checked = true;
            else
                c2.Checked = false;

            var dr3 = b.Consultar($"call p_consultar_permiso({idacceso}, {idpermiso + 2}, {idadministrador})", "permisos", true).Tables[0].Rows[0];
            if (dr3["rs"].ToString().Equals("Aceptado"))
                c3.Checked = true;
            else
                c3.Checked = false;

            var dr4 = b.Consultar($"call p_consultar_permiso({idacceso}, {idpermiso + 3}, {idadministrador})", "permisos", true).Tables[0].Rows[0];
            if (dr4["rs"].ToString().Equals("Aceptado"))
                c4.Checked = true;
            else
                c4.Checked = false;
        }

        public void SetCommit(bool estado)
        {
            b.Comando($"SET AUTOCOMMIT = {(estado ? 1 : 0)}", true);
        }

        public void CommitRollback(bool estado)
        {
            b.Comando(estado ? "COMMIT" : "ROLLBACK", false);
        }

        public void StartTransaction()
        {
            b.Comando("START TRANSACTION", true);
        }
        
        public void Mostrar(string consulta, DataGridView tabla, string datos)
        {
            tabla.Columns.Clear();
            tabla.DataSource = b.Consultar(consulta, datos).Tables[0];
            tabla.Columns["IdAdministrador"].Visible = false;
            tabla.Columns["Password"].Visible = false;
            tabla.Columns["created_at"].Visible = false;
            tabla.Columns["updated_at"].Visible = false;
            tabla.Columns["Activo"].Visible =false;
            tabla.Columns.Insert(2, Boton("Editar", Color.Green));
            if (tabla.Rows.Count > 0)
            {
                bool estado = Convert.ToBoolean(tabla.Rows[0].Cells["Activo"].Value);
                if (estado)
                {
                    tabla.Columns.Insert(3, Boton("Desasctivar", Color.Red));
                }
                else
                {
                    tabla.Columns.Insert(3, Boton("Activar", Color.Blue));
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
            btn.DefaultCellStyle.ForeColor = Color.White;
            return btn;

        }
    }
}

