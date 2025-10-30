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
    public partial class FrmDatosAdministrador : Form
    {
        ManejadorAdministrador ma;
        public FrmDatosAdministrador()
        {
            ma = new ManejadorAdministrador();
            InitializeComponent();
            if(FrmAdministradores.administradorr.IdAdministrador >0)
            {
                TxtNombre.Text = FrmAdministradores.administradorr.Nombre;
                TxtContraseña.Text = FrmAdministradores.administradorr.Password;
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (FrmAdministradores.administradorr.IdAdministrador == 0)
            {
                ma.Guardar(new Administrador(0,TxtNombre.Text, TxtContraseña.Text));
                Close();
            }
            else
            {
                ma.Editar(new Administrador(FrmAdministradores.administradorr.IdAdministrador, TxtNombre.Text, TxtContraseña.Text));
                Close();
            }
        }

        private void CmbAccesos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbAccesos.SelectedItem != null)
            {
                if (!LsbAccesos.Items.Contains(CmbAccesos.SelectedItem))
                {
                    LsbAccesos.Items.Add(CmbAccesos.SelectedItem);
                }
            }
        }
    }
}
