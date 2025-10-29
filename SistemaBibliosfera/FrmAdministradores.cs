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
        public static Administrador administradorr = new Administrador(0, "", "");
        int fila = 0, columna = 0;

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            administradorr.IdAdministrador = 0;
            administradorr.Nombre = "";
            administradorr.Password = "";
            FrmDatosAdministrador da = new FrmDatosAdministrador();
            da.ShowDialog();
            DtgDatos.Columns.Clear();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            ma.Mostrar($"select * from Administradores where nombre like '%{TxtUsuario.Text}%'", DtgDatos, "Administradores");
        }

        private void DtgDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            administradorr.IdAdministrador = int.Parse(DtgDatos.Rows[fila].Cells["IdAdministrador"].Value.ToString());
            administradorr.Nombre = DtgDatos.Rows[fila].Cells["Nombre"].Value.ToString();
            administradorr.Password = DtgDatos.Rows[fila].Cells["clave"].Value.ToString();
            switch (columna)
            {
                case 2:
                    {
                        FrmDatosAdministrador da = new FrmDatosAdministrador();
                        da.Controls["TxtClave"].Text = "";
                        da.ShowDialog();
                        DtgDatos.Columns.Clear();

                    }
                    break;
                case 3:
                    {
                        ma.Desactivar(administradorr);
                        DtgDatos.Columns.Clear();

                    }
                    break;
            }
        }

        public FrmAdministradores()
        {
            InitializeComponent();
            ma = new ManejadorAdministrador();
        }
    }
}
