using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using CapaNegocio;
using System.Data;
using System.Linq; // Necesario para algunas extensiones de C#

namespace CapaPresentacion
{
    public partial class VentaDeBoletos : Form
    {
        // VARIABLES GLOBALES
        private int IdPelicula;
        private string TituloPelicula;
        private Image ImagenPelicula; // <-- ALMACENA LA IMAGEN RECIBIDA
        private decimal TotalAPagar = 0;
        private DataTable tablaProductos; // <-- AHORA ALMACENA LOS PRECIOS DE SQL

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

            // 2. CARGAMOS LOS PRECIOS DE LA BASE DE DATOS
            CargarPreciosComida();

            // 3. Limpiamos todo primero para evitar errores
            LimpiarTodo();

            // 4. Llenamos los ComboBoxes con datos nuevos
            LlenarHorarios();
            LlenarCantidad();
            LlenarTipoEntrada();
            LlenarCombosComida();
        }

        // --- NUEVO MÉTODO: TRAER PRECIOS DE SQL ---
        private void CargarPreciosComida()
        {
            try
            {
                CN_Productos negocio = new CN_Productos();
                // Ojo: tablaProductos debe ser 'private DataTable tablaProductos;' a nivel de clase
                tablaProductos = negocio.ObtenerProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar precios de comida: " + ex.Message);
            }
        }

        // --- BOTÓN CONFIRMAR (CÁLCULO REAL CON PRECIOS DE SQL) ---
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            // Validar
            if (string.IsNullOrEmpty(cmbHorario.Text) || string.IsNullOrEmpty(cmbCantidad.Text))
            {
                MessageBox.Show("Faltan datos.");
                return;
            }

            // 1. Calcular Boletos
            int cantidad = int.Parse(cmbCantidad.Text);
            // El precio del boleto sigue fijo por ahora, se podría traer de SQL
            decimal precioBoleto = cmbEntrada.Text.Contains("VIP") ? 300 : 125;
            decimal subtotalBoletos = cantidad * precioBoleto;
            string tipoEntrada = cmbEntrada.Text.Contains("VIP") ? "VIP" : "Normal";

            // 2. Calcular Comida (USANDO PRECIOS DE SQL)
            decimal comida = 0;

            // El orden en SQL es: Combo 1 (0), Combo 2 (1), Combo 3 (2), Combo 4 (3)
            if (tablaProductos != null && tablaProductos.Rows.Count >= 4)
            {
                // Leemos el precio de la fila correspondiente (0=Combo1, 1=Combo2...)
                decimal p1 = Convert.ToDecimal(tablaProductos.Rows[0]["Precio"]);
                decimal p2 = Convert.ToDecimal(tablaProductos.Rows[1]["Precio"]);
                decimal p3 = Convert.ToDecimal(tablaProductos.Rows[2]["Precio"]);
                decimal p4 = Convert.ToDecimal(tablaProductos.Rows[3]["Precio"]);

                // Multiplicamos cantidad seleccionada * precio real
                if (cmbCombo1 != null) comida += int.Parse(cmbCombo1.Text) * p1;
                if (cmbCombo2 != null) comida += int.Parse(cmbCombo2.Text) * p2;
                if (cmbCombo3 != null) comida += int.Parse(cmbCombo3.Text) * p3;
                if (cmbCombo4 != null) comida += int.Parse(cmbCombo4.Text) * p4;
            }
            else
            {
                // Si falla la BD, usamos un Fallback con precios fijos para evitar que la app crashee
                if (cmbCombo1 != null) comida += int.Parse(cmbCombo1.Text) * 300;
                if (cmbCombo2 != null) comida += int.Parse(cmbCombo2.Text) * 330;
                if (cmbCombo3 != null) comida += int.Parse(cmbCombo3.Text) * 460;
                if (cmbCombo4 != null) comida += int.Parse(cmbCombo4.Text) * 1100;
            }

