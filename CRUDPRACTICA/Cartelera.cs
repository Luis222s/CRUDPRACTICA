using CapaPresentacion;
using System;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

namespace CRUDPRACTICA
{
    public partial class Cartelera : Form
    {
        public Cartelera FormPrincipal { get; set; }
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



        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0x0f012, 0);
        }

        private void Btn_Peli1_Click(object sender, EventArgs e)
        {
            Pelicula1 frm = new Pelicula1();
            frm.Show();
            this.Hide();
        }

        private void Btn_Peli2_Click(object sender, EventArgs e)
        {
            Pelicula2 frm = new Pelicula2();
            frm.Show();
            this.Hide();
        }

        private void Btn_Peli3_Click(object sender, EventArgs e)
        {
            Pelicula3 frm = new Pelicula3();
            frm.Show();
            this.Hide();
        }

        private void Btn_Peli4_Click(object sender, EventArgs e)
        {
            Pelicula4 frm = new Pelicula4();
            frm.Show();
            this.Hide();
        }

        private void Cartelera_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Acercade go = new Acercade();
            go.Show();
            this.Hide();
        }
    }
}
