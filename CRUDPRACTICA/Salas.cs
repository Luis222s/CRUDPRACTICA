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
            ComboBox activo = null;

            if (comboBox.SelectedIndex > 0) activo = comboBox;
            else if (comboBox1.SelectedIndex > 0) activo = comboBox1;
            else if (comboBox2.SelectedIndex > 0) activo = comboBox2;
            else if (comboBox3.SelectedIndex > 0) activo = comboBox3;

            // Si ninguno está seleccionado (todos en 0) → activar todos
            if (activo == null)
            {
                comboBox.Enabled = true;
                comboBox1.Enabled = true;
                comboBox2.Enabled = true;
                comboBox3.Enabled = true;
                return;
            }

            // Si hay uno seleccionado → desactivar los demás
            comboBox.Enabled = (activo == comboBox);
            comboBox1.Enabled = (activo == comboBox1);
            comboBox2.Enabled = (activo == comboBox2);
            comboBox3.Enabled = (activo == comboBox3);
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox activo = null;

            if (comboBox.SelectedIndex > 0) activo = comboBox;
            else if (comboBox1.SelectedIndex > 0) activo = comboBox1;
            else if (comboBox2.SelectedIndex > 0) activo = comboBox2;
            else if (comboBox3.SelectedIndex > 0) activo = comboBox3;

            // Si ninguno está seleccionado (todos en 0) → activar todos
            if (activo == null)
            {
                comboBox.Enabled = true;
                comboBox1.Enabled = true;
                comboBox2.Enabled = true;
                comboBox3.Enabled = true;
                return;
            }

            // Si hay uno seleccionado → desactivar los demás
            comboBox.Enabled = (activo == comboBox);
            comboBox1.Enabled = (activo == comboBox1);
            comboBox2.Enabled = (activo == comboBox2);
            comboBox3.Enabled = (activo == comboBox3);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox activo = null;

            if (comboBox.SelectedIndex > 0) activo = comboBox;
            else if (comboBox1.SelectedIndex > 0) activo = comboBox1;
            else if (comboBox2.SelectedIndex > 0) activo = comboBox2;
            else if (comboBox3.SelectedIndex > 0) activo = comboBox3;

            // Si ninguno está seleccionado (todos en 0) → activar todos
            if (activo == null)
            {
                comboBox.Enabled = true;
                comboBox1.Enabled = true;
                comboBox2.Enabled = true;
                comboBox3.Enabled = true;
                return;
            }

            // Si hay uno seleccionado → desactivar los demás
            comboBox.Enabled = (activo == comboBox);
            comboBox1.Enabled = (activo == comboBox1);
            comboBox2.Enabled = (activo == comboBox2);
            comboBox3.Enabled = (activo == comboBox3);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox activo = null;

            if (comboBox.SelectedIndex > 0) activo = comboBox;
            else if (comboBox1.SelectedIndex > 0) activo = comboBox1;
            else if (comboBox2.SelectedIndex > 0) activo = comboBox2;
            else if (comboBox3.SelectedIndex > 0) activo = comboBox3;

            // Si ninguno está seleccionado (todos en 0) → activar todos
            if (activo == null)
            {
                comboBox.Enabled = true;
                comboBox1.Enabled = true;
                comboBox2.Enabled = true;
                comboBox3.Enabled = true;
                return;
            }

            // Si hay uno seleccionado → desactivar los demás
            comboBox.Enabled = (activo == comboBox);
            comboBox1.Enabled = (activo == comboBox1);
            comboBox2.Enabled = (activo == comboBox2);
            comboBox3.Enabled = (activo == comboBox3);
        }
    }
}
