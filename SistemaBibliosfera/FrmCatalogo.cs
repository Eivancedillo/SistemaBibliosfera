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
        bool prestamo = false;
        public FrmCatalogo()
        {
            InitializeComponent();
            Mc = new ManejadorCatalogo();

            LibroAutores = new List<Autor>();
            LibroCategorias = new List<Categoria>();
            libro = new Libro(0, "", "", 0, 0, LibroAutores, LibroCategorias);

            Mc.LlenarCmbs(CmbEstado, CmbFiltro, CmbOrdenar);
        }

        public FrmCatalogo(bool prestamotraido)
        {
            InitializeComponent();
            Mc = new ManejadorCatalogo();

            LibroAutores = new List<Autor>();
            LibroCategorias = new List<Categoria>();
            libro = new Libro(0, "", "", 0, 0, LibroAutores, LibroCategorias);
            prestamo = prestamotraido;

            Mc.LlenarCmbs(CmbEstado, CmbFiltro, CmbOrdenar);
        }

        private void DtgDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Mc.LlenarEntidad(libro, DtgDatos);

            switch (columna)
            {
                case 10:
                    {
                        FrmAdquisiciones frm = new FrmAdquisiciones(libro);
                        frm.ShowDialog();
                        DtgDatos.Columns.Clear();
                    }
                    ; break;
                case 11:
                    {
                        if(!prestamo)
                            Mc.DesactivarLibro(libro);
                        else
                        {
                            if(DtgDatos.Rows[e.RowIndex].Cells["Disp"].Value.ToString() == "0")
                            {
                                MessageBox.Show("No hay ejemplares disponibles de este libro para préstamo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }

                            var rs = MessageBox.Show($"¿Desea seleccionar el libro '{libro.Titulo}' para el préstamo?", "Confirmar selección", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if(rs == DialogResult.Yes)
                            {
                                FrmDatosPrestamos.libroejemplar = libro;
                                Close();
                            }
                        }
                    }
                    ; break;
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (CmbEstado.SelectedItem == null || CmbFiltro.SelectedItem == null || CmbOrdenar.SelectedItem == null)
            {
                MessageBox.Show("Seleccione todos los filtros antes de continuar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(!prestamo)
                Mc.Mostrar(DtgDatos, TxtBuscar, CmbEstado, CmbFiltro, CmbOrdenar);
            else
                Mc.Mostrar(DtgDatos, TxtBuscar, CmbEstado, CmbFiltro, CmbOrdenar, true);
        }

        private void DtgDatos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex; columna = e.ColumnIndex;
        }

        private void FrmCatalogo_Load(object sender, EventArgs e)
        {

        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
