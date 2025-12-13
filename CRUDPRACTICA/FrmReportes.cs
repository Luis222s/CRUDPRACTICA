using System;
using System.Data;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FrmReportes : Form
    {
        public FrmReportes()
        {
            InitializeComponent();
        }

        // --- CARGA INICIAL ---
        private void FrmReportes_Load(object sender, EventArgs e)
        {
            CargarDatosDashboard();
        }

        private void CargarDatosDashboard()
        {
            try
            {
                CN_Reportes negocio = new CN_Reportes();
                DataTable tabla = negocio.VerReporte();

                if (tabla.Rows.Count > 0)
                {
                    DataRow fila = tabla.Rows[0];

                    // 1. CANTIDAD DE TICKETS
                    // Si en SQL devuelve 0, aquí mostrará "0"
                    lblTickets.Text = fila["CantidadVentas"].ToString();

                    // 2. TOTAL DINERO
                    decimal ingresos = 0;
                    decimal.TryParse(fila["TotalIngresos"].ToString(), out ingresos);
                    lblIngresos.Text = ingresos.ToString("C2"); // Formato moneda ($)

                    // 3. PELÍCULA MÁS VENDIDA
                    // Si no hay ventas, el SQL devuelve "Ninguna"
                    lblPelicula.Text = fila["PeliculaTop"].ToString();
                }
                else
                {
                    // Esto solo pasa si el procedimiento SQL no devuelve ninguna fila (raro)
                    lblTickets.Text = "0";
                    lblIngresos.Text = "$0.00";
                    lblPelicula.Text = "---";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en reporte: " + ex.Message);
            }
        }

        // --- BOTONES Y NAVEGACIÓN ---



        // Minimizar
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Cerrar Aplicación o Formulario
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblTickets_Click(object sender, EventArgs e)
        {

        }

        private void lblPelicula_Click(object sender, EventArgs e)
        {

        }

        private void lblIngresos_Click(object sender, EventArgs e)
        {

        }
    }
}