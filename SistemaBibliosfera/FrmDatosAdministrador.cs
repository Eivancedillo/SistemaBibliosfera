using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manejadores;
using Entidades;

namespace SistemaBibliosfera
{
    public partial class FrmDatosAdministrador : Form
    {
        ManejadorAdministrador ma;
        bool cargado = false;
        public FrmDatosAdministrador()
        {
            InitializeComponent();

            ma = new ManejadorAdministrador();
            ma.LlenarAccesos(CmbAccesos);
            CmbAccesos.Enabled = false; CbVer.Enabled = false; CbEditar.Enabled = false; CbCrear.Enabled = false; CbActivar.Enabled = false;

            if (FrmAdministradores.administradorr.IdAdministrador > 0)
            {
                TxtNombre.Text = FrmAdministradores.administradorr.Nombre;

                if(FrmAdministradores.administradorr.IdAdministrador == 1)
                {
                    BtnEditar.Enabled = false; // Admin no se puede editar
                }
            }

            cargado = true;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (FrmAdministradores.administradorr.IdAdministrador == 0)
            {
                if (TxtNombre.Text.Equals("") || TxtContraseña.Text.Equals(""))
                {
                    MessageBox.Show("Por favor, complete todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                if (TxtNombre.Text.Equals(""))
                {
                    MessageBox.Show("Por favor, complete el campo de nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            ma.CommitRollback(true);
            ma.SetCommit(true);

            if (FrmAdministradores.administradorr.IdAdministrador == 0)
            {
                ma.Guardar(new Administrador(0, TxtNombre.Text, TxtContraseña.Text));
            }

            else
            {
                if(TxtContraseña.Text.Equals(""))
                {
                    ma.Editar(new Administrador(FrmAdministradores.administradorr.IdAdministrador, TxtNombre.Text, ""), false);
                }
                else
                {
                    ma.Editar(new Administrador(FrmAdministradores.administradorr.IdAdministrador, TxtNombre.Text, TxtContraseña.Text), true);
                }
            }

            Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            ma.CommitRollback(false);
            ma.SetCommit(true);
            Close();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (FrmAdministradores.administradorr.IdAdministrador == 0)
                MessageBox.Show("Por favor, primero cree al bibliotecario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                CmbAccesos.Enabled = true; CbVer.Enabled = true; CbEditar.Enabled = true; CbCrear.Enabled = true; CbActivar.Enabled = true; BtnEditar.Enabled = false;
                ma.SetCommit(false);
                ma.StartTransaction();
            }
        }

        private void CbVer_CheckedChanged(object sender, EventArgs e)
        {
            if (!cargado)
                return;

            if(CbVer.Checked)
                ma.GuardarPermiso(int.Parse(CmbAccesos.SelectedValue.ToString()), 1, FrmAdministradores.administradorr.IdAdministrador);
            else
                ma.BorrarPermiso(int.Parse(CmbAccesos.SelectedValue.ToString()), 1, FrmAdministradores.administradorr.IdAdministrador);
        }

        private void CbCrear_CheckedChanged(object sender, EventArgs e)
        {
            if (!cargado)
                return;
            if (CbCrear.Checked)
                ma.GuardarPermiso(int.Parse(CmbAccesos.SelectedValue.ToString()), 2, FrmAdministradores.administradorr.IdAdministrador);
            else
                ma.BorrarPermiso(int.Parse(CmbAccesos.SelectedValue.ToString()), 2, FrmAdministradores.administradorr.IdAdministrador);
        }

        private void CbEditar_CheckedChanged(object sender, EventArgs e)
        {
            if (!cargado)
                return;
            if (CbEditar.Checked)
                ma.GuardarPermiso(int.Parse(CmbAccesos.SelectedValue.ToString()), 3, FrmAdministradores.administradorr.IdAdministrador);
            else
                ma.BorrarPermiso(int.Parse(CmbAccesos.SelectedValue.ToString()), 3, FrmAdministradores.administradorr.IdAdministrador);
        }

        private void CbActivar_CheckedChanged(object sender, EventArgs e)
        {
            if (!cargado)
                return;
            if (CbActivar.Checked)
                ma.GuardarPermiso(int.Parse(CmbAccesos.SelectedValue.ToString()), 4, FrmAdministradores.administradorr.IdAdministrador);
            else
                ma.BorrarPermiso(int.Parse(CmbAccesos.SelectedValue.ToString()), 4, FrmAdministradores.administradorr.IdAdministrador);
        }

        private void CmbAccesos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!cargado)
                return;
            ma.LlenarPermisos(int.Parse(CmbAccesos.SelectedValue.ToString()), FrmAdministradores.administradorr.IdAdministrador, CbVer, CbCrear, CbEditar, CbActivar);
        }

		private void label6_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}
	}
}
