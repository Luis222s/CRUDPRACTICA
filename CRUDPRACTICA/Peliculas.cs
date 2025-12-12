using CRUDPRACTICA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Peliculas : Form
    {
        public Peliculas()
        {
            InitializeComponent();

            AbrirFormHijo(new Home());
        }

        private void Btn_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AbrirFormHijo(object FormHijo)
        {
            if (this.panel1.Controls.Count > 0)
                this.panel1.Controls.RemoveAt(0);
            Form fos = FormHijo as Form;
            fos.TopLevel = false;
            fos.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(fos);
            this.panel1.Tag = fos;
            fos.Show();
        }

        private void btn_inicio_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new Home());
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_cartelera_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new Cartelera());
        }

        private void btn_acerca_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new Acercade());
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Has salido del sistema");

            Login formLogin = new Login();
            formLogin.Show();

            this.Hide();
        }
    }
}
