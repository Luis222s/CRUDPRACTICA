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

namespace CapaPresentacion
{
    public partial class Pelicula2 : Form
    {
        public Cartelera FormPrincipal { get; set; }
        public Pelicula2()
        {
            InitializeComponent();

            int radius = 20;

            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(Btn_Cancelar2.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(Btn_Cancelar2.Width - radius, Btn_Cancelar2.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, Btn_Cancelar2.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            Btn_Cancelar2.Region = new Region(path);

            GraphicsPath path1 = new GraphicsPath();
            path1.AddArc(0, 0, radius, radius, 180, 90);
            path1.AddArc(Btn_Boletos2.Width - radius, 0, radius, radius, 270, 90);
            path1.AddArc(Btn_Boletos2.Width - radius, Btn_Boletos2.Height - radius, radius, radius, 0, 90);
            path1.AddArc(0, Btn_Boletos2.Height - radius, radius, radius, 90, 90);
            path1.CloseFigure();
            Btn_Boletos2.Region = new Region(path);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void CargarDatosPelicula()
        {
            Pelicula tron3 = new Pelicula
            {
                Titulo = "Tron 3",
                Generos = "Ciencia ficción, Acción, Telerrealidad, Aventura",
                Duracion = "1 Hora 36 Minutos",
                FechaEstreno = "9 de octubre de 2025",
                Descripcion = "Tron: 3 es una película estadounidense de ciencia ficción producida por\r\nWalt Disney Pictures y distribuida por Walt Disney Studios Motion Pictures. \r\nSirve como secuela independiente de Tron y Tron: Legacy."
            };

            label5.Text = tron3.Titulo;
            label1.Text = "Géneros: " + tron3.Generos;
            label2.Text = "Duración: " + tron3.Duracion;
            label4.Text = "Fecha de estreno: " + tron3.FechaEstreno;
            label3.Text = tron3.Descripcion;
        }

        private void Btn_Cancelar2_Click(object sender, EventArgs e)
        {
            Cartelera frm = new Cartelera();
            frm.Show();
            this.Close();
        }

        private void Btn_Boletos2_Click(object sender, EventArgs e)
        {
            VentaDeBoletos1 frm = new VentaDeBoletos1();
            frm.Show();
            this.Close();
        }

        private void Pelicula2_Load(object sender, EventArgs e)
        {
            CargarDatosPelicula();
        }
    }
}
