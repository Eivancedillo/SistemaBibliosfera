using AccesoDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
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
            var rs = MessageBox.Show("¿Está seguro de que desea cancelar este préstamo? Esta acción no se puede deshacer.", "Confirmar cancelación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (rs == DialogResult.Yes)
                b.Comando($"CALL p_cancelar_prestamos({prestamo.IdPrestamo}, {prestamo.IdEjemplar})");
        }

        public void Finalizar(Prestamo prestamo)
        {
            var rs = MessageBox.Show("¿Está seguro de que desea finalizar este préstamo? Esta acción no se puede deshacer.", "Confirmar finalización", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (rs == DialogResult.Yes)
            {
                // Conseguir fecha actual formateada
                string fechaFormateada = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                // Consultar si el libro esta dañado para marcarlo como reparacion
                var rs2 = MessageBox.Show("¿El ejemplar está dañado?", "Estado del ejemplar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if(rs2 == DialogResult.Yes)
                {
                    b.Comando($"CALL p_finalizar_prestamosreparacion({prestamo.IdPrestamo}, {prestamo.IdEjemplar},'{fechaFormateada}')");
                }
                else
                    b.Comando($"CALL p_finalizar_prestamos({prestamo.IdPrestamo}, {prestamo.IdEjemplar},'{fechaFormateada}')");
            }
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

        public void MostrarAdeudo(int IdPrestamo, out int IdMulta, out int IdEjemplar, TextBox Titulo, TextBox Codigo, TextBox Fecha, TextBox Monto)
        {
            // Conseguir datos de la Multa de v_multas
            var tabla = b.Consultar($"SELECT * FROM v_multas WHERE IdPrestamo = {IdPrestamo}", "v_multas").Tables[0];

            Titulo.Text = tabla.Rows[0]["Titulo"].ToString();
            Codigo.Text = tabla.Rows[0]["Codigo"].ToString();
            Fecha.Text = tabla.Rows[0]["FechaDevolucionPrevista"].ToString();
            Monto.Text = tabla.Rows[0]["Monto"].ToString();
            IdMulta = int.Parse(tabla.Rows[0]["IdMulta"].ToString());
            IdEjemplar = int.Parse(tabla.Rows[0]["IdEjemplar"].ToString());
        }

        public void AdeudarLibros()
        {
            b.Comando($"CALL p_adeudar_prestamos()");
        }

        public void PagarAdeudos(int IdMulta, int IdEjemplar, int IdPrestamo)
        {
            var rs = MessageBox.Show("¿Está seguro de que desea pagar esta multa? Esta acción no se puede deshacer.", "Confirmar pago", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rs == DialogResult.Yes)
            {
                string fechaFormateada = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                b.Comando($"CALL p_pagar_multa({IdMulta}, {IdEjemplar}, {IdPrestamo},'{fechaFormateada}')");
            }
        }

        public bool TieneAdeudosPendientes(int numeroControl)
        {
            // Consultamos si existe AL MENOS UN préstamo con estado 'Adeudo' para este usuario
            DataTable dt = b.Consultar($"SELECT COUNT(*) FROM Prestamos WHERE NumeroControl = {numeroControl} AND EstadoPrestamo = 'Adeudo'", "Prestamos").Tables[0];

            int cantidadAdeudos = int.Parse(dt.Rows[0][0].ToString());

            // Si la cantidad es mayor a 0, significa que SÍ tiene adeudos
            return cantidadAdeudos > 0;
        }

        public void Mostrar(string query, DataGridView tabla, string datos)
        {
            int conteo = 11;

            tabla.Columns.Clear();
            tabla.DataSource = b.Consultar(query, datos).Tables[0];
            tabla.Columns["IdPrestamo"].Visible = false;
            tabla.Columns["IdEjemplar"].Visible = false;
            tabla.Columns["IdLibro"].Visible = false;

            // Si FechaDevolucionReal no tiene datos, ocultarla
            if (tabla.Rows.Count > 0 && tabla.Rows[0].Cells["FechaDevolucionReal"].Value.ToString() == "")
                tabla.Columns["FechaDevolucionReal"].Visible = false;

            if (tabla.Rows.Count > 0)
            {
                string estado = tabla.Rows[0].Cells["EstadoPrestamo"].Value.ToString();
                if (estado.Equals("Activo"))
                {
                    tabla.Columns.Insert(conteo, Boton("Editar", Color.Green));
                    conteo++;
                    tabla.Columns.Insert(conteo, Boton("Cancelar", Color.Red));
                    conteo++;
                    tabla.Columns.Insert(conteo, Boton("Finalizar", Color.Blue));
                }
                else if (estado.Equals("Adeudo"))
                {
                    tabla.Columns.Insert(conteo, Boton("Pagar", Color.Orange));
                }
            }

            // Cambiar nombres de columnas a formato amigable
            tabla.Columns["NumeroControl"].HeaderText = "Número de Control";
            tabla.Columns["FechaPrestamo"].HeaderText = "Fecha de Préstamo";
            tabla.Columns["FechaDevolucionPrevista"].HeaderText = "Fecha de Devolución Prevista";
            tabla.Columns["FechaDevolucionReal"].HeaderText = "Fecha de Devolución Real";
            tabla.Columns["EstadoPrestamo"].HeaderText = "Estado del Préstamo";

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

        #region ENVÍO DE CORREOS AUTOMÁTICOS
        public void EnviarRecordatoriosAutomaticos()
        {
            // 1. CONSULTA
            DataTable dt = b.Consultar("SELECT * FROM v_correos_pendientes", "Correos").Tables[0];

            int enviados = 0;

            // 2. PROCESO: Recorremos la lista que nos dio la vista
            foreach (DataRow row in dt.Rows)
            {
                // Obtenemos los datos de la fila
                string idPrestamo = row["IdPrestamo"].ToString();
                string email = row["Email"].ToString();
                string nombre = row["NombreCompleto"].ToString(); // Ya viene concatenado
                string libro = row["Libro"].ToString();
                string fecha = DateTime.Parse(row["FechaDevolucionPrevista"].ToString()).ToShortDateString();

                // Armamos el correo
                string asunto = "📚 Recordatorio Bibliosfera: Tu libro vence pronto";
                string cuerpo = $@"
            <h3>Hola, {nombre}</h3>
            <p>El libro <b>'{libro}'</b> tiene como fecha límite: <b style='color:red'>{fecha}</b>.</p>
            <p>¡No olvides devolverlo!</p>";

                // 3. ENVÍO Y ACTUALIZACIÓN
                if (EnviarCorreo(email, asunto, cuerpo))
                {
                    // Marcamos en la tabla original que ya se avisó
                    b.Comando($"UPDATE Prestamos SET AvisoEnviado = 1 WHERE IdPrestamo = {idPrestamo}");
                    enviados++;
                }
            }

            if (enviados > 0)
            {
                // Depuracion
                // MessageBox.Show($"Se enviaron {enviados} correos exitosamente.");
            }
        }

        private bool EnviarCorreo(string destinatario, string asunto, string cuerpo)
        {
            // 1. Configuración del Servidor (Ejemplo con GMAIL)
            // Si usas Outlook/Hotmail el host es "smtp.office365.com" y puerto 587
            string remitente = "bibliosfera6@gmail.com";
            string password = "lsqx yulg fmbl didt";
            string host = "smtp.gmail.com";
            int puerto = 587;

            try
            {
                // 2. Preparamos el mensaje
                MailMessage mensaje = new MailMessage();
                mensaje.From = new MailAddress(remitente, "Biblioteca Bibliosfera"); // El segundo parámetro es el nombre que ve el usuario
                mensaje.To.Add(destinatario);
                mensaje.Subject = asunto;
                mensaje.Body = cuerpo;
                mensaje.IsBodyHtml = true; // Importante para que se vean bien las negritas y formatos HTML

                // 3. Configuramos el cliente SMTP
                SmtpClient cliente = new SmtpClient(host, puerto);
                cliente.EnableSsl = true; // Gmail requiere SSL
                cliente.UseDefaultCredentials = false;
                cliente.DeliveryMethod = SmtpDeliveryMethod.Network;
                cliente.Credentials = new NetworkCredential(remitente, password);

                // 4. Enviamos
                cliente.Send(mensaje);
                return true; // Todo salió bien
            }
            catch (Exception ex)
            {
                // Si falla, puedes guardar el error en un log o mostrarlo en consola para depurar
                Console.WriteLine("Error al enviar correo: " + ex.Message);
                return false; // Hubo un error
            }
        }
        #endregion
    }
}
