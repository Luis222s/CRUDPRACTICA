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
    public partial class VentaDeBoletos : Form
    {
        public Cartelera FormPrincipal { get; set; }
        public VentaDeBoletos()
        {
            InitializeComponent();
            comboBox3.SelectedIndex = 0; comboBox4.SelectedIndex = 0; comboBox5.SelectedIndex = 0; comboBox6.SelectedIndex = 0;

            int radius = 20;

            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(Btn_Confirmar1.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(Btn_Confirmar1.Width - radius, Btn_Confirmar1.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, Btn_Confirmar1.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            Btn_Confirmar1.Region = new Region(path);
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            Cartelera frm = new Cartelera();
            frm.Show();
        }

        private void Btn_Confirmar1_Click(object sender, EventArgs e)
        {
            if (cmb_Tickets1.SelectedItem == null || cmb_Horario1.SelectedItem == null || comboBox3.SelectedItem == null || comboBox4.SelectedItem == null || comboBox5.SelectedItem == null || comboBox6.SelectedItem == null)
            {
                MessageBox.Show("Rellena todos los campos para continuar.","Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                Documental entrada = new Documental();
                entrada.Tipo = cmb_entrada1.Text;
                entrada.Cantidad = int.Parse(cmb_Tickets1.Text);

                decimal totalEntradas = entrada.CalcularPrecio();

                ComboCine combos = new ComboCine
                {
                    CantidadCombo1 = int.Parse(comboBox3.Text),
                    CantidadCombo2 = int.Parse(comboBox4.Text),
                    CantidadCombo3 = int.Parse(comboBox5.Text),
                    CantidadCombo4 = int.Parse(comboBox6.Text)
                };

                decimal totalCombos = combos.CalcularPrecio();

                decimal total = totalEntradas + totalCombos;

                Salas frm = new Salas(total);
                frm.Show();
                this.Close();
            }
        }

        private void VentaDeBoletos_Load(object sender, EventArgs e)
        {

        }
    }
}
