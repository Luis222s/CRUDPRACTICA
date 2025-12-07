using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using CapaNegocio;
using System.IO;

namespace CapaPresentacion
{
    public partial class VentaDeBoletos : Form
    {
        // VARIABLES GLOBALES
        private int IdPelicula;
        private string TituloPelicula;
        private Image ImagenPelicula; // <-- ALMACENA LA IMAGEN RECIBIDA
        private decimal TotalAPagar = 0;

        // --- CONSTRUCTOR CORREGIDO (3 ARGUMENTOS) ---
        public VentaDeBoletos(string idRecibido, string tituloRecibido, Image imagenRecibida)
        {
            InitializeComponent();
            ConfigurarDiseñoRedondo();

            // 1. Guardamos los datos recibidos
            if (int.TryParse(idRecibido, out int id))
            {
                this.IdPelicula = id;
                this.TituloPelicula = tituloRecibido;
            }
            this.ImagenPelicula = imagenRecibida; // <-- GUARDAMOS EL OBJETO IMAGEN
        }

        // Constructor vacío (para el diseñador)
        public VentaDeBoletos()
        {
            InitializeComponent();
            ConfigurarDiseñoRedondo();
        }

        // --- CARGA DEL FORMULARIO ---
        private void VentaDeBoletos_Load(object sender, EventArgs e)
        {
            this.Text = "Comprando: " + TituloPelicula;

            // 1. Mostrar la imagen recibida
            if (this.ImagenPelicula != null)
            {
                // Asumo que tu PictureBox se llama pictureBox2
                pictureBox2.Image = this.ImagenPelicula;
                pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            }

            // 2. Limpiamos todo primero para evitar errores
            LimpiarTodo();

            // 3. Llenamos los ComboBoxes con datos nuevos
            LlenarHorarios();
            LlenarCantidad();
            LlenarTipoEntrada();
            LlenarCombosComida();
        }

        // --- MÉTODOS DE LIMPIEZA ---
        private void LimpiarTodo()
        {
            // Limpiamos items y reseteamos selección
            cmbHorario.Items.Clear();
            cmbHorario.SelectedIndex = -1;
            cmbHorario.Text = "";

            cmbCantidad.Items.Clear();
            cmbCantidad.SelectedIndex = -1;
            cmbCantidad.Text = "";

            cmbEntrada.Items.Clear();
            cmbEntrada.SelectedIndex = -1;
            cmbEntrada.Text = "";

            // Limpiar comidas (si existen en el diseño)
            if (cmbCombo1 != null) { cmbCombo1.Items.Clear(); cmbCombo1.SelectedIndex = -1; }
            if (cmbCombo2 != null) { cmbCombo2.Items.Clear(); cmbCombo2.SelectedIndex = -1; }
            if (cmbCombo3 != null) { cmbCombo3.Items.Clear(); cmbCombo3.SelectedIndex = -1; }
            if (cmbCombo4 != null) { cmbCombo4.Items.Clear(); cmbCombo4.SelectedIndex = -1; }
        }

        // --- MÉTODOS DE LLENADO ---
        private void LlenarHorarios()
        {
            cmbHorario.Items.Add("3:00 PM");
            cmbHorario.Items.Add("6:00 PM");
            cmbHorario.Items.Add("9:00 PM");
            // Seleccionamos el primero por defecto para que no quede vacío
            cmbHorario.SelectedIndex = 0;
        }

        private void LlenarCantidad()
        {
            for (int i = 1; i <= 10; i++) cmbCantidad.Items.Add(i.ToString());
            cmbCantidad.SelectedIndex = 0;
        }

        private void LlenarTipoEntrada()
        {
            cmbEntrada.Items.Add("Normal ($125)");
            cmbEntrada.Items.Add("VIP ($300)");
            cmbEntrada.SelectedIndex = 0;
        }

