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
    public partial class Pelicula4 : Form
    {
        public Cartelera FormPrincipal { get; set; }
        public Pelicula4()
        {
            InitializeComponent();

            int radius = 20;

            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(Btn_Cancelar4.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(Btn_Cancelar4.Width - radius, Btn_Cancelar4.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, Btn_Cancelar4.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            Btn_Cancelar4.Region = new Region(path);

            GraphicsPath path1 = new GraphicsPath();
            path1.AddArc(0, 0, radius, radius, 180, 90);
            path1.AddArc(Btn_Boletos4.Width - radius, 0, radius, radius, 270, 90);
            path1.AddArc(Btn_Boletos4.Width - radius, Btn_Boletos4.Height - radius, radius, radius, 0, 90);
            path1.AddArc(0, Btn_Boletos4.Height - radius, radius, radius, 90, 90);
            path1.CloseFigure();
            Btn_Boletos4.Region = new Region(path);
        }

        private void Btn_Cancelar4_Click(object sender, EventArgs e)
        {
            Cartelera frm = new Cartelera();
            frm.Show();
            this.Close();
        }

        private void Btn_Boletos4_Click(object sender, EventArgs e)
        {
            VentaDeBoletos3 frm = new VentaDeBoletos3();
            frm.Show();
            this.Close();
        }
        private void CargarDatosPelicula()
        {
            Pelicula CH = new Pelicula
            {
                Titulo = "Chainsaw Man: Reze Arc",
                Generos = "Géneros: Terror, Aventura, ANime",
                Duracion = "1 Hora 40 Minutos",
                FechaEstreno = "19 de Septiembre del 2025",
                Descripcion = "Chainsaw Man - la película: arco de Reze​, también conocida simplemente como\r\nChainsaw Man: arco de Reze, es una película de anime japonesa de acción \r\ny fantasía oscura de 2025 basada en el manga Chainsaw Man de Tatsuki \r\nFujimoto."
            };

            label5.Text = CH.Titulo;
            label1.Text = "Géneros: " + CH.Generos;
            label2.Text = "Duración: " + CH.Duracion;
            label4.Text = "Fecha de estreno: " + CH.FechaEstreno;
            label3.Text = CH.Descripcion;
        }

        private void Pelicula4_Load(object sender, EventArgs e)
        {
            CargarDatosPelicula();
        }
    }
}
