using CapaNegocio;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Data;
using System.Collections.Generic; // Necesario para List<T>
using System.Linq; // Necesario para String.Join

namespace CapaPresentacion
{
    public partial class Salas : Form
    {
        // Datos recibidos de la compra
        private int idPelicula;
        private string horario;
        private string tituloPelicula;
        private int cantidadBoletos;
        private decimal totalPagar;
        private string tipoEntrada;
        private Image ImagenPelicula;

        // LISTAS PARA EL MODO GRÁFICO
        private List<Button> botonesAsiento = new List<Button>();
        private List<string> asientosSeleccionados = new List<string>();

        public Salas(int id, string titulo, string horario, int cantidad, decimal total, string tipo, Image imagenRecibida)
        {
            InitializeComponent();

            // 1. Guardar variables
            this.idPelicula = id;
            this.horario = horario;
            this.tituloPelicula = titulo;
            this.cantidadBoletos = cantidad;
            this.totalPagar = total;
            this.tipoEntrada = tipo;
            this.ImagenPelicula = imagenRecibida;

            // 2. Determinar Sala y Texto
            int idSalaDestino = (tipo.Contains("VIP")) ? 3 : 1;
            string textSala = (idSalaDestino == 3) ? "VIP" : "NORMAL"; // Declarada aquí para que no falle

            // 3. Mostrar Info en Pantalla
            // Usamos try-catch por seguridad visual, pero la variable 'textSala' ya existe
            try
            {
                if (lblTipoSala != null)
                {
                    lblTipoSala.Text = $"CATEGORÍA: {textSala} (Sala {idSalaDestino})";
                    lblTipoSala.ForeColor = (textSala == "VIP") ? Color.Yellow : Color.White;
                }

                if (label9 != null)
                {
                    label9.Text = $"Total: ${total}";
                }
            }
            catch { }

            // 4. Cargar Asientos Gráficos
            CargarAsientosDeBaseDatos(idSalaDestino);

            // 5. Diseño
            ConfigurarBotonRedondo();
        }

