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


        public Pelicula1()
        {
            InitializeComponent();

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
            this.Close();
        }

        private void Btn_Boletos1_Click(object sender, EventArgs e)
        {
            VentaDeBoletos frm = new VentaDeBoletos();
            frm.Show();
            this.Close();
        }
        private void CargarDatosPelicula()
        {

            Pelicula Us = new Pelicula
            {
                Titulo = "Us",
                Generos = "Géneros: Cine de terror, Thriller, Comedia cinematográfica, Drama",
                Duracion = "2 Horas 1 Minutos",
                FechaEstreno = "22 de marzo del 2019",
                Descripcion = "Adelaide y su esposo viajan a la casa en la que ella creció junto a la playa. Tiene un presentimiento \r\nsiniestro que precede a un encuentro espeluznante: cuatro enmascarados se presentan ante su casa. \r\nLo aterrador viene cuando muestran sus rostros."
            };

            label5.Text = Us.Titulo;
            label1.Text = "Géneros: " + Us.Generos;
            label2.Text = "Duración: " + Us.Duracion;
            label4.Text = "Fecha de estreno: " + Us.FechaEstreno;
            label3.Text = Us.Descripcion;
        }

        private void Pelicula1_Load(object sender, EventArgs e)
        {
            CargarDatosPelicula();
        }
    }
}
