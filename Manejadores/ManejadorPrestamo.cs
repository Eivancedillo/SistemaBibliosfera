using AccesoDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Manejadores
{
    public class ManejadorPrestamo
    {
        Base b = new Base();

        public void Insertar(Prestamo prestamo)
        {
            string fechaFormateada = prestamo.FechaDevolucionPrevista.ToString("yyyy-MM-dd HH:mm:ss");

            b.Comando($"CALL p_insertar_prestamos({prestamo.NumeroControl}, {prestamo.IdEjemplar}, '{fechaFormateada}')");
        }

        public void Editar(Prestamo prestamo)
        {
            string fechaFormateada = prestamo.FechaDevolucionPrevista.ToString("yyyy-MM-dd HH:mm:ss");
            b.Comando($"CALL p_editar_prestamos({prestamo.IdPrestamo}, '{fechaFormateada}', '{prestamo.EstadoPrestamo}')");
        }

        public void Prestar(Prestamo prestamo)
        {
            b.Comando($"CALL p_prestar_ejemplar({prestamo.IdEjemplar})");
        }

        public void Pagar(Prestamo prestamo)
        {
            b.Comando($"CALL p_pagar_prestamos({prestamo.IdPrestamo})");
        }

        public void Cancelar(Prestamo prestamo)
        {
            b.Comando($"CALL p_cancelar_prestamos({prestamo.IdPrestamo})");
        }

        public void Finalizar(Prestamo prestamo)
        {
            b.Comando($"CALL p_finalizar_prestamos({prestamo.IdPrestamo})");
        }

        public void MostrarNombreMiembro(int numeroControl, TextBox txt)
        {
            txt.Text = b.Consultar($"SELECT CONCAT(Nombre, ' ', Apellidos) AS NombreCompleto FROM Miembros WHERE NumeroControl = {numeroControl}", "Miembros").Tables[0].Rows[0]["NombreCompleto"].ToString();
        }

        public void MostrarNombreLibro(int idLibro, TextBox txt)
        {
            txt.Text = b.Consultar($"SELECT Titulo FROM Libros WHERE IdLibro = {idLibro}", "Libros").Tables[0].Rows[0]["Titulo"].ToString();
        }

        public void MostrarCodigoEjemplar(int idEjemplar, TextBox txt)
        {
            txt.Text = b.Consultar($"SELECT Codigo FROM Ejemplares WHERE IdEjemplar = {idEjemplar}", "Ejemplares").Tables[0].Rows[0]["Codigo"].ToString();
        }

        public void Mostrar(string query, DataGridView tabla, string datos)
        {
            int conteo = 11;

            tabla.Columns.Clear();
            tabla.DataSource = b.Consultar(query, datos).Tables[0];
            tabla.Columns["IdPrestamo"].Visible = false;
            tabla.Columns["IdEjemplar"].Visible = false;
            tabla.Columns["IdLibro"].Visible = false;

            tabla.Columns.Insert(conteo, Boton("Editar", Color.Green));
            conteo++;

            if (tabla.Rows.Count > 0)
            {
                string estado = tabla.Rows[0].Cells["EstadoPrestamo"].Value.ToString();
                if (estado.Equals("Activo"))
                {
                    tabla.Columns.Insert(conteo, Boton("Cancelar", Color.Red));
                    conteo++;
                    tabla.Columns.Insert(conteo, Boton("Finalizar", Color.Blue));
                }
                else if (estado.Equals("Adeudado"))
                {
                    tabla.Columns.Insert(conteo, Boton("Pagar", Color.Orange));
                }
            }

            tabla.AutoResizeColumns();
            tabla.AutoResizeRows();
        }

        public static DataGridViewButtonColumn Boton(string titulo, Color color)
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Text = titulo;
            btn.UseColumnTextForButtonValue = true;
            btn.FlatStyle = FlatStyle.Popup;
            btn.DefaultCellStyle.BackColor = color;
            btn.DefaultCellStyle.ForeColor = Color.White;
            return btn;
        }
    }
}
