using System;
using System.Data;
using System.Windows.Forms;
using CapaNegocio; // Importante para llamar a la lógica

namespace CapaPresentacion
{
    public partial class FrmReportes : Form
    {
        public FrmReportes()
        {
            InitializeComponent();
        }

        // Evento Load: Se ejecuta automáticamente al abrir la ventana
        private void FrmReportes_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            try
            {
                CN_Reportes negocio = new CN_Reportes();
                DataTable tabla = negocio.VerReporte();

                if (tabla.Rows.Count > 0)
                {
                    DataRow fila = tabla.Rows[0];

                    // --- ASIGNACIÓN DE DATOS A LOS LABELS ---

                    // 1. Cantidad de Tickets Vendidos
                    // Asegúrate de que tu Label se llame 'lblTickets' en el diseño
                    lblTickets.Text = fila["CantidadVentas"].ToString();

                    // 2. Total de Dinero Recaudado
                    // Lo convertimos a decimal para darle formato de moneda ($)
                    decimal ingresos = Convert.ToDecimal(fila["TotalIngresos"]);
                    lblIngresos.Text = "$" + ingresos.ToString("N2"); // N2 pone 2 decimales

                    // 3. Película Más Popular
                    string peli = fila["PeliculaTop"].ToString();
                    lblPelicula.Text = string.IsNullOrEmpty(peli) ? "Sin datos" : peli;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar reporte: " + ex.Message);
            }
        }

        // Botón Cerrar (Si tienes un botón para volver)
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //ir a cartelera
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Cartelera cartelera = new Cartelera();
            cartelera.Show();
            this.Hide();

        }
        //minimizar
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
        //cerrar
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}