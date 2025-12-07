using CapaNegocio;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmPelicula : Form
    {
        // Guardamos el ID para saber qué ticket vender luego
        private int idPeliculaActual;
        private string tituloPelicula;

        // EL CONSTRUCTOR RECIBE EL ID DESDE LA CARTELERA
        public FrmPelicula(string idRecibido)
        {
            InitializeComponent();
            ConfigurarDiseñoRedondo();

            // Convertimos el texto "1" a numero 1 y buscamos en la BD
            if (int.TryParse(idRecibido, out int id))
            {
                idPeliculaActual = id;
                CargarDatosDesdeSQL(id);
            }
        }

        private void CargarDatosDesdeSQL(int id)
        {
            try
            {
                // Usamos la clase CN_Peliculas que conecta con tu CD_Peliculas
                CN_Peliculas negocio = new CN_Peliculas();
                DataTable tabla = negocio.ObtenerPelicula(id);

                if (tabla.Rows.Count > 0)
                {
                    DataRow fila = tabla.Rows[0];

                    // Asignamos los datos reales de SQL a tus Labels
                    tituloPelicula = fila["Titulo"].ToString();

                    label5.Text = tituloPelicula; // Título grande
                    label1.Text = "Géneros: " + fila["Genero"].ToString();
                    label2.Text = "Duración: " + fila["Duracion"].ToString() + " min";

                    // Convertimos la fecha a texto corto (sin hora)
                    DateTime fecha = Convert.ToDateTime(fila["FechaEstreno"]);
                    label4.Text = "Fecha de estreno: " + fecha.ToShortDateString();

                    label3.Text = fila["Sinopsis"].ToString(); // Descripción larga
                                                               // --- AGREGA ESTO PARA CAMBIAR LA IMAGEN ---
                                                               // Asumiendo que tu PictureBox se llama 'pictureBox1'

                    //agregamos la clasificación de la pelicula
                    label6.Text = "Clasificación: " + fila["Clasificacion"].ToString();



                    switch (id)
                    {
                        case 1:
                            // Asegúrate de usar el nombre exacto de la imagen en tus recursos
                            // Si no te sale 'Properties', intenta solo 'Resources.Nombre'
                            pictureBox1.Image = Properties.Resources.avengers_poster;
                            break;
                        case 2:
                            pictureBox1.Image = Properties.Resources.padrino_poster;
                            break;
                        case 3:
                            pictureBox1.Image = Properties.Resources.guardians_poster;
                            break;
                        case 4:
                            pictureBox1.Image = Properties.Resources.chainsaw_poster;
                            break;
                        default:
                            // Imagen por defecto si agregas una peli 5 y no tienes foto
                            // pictureBox1.Image = Properties.Resources.logo_cine; 
                            break;
                    }

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
        }

        // --- TU DISEÑO DE BORDES REDONDOS (Sin cambios) ---
        private void ConfigurarDiseñoRedondo()
        {
            try
            {
                int radius = 20;
                RedondearBoton(Btn_Cancelar1, radius);
                RedondearBoton(Btn_Boletos1, radius);
            }
            catch { }
        }

        private void RedondearBoton(Button btn, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(btn.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(btn.Width - radius, btn.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, btn.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            btn.Region = new Region(path);
        }

        // --- BOTONES ---

        private void button1_Click(object sender, EventArgs e) // Botón Volver/Cancelar
        {
            Cartelera frm = new Cartelera();
            frm.Show();
            this.Close();
        }

        private void Btn_Boletos1_Click(object sender, EventArgs e) // Botón Comprar
        {

            VentaDeBoletos frm = new VentaDeBoletos(idPeliculaActual.ToString(), tituloPelicula);
            frm.Show();
            this.Close();
        }

        private void Pelicula1_Load(object sender, EventArgs e)
        {
            // Ya cargamos en el constructor, no hace falta nada aquí
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}