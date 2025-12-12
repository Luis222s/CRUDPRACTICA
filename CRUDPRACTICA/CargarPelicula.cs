using CapaNegocio;
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

    public partial class CargarPelicula : Form
    {
        private CN_Pelicula negocioPeliculas = new CN_Pelicula();
        private bool EsNuevoRegistro = false;
        private string IdPeliculaSeleccionada = null;
        public CargarPelicula()
        {
            InitializeComponent();
            ConfigurarFormulario();
            CargarPeliculas();
        }

        // --- INICIALIZACIÓN Y CARGA ---
        private void ConfigurarFormulario()
        {
            HabilitarControles(false);
            dgvPeliculas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPeliculas.ReadOnly = true;
            dgvPeliculas.AllowUserToAddRows = false;
        }

        private void CargarPeliculas()
        {
            try
            {
                dgvPeliculas.DataSource = negocioPeliculas.MostrarPeliculas();

                // Ocultar columnas sensibles/grandes
                if (dgvPeliculas.Columns.Contains("Imagen")) dgvPeliculas.Columns["Imagen"].Visible = false;
                if (dgvPeliculas.Columns.Contains("Activo")) dgvPeliculas.Columns["Activo"].Visible = false;

                dgvPeliculas.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la lista de películas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Función para habilitar/deshabilitar los controles
        private void HabilitarControles(bool habilitar)
        {
            txtTitulo.Enabled = habilitar;
            txtGenero.Enabled = habilitar;
            txtDuracion.Enabled = habilitar;
            txtClasificacion.Enabled = habilitar;

            txtSinopsis.Enabled = habilitar;
            dtpFecha.Enabled = habilitar;
            btnSubirImagen.Enabled = habilitar;
            btnQuitarImagen.Enabled = habilitar;

            btnNuevo.Enabled = !habilitar;
            btnEditar.Enabled = !habilitar;
            btnEliminar.Enabled = !habilitar;

            btnGuardar.Enabled = habilitar;
            btnCancela.Enabled = habilitar;
        }

        private void LimpiarControles()
        {
            txtTitulo.Text = "";
            txtGenero.Text = "";
            txtDuracion.Text = "";
            txtClasificacion.Text = "";

            txtSinopsis.Text = "";
            dtpFecha.Value = DateTime.Now;
            pbPoster.Image = null; // Limpiamos la imagen
            IdPeliculaSeleccionada = null;
        }

        // Función auxiliar para convertir la imagen de PictureBox a byte[] para SQL
        private byte[] ConvertirImagenABytes(Image imagen)
        {
            if (imagen == null)
            {
                return null;
            }

            using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
            {
                // Usamos formato PNG o JPEG. PNG para mejor calidad sin pérdida.
                imagen.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        private void CargarPeliculas_Load(object sender, EventArgs e)
        {

        }

        private void btnQuitarImagen_Click(object sender, EventArgs e)
        {

        }

        private void btnSubirImagen_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void btnCancela_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
