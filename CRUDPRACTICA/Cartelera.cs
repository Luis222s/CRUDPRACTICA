using CapaNegocio;
using CapaPresentacion;
using System;
using System.Data;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

namespace CRUDPRACTICA
{
    public partial class Cartelera : Form
    {
        CN_Pelicula negocioPeliculas = new CN_Pelicula();
        public Cartelera()
        {
            InitializeComponent();

            int radius = 20;

            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(Btn_Peli1.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(Btn_Peli1.Width - radius, Btn_Peli1.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, Btn_Peli1.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            Btn_Peli1.Region = new Region(path);

            GraphicsPath path1 = new GraphicsPath();
            path1.AddArc(0, 0, radius, radius, 180, 90);
            path1.AddArc(Btn_Peli2.Width - radius, 0, radius, radius, 270, 90);
            path1.AddArc(Btn_Peli2.Width - radius, Btn_Peli2.Height - radius, radius, radius, 0, 90);
            path1.AddArc(0, Btn_Peli2.Height - radius, radius, radius, 90, 90);
            path1.CloseFigure();
            Btn_Peli2.Region = new Region(path);

            GraphicsPath path2 = new GraphicsPath();
            path2.AddArc(0, 0, radius, radius, 180, 90);
            path2.AddArc(Btn_Peli3.Width - radius, 0, radius, radius, 270, 90);
            path2.AddArc(Btn_Peli3.Width - radius, Btn_Peli3.Height - radius, radius, radius, 0, 90);
            path2.AddArc(0, Btn_Peli3.Height - radius, radius, radius, 90, 90);
            path2.CloseFigure();
            Btn_Peli3.Region = new Region(path);

            GraphicsPath path3 = new GraphicsPath();
            path3.AddArc(0, 0, radius, radius, 180, 90);
            path3.AddArc(Btn_Peli4.Width - radius, 0, radius, radius, 270, 90);
            path3.AddArc(Btn_Peli4.Width - radius, Btn_Peli4.Height - radius, radius, radius, 0, 90);
            path3.AddArc(0, Btn_Peli4.Height - radius, radius, radius, 90, 90);
            path3.CloseFigure();
            Btn_Peli4.Region = new Region(path);

            GraphicsPath path4 = new GraphicsPath();
            path4.AddArc(0, 0, radius, radius, 180, 90);
            path4.AddArc(button1.Width - radius, 0, radius, radius, 270, 90);
            path4.AddArc(button1.Width - radius, button1.Height - radius, radius, radius, 0, 90);
            path4.AddArc(0, button1.Height - radius, radius, radius, 90, 90);
            path4.CloseFigure();
            button1.Region = new Region(path);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
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
                Font = new Font("Segoe UI", 15, FontStyle.Bold),
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

        private void BtnDetalles_Click(object sender, EventArgs e)
        {
            
        }



        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
           
        }

        private void Btn_Minimizar_Click(object sender, EventArgs e)
        {
           
        }


        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void Btn_Peli1_Click(object sender, EventArgs e)
        {
           
        }

        private void Btn_Peli2_Click(object sender, EventArgs e)
        {
            
        }

        private void Btn_Peli3_Click(object sender, EventArgs e)
        {
            
        }

        private void Btn_Peli4_Click(object sender, EventArgs e)
        {
            
        }

        private void Cartelera_Load(object sender, EventArgs e)
        {
            CargarPeliculasDinamicas();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
