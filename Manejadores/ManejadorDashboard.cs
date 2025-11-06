using AccesoDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manejadores
{
    public class ManejadorDashboard
    {
        Base b = new Base();

        public void ConsultarNombreAdministrador(int IdAdministrador, Label lbl)
        {
            DataTable dt = b.Consultar($"select Nombre from Administradores where IdAdministrador = {IdAdministrador}", "Administradores").Tables[0];
            DataRow dr = dt.Rows[0];

            lbl.Text = dr["Nombre"].ToString();
        }

        public void ConsultarTotalLibros(Label lbl)
        {
            DataTable dt = b.Consultar("select count(*) as TotalLibros from Libros where Activo = true", "Libros").Tables[0];
            DataRow dr = dt.Rows[0];

            lbl.Text = dr["TotalLibros"].ToString();
        }

        public void ConsultarTotalMiembros(Label lbl)
        {
            DataTable dt = b.Consultar("select count(*) as TotalMiembros from Miembros where Estado = true", "Miembros").Tables[0];
            DataRow dr = dt.Rows[0];

            lbl.Text = dr["TotalMiembros"].ToString();
        }

        public void ConsultarPrestamosActivos(Label lbl)
        {
            DataTable dt = b.Consultar("select count(*) as TotalPrestamos from Prestamos where EstadoPrestamo = 'Activo'", "Prestamos").Tables[0];
            DataRow dr = dt.Rows[0];

            lbl.Text = dr["TotalPrestamos"].ToString();
        }

        public void ConsultarPrestamosHoy(Label lbl)
        {
            // Solo necesitamos la FECHA
            string fechaHoy = DateTime.Now.ToString("yyyy-MM-dd");

            // Usamos DATE(FechaPrestamo) para que MySQL ignore la hora al comparar
            DataTable dt = b.Consultar($"SELECT COUNT(*) as TotalPrestamosHoy FROM Prestamos WHERE DATE(FechaPrestamo) = '{fechaHoy}' AND EstadoPrestamo = 'Activo'", "Prestamos").Tables[0];

            DataRow dr = dt.Rows[0];
            lbl.Text = dr["TotalPrestamosHoy"].ToString();
        }

        public void ConsultarAsistenciasHoy(Label lbl)
        {
            // Solo necesitamos la FECHA
            string fechaHoy = DateTime.Now.ToString("yyyy-MM-dd");

            // Usamos DATE(FechaPrestamo) para que MySQL ignore la hora al comparar
            DataTable dt = b.Consultar($"SELECT COUNT(*) as TotalAsistenciasHoy FROM RegistroEntradas WHERE DATE(FechaIngreso) = '{fechaHoy}'", "RegistroEntradas").Tables[0];

            DataRow dr = dt.Rows[0];
            lbl.Text = dr["TotalAsistenciasHoy"].ToString();
        }

        public void ConsultarDevolucionesHoy(Label lbl)
        {
            // Solo necesitamos la FECHA
            string fechaHoy = DateTime.Now.ToString("yyyy-MM-dd");

            // Usamos DATE(FechaDevolucion) para que MySQL ignore la hora al comparar
            DataTable dt = b.Consultar($"SELECT COUNT(*) as TotalDevolucionesHoy FROM Prestamos WHERE DATE(FechaDevolucionReal) = '{fechaHoy}' AND EstadoPrestamo = 'Finalizado' AND FechaDevolucionReal is not null", "Prestamos").Tables[0];

            DataRow dr = dt.Rows[0];
            lbl.Text = dr["TotalDevolucionesHoy"].ToString();
        }

        public void ConsultarTopCategorias(List<Label> lblsTop5, Label lblMaximo)
        {
            // 1. Limpieza inicial
            foreach (var lbl in lblsTop5) lbl.Text = "N/A";
            lblMaximo.Text = "N/A";

            // 2. Consultar
            DataTable dt = b.Consultar("SELECT * FROM v_top_categorias", "v_top_categorias").Tables[0];

            // 3. Si NO hay datos, salimos
            if (dt.Rows.Count == 0) return;

            // 4. Llenar el Label MÁXIMO
            string catMax = dt.Rows[0]["Categoria"].ToString();
            // string valMax = dt.Rows[0]["TotalPrestamos"].ToString();
            lblMaximo.Text = $"{catMax}";

            // 5. Llenar la lista del Top 5 (igual que antes)
            for (int i = 0; i < Math.Min(dt.Rows.Count, lblsTop5.Count); i++)
            {
                string cat = dt.Rows[i]["Categoria"].ToString();
                // string val = dt.Rows[i]["TotalPrestamos"].ToString();
                lblsTop5[i].Text = $"{cat}";
            }
        }

        public int ContarPrestamosPorVencer()
        {
            DataTable dt = b.Consultar("SELECT * FROM v_prestamosavencer", "v_prestamosavencer").Tables[0];

            // Devolvemos el valor de la primera (y única) celda
            return int.Parse(dt.Rows[0][0].ToString());
        }

        public int ContarLibrosEnReparacion()
        {
            DataTable dt = b.Consultar("SELECT * FROM v_prestamosreparacion", "v_prestamosreparacion").Tables[0];
            return int.Parse(dt.Rows[0][0].ToString());
        }

        // Método privado para manejar la visualización de CUALQUIER alerta
        public void MostrarAlerta(int cantidad, string mensajeBase, Color colorFondo, Panel panel, Label label)
        {
            if (cantidad > 0)
            {
                // Si hay alertas, mostramos y configuramos
                label.Text = $"{cantidad} {mensajeBase}";
                panel.BackColor = colorFondo;
                panel.Visible = true;
                label.Visible = true;
            }
            else
            {
                // Si no hay, ocultamos todo
                panel.Visible = false;
                label.Visible = false;
            }
        }
    }
}
