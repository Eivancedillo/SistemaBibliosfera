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

namespace SistemaBibliosfera
{
    public partial class FrmDashboard : Form
    {
        ManejadorDashboard Md;
        public FrmDashboard()
        {
            InitializeComponent();

            Md = new ManejadorDashboard();
            
            // Mostrar administrador usado
            Md.ConsultarNombreAdministrador(FrmPrincipal.IdAdministrador, LblBibliotecario);

            // Mostrar total de libros, miembros y prestamos activos
            Md.ConsultarTotalLibros(LblTotalLibros);
            Md.ConsultarTotalMiembros(LblTotalMiembros);
            Md.ConsultarPrestamosActivos(LblPrestamosActivos);

            // Mostrar total de prestamos, asistencias y devoluciones de HOY
            Md.ConsultarPrestamosHoy(LblPrestamosHoy);
            Md.ConsultarAsistenciasHoy(LblAsistenciasHoy);
            Md.ConsultarDevolucionesHoy(LblDevolucionesHoy);

            // Mostrar el TOP 5 de categorias mas prestadas
            Md.ConsultarTopCategorias(new List<Label> { LblCatTop1, LblCatTop2, LblCatTop3, LblCatTop4, LblCatTop5 }, LblCategoriaMasPopular);

            // Alertas

            // 1. Alerta de Vencimientos (Color Rojo Claro)
            Md.MostrarAlerta(Md.ContarPrestamosPorVencer(), "préstamos prontos a vencer",
            Color.LightPink,
            panelAlertaVencimiento,
            lblAlertaVencimiento);

            // 2. Alerta de Reparaciones (Color Amarillo Claro)
            Md.MostrarAlerta(Md.ContarLibrosEnReparacion(), "libros en mal estado (reparación)",
            Color.LightYellow,
            panelAlertaReparacion,
            lblAlertaReparacion);
        }


    }
}
