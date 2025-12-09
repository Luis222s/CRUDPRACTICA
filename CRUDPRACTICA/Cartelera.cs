using CapaDatos;
using CapaNegocio;
using CapaPresentacion;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Runtime.InteropServices; // <--- AGREGADO: Necesario para DllImport (movimiento de ventana)

namespace CapaPresentacion
{
    public partial class Cartelera : Form
    {
        public Cartelera FormPrincipal { get; set; }
        private CN_Peliculas negocioPeliculas = new CN_Peliculas();

        public Cartelera()
        {
            InitializeComponent();
            this.Text = "CineMax - Cartelera";
        }

        private void Cartelera_Load(object sender, EventArgs e)
        {
            CargarPeliculasDinamicas();
        }

        // --- CARGA DE DATOS DINÁMICA ---
        private void CargarPeliculasDinamicas()
        {
            // Limpiamos el FlowLayoutPanel antes de cargar
            // Asegúrate de que este control se llama flowLayoutPanelCartelera en tu diseñador
            flowLayoutPanelCartelera.Controls.Clear();

            try
            {
                // Traemos todas las películas
                DataTable tabla = negocioPeliculas.MostrarPeliculas();

                foreach (DataRow fila in tabla.Rows)
                {
                    // Creamos un contenedor (Panel) para cada película
                    Panel peliPanel = CrearPanelPelicula(fila);
                    flowLayoutPanelCartelera.Controls.Add(peliPanel);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la cartelera: " + ex.Message);
            }
        }

        // Crea y configura el panel que contiene la imagen y el botón
        private Panel CrearPanelPelicula(DataRow fila)
        {
            int idPelicula = Convert.ToInt32(fila["IdPelicula"]);
            string titulo = fila["Titulo"].ToString();
            byte[] imagenBytes = fila["Imagen"] != DBNull.Value ? (byte[])fila["Imagen"] : null;

            Panel panel = new Panel
            {
                Width = 200,
                Height = 350,
                Margin = new Padding(15, 10, 15, 10),
                BackColor = Color.FromArgb(40, 40, 40) // Fondo oscuro
            };

            // 1. PictureBox para el Poster
            PictureBox pbPoster = new PictureBox
            {
                Width = 180,
                Height = 250,
                Location = new Point(10, 10),
                SizeMode = PictureBoxSizeMode.Zoom,
                Tag = idPelicula, // Guardamos el ID
            };

            // Cargar la imagen
            if (imagenBytes != null && imagenBytes.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(imagenBytes))
                {
                    pbPoster.Image = Image.FromStream(ms);
                }
            }
            else
            {
                // Solución al error CS0117: Usamos un color si no hay imagen (o si Properties.Resources.placeholder no existe)
                pbPoster.BackColor = Color.DimGray;
            }


            // 2. Label para el Título
            Label lblTitulo = new Label
            {
                Text = titulo,
                Width = 180,
                Height = 40,
                Location = new Point(10, 270),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
            };

            // 3. Botón "Ver detalles..." (El botón de navegación)
            Button btnDetalles = new Button
            {
                Text = "Ver detalles...",
                Width = 120,
                Height = 30,
                Location = new Point(40, 315),
                BackColor = Color.Red,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Tag = idPelicula.ToString(), // El ID es el Tag
            };

            btnDetalles.FlatAppearance.BorderSize = 0;
            btnDetalles.Click += BtnDetalles_Click;

            panel.Controls.Add(pbPoster);
            panel.Controls.Add(lblTitulo);
            panel.Controls.Add(btnDetalles);

            return panel;
        }

        // --- NAVEGACIÓN DINÁMICA (MÉTODO ÚNICO) ---
        private void BtnDetalles_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (btn != null && btn.Tag != null)
            {
                string idPelicula = btn.Tag.ToString();

                // Abrimos el formulario de detalle de la película (FrmPelicula)
                FrmPelicula detalle = new FrmPelicula(idPelicula);
                detalle.Show();
                this.Hide(); // Ocultamos la cartelera
            }
        }


        // --- EVENTOS DE VENTANA Y MOVIMIENTO ---
        // Estos requieren el 'using System.Runtime.InteropServices;'
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture(); SendMessage(this.Handle, 0x112, 0x0f012, 0);
        }
        //se cierra cartelera
        private void Btn_Cerrar_Click(object sender, EventArgs e) => this.Close();
        private void Btn_Minimizar_Click(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;

        // Mantenemos este evento, aunque no parece hacer nada funcional
        private void flowLayoutPanelCartelera_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}