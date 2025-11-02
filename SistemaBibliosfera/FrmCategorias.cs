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
    public partial class FrmCategorias : Form
    {
        ManejadorAdquisicion mad;
        public static Categoria categoria = new Categoria(0, "");
        int fila = 0, columna = 0;
        public FrmCategorias()
        {
            InitializeComponent();
            mad = new ManejadorAdquisicion();
            CmbEstado.Items.Add("Activo");
            CmbEstado.Items.Add("Inactivo");
            CmbEstado.SelectedIndex = 0;
            
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            int estadoBool = (CmbEstado.SelectedIndex == 0) ? 1 : 0;

            string consulta = $"SELECT * FROM Categorias WHERE Nombre LIKE '%{TxtBuscar.Text}%' AND Activo = {estadoBool}";
            mad.Mostrar(consulta, DtgDatos, "Categorias", CmbEstado.Text);
        }

        private void DtgDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            categoria.IdCategoria = int.Parse(DtgDatos.Rows[fila].Cells["IdCategoria"].Value.ToString());
            categoria.Nombre = DtgDatos.Rows[fila].Cells["Nombre"].Value.ToString();

            switch (columna)
            {
                case 3:
                    {
                        // Seleccionar
                        this.Close();

                    }; break;
                case 4:
                    {
                        //Editar
                        FrmDatosCategoria datosCategoria = new FrmDatosCategoria();
                        datosCategoria.ShowDialog();
                        DtgDatos.Columns.Clear();

                    }; break;
                case 5:
                    {
                        // Activar / Desactivar
                        if (CmbEstado.Text == "Activo")
                        {
                            mad.DesactivarC(categoria);
                        }
                        else
                        {
                            mad.ActivarC(categoria);
                        }
                        DtgDatos.Columns.Clear();

                    }
                    ; break;
            }
        }

        private void DtgDatos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex; columna = e.ColumnIndex;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            categoria.IdCategoria = 0;
            categoria.Nombre = "";
            FrmDatosCategoria datosCategoria = new FrmDatosCategoria();
            datosCategoria.ShowDialog();
            DtgDatos.Columns.Clear();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
