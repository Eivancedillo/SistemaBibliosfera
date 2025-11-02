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
    public partial class FrmAutores : Form
    {
        ManejadorAdquisicion mad;
        public static Autor autor = new Autor(0, "");
        int fila = 0, columna = 0;
        public FrmAutores()
        {
            InitializeComponent();
            mad = new ManejadorAdquisicion();
            CmbEstado.Items.Add("Activo");
            CmbEstado.Items.Add("Inactivo");
            CmbEstado.SelectedIndex = 0;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            int estadoBool = (CmbEstado.SelectedIndex == 0) ? 1 : 0;

            string consulta = $"SELECT * FROM Autores WHERE Autor LIKE '%{TxtBuscar.Text}%' AND Activo = {estadoBool}";
            mad.Mostrar(consulta, DtgDatos, "Autores", CmbEstado.Text);
        }

        private void DtgDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            autor.IdAutor = int.Parse(DtgDatos.Rows[fila].Cells["IdAutor"].Value.ToString());
            autor.Nombre = DtgDatos.Rows[fila].Cells["Autor"].Value.ToString();

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
                        FrmDatosAutor datosAutor = new FrmDatosAutor();
                        datosAutor.ShowDialog();
                        DtgDatos.Columns.Clear();

                    }; break;
                case 5:
                    {
                        // Activar / Desactivar
                        if (CmbEstado.Text == "Activo")
                        {
                            mad.DesactivarA(autor);
                        }
                        else
                        {
                            mad.ActivarA(autor);
                        }
                        DtgDatos.Columns.Clear();

                    }; break;
            }
        }

        private void DtgDatos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex; columna = e.ColumnIndex;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            autor.IdAutor = 0;
            autor.Nombre = "";
            FrmDatosAutor datosAutor = new FrmDatosAutor();
            datosAutor.ShowDialog();
            DtgDatos.Columns.Clear();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
