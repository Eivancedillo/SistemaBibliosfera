using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos;
using Entidades;

namespace Manejadores
{
    public class ManejadorAdquisicion
    {
        Base b = new Base();

        #region GUARDAR CATEGORIA
        public void GuardarC (Categoria categoria )
        {
            b.Comando($"CALL p_insertar_categorias({categoria.Nombre}");
        }
        #endregion GUARDAR CATEGORIA

        #region MODIFICAR CATEGORIA
        public void ModificarC (Categoria categoria)
        {
            b.Comando($"CALL p_editar_categoria({categoria.Nombre}, {categoria.IdCategoria})");
        }
        #endregion MODIFICAR CATEGORIA

        #region DESACTIVAR CATEGORIA
        public void DesactivarC (Categoria categoria)
        {
            b.Comando($"CALL p_desactivar_categorias({categoria.IdCategoria})");
        }

        #endregion DESACTIVAR CATEGORIA

        #region ACTIVAR CATEGORIA
        public void ActivarC (Categoria categoria)
        {
            b.Comando($"CALL p_activar_categorias({categoria.IdCategoria})");
        }
        #endregion ACTIVAR CATEGORIA

        #region GUARDAR EDITORIAL
        public void GuardarE (Editorial editorial)
        {
            b.Comando($"CALL p_insertar_editoriales({editorial.Nombre})");
        }
        #endregion GUARDAR EDITORIAL

        #region MODIFICAR EDITORIAL
        public void ModificarE (Editorial editorial)
        {
            b.Comando($"CALL p_editar_editoriales({editorial.Nombre}, {editorial.IdEditorial})");
        }
        #endregion MODIFICAR EDITORIAL

        #region DESACTIVAR EDITORIAL
        public void DesactivarE (Editorial editorial)
        {
            b.Comando($"CALL p_desactivar_editoriales({editorial.IdEditorial})");
        }
        #endregion DESACTIVAR EDITORIAL

        #region ACTIVAR EDITORIAL 
        public void ActivarE (Editorial editorial)
        {
            b.Comando($"CALL p_activar_editoriales({editorial.IdEditorial})");
        }
        #endregion ACTIVAR EDITORIAL

        #region GUARDAR AUTORES
        public void GuardarA (Autor autor)
        {
            b.Comando($"CALL p_insertar_autores({autor.Nombre})");
        }
        #endregion GUARDAR AUTORES

        #region MODIFICAR AUTORES
        public void ModificarA (Autor autor)
        {
            b.Comando($"CALL p_editar_autores({autor.Nombre}, {autor.IdAutor})");
        }
        #endregion MODIFICAR AUTORES

        #region DESACTIVAR AUTORES
        public void DesactivarA (Autor autor)
        {
            b.Comando($"CALL p_desactivar_autores({autor.IdAutor})");
        }
        #endregion DESACTIVAR AUTORES

        #region ACTIVAR AUTORES
        public void ActivarA (Autor autor)
        {
            b.Comando($"CALL p_activar_autores({autor.IdAutor})");
        }
        #endregion ACTIVAR AUTORES

        #region DATOS QUE SE MOSTRARAN EN EL DTG
        public void Mostrar (string consulta, DataGridView tabla, string datos)
        {
            tabla.Columns.Clear();
            tabla.DataSource = b.Consultar(consulta, datos).Tables[0];
            tabla.Columns["IdCategoria"].Visible = false;
            tabla.Columns["IdEditorial"].Visible = false;
            tabla.Columns["IdAutor"].Visible = false;
            tabla.Columns.Insert(3, Boton("Seleccionar", Color.Green));
            tabla.Columns.Insert(4, Boton("Editar", Color.Blue));
            tabla.Columns.Insert(5, Boton("Desactivar", Color.Red));
            tabla.AutoResizeColumns();
            tabla.AutoResizeRows();

        }
        #endregion DATOS QUE SE MOSTRARAN EN EL DTG


        public static DataGridViewButtonColumn Boton(string titulo, Color fondo)
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Text = titulo;
            btn.UseColumnTextForButtonValue = true;
            btn.FlatStyle = FlatStyle.Popup;
            btn.DefaultCellStyle.BackColor = fondo;
            btn.DefaultCellStyle.ForeColor = Color.Black;
            return btn;
        }




    }
}
