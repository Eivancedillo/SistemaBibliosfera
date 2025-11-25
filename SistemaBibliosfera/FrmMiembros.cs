using Entidades;
using Manejadores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemaBibliosfera
{
    public partial class FrmMiembros : Form
    {
        int fila = 0, columna = 0;
        bool prestamo = false;
        public static Miembro miembro = new Miembro(0,"", "", "", "", true);
        ManejadorMiembros Mm;
        ManejadorPermisos permisos;

        public FrmMiembros()
        {
            InitializeComponent();
            Mm = new ManejadorMiembros();
            permisos = new ManejadorPermisos();

            CmbEstado.Items.Clear();
            CmbEstado.Items.Add("Activos");
            CmbEstado.Items.Add("Inactivos");
            CmbEstado.SelectedIndex = 0;
        }

        // Sobre carga para el caso de préstamos
        public FrmMiembros(bool prestamotraido)
        {
            InitializeComponent();
            Mm = new ManejadorMiembros();
            permisos = new ManejadorPermisos();

            CmbEstado.Items.Clear();
            CmbEstado.Items.Add("Activos");
            CmbEstado.Items.Add("Inactivos");
            CmbEstado.SelectedIndex = 0;

            button1.Enabled = false;
            CmbEstado.Enabled = false;
            prestamo = prestamotraido;
        }

        private void DtgDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            miembro.NumeroControl = Convert.ToInt32(DtgDatos.Rows[fila].Cells["NumeroControl"].Value);
            miembro.Nombre = DtgDatos.Rows[fila].Cells["Nombre"].Value.ToString();
            miembro.Apellidos = DtgDatos.Rows[fila].Cells["Apellidos"].Value.ToString();
            miembro.Email = DtgDatos.Rows[fila].Cells["Email"].Value.ToString();
            miembro.Telefono = DtgDatos.Rows[fila].Cells["Telefono"].Value.ToString();

            switch (columna)
            {
                case 5:
                    {
                        // Editar
                        if(!permisos.ComprobarPermiso(4, 3, FrmPrincipal.IdAdministrador))
                        {
                            MessageBox.Show("No tienes permiso para realizar esta acción.", "Permiso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        FrmDatosMiembro frm = new FrmDatosMiembro();
                        frm.ShowDialog();
                        DtgDatos.Columns.Clear();
                    }
                    ; break;
                case 6:
                    {
                        if (!prestamo)
                        {
                            // Activar/Desactivar
                            if(!permisos.ComprobarPermiso(4, 4, FrmPrincipal.IdAdministrador))
                            {
                                MessageBox.Show("No tienes permiso para realizar esta acción.", "Permiso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }

                            bool estado = Convert.ToBoolean(DtgDatos.Rows[0].Cells["Estado"].Value);
                            if (estado)
                                Mm.Desactivar(miembro);
                            else
                                Mm.Activar(miembro);

                            DtgDatos.Columns.Clear();
                        }
                        else
                        {
                            FrmDatosPrestamos.miembroprestamo = miembro;

                            var rs = MessageBox.Show($"¿Desea seleccionar a {miembro.Nombre} {miembro.Apellidos} para el préstamo?", "Confirmar selección", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if(rs == DialogResult.Yes)
                                Close();
                            else
                                FrmDatosPrestamos.miembroprestamo = new Miembro(0, "", "", "", "", true);
                        }
                    }
                    ; break;
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(!permisos.ComprobarPermiso(4, 1, FrmPrincipal.IdAdministrador))
            {
                MessageBox.Show("No tienes permiso para realizar esta acción.", "Permiso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (CmbEstado.SelectedItem == null)
                MessageBox.Show("Seleccione un estado para buscar.", "Estado no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (!prestamo)
                {
                    string estado = CmbEstado.SelectedItem.ToString() == "Activos" ? "1" : "0";
                    Mm.Mostrar($"select * from Miembros where (NumeroControl like '%{TxtBuscar.Text}%' or Nombre like '%{TxtBuscar.Text}%') and Estado = {estado};", DtgDatos, "Miembros");
                }
                else
                {
                    string estado = CmbEstado.SelectedItem.ToString() == "Activos" ? "1" : "0";
                    Mm.Mostrar($"select * from Miembros where (NumeroControl like '%{TxtBuscar.Text}%' or Nombre like '%{TxtBuscar.Text}%') and Estado = {estado};", DtgDatos, "Miembros", true);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!permisos.ComprobarPermiso(4, 2, FrmPrincipal.IdAdministrador))
            {
                MessageBox.Show("No tienes permiso para realizar esta acción.", "Permiso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            miembro.NumeroControl = 0;
            miembro.Nombre = "";
            miembro.Apellidos = "";
            miembro.Email = "";
            miembro.Telefono = "";

            FrmDatosMiembro frm = new FrmDatosMiembro();
            frm.ShowDialog();
            DtgDatos.Columns.Clear();
        }

        private void DtgDatos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex; columna = e.ColumnIndex;
        }
    }
}
