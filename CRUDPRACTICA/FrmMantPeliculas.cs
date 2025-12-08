using CapaNegocio;
using System;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using System.Linq; 

namespace CapaPresentacion
{
    public partial class FrmMantPeliculas : Form
    {
        private CN_Peliculas negocioPeliculas = new CN_Peliculas();
        private bool EsNuevoRegistro = false;
        private string IdPeliculaSeleccionada = null;

        // Constructor
        public FrmMantPeliculas()
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
            btnCancelar.Enabled = habilitar;
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

        // --- EVENTOS DE BOTONES ---
        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            LimpiarControles();
            HabilitarControles(true);
            EsNuevoRegistro = true;
            txtTitulo.Focus();
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            if (dgvPeliculas.SelectedRows.Count > 0)
            {
                HabilitarControles(true);
                EsNuevoRegistro = false;

                DataGridViewRow fila = dgvPeliculas.CurrentRow;

                // Cargar datos
                IdPeliculaSeleccionada = fila.Cells["IdPelicula"].Value.ToString();
                txtTitulo.Text = fila.Cells["Titulo"].Value.ToString();
                txtGenero.Text = fila.Cells["Genero"].Value.ToString();
                txtDuracion.Text = fila.Cells["Duracion"].Value.ToString();
                txtClasificacion.Text = fila.Cells["Clasificacion"].Value.ToString();
                txtSinopsis.Text = fila.Cells["Sinopsis"].Value.ToString();
                dtpFecha.Value = Convert.ToDateTime(fila.Cells["FechaEstreno"].Value);

                // --- LÓGICA DE CARGA DE IMAGEN ---
                if (fila.Cells["Imagen"].Value != DBNull.Value && fila.Cells["Imagen"].Value != null)
                {
                    byte[] imgBytes = (byte[])fila.Cells["Imagen"].Value;
                    using (System.IO.MemoryStream ms = new System.IO.MemoryStream(imgBytes))
                    {
                        pbPoster.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    pbPoster.Image = null; // Si no hay imagen, PictureBox vacío
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona la película a editar.", "Advertencia");
            }
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Validaciones (Solo Título es obligatorio)
                if (string.IsNullOrWhiteSpace(txtTitulo.Text))
                {
                    MessageBox.Show("El título es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Convertimos la imagen del PictureBox a formato binario (byte[])
                byte[] imagenData = ConvertirImagenABytes(pbPoster.Image);

                // 1. Decidir si Insertar o Editar
                if (EsNuevoRegistro)
                {
                    // Llama al método de Insertar (CON IMAGEN)
                    negocioPeliculas.InsertarPelicula(
                        txtTitulo.Text, txtGenero.Text, txtDuracion.Text, txtClasificacion.Text,
                        dtpFecha.Value, txtSinopsis.Text, imagenData // PASAMOS IMAGEN
                    );
                    MessageBox.Show("Película insertada correctamente.", "Éxito");
                }
                else
                {
                    // Llama al método de Editar (CON IMAGEN)
                    negocioPeliculas.EditarPelicula(
                        IdPeliculaSeleccionada, txtTitulo.Text, txtGenero.Text, txtDuracion.Text,
                        txtClasificacion.Text, txtSinopsis.Text, imagenData // PASAMOS IMAGEN
                    );
                    MessageBox.Show("Película editada correctamente.", "Éxito");
                }

                // 2. Finalizar la operación
                CargarPeliculas();
                LimpiarControles();
                HabilitarControles(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar guardar la película: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (dgvPeliculas.SelectedRows.Count > 0)
            {
                DialogResult resultado = MessageBox.Show(
                    "¿Está seguro de dar de baja la película seleccionada?",
                    "Confirmar Eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        string id = dgvPeliculas.CurrentRow.Cells["IdPelicula"].Value.ToString();
                        negocioPeliculas.EliminarPelicula(id);
                        MessageBox.Show("Película marcada como inactiva.", "Éxito");
                        CargarPeliculas();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al intentar eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona la película a eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            LimpiarControles();
            HabilitarControles(false);
            dgvPeliculas.ClearSelection();
            EsNuevoRegistro = false;
        }

        // --- MÉTODOS DE MANEJO DE IMAGEN ---
        private void btnSubirImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Archivos de Imagen (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                pbPoster.Image = Image.FromFile(openFile.FileName);
            }
        }

        private void btnQuitarImagen_Click(object sender, EventArgs e)
        {
            pbPoster.Image = null; // Quitar la imagen
        }

        // --- EVENTOS DEL DISEÑADOR (SIN LÓGICA) ---
        private void FrmMantPeliculas_Load(object sender, EventArgs e) { }
        private void Btn_Minimizar_Click(object sender, EventArgs e) { this.WindowState = FormWindowState.Minimized; }
        private void Btn_Cerrar_Click(object sender, EventArgs e) { this.Close(); }

        private void pbPoster_Click(object sender, EventArgs e)
        {

        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtSinopsis_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtClasificacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDuracion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGenero_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTitulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvPeliculas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}