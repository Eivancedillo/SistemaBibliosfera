﻿using Entidades;
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
        public static Miembro miembro = new Miembro(0,"", "", "", "", true);
        ManejadorMiembros Mm;

        public FrmMiembros()
        {
            InitializeComponent();
            Mm = new ManejadorMiembros();

            CmbEstado.Items.Clear();
            CmbEstado.Items.Add("Activos");
            CmbEstado.Items.Add("Inactivos");
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if(CmbEstado.SelectedItem == null)
                MessageBox.Show("Seleccione un estado para buscar.", "Estado no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                string estado = CmbEstado.SelectedItem.ToString() == "Activos" ? "1" : "0";
                Mm.Mostrar($"select * from Miembros where (NumeroControl like '%{TxtBuscar.Text}%' or Nombre like '%{TxtBuscar.Text}%') and Estado = {estado};", DtgDatos, "Miembros");
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            miembro.NumeroControl = 0;
            miembro.Nombre = "";
            miembro.Apellidos = "";
            miembro.Email = "";
            miembro.Telefono = "";

            FrmDatosMiembro frm = new FrmDatosMiembro();
            frm.ShowDialog();
            DtgDatos.Columns.Clear();
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
                        FrmDatosMiembro frm = new FrmDatosMiembro();
                        frm.ShowDialog();
                        DtgDatos.Columns.Clear();
                    }
                    ; break;
                case 6:
                    {
                        bool estado = Convert.ToBoolean(DtgDatos.Rows[0].Cells["Estado"].Value);
                        if (estado)
                            Mm.Desactivar(miembro);
                        else
                            Mm.Activar(miembro);

                        DtgDatos.Columns.Clear();
                    }
                    ; break;
            }
        }

        private void DtgDatos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex; columna = e.ColumnIndex;
        }
    }
}