        // --- CARGA DE DATOS ---
        private void CargarAsientosDeBaseDatos(int idSala)
        {
            try
            {
                CN_Tickets negocio = new CN_Tickets();
                DataTable tablaAsientos = negocio.TraerAsientos(idSala);

                // ¡AQUÍ LLAMAMOS AL DIBUJO GRÁFICO!
                RenderizarAsientosGraficos(tablaAsientos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar asientos: " + ex.Message);
            }
        }

        // --- RENDERIZADO DE BOTONES SOBRE LA IMAGEN ---
        private void RenderizarAsientosGraficos(DataTable tablaAsientos)
        {
            botonesAsiento.Clear();

            // Buscamos el PictureBox (Asegúrate de que se llame pbMapaAsientos en el diseño)
            PictureBox pb = this.Controls.Find("pbMapaAsientos", true).FirstOrDefault() as PictureBox;

            if (pb == null)
            {
                MessageBox.Show("No se encontró el mapa de asientos (pbMapaAsientos).");
                return;
            }

            pb.Controls.Clear(); // Limpiamos botones viejos

            // --- AJUSTA ESTAS COORDENADAS A TU IMAGEN ---
            int startX = 50;
            int startY = 80;
            int seatWidth = 40;
            int seatHeight = 35;
            int spacingX = 10;
            int spacingY = 15;
            int maxSeatsPerRow = 10;

            int currentX = startX;
            int currentY = startY;
            int seatsInCurrentRow = 0;

            foreach (DataRow fila in tablaAsientos.Rows)
            {
                string codigoAsiento = fila["CodigoAsiento"].ToString();

                Button btnAsiento = new Button();
                btnAsiento.Text = codigoAsiento;
                btnAsiento.Size = new Size(seatWidth, seatHeight);
                btnAsiento.Location = new Point(currentX, currentY);

                // Estilo
                btnAsiento.BackColor = Color.Green; // Libre
                btnAsiento.ForeColor = Color.White;
                btnAsiento.FlatStyle = FlatStyle.Flat;
                btnAsiento.FlatAppearance.BorderSize = 0;
                btnAsiento.Font = new Font("Segoe UI", 7, FontStyle.Bold);

                btnAsiento.Tag = codigoAsiento;
                btnAsiento.Click += BtnAsiento_Click; // Evento Click

                pb.Controls.Add(btnAsiento); // Agregamos SOBRE la imagen
                botonesAsiento.Add(btnAsiento);

                // Siguiente posición
                currentX += seatWidth + spacingX;
                seatsInCurrentRow++;

                if (seatsInCurrentRow >= maxSeatsPerRow)
                {
                    currentY += seatHeight + spacingY;
                    currentX = startX;
                    seatsInCurrentRow = 0;
                }
            }
        }

        // --- EVENTO CLICK DEL ASIENTO (SELECCIÓN) ---
        private void BtnAsiento_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string asiento = btn.Tag.ToString();

            if (btn.BackColor == Color.Green) // Seleccionar
            {
                if (asientosSeleccionados.Count >= cantidadBoletos)
                {
                    MessageBox.Show($"Solo puedes seleccionar {cantidadBoletos} asientos.", "Límite", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                btn.BackColor = Color.Orange;
                asientosSeleccionados.Add(asiento);
            }
            else if (btn.BackColor == Color.Orange) // Deseleccionar
            {
                btn.BackColor = Color.Green;
                asientosSeleccionados.Remove(asiento);
            }

            // Actualizar visualización (Label o TextBox)
            if (this.Controls.Find("txtMostrarAsientos", true).FirstOrDefault() is Control txt)
            {
                txt.Text = string.Join(", ", asientosSeleccionados);
            }
        }

        // --- BOTÓN CONFIRMAR ---
        private void Btn_Confirmar_Click(object sender, EventArgs e)
        {
            if (asientosSeleccionados.Count != cantidadBoletos)
            {
                MessageBox.Show($"Faltan asientos. Seleccionaste {asientosSeleccionados.Count} de {cantidadBoletos}.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                CN_Tickets negocio = new CN_Tickets();
                Guid usuarioId = Login.UsuarioSesion != null ? Login.UsuarioSesion.Id : Guid.NewGuid();
                int idSala = tipoEntrada.Contains("VIP") ? 3 : 1;

                string productos = "Boletos + Combos";
                string asientoTexto = string.Join(",", asientosSeleccionados); // Guardamos todos los asientos como texto

                // Guardamos (Nota: Esto guarda 1 ticket con la lista de asientos en texto.
                // Para guardar 1 fila por asiento, necesitarías un bucle aquí).
                string codigo = negocio.RegistrarVenta(
                    usuarioId, this.idPelicula, idSala, this.horario,
                    1, // ID Asiento Simulado (Ya que guardamos el texto real en otro lado o tocaría cambiar la BD)
                    1, this.totalPagar, productos + " (" + asientoTexto + ")"
                );

                MessageBox.Show($"¡Compra Exitosa!\nTicket: {codigo}\nAsientos: {asientoTexto}", "Listo");

                Cartelera inicio = new Cartelera();
                inicio.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // --- BOTÓN ATRÁS ---
        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
            VentaDeBoletos venta = new VentaDeBoletos(this.idPelicula.ToString(), this.tituloPelicula, this.ImagenPelicula);
            venta.Show();
        }

        // --- DISEÑO Y MOVIMIENTO ---
        private void ConfigurarBotonRedondo() { /* Tu código original */ }
        private void pictureBox5_Click(object sender, EventArgs e) { this.Close(); new Cartelera().Show(); }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")] private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")] private extern static void SendMessage(IntPtr h, int m, int w, int l);
        private void panelTop_MouseDown(object sender, MouseEventArgs e) { ReleaseCapture(); SendMessage(this.Handle, 0x112, 0x0f012, 0); }

        // Eventos vacíos
        private void Salas_Load(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void panel1_Paint_1(object sender, PaintEventArgs e) { }
        private void txtMostrarAsientos_TextChanged(object sender, EventArgs e) { }
        private void lblTipoSala_TextChanged(object sender, EventArgs e) { }
        private void pbMapaAsientos_Click(object sender, EventArgs e) { }
        private void comboBox_SelectedIndexChanged(object sender, EventArgs e) { } // Ya no se usa
        // ... (otros eventos viejos) ...
    }
}