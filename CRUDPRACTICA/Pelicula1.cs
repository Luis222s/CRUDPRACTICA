using CapaDatos;
using CapaNegocio;
using CRUDPRACTICA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace CapaPresentacion
{
    public partial class Pelicula1 : Form
    {
        public Cartelera FormPrincipal { get; set; }


        public Pelicula1(string idRecibido)
        {
            InitializeComponent();

            if (int.TryParse(idRecibido, out int id))
            {
                idPeliculaActual = id;
                CargarDatosDesdeSQL(id);
            }

            int radius = 20;

            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(Btn_Cancelar1.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(Btn_Cancelar1.Width - radius, Btn_Cancelar1.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, Btn_Cancelar1.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            Btn_Cancelar1.Region = new Region(path);

            GraphicsPath path1 = new GraphicsPath();
            path1.AddArc(0, 0, radius, radius, 180, 90);
            path1.AddArc(Btn_Boletos1.Width - radius, 0, radius, radius, 270, 90);
            path1.AddArc(Btn_Boletos1.Width - radius, Btn_Boletos1.Height - radius, radius, radius, 0, 90);
            path1.AddArc(0, Btn_Boletos1.Height - radius, radius, radius, 90, 90);
            path1.CloseFigure();
            Btn_Boletos1.Region = new Region(path);
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Cartelera frm = new Cartelera();
            frm.Show();
        }

        private void Btn_Boletos1_Click(object sender, EventArgs e)
        {
            /*VentaDeBoletos frm = new VentaDeBoletos(idPeliculaActual.ToString(), tituloPelicula, pictureBox1.Image);
            frm.Show();*/
            this.Close();
        }

        private int idPeliculaActual;
        private string tituloPelicula;

        private void CargarDatosDesdeSQL(int id)
        {
            try
            {
                CN_Pelicula negocio = new CN_Pelicula();
                DataTable tabla = negocio.ObtenerPelicula(id);

                if (tabla.Rows.Count > 0)
                {
                    DataRow fila = tabla.Rows[0];

                    // 1. CARGA DE TEXTO
                    tituloPelicula = fila["Titulo"].ToString();
                    label5.Text = tituloPelicula;
                    label1.Text = "Géneros: " + fila["Genero"].ToString();
                    label2.Text = "Duración: " + fila["Duracion"].ToString() + " min";
                    label3.Text = "Clasificación: " + fila["Clasificacion"].ToString();

                    // CAPTURAMOS LA SINOPSIS
                    string sinopsis = fila["Sinopsis"] != DBNull.Value ? fila["Sinopsis"].ToString() : "Sinopsis no disponible.";
                    try
                    {
                        if (this.Controls.Find("rtxtSinopsis", true).FirstOrDefault() is RichTextBox rtb)
                        {
                            rtb.Text = sinopsis;
                            rtb.ReadOnly = true; 

                        }
                    }
                    catch (Exception ex)
                    {
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

        private void Pelicula1_Load(object sender, EventArgs e)
        {

        }
    }
}