        private void LlenarCombosComida()
        {
            LlenarUnCombo(cmbCombo1);
            LlenarUnCombo(cmbCombo2);
            LlenarUnCombo(cmbCombo3);
            LlenarUnCombo(cmbCombo4);
        }

        private void LlenarUnCombo(ComboBox cmb)
        {
            if (cmb != null)
            {
                cmb.Items.Add("0"); // Opción 0 por defecto
                for (int i = 1; i <= 5; i++) cmb.Items.Add(i.ToString());
                cmb.SelectedIndex = 0; // Seleccionar "0"
            }
        }

        // --- BOTÓN CONFIRMAR (MODIFICADO PARA PASAR 7 ARGUMENTOS) ---
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            // Validar
            if (string.IsNullOrEmpty(cmbHorario.Text) || string.IsNullOrEmpty(cmbCantidad.Text))
            {
                MessageBox.Show("Faltan datos.");
                return;
            }

            // ... (Cálculos de precio) ...
            int cantidad = int.Parse(cmbCantidad.Text);
            decimal precio = cmbEntrada.Text.Contains("VIP") ? 300 : 125;
            decimal subtotal = cantidad * precio;

            decimal comida = 0;
            if (cmbCombo1 != null) comida += int.Parse(cmbCombo1.Text) * 300;
            if (cmbCombo2 != null) comida += int.Parse(cmbCombo2.Text) * 330;
            if (cmbCombo3 != null) comida += int.Parse(cmbCombo3.Text) * 460;
            if (cmbCombo4 != null) comida += int.Parse(cmbCombo4.Text) * 1100;

            TotalAPagar = subtotal + comida;


            // Ir a Salas con los datos
            // ESTA LLAMADA AHORA TIENE 7 ARGUMENTOS (6 de datos + 1 de Imagen)
            Salas salas = new Salas(
                IdPelicula,
                TituloPelicula,
                cmbHorario.Text,
                cantidad,
                TotalAPagar,
                cmbEntrada.Text,
                this.ImagenPelicula // <-- ARGUMENTO 7: IMAGEN
            );
            salas.Show();
            this.Close();
        }

        // --- DISEÑO VISUAL ---
        private void pictureBox1_Click(object sender, EventArgs e) // Casa
        {
            Cartelera principal = new Cartelera();
            principal.Show();
            this.Close();
        }

        private void btnVolver_Click(object sender, EventArgs e) // Flecha atrás
        {
            // FrmPelicula detalle = new FrmPelicula(IdPelicula.ToString());
            // detalle.Show();
            this.Close();
        }

        private void ConfigurarDiseñoRedondo()
        {
            try
            {
                int radius = 20;
                AplicarBorde(btnConfirmar, radius);
            }
            catch { }
        }

        private void AplicarBorde(Button btn, int radius)
        {
            if (btn == null) return;
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(btn.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(btn.Width - radius, btn.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, btn.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            btn.Region = new Region(path);
        }

        // Eventos vacíos para que no falle el diseñador
        private void cmbHorario_SelectedIndexChanged(object sender, EventArgs e) { }
        private void cmbCantidad_SelectedIndexChanged(object sender, EventArgs e) { }
        private void cmbEntrada_SelectedIndexChanged(object sender, EventArgs e) { }
        private void cmbCombo1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void cmbCombo2_SelectedIndexChanged(object sender, EventArgs e) { }
        private void cmbCombo3_SelectedIndexChanged(object sender, EventArgs e) { }
        private void cmbCombo4_SelectedIndexChanged(object sender, EventArgs e) { }
        private void Btn_Confirmar1_Click(object sender, EventArgs e) { }
        private void pictureBox2_Click(object sender, EventArgs e) { } // Nuevo Click Handler

        // Mover ventana
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture(); SendMessage(this.Handle, 0x112, 0x0f012, 0);
        }

        //Te manda para frmpeliculas
        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmPelicula frm = new FrmPelicula(IdPelicula.ToString());
            frm.Show();
        }
    }
}