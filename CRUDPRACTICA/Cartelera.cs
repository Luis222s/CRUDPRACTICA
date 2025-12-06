using CapaDatos;
using CapaPresentacion;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using CapaNegocio;
using System.Data; // Necesario para DataTable

namespace CapaPresentacion
{
    public partial class Cartelera : Form
    {
        public Cartelera FormPrincipal { get; set; }

        public Cartelera()
        {
            InitializeComponent();
            ConfigurarDiseñoBotones();
        }

        private void Cartelera_Load(object sender, EventArgs e)
        {
            // Al abrir, cargamos los nombres reales de la BD
            CargarPeliculasEnBotones();
        }

        // --- DISEÑO VISUAL ---
        private void ConfigurarDiseñoBotones()
        {
            try
            {
                int radius = 20;
                AplicarBordeRedondo(Btn_Peli1, radius);
                AplicarBordeRedondo(Btn_Peli2, radius);
                AplicarBordeRedondo(Btn_Peli3, radius);
                AplicarBordeRedondo(Btn_Peli4, radius);
                AplicarBordeRedondo(button1, radius);
            }
            catch { }
        }

        private void AplicarBordeRedondo(Button btn, int radius)
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

        // --- CARGA DE DATOS (BACKEND -> FRONTEND) ---
        private void CargarPeliculasEnBotones()
        {
            CN_Peliculas negocio = new CN_Peliculas();
            try
            {
                // 1. Traemos todas las películas de la Base de Datos
                DataTable tabla = negocio.MostrarPeliculas();

                // 2. Asignamos nombre e ID a los botones

                // BOTÓN 1
                if (tabla.Rows.Count > 0)
                {
                    ConfigurarBoton(Btn_Peli1, tabla.Rows[0]);
                }
                else Btn_Peli1.Visible = false;

                // BOTÓN 2
                if (tabla.Rows.Count > 1)
                {
                    ConfigurarBoton(Btn_Peli2, tabla.Rows[1]);
                }
                else Btn_Peli2.Visible = false;

                // BOTÓN 3
                if (tabla.Rows.Count > 2)
                {
                    ConfigurarBoton(Btn_Peli3, tabla.Rows[2]);
                }
                else Btn_Peli3.Visible = false;

                // BOTÓN 4
                if (tabla.Rows.Count > 3)
                {
                    ConfigurarBoton(Btn_Peli4, tabla.Rows[3]);
                }
                else Btn_Peli4.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar películas: " + ex.Message);
            }
        }

        // Método auxiliar para configurar texto y tag
        private void ConfigurarBoton(Button btn, DataRow fila)
        {
            btn.Visible = true;

            // 1. Guardamos el ID oculto (Esto es lo vital para la venta)
            btn.Tag = fila["IdPelicula"].ToString();

            // 2. Mantenemos el texto "Ver detalles..." (O el que tengas en el diseño)
            // No hacemos btn.Text = fila["Titulo"].ToString(); para no afear el botón negro.

            // 3. OPCIONAL: Si tienes labels encima de los botones (ej: lblTitulo1), 
            // podrías cambiarles el texto aquí si me dices cómo se llaman.
        }

        // --- MOVIMIENTO DE VENTANA ---
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture(); SendMessage(this.Handle, 0x112, 0x0f012, 0);
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e) => Application.Exit();
        private void Btn_Minimizar_Click(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;

        // --- NAVEGACIÓN DINÁMICA (EL CAMBIO IMPORTANTE) ---

        // Antes abrías formularios fijos. Ahora llamamos a una función inteligente "IrAComprar"
        private void Btn_Peli1_Click(object sender, EventArgs e) => IrAComprar(Btn_Peli1);
        private void Btn_Peli2_Click(object sender, EventArgs e) => IrAComprar(Btn_Peli2);
        private void Btn_Peli3_Click(object sender, EventArgs e) => IrAComprar(Btn_Peli3);
        private void Btn_Peli4_Click(object sender, EventArgs e) => IrAComprar(Btn_Peli4);

        private void IrAComprar(Button btn)
        {
            if (btn.Tag != null)
            {
                string idPelicula = btn.Tag.ToString();


                // AQUÍ VA EL SIGUIENTE PASO: Abrir frmComprarTicket(idPelicula)

                FrmPelicula detalle = new FrmPelicula(idPelicula);
                detalle.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Acercade go = new Acercade();
            go.Show();
            this.Hide();
        }
    }
}