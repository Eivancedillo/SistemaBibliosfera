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
        ManejadorCatalogo Mc;
        ManejadorPermisos permisos;

        List<Autor> LibroAutores;
        List<Categoria> LibroCategorias;
        List<Ejemplar> ejemplares;

        Libro libro;

        bool editando = false;

        public FrmAdquisiciones()
        {
            InitializeComponent();

            LibroAutores = new List<Autor>();
            LibroCategorias = new List<Categoria>();
            ejemplares = new List<Ejemplar>();

            Ma = new ManejadorAdquisicion();
            permisos = new ManejadorPermisos();
            libro = new Libro(0, "", "", 0, 0, LibroAutores, LibroCategorias);

            TxtTitulo.Enabled = false; TxtCategoria.Enabled = false; TxtAutor.Enabled = false; TxtEditorial.Enabled = false; TxtAnioPublicacion.Enabled = false;
            BtnVerAutores.Enabled = false; BtnVerCategorias.Enabled = false; BtnVerEditoriales.Enabled = false;
        }

        // Segunda sobrecarga del constructor para recibir un libro ya existente
        public FrmAdquisiciones(Libro librocatalogo)
        {
            InitializeComponent();

            Ma = new ManejadorAdquisicion();
            Mc = new ManejadorCatalogo();
            permisos = new ManejadorPermisos();

            ejemplares = new List<Ejemplar>();
            editando = true;

            libro = new Libro(librocatalogo.IdLibro, librocatalogo.ISBN, librocatalogo.Titulo, librocatalogo.IdEditorial, librocatalogo.AnioPublicacion, librocatalogo.LibroAutores, librocatalogo.LibroCategoria);
            TxtCategoria.Enabled = false; TxtAutor.Enabled = false; TxtEditorial.Enabled = false;

            // Llenar los campos con la informacion del libro pasado por parametro
            TxtIsbn.Text = libro.ISBN;
            TxtTitulo.Text = libro.Titulo;
            TxtAnioPublicacion.Text = libro.AnioPublicacion.ToString();
            TxtEditorial.Text = Ma.MostrarE(libro.IdEditorial);

            foreach (var autor in libro.LibroAutores)
            {
                TxtAutor.Text += autor.Nombre + ", ";
            }
            foreach (var categoria in libro.LibroCategoria)
            {
                TxtCategoria.Text += categoria.Nombre + ", ";
            }

            // Quitar las comas finales
            if (TxtAutor.Text.EndsWith(", "))
                TxtAutor.Text = TxtAutor.Text.Substring(0, TxtAutor.Text.Length - 2);
            if (TxtCategoria.Text.EndsWith(", "))
                TxtCategoria.Text = TxtCategoria.Text.Substring(0, TxtCategoria.Text.Length - 2);
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
            if(!permisos.ComprobarPermiso(3, 2, FrmPrincipal.IdAdministrador) && !editando)
            {
                MessageBox.Show("No tiene permiso para realizar esta acción.", "Permiso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Primero validar que se ingreso un ISBN
            if (TxtIsbn.Text.Equals(""))
            { 
                MessageBox.Show("Por favor, ingrese un ISBN.", "ISBN vacio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (TxtTitulo.Text.Equals("") || TxtAutor.Text.Equals("") || TxtCategoria.Text.Equals("") || TxtEditorial.Text  .Equals(""))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (TxtAnioPublicacion.Text.Length != 4 || !int.TryParse(TxtAnioPublicacion.Text, out _))
            {
                MessageBox.Show("Por favor, ingrese un año de publicación (4 dígitos).", "Año inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (int.Parse(TxtAnioPublicacion.Text) >= 1901)
            {
                if (int.Parse(TxtAnioPublicacion.Text) > DateTime.Now.Year)
                {
                    MessageBox.Show($"El año de publicación no puede ser mayor al año actual ({DateTime.Now.Year}).", "Año inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                MessageBox.Show("El año de publicación no puede ser menor a 1901.", "Año inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            libro.Titulo = TxtTitulo.Text;
            libro.AnioPublicacion = int.Parse(TxtAnioPublicacion.Text);

            if(editando)
                Mc.EditarLibro(libro);
            else
                Ma.GuardarLibro(libro);

            var rs = MessageBox.Show("¿Desea agregar ejemplares del libro?", "Agregar ejemplares", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rs == DialogResult.Yes)
            {
                FrmEjemplares frm = new FrmEjemplares(libro.IdLibro);
                frm.ShowDialog();

                Close();
            }
            else
            {
                if (editando)
                    Close();
                else
                {
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
            }

        }

        private void TxtIsbn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxtIsbn.Select(0, 0);
                this.ActiveControl = null;

                e.SuppressKeyPress = true;

                // Conirmar si es el ISBN correcto
                var rs = MessageBox.Show($"ISBN ingresado: '{TxtIsbn.Text}', ¿es correcto?", "IBSN ingresado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (rs == DialogResult.Yes)
                {
                    TxtIsbn.ReadOnly = true;

                    libro.ISBN = TxtIsbn.Text.Trim();

                    if (!editando)
                    {
                        TxtAnioPublicacion.Enabled = true; TxtTitulo.Enabled = true;
                        BtnVerCategorias.Enabled = true; BtnVerEditoriales.Enabled = true; BtnVerAutores.Enabled = true;
                    }
                }
                else
                {
                    TxtIsbn.Text = "";
                }
            }
        }

        private void BtnInsertarISBN_Click(object sender, EventArgs e)
        {
            // Conirmar si es el ISBN correcto
            var rs = MessageBox.Show($"ISBN ingresado: '{TxtIsbn.Text}', ¿es correcto?", "IBSN ingresado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rs == DialogResult.Yes)
            {
                TxtIsbn.ReadOnly = true;

                libro.ISBN = TxtIsbn.Text.Trim();

                if (!editando)
                {
                    TxtAnioPublicacion.Enabled = true; TxtTitulo.Enabled = true;
                    BtnVerCategorias.Enabled = true; BtnVerEditoriales.Enabled = true; BtnVerAutores.Enabled = true;
                }
            }
            else
            {
                TxtIsbn.Text = "";
            }
        }

        private void FrmAdquisiciones_Load(object sender, EventArgs e)
		{

		}
    }
}
