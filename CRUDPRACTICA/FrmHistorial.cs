using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using CapaNegocio; 
using System.Runtime.InteropServices;
using CapaDatos;

namespace CapaPresentacion
{
    public partial class FrmHistorial : Form
    {
        public FrmHistorial()
        {
            InitializeComponent();
            ConfigurarDiseño();
        }

        private void FrmHistorial_Load(object sender, EventArgs e)
        {
            // Al abrir, cargamos la lista de ventas automáticamente
            CargarDatosHistorial();
        }

        private void CargarDatosHistorial()
        {
            try
            {
                CN_Tickets negocio = new CN_Tickets();

                // Llenamos la tabla con el historial de SQL
                // (Asegúrate de que tu DataGridView se llame dataGridView1 en el diseño)
                dgvTickets.DataSource = negocio.VerHistorialVentas();

                // Ajustes de diseño para la tabla
                dgvTickets.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvTickets.AllowUserToAddRows = false;
                dgvTickets.ReadOnly = true;
                dgvTickets.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar lista: " + ex.Message);
            }
        }

        // --- BOTONES DE ACCIÓN ---

        // Botón "Ver Ticket" (El que antes era Editar)
        private void Btn_editar_Click(object sender, EventArgs e)
        {
            if (dgvTickets.SelectedRows.Count > 0)
            {
                try
                {
                    if (dgvTickets.SelectedRows.Count > 0) // Asumo que tu tabla se llama dgvTickets
                    {
                        try
                        {
                            // --- USAR NOMBRES EXACTOS DE LAS COLUMNAS ---

                            string codigo = dgvTickets.CurrentRow.Cells["CodigoTicket"].Value.ToString();
                            string pelicula = dgvTickets.CurrentRow.Cells["Pelicula"].Value.ToString();
                            string horario = dgvTickets.CurrentRow.Cells["Horario"].Value.ToString();
                            string precio = dgvTickets.CurrentRow.Cells["PrecioTotal"].Value.ToString();
                            string idPelicula = dgvTickets.CurrentRow.Cells["IdPelicula"].Value.ToString(); // <-- NUEVO

                            // PASAMOS EL ID AL FORMULARIO DE EDICIÓN
                            FrmEditarTicket frmEditar = new FrmEditarTicket(codigo, pelicula, horario, precio, idPelicula); // <-- DEBEMOS EDITAR ESTO

                            if (frmEditar.ShowDialog() == DialogResult.OK)
                            {
                                // Refrescar tabla si la edición fue exitosa
                                CargarDatosHistorial();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al intentar editar el ticket: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Por favor, selecciona una fila para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al intentar editar el ticket: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Botón "Anular" (El que antes era Eliminar)
        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            // 1. Verificar si hay una fila seleccionada
            if (dgvTickets.SelectedRows.Count > 0)
            {
                // 2. Obtener el ID del ticket de la fila actual
                string codigoTicket = dgvTickets.CurrentRow.Cells["CodigoTicket"].Value.ToString();

                // 3. Pedir confirmación al usuario
                DialogResult resultado = MessageBox.Show(
                    "¿Está seguro que desea ANULAR y eliminar el ticket con código " + codigoTicket + "?",
                    "Confirmar Eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        // 4. Ejecutar la eliminación en la capa de negocio
                        CN_Tickets negocio = new CN_Tickets();
                        negocio.EliminarTicket(codigoTicket); // Llamada al método que creamos

                        MessageBox.Show("Venta anulada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // 5. Refrescar la tabla para ver el cambio
                        CargarDatosHistorial();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al intentar anular la venta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila para anular.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Botón "Exportar" (El que antes era Guardar)
        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            // Asumiendo que tu método de carga de tabla se llama MostrarTickets()
            CargarDatosHistorial();
            MessageBox.Show("Tabla de historial actualizada.", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        

        // Botón Salir (Casita)
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Cartelera menu = new Cartelera();
            menu.Show();
            this.Close();
        }

        // --- TU DISEÑO VISUAL (Reciclado) ---
        private void ConfigurarDiseño()
        {
            try
            {
                int radius = 20;
                // Aplicamos borde a los 3 botones principales
                AplicarBorde(Btn_guardar, radius);
                AplicarBorde(Btn_editar, radius);
                AplicarBorde(Btn_eliminar, radius);
            }
            catch { }
        }

        private void AplicarBorde(Button btn, int radius)
        {
            if (btn == null) return;
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(btn.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(btn.Width - radius, btn.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, btn.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            btn.Region = new Region(path);
        }

        // Movimiento de ventana
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Btn_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
        // Conecta esto al evento MouseDown del panel o formulario si quieres moverlo
        // private void FrmHistorial_MouseDown(object sender, MouseEventArgs e) { ReleaseCapture(); SendMessage(this.Handle, 0x112, 0x0f012, 0); }
    }
}
