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
                dataGridView1.DataSource = negocio.VerHistorialVentas();

                // Ajustes de diseño para la tabla
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.ReadOnly = true;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtenemos datos de la fila seleccionada
                string codigo = dataGridView1.CurrentRow.Cells["CodigoTicket"].Value.ToString();
                string peli = dataGridView1.CurrentRow.Cells["Pelicula"].Value.ToString();
                string total = dataGridView1.CurrentRow.Cells["PrecioTotal"].Value.ToString();

                MessageBox.Show($"TICKET SELECCIONADO:\n\nCódigo: {codigo}\nPelícula: {peli}\nTotal: ${total}",
                                "Detalle de Venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Por favor selecciona una venta de la lista.");
            }
        }

        // Botón "Anular" (El que antes era Eliminar)
        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Función de anular venta disponible próximamente (Requiere permisos de Admin).");
        }

        // Botón "Exportar" (El que antes era Guardar)
        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Función Exportar a Excel en construcción.");
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
