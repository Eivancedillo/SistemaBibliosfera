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
    public partial class FrmAdquisiciones : Form
    {
        ManejadorAdquisicion Ma;
        List<Autor> LibroAutores;
        List<Categoria> LibroCategorias;
        Libro libro;
        bool x = false;

        public FrmAdquisiciones()
        {
            InitializeComponent();

            LibroAutores = new List<Autor>();
            LibroCategorias = new List<Categoria>();

            Ma = new ManejadorAdquisicion();
            libro = new Libro(0, "", "", 0, 0, LibroAutores, LibroCategorias);

            CmbEstado.Items.Add("Disponible");
            CmbEstado.Items.Add("Prestado");
            CmbEstado.Items.Add("Reparacion");
            CmbEstado.Items.Add("Perdido");

            TxtTitulo.Enabled = false; TxtCategoria.Enabled = false; TxtAutor.Enabled = false; TxtEditorial.Enabled = false; TxtAnioPublicacion.Enabled = false;
            CmbCodigo.Enabled = false; TxtUbicacion.Enabled = false; CmbEstado.Enabled = false;

            BtnVerAutores.Enabled = false; BtnVerCategorias.Enabled = false; BtnVerEditoriales.Enabled = false; BtnMasCodigo.Enabled = false; BtnMenosCodigo.Enabled = false;
        }

        private void BtnVerCategorias_Click(object sender, EventArgs e)
        {
            FrmCatagorias frm = new FrmCatagorias(libro);
            frm.ShowDialog();

            TxtCategoria.Text = "";

            foreach (var categoria in libro.LibroCategoria)
            {
                TxtCategoria.Text += categoria.Nombre + ", ";
            }

            // Aquitar al ultimo la coma
            if (TxtCategoria.Text.EndsWith(", "))
                TxtCategoria.Text = TxtCategoria.Text.Substring(0, TxtCategoria.Text.Length - 2);
        }

        private void BtnVerAutores_Click(object sender, EventArgs e)
        {
            FrmAutores frm = new FrmAutores(libro);
            frm.ShowDialog();

            TxtAutor.Text = "";

            foreach (var autor in libro.LibroAutores)
            {
                TxtAutor.Text += autor.Nombre + ", ";
            }

            // Quitar la ultima coma
            if (TxtAutor.Text.EndsWith(", "))
                TxtAutor.Text = TxtAutor.Text.Substring(0, TxtAutor.Text.Length - 2);
        }

        private void BtnVerEditoriales_Click(object sender, EventArgs e)
        {
            FrmEditoriales frm = new FrmEditoriales(libro);
            frm.ShowDialog();

            TxtEditorial.Text = "";
            TxtEditorial.Text = Ma.MostrarE(libro.IdEditorial);
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            // Limpiar entidad libro
            libro.ISBN = "";
            libro.Titulo = "";
            libro.AnioPublicacion = 0;
            libro.IdEditorial = 0;
            libro.LibroAutores = new List<Autor>();
            libro.LibroCategoria = new List<Categoria>();

            Close();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if(TxtAnioPublicacion.Text == "" || TxtTitulo.Text == "")
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(TxtAnioPublicacion.Text.Length != 4 || !int.TryParse(TxtAnioPublicacion.Text, out _))
            {
                MessageBox.Show("Por favor, ingrese un año de publicación válido (4 dígitos).", "Año inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            libro.Titulo = TxtTitulo.Text;
            libro.AnioPublicacion = int.Parse(TxtAnioPublicacion.Text);

            var rs = MessageBox.Show("¿Desea agregar ejemplares del libro?", "Agregar ejemplares", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rs == DialogResult.Yes)
            {
                CmbCodigo.Enabled = true; TxtUbicacion.Enabled = true; CmbEstado.Enabled = true;
                BtnMasCodigo.Enabled = true; BtnMenosCodigo.Enabled = true;
            }
            else
                Ma.GuardarLibro(libro);

            // Limpiar entidad libro
                libro.ISBN = "";
                libro.Titulo = "";
                libro.AnioPublicacion = 0;
                libro.IdEditorial = 0;
                libro.LibroAutores = new List<Autor>();
                libro.LibroCategoria = new List<Categoria>();

            // Limpiar formulario
            TxtIsbn.Enabled = true; TxtTitulo.Enabled = false; TxtAnioPublicacion.Enabled = false; 
            BtnVerCategorias.Enabled = false; BtnVerEditoriales.Enabled = false; BtnVerAutores.Enabled = false;
            TxtTitulo.Text = ""; TxtAnioPublicacion.Text = ""; TxtIsbn.Text = "";
            TxtCategoria.Text = ""; TxtAutor.Text = ""; TxtEditorial.Text = "";

        }

        private void TxtIsbn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Conirmar si es el ISBN correcto
                var rs = MessageBox.Show($"ISBN ingresado: '{TxtIsbn.Text}', ¿es correcto?", "IBSN ingresado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (rs == DialogResult.Yes)
                {
                    TxtIsbn.Enabled = false;

                    libro.ISBN = TxtIsbn.Text;

                    if (!x)
                    {
                        TxtAnioPublicacion.Enabled = true; TxtTitulo.Enabled = true;
                        BtnVerCategorias.Enabled = true; BtnVerEditoriales.Enabled = true; BtnVerAutores.Enabled = true;

                        x = true;
                    }
                }

                e.SuppressKeyPress = true;
            }
        }
    }
}
