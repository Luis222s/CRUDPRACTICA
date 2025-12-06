using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using CapaNegocio;
using CapaDatos;

namespace CapaPresentacion
{
    public partial class VentaDeBoletos : Form
    {
        // Variables para guardar lo que compramos
        private int idPelicula;
        private string tituloPelicula;

        // CAMBIO: El constructor ahora pide ID y Título
        public VentaDeBoletos(string idRecibido, string tituloRecibido)
        {
            InitializeComponent();
            ConfigurarDiseñoRedondo(); // Tu diseño visual

            // Guardamos los datos que nos mandó el formulario anterior
            if (int.TryParse(idRecibido, out int id))
            {
                idPelicula = id;
                tituloPelicula = tituloRecibido;
            }

            // Configuramos la pantalla inicial
            CargarDatosIniciales();
        }

        private void CargarDatosIniciales()
        {
            // Ponemos el título de la película en algún label (si tienes uno)
            // lblTituloPelicula.Text = tituloPelicula; 

            this.Text = "Comprando: " + tituloPelicula; // Cambia el nombre de la ventana

            // Llenamos los horarios (Simulado por ahora, luego vendrá de BD)
            cmbHorario.Items.Clear();
            cmbHorario.Items.Add("3:00 PM");
            cmbHorario.Items.Add("6:00 PM");
            cmbHorario.Items.Add("9:00 PM");
            cmbHorario.SelectedIndex = 0;

            // Llenamos cantidad de tickets
            cmbCantidad.Items.Clear();
            for (int i = 1; i <= 10; i++) cmbCantidad.Items.Add(i.ToString());
            cmbCantidad.SelectedIndex = 0;
        }

        // --- TU DISEÑO VISUAL (Intacto) ---
        private void ConfigurarDiseñoRedondo()
        {
            // Aquí iría tu código de GraphicsPath si tienes botones redondos en este form
            // Si no tienes botones especiales aquí todavía, deja esto vacío.
        }

        // --- BOTÓN CONFIRMAR / SIGUIENTE ---
        private void btnConfirmar_Click(object sender, EventArgs e) // Asegúrate que tu botón se llame así
        {
            // Aquí iríamos a la selección de Asientos o procesaríamos el pago
            MessageBox.Show($"Procesando venta para: {tituloPelicula}\nHorario: {cmbHorario.Text}\nBoletos: {cmbCantidad.Text}");

            // Lógica futura: Guardar en BD o ir a Salas.cs
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            // Volvemos a la pantalla anterior
            FrmPelicula detalle = new FrmPelicula(idPelicula.ToString());
            detalle.Show();
            this.Close();
        }

        private void cmbHorario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void VentaDeBoletos_Load(object sender, EventArgs e)
        {

        }

        // ... (Aquí van tus códigos de mover ventana si los tienes) ...
    }
}