using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Data; 
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace CapaPresentacion
{
    public partial class Salas : Form
    {
        // DATOS RECIBIDOS
        private int idPelicula;
        private string horario;
        private string tituloPelicula;
        private int cantidadBoletos;
        private decimal totalPagar;
        private string tipoEntrada;
        private Image ImagenPelicula; // <-- Guardamos la foto aquí

        // LISTAS PARA EL MODO GRÁFICO
        private List<Button> botonesAsiento = new List<Button>();
        private List<string> asientosSeleccionados = new List<string>();

        // CONSTRUCTOR MODIFICADO (7 ARGUMENTOS)
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

            // 2. Determinar Sala y Nombre
            int idSalaDestino = (tipo.Contains("VIP")) ? 3 : 1;
            string nombreSala = (idSalaDestino == 3) ? "VIP" : "NORMAL";

            // 3. Mostrar Info en Pantalla (Directamente)
            // Usamos try-catch por seguridad, pero asignamos directo al control
            try
            {
                // Mostrar Total
                label9.Text = $"Total: ${total}";

                // Mostrar Categoría y Sala
                // (Asegúrate de que en el diseño este control se llame 'lblTipoSala')
                lblTipoSala.Text = $"CATEGORÍA: {nombreSala} (Sala {idSalaDestino})";

                // Cambiar color según tipo
                if (nombreSala == "VIP")
                    lblTipoSala.ForeColor = Color.Yellow;
                else
                    lblTipoSala.ForeColor = Color.White;
            }
            catch { }

            // 4. Cargar Asientos Gráficos
            CargarAsientosGraficos(idSalaDestino);

            // 5. Diseño
            ConfigurarBotonRedondo();
        }



        // --- CARGA DE ASIENTOS DESDE BD ---
        private void CargarAsientosGraficos(int idSala)
        {
            try
            {
                CN_Tickets negocio = new CN_Tickets();
                DataTable tablaAsientos = negocio.TraerAsientos(idSala); // Trae A1, A2... desde SQL

                RenderizarBotones(tablaAsientos); // Dibuja los botones
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar asientos: " + ex.Message);
            }
        }

        // --- DIBUJAR LOS BOTONES VERDES ---
        private void RenderizarBotones(DataTable tablaAsientos)
        {
            // Buscamos el mapa (PictureBox)
            PictureBox pb = this.Controls.Find("pbMapaAsientos", true).FirstOrDefault() as PictureBox;
            if (pb == null) return;

            pb.Controls.Clear(); // Limpiar viejos
            botonesAsiento.Clear();

            // COORDENADAS (AJÚSTALAS A TU IMAGEN SI ES NECESARIO)
            int startX = 60;
            int startY = 120;
            int w = 35; int h = 30; // Tamaño botón
            int spX = 8; int spY = 15; // Espacio
            int maxFila = 14; // Asientos por fila

            int x = startX; int y = startY;
            int count = 0;

            foreach (DataRow fila in tablaAsientos.Rows)
            {
                string codigo = fila["CodigoAsiento"].ToString();

                Button btn = new Button();
                btn.Text = codigo;
                btn.Size = new Size(w, h);
                btn.Location = new Point(x, y);
                btn.BackColor = Color.Green; // Disponible
                btn.ForeColor = Color.White;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.Font = new Font("Segoe UI", 7, FontStyle.Bold);
                btn.Tag = codigo; // Guardamos el código (A1)

                // Evento Click
                btn.Click += BtnAsiento_Click;

                pb.Controls.Add(btn);
                botonesAsiento.Add(btn);

                // Mover al siguiente
                x += w + spX;
                count++;
                if (count >= maxFila) { y += h + spY; x = startX; count = 0; }
            }
        }

        // --- CLIC EN UN ASIENTO (SELECCIONAR) ---
        private void BtnAsiento_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string asiento = btn.Tag.ToString();

            if (btn.BackColor == Color.Green) // Si está libre -> Seleccionar
            {
                if (asientosSeleccionados.Count >= cantidadBoletos)
                {
                    MessageBox.Show($"Solo puedes elegir {cantidadBoletos} asientos.", "Lleno");
                    return;
                }
                btn.BackColor = Color.Orange;
                asientosSeleccionados.Add(asiento);
            }
            else if (btn.BackColor == Color.Orange) // Si es mío -> Deseleccionar
            {
                btn.BackColor = Color.Green;
                asientosSeleccionados.Remove(asiento);
            }

            // Mostrar en el cuadro de texto (Si existe)
            if (this.Controls.Find("txtMostrarAsientos", true).FirstOrDefault() is TextBox txt)
            {
                txt.Text = string.Join(", ", asientosSeleccionados);
            }
        }

        // --- BOTÓN CONFIRMAR (GUARDAR VENTA) ---
        private void Btn_Confirmar_Click(object sender, EventArgs e)
        {
            // 1. VALIDACIÓN DE CANTIDAD
            if (asientosSeleccionados.Count != cantidadBoletos)
            {
                MessageBox.Show($"Faltan asientos. Seleccionaste {asientosSeleccionados.Count} de {cantidadBoletos}.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // CAMBIO PRINCIPAL: Usamos CN_Tickets en vez de CN_Ventas
                CN_Tickets negocio = new CN_Tickets();

                // A. Preparar Datos
                Guid usuarioId = Login.UsuarioSesion != null ? Login.UsuarioSesion.Id : Guid.Empty;

                // Determinamos ID de Sala (3=VIP, 1=Normal)
                int idSala = (tipoEntrada.Contains("VIP")) ? 3 : 1;

                int metodoPago = 1; // 1 = Efectivo (Por defecto)

                // B. Preparar el texto de detalle (Asientos + Combos)
                // Como la tabla Tickets es una sola fila, guardamos la lista de asientos en el campo de texto
                string listaAsientos = string.Join(", ", asientosSeleccionados);
                string detalleProductos = $"Boletos ({listaAsientos}) + Combos";

                // C. GUARDAR EN TABLA 'TICKETS'
                // Usamos un ID de asiento fijo (1) porque guardamos los reales en el texto 'detalleProductos'
                // Esto evita errores de Foreign Key si el asiento A1 no es el ID 1 exacto.
                string codigoTicket = negocio.RegistrarVenta(
                    usuarioId,
                    this.idPelicula,
                    idSala,
                    this.horario,
                    1, // AsientoId (Genérico)
                    metodoPago,
                    this.totalPagar,
                    detalleProductos // Guardamos aquí la lista de asientos y combos
                );

                // D. FINALIZAR
                MessageBox.Show($"¡Compra Exitosa!\n\nCódigo de Ticket: {codigoTicket}\nAsientos: {listaAsientos}", "CineLux", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Volver al inicio
                Cartelera inicio = new Cartelera();
                inicio.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar en Tickets: " + ex.Message, "Error");
            }
        }

        // --- BOTÓN ATRÁS (DEVUELVE LA IMAGEN) ---
        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
            VentaDeBoletos venta = new VentaDeBoletos(
                this.idPelicula.ToString(),
                this.tituloPelicula,
                this.ImagenPelicula // <-- Aquí devolvemos la imagen
            );
            venta.Show();
        }

        // --- DISEÑO ---
        private void ConfigurarBotonRedondo()
        {
            try
            {
                int r = 20; GraphicsPath p = new GraphicsPath();
                p.AddArc(0, 0, r, r, 180, 90); p.AddArc(Btn_Confirmar.Width - r, 0, r, r, 270, 90);
                p.AddArc(Btn_Confirmar.Width - r, Btn_Confirmar.Height - r, r, r, 0, 90);
                p.AddArc(0, Btn_Confirmar.Height - r, r, r, 90, 90); p.CloseFigure();
                Btn_Confirmar.Region = new Region(p);
            }
            catch { }
        }
        private void pictureBox5_Click(object sender, EventArgs e) { this.Close(); new Cartelera().Show(); }

        [DllImport("user32.dll")] private extern static void ReleaseCapture();
        [DllImport("user32.dll")] private extern static void SendMessage(IntPtr h, int m, int w, int l);
        private void panelTop_MouseDown(object sender, MouseEventArgs e) { ReleaseCapture(); SendMessage(this.Handle, 0x112, 0x0f012, 0); }

        // Eventos vacíos del diseñador (No borrar)
        private void Salas_Load(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void panel1_Paint_1(object sender, PaintEventArgs e) { }
        private void txtMostrarAsientos_TextChanged(object sender, EventArgs e) { }
        private void lblTipoSala_TextChanged(object sender, EventArgs e) { }
        private void pbMapaAsientos_Click(object sender, EventArgs e) { }
        private void comboBox_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}