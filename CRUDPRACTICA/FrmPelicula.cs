using CapaNegocio;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.IO; 

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
                CN_Peliculas negocio = new CN_Peliculas();
                DataTable tabla = negocio.ObtenerPelicula(id);

                if (tabla.Rows.Count > 0)
                {
                    DataRow fila = tabla.Rows[0];

                    // 1. CARGA DE TEXTO
                    tituloPelicula = fila["Titulo"].ToString();
                    label5.Text = tituloPelicula;
                    label1.Text = "Géneros: " + fila["Genero"].ToString();
                    label2.Text = "Duración: " + fila["Duracion"].ToString() + " min";
                    label6.Text = "Clasificación: " + fila["Clasificacion"].ToString();

                    // CAPTURAMOS LA SINOPSIS
                    string sinopsis = fila["Sinopsis"] != DBNull.Value ? fila["Sinopsis"].ToString() : "Sinopsis no disponible.";

                    // --- USAR RichTextBox (rtxtSinopsis) ---
                    try
                    {
                        // Asumiendo que el RichTextBox se llama rtxtSinopsis
                        if (this.Controls.Find("rtxtSinopsis", true).FirstOrDefault() is RichTextBox rtb)
                        {
                            rtb.Text = sinopsis;
                            rtb.ReadOnly = true; // El usuario no puede editar
                                               
                        }
                    }
                    catch (Exception ex)
                    {
                        // Manejo de error si no se encuentra el RichTextBox o si el Label3 fue eliminado
                        MessageBox.Show("Error al configurar el RichTextBox: " + ex.Message, "Error de Sinopsis");
                    }


                    DateTime fecha = Convert.ToDateTime(fila["FechaEstreno"]);
                    label4.Text = "Fecha de estreno: " + fecha.ToShortDateString();

                    // 2. --- LÓGICA CLAVE: CARGAR LA IMAGEN DESDE LOS BYTES DE SQL ---
                    if (fila["Imagen"] != DBNull.Value && fila["Imagen"] != null)
                    {
                        byte[] imgBytes = (byte[])fila["Imagen"];
                        using (MemoryStream ms = new MemoryStream(imgBytes))
                        {
                            pictureBox1.Image = Image.FromStream(ms);
                            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                        }
                    }
                    else
                    {
                        pictureBox1.Image = null;
                        pictureBox1.BackColor = Color.DimGray;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
        }

        // --- BOTONES ---

        private void Btn_Boletos1_Click(object sender, EventArgs e) // Botón Comprar
        {
            // Pasa la imagen actual del PictureBox (la que se cargó de la BD)
            VentaDeBoletos frm = new VentaDeBoletos(idPeliculaActual.ToString(), tituloPelicula, pictureBox1.Image);
            frm.Show();
            this.Close();
        }

        // --- TU DISEÑO DE BORDES REDONDOS (Se mantiene sin cambios) ---
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

        // --- EVENTOS DE DISEÑO (Se mantienen sin cambios) ---
        private void Pelicula1_Load(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void pictureBox1_Click(object sender, EventArgs e) { }

        private void Btn_Cancelar1_Click_1(object sender, EventArgs e)
        {
            Cartelera frm = new Cartelera();
            frm.Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void rtxtSinopsis_TextChanged(object sender, EventArgs e)
        {

        }
    }
}