            // 3. Calcular Total a Pagar
            TotalAPagar = subtotalBoletos + comida;

            // 4. Confirmación Visual
            DialogResult respuesta = MessageBox.Show(
                $"Resumen:\nBoletos: ${subtotalBoletos}\nComida: ${comida}\n\nTOTAL: ${TotalAPagar}\n\n¿Proceder?",
                "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                // 5. Ir a Salas con los datos (7 argumentos)
                Salas salas = new Salas(
                    IdPelicula,
                    TituloPelicula,
                    cmbHorario.Text,
                    cantidad,
                    TotalAPagar,
                    tipoEntrada, // Usa 'tipoEntrada' ("VIP" o "Normal") que es el correcto
                    this.ImagenPelicula
                );
                salas.Show();
                this.Close();
            }
        }

        // --- MÉTODOS DE LLENADO Y AUXILIARES ---
        private void LimpiarTodo()
        {
            // Limpiamos items y reseteamos selección
            cmbHorario.Items.Clear(); cmbHorario.SelectedIndex = -1; cmbHorario.Text = "";
            cmbCantidad.Items.Clear(); cmbCantidad.SelectedIndex = -1; cmbCantidad.Text = "";
            cmbEntrada.Items.Clear(); cmbEntrada.SelectedIndex = -1; cmbEntrada.Text = "";

            // Limpiar comidas (si existen en el diseño)
            if (cmbCombo1 != null) { cmbCombo1.Items.Clear(); cmbCombo1.SelectedIndex = -1; }
            if (cmbCombo2 != null) { cmbCombo2.Items.Clear(); cmbCombo2.SelectedIndex = -1; }
            if (cmbCombo3 != null) { cmbCombo3.Items.Clear(); cmbCombo3.SelectedIndex = -1; }
            if (cmbCombo4 != null) { cmbCombo4.Items.Clear(); cmbCombo4.SelectedIndex = -1; }
        }

        private void LlenarHorarios()
        {
            cmbHorario.Items.Add("3:00 PM");
            cmbHorario.Items.Add("6:00 PM");
            cmbHorario.Items.Add("9:00 PM");
            cmbHorario.SelectedIndex = 0; // Seleccionar el primero por defecto
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

        // --- DISEÑO VISUAL Y MOVIMIENTO ---

        // Método para aplicar borde redondo a botones
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

        // Configurar botones
        private void ConfigurarDiseñoRedondo()
        {
            try
            {
                int radius = 20;
                AplicarBorde(btnConfirmar, radius);
            }
            catch { }
        }

        // ocultar y cerrar
        private void pictureBox1_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        // Regresar a FrmPelicula (Flecha atrás)
        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmPelicula frm = new FrmPelicula(IdPelicula.ToString());
            frm.Show();
        }

        // Movimiento de la ventana
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture(); SendMessage(this.Handle, 0x112, 0x0f012, 0);
        }

        // Eventos vacíos para que no falle el diseñador
        private void btnVolver_Click(object sender, EventArgs e) { } // Solo se mantiene si tienes un botón de Volver diferente a btnAtras
        private void cmbHorario_SelectedIndexChanged(object sender, EventArgs e) { }
        private void cmbCantidad_SelectedIndexChanged(object sender, EventArgs e) { }
        private void cmbEntrada_SelectedIndexChanged(object sender, EventArgs e) { }
        private void cmbCombo1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void cmbCombo2_SelectedIndexChanged(object sender, EventArgs e) { }
        private void cmbCombo3_SelectedIndexChanged(object sender, EventArgs e) { }
        private void cmbCombo4_SelectedIndexChanged(object sender, EventArgs e) { }
        private void Btn_Confirmar1_Click(object sender, EventArgs e) { }
        private void pictureBox2_Click(object sender, EventArgs e) { }
        private void cmbCombo2_SelectedIndexChanged_1(object sender, EventArgs e) { }
    }
}