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
    public partial class FrmCatalogo : Form
    {
        ManejadorCatalogo Mc;
        List<Autor> LibroAutores;
        List<Categoria> LibroCategorias;
        Libro libro;
        int fila = 0, columna = 0;
        public FrmCatalogo()
        {
            InitializeComponent();
            Mc = new ManejadorCatalogo();

            LibroAutores = new List<Autor>();
            LibroCategorias = new List<Categoria>();
            libro = new Libro(0, "", "", 0, 0, LibroAutores, LibroCategorias);

            Mc.LlenarCmbs(CmbEstado, CmbFiltro, CmbOrdenar);
        }

        private void DtgDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (CmbEstado.SelectedItem == null || CmbFiltro.SelectedItem == null || CmbOrdenar.SelectedItem == null)
            {
                MessageBox.Show("Seleccione todos los filtros antes de continuar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Mc.Mostrar(DtgDatos, TxtBuscar, CmbEstado, CmbFiltro, CmbOrdenar);
        }

        private void DtgDatos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex; columna = e.ColumnIndex;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
