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
    public partial class Pelicula3 : Form
    {
        public Cartelera FormPrincipal { get; set; }
        public Pelicula3()
        {
            InitializeComponent();

            int radius = 20;

            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(Btn_Cancelar3.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(Btn_Cancelar3.Width - radius, Btn_Cancelar3.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, Btn_Cancelar3.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            Btn_Cancelar3.Region = new Region(path);

            GraphicsPath path1 = new GraphicsPath();
            path1.AddArc(0, 0, radius, radius, 180, 90);
            path1.AddArc(Btn_Boletos3.Width - radius, 0, radius, radius, 270, 90);
            path1.AddArc(Btn_Boletos3.Width - radius, Btn_Boletos3.Height - radius, radius, radius, 0, 90);
            path1.AddArc(0, Btn_Boletos3.Height - radius, radius, radius, 90, 90);
            path1.CloseFigure();
            Btn_Boletos3.Region = new Region(path);
        }

        private void Btn_Cancelar3_Click(object sender, EventArgs e)
        {
            Cartelera frm = new Cartelera();
            frm.Show();
            this.Close();
        }

        private void Btn_Boletos3_Click(object sender, EventArgs e)
        {
            VentaDeBoletos2 frm = new VentaDeBoletos2();
            frm.Show();
            this.Close();
        }

        private void CargarDatosPelicula()
        {
            Pelicula GDG = new Pelicula
            {
                Titulo = "Guardianes de la Galaxia vol. 2",
                Generos = "Géneros: Ciencia fictición, Acción, Telerrealidad, Aventura\r\n",
                Duracion = "2 Horas 17 Minutos",
                FechaEstreno = "5 de mayo de 2017",
                Descripcion = "Una poderosa raza alienígena contrata a los Guardianes para que protejan sus \r\nvaliosas baterías de energía, pero, cuando Rocket las roba, los alienígenas envían a \r\nsus tropas de combate a vengarse de los Guardianes. Mientras tratan de escapar \r\ncon vida, intentan resolver el misterio de los verdaderos orígenes de Peter Quill."
            };

            label5.Text = GDG.Titulo;
            label1.Text = "Géneros: " + GDG.Generos;
            label2.Text = "Duración: " + GDG.Duracion;
            label4.Text = "Fecha de estreno: " + GDG.FechaEstreno;
            label3.Text = GDG.Descripcion;
        }

        private void Pelicula3_Load(object sender, EventArgs e)
        {
            CargarDatosPelicula();
        }
    }
}
