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
    public partial class VentaDeBoletos3 : Form
    {
        public Cartelera FormPrincipal { get; set; }
        public VentaDeBoletos3()
        {
            InitializeComponent();
            comboBox3.SelectedIndex = 0; comboBox4.SelectedIndex = 0; comboBox5.SelectedIndex = 0; comboBox6.SelectedIndex = 0;

            int radius = 20;

            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(Btn_Confirmar3.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(Btn_Confirmar3.Width - radius, Btn_Confirmar3.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, Btn_Confirmar3.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            Btn_Confirmar3.Region = new Region(path);
        }

        private void Btn_Confirmar3_Click(object sender, EventArgs e)
        {
            if (cmb_Tickets3.SelectedItem == null || cmb_Horario3.SelectedItem == null || comboBox3.SelectedItem == null || comboBox4.SelectedItem == null || comboBox5.SelectedItem == null || comboBox6.SelectedItem == null) 
            {
                MessageBox.Show("Rellena todos los campos para continuar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                Documental entrada = new Documental();
                entrada.Tipo = cmb_entrada1.Text;
                entrada.Cantidad = int.Parse(cmb_Tickets3.Text);

                decimal totalEntradas = entrada.CalcularPrecio();

                ComboCine combos = new ComboCine
                {
                    CantidadCombo1 = int.Parse(comboBox3.Text),
                    CantidadCombo2 = int.Parse(comboBox4.Text),
                    CantidadCombo3 = int.Parse(comboBox5.Text),
                    CantidadCombo4 = int.Parse(comboBox6.Text)
                };

                decimal totalCombos = combos.CalcularPrecio();

                decimal totalGeneral = totalEntradas + totalCombos;

                Salas frm = new Salas(totalGeneral);
                frm.Show();
                this.Close();
            }
        }

        private void pictureBox_3_Click(object sender, EventArgs e)
        {
            this.Close();
            Cartelera frm = new Cartelera();
            frm.Show();
        }

        private void VentaDeBoletos3_Load(object sender, EventArgs e)
        {

        }
    }
}
