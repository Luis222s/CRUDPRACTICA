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
    public partial class Salas : Form
    {
        public Cartelera FormPrincipal { get; set; }
        public Salas(decimal total)
        {
            InitializeComponent();
            comboBox.SelectedIndex = 0; comboBox1.SelectedIndex = 0; comboBox2.SelectedIndex = 0; comboBox3.SelectedIndex = 0;
            label9.Text = $"Total:    ${total}";

            int radius = 20;

            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(Btn_Confirmar.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(Btn_Confirmar.Width - radius, Btn_Confirmar.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, Btn_Confirmar.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            Btn_Confirmar.Region = new Region(path);

        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void Sillas()
        {
            if (comboBox.SelectedIndex > 0)
            {
                comboBox1.Enabled = false; comboBox2.Enabled = false; comboBox3.Enabled = false;
            }
            if (comboBox1.SelectedIndex > 0)
            {
                comboBox.Enabled = false; comboBox2.Enabled = false; comboBox3.Enabled = false;
            }
            if (comboBox2.SelectedIndex > 0)
            {
                comboBox.Enabled = false; comboBox1.Enabled = false; comboBox3.Enabled = false;
            }
            if (comboBox3.SelectedIndex > 0)
            {
                comboBox.Enabled = false; comboBox2.Enabled = false; comboBox1.Enabled = false;
            }

        }

        private void Btn_Confirmar_Click(object sender, EventArgs e)
        {
            if (comboBox.SelectedIndex == 0 && comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 0 && comboBox3.SelectedIndex == 0)
            {
                MessageBox.Show("Debes elegir tu asiento", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Pago frm1 = new Pago();
                frm1.Show();
                this.Close();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
            Cartelera frm = new Cartelera();
            frm.Show();
        }

        private void Salas_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sillas();
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sillas();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sillas();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sillas();
        }
    }
}
