using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Manejadores;

namespace SistemaBibliosfera
{
    public partial class FrmAdministradores : Form
    {
        ManejadorAdministrador ma;
        ManejadorPermisos permisos;

        public static Administrador administradorr = new Administrador(0, "", "");
        int fila = 0, columna = 0;

        public FrmAdministradores()
        {
            InitializeComponent();
            ma = new ManejadorAdministrador();
            permisos = new ManejadorPermisos();

            CmbEstado.Items.Clear();
            CmbEstado.Items.Add("Activos");
            CmbEstado.Items.Add("Inactivos");

            CmbEstado.SelectedIndex = 0;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if(!permisos.ComprobarPermiso(5, 2, FrmPrincipal.IdAdministrador))
            { 
                MessageBox.Show("No tienes permiso para realizar esta acción.", "Permiso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            administradorr.IdAdministrador = 0;
            administradorr.Nombre = "";
            administradorr.Password = "";
            FrmDatosAdministrador da = new FrmDatosAdministrador();
            da.ShowDialog();
            DtgDatos.Columns.Clear();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if(!permisos.ComprobarPermiso(5, 1, FrmPrincipal.IdAdministrador))
            { 
                MessageBox.Show("No tienes permiso para realizar esta acción.", "Permiso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (CmbEstado.SelectedItem == null)
                MessageBox.Show("Seleccione un estado para buscar.", "Estado no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (CmbEstado.Text.Equals("Activos"))
                    ma.Mostrar($"select * from Administradores where Activo = 1 and Nombre like '%{TxtUsuario.Text}%'", DtgDatos, "Administradores");
                else
                    ma.Mostrar($"select * from Administradores where Activo = 0 and Nombre like '%{TxtUsuario.Text}%'", DtgDatos, "Administradores");
            }
        }

        private void DtgDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            administradorr.IdAdministrador = int.Parse(DtgDatos.Rows[fila].Cells["IdAdministrador"].Value.ToString());
            administradorr.Nombre = DtgDatos.Rows[fila].Cells["Nombre"].Value.ToString();
            administradorr.Password = DtgDatos.Rows[fila].Cells["Password"].Value.ToString();
            switch (columna)
            {
                case 2:
                    {
                        // Editar
                        if(!permisos.ComprobarPermiso(5, 3, FrmPrincipal.IdAdministrador))
                        { 
                            MessageBox.Show("No tienes permiso para realizar esta acción.", "Permiso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        FrmDatosAdministrador da = new FrmDatosAdministrador();
                        da.ShowDialog();
                        DtgDatos.Columns.Clear();

                    }
                    break;
                case 3:
                    {
                        // Activar / Desactivar
                        if(!permisos.ComprobarPermiso(5, 4, FrmPrincipal.IdAdministrador))
                        { 
                            MessageBox.Show("No tienes permiso para realizar esta acción.", "Permiso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        bool estado = Convert.ToBoolean(DtgDatos.Rows[0].Cells["Activo"].Value);
                        if (estado)
                        {
                            ma.Desactivar(administradorr);
                        }
                        else
                        {
                            ma.Activar(administradorr);
                        }

                        DtgDatos.Columns.Clear();
                    }
                    break;
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DtgDatos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex; columna = e.ColumnIndex;
        }
    }
}
