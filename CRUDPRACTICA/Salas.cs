using CapaNegocio;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Data;

namespace CapaPresentacion
{
    public partial class Salas : Form
    {
        // Datos recibidos de la compra
        private int idPelicula;
        private string horario;
        private string tituloPelicula;
        private int cantidadBoletos;
        private decimal totalPagar;
        private string tipoEntrada;

        // AÑADIDO: Variable para guardar la imagen que recibimos de VentaDeBoletos
        private Image ImagenPelicula;

        // CONSTRUCTOR MODIFICADO (7 ARGUMENTOS)
        public Salas(int id, string titulo, string horario, int cantidad, decimal total, string tipo, Image imagenRecibida)
        {
            InitializeComponent();

            this.idPelicula = id;
            this.horario = horario;
            this.tituloPelicula = titulo;
            this.cantidadBoletos = cantidad;
            this.totalPagar = total;
            this.tipoEntrada = tipo;

            // GUARDAMOS LA IMAGEN (Aunque Salas no la use, la transporta)
            this.ImagenPelicula = imagenRecibida;

            label9.Text = $"Total: ${total}";

            // DETERMINAR SALA (Lógica simple por ahora)
            int idSalaDestino = (tipo.Contains("VIP")) ? 3 : 1;

            // CARGAR ASIENTOS REALES DE LA BASE DE DATOS
            CargarAsientosDeBaseDatos(idSalaDestino);

            ConfigurarBotonRedondo();
        }

        // --- MÉTODO PARA VOLVER A VentaDeBoletos (PASA LA IMAGEN DE VUELTA) ---
        private void btnAtras_Click(object sender, EventArgs e)
        {
            // Cierra la ventana actual (Salas)
            this.Close();

            // Crea una NUEVA instancia de VentaDeBoletos, pasando la imagen almacenada.
            VentaDeBoletos venta = new VentaDeBoletos(
                this.idPelicula.ToString(),
                this.tituloPelicula,
                this.ImagenPelicula // <-- ARGUMENTO CLAVE: La imagen
            );
            venta.Show();
        }

        // --- [MÉTODOS RESTANTES OMITIDOS POR BREVEDAD, DEBEN PERMANECER EN TU ARCHIVO] ---

        private void CargarAsientosDeBaseDatos(int idSala)
        {
            try
            {
                CN_Tickets negocio = new CN_Tickets();
                DataTable tablaAsientos = negocio.TraerAsientos(idSala);

                // Limpiamos los combos
                comboBox.Items.Clear(); comboBox.Items.Add("---");
                comboBox1.Items.Clear(); comboBox1.Items.Add("---");
                comboBox2.Items.Clear(); comboBox2.Items.Add("---");
                comboBox3.Items.Clear(); comboBox3.Items.Add("---");

                // Repartimos los asientos entre los 4 combos para que se vea ordenado
                int contador = 0;
                foreach (DataRow fila in tablaAsientos.Rows)
                {
                    string codigo = fila["CodigoAsiento"].ToString();

                    if (contador < 8) comboBox.Items.Add(codigo);
                    else if (contador < 16) comboBox1.Items.Add(codigo);
                    else if (contador < 24) comboBox2.Items.Add(codigo);
                    else comboBox3.Items.Add(codigo);

                    contador++;
                }

                // Seleccionamos el primero
                comboBox.SelectedIndex = 0;
                comboBox1.SelectedIndex = 0;
                comboBox2.SelectedIndex = 0;
                comboBox3.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar asientos: " + ex.Message);
            }
        }

        // Método para llenar los combos con asientos (A1, A2...)
        private void LlenarAsientos(ComboBox cmb, string letraFila)
        {
            cmb.Items.Clear();
            cmb.Items.Add("---"); // Opción vacía (Índice 0)

            // Agregamos 10 asientos por fila
            for (int i = 1; i <= 10; i++)
            {
                cmb.Items.Add($"{letraFila}{i}"); // Ej: A1, A2...
            }

            // Ahora sí es seguro seleccionar el 0 porque ya existen items
            cmb.SelectedIndex = 0;
        }

        // --- BOTÓN CONFIRMAR (Guardar en BD) ---
        private void Btn_Confirmar_Click(object sender, EventArgs e)
        {
            // 1. Validar que eligió un asiento (que no estén todos en "---")
            if (comboBox.SelectedIndex == 0 && comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 0 && comboBox3.SelectedIndex == 0)
            {
                MessageBox.Show("Debes elegir al menos un asiento.", "Falta Asiento", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Obtener el texto del asiento seleccionado
            string asientoTexto = "";
            if (comboBox.SelectedIndex > 0) asientoTexto = comboBox.SelectedItem.ToString();
            else if (comboBox1.SelectedIndex > 0) asientoTexto = comboBox1.SelectedItem.ToString();
            else if (comboBox2.SelectedIndex > 0) asientoTexto = comboBox2.SelectedItem.ToString();
            else if (comboBox3.SelectedIndex > 0) asientoTexto = comboBox3.SelectedItem.ToString();

            try
            {
                CN_Tickets negocio = new CN_Tickets();

                // Datos para SQL
                Guid usuarioId = Login.UsuarioSesion != null ? Login.UsuarioSesion.Id : Guid.NewGuid();
                int idSala = 1; // Por defecto Sala 1
                int idAsientoSimulado = 1; // Simulamos ID numérico (en futuro buscar real)
                int metodoPago = 1; // 1 = Efectivo
                string productos = "Boletos + Combos"; // Descripción simple

                // Llamada con los 8 parámetros
                string codigo = negocio.RegistrarVenta(
          usuarioId,
          this.idPelicula,
          idSala,
          this.horario,
          idAsientoSimulado,
          metodoPago,
          this.totalPagar,
          productos
        );

                MessageBox.Show($"¡Compra Exitosa!\nTu código es: {codigo}\nAsiento: {asientoTexto}", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Volver al inicio
                Cartelera inicio = new Cartelera();
                inicio.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        // --- LÓGICA VISUAL DE COMBOS (Solo uno activo a la vez) ---
        private void Combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox activo = null;
            if (comboBox.SelectedIndex > 0) activo = comboBox;
            else if (comboBox1.SelectedIndex > 0) activo = comboBox1;
            else if (comboBox2.SelectedIndex > 0) activo = comboBox2;
            else if (comboBox3.SelectedIndex > 0) activo = comboBox3;

            if (activo == null)
            {
                comboBox.Enabled = true; comboBox1.Enabled = true; comboBox2.Enabled = true; comboBox3.Enabled = true;
            }
            else
            {
                comboBox.Enabled = (activo == comboBox);
                comboBox1.Enabled = (activo == comboBox1);
                comboBox2.Enabled = (activo == comboBox2);
                comboBox3.Enabled = (activo == comboBox3);
            }

            if (activo != null && txtMostrarAsientos != null)
            {
                txtMostrarAsientos.Text = activo.SelectedItem.ToString();
            }
        }

        // --- DISEÑO VISUAL ---
        private void ConfigurarBotonRedondo()
        {
            try
            {
                int radius = 20;
                GraphicsPath path = new GraphicsPath();
                path.AddArc(0, 0, radius, radius, 180, 90);
                path.AddArc(Btn_Confirmar.Width - radius, 0, radius, radius, 270, 90);
                path.AddArc(Btn_Confirmar.Width - radius, Btn_Confirmar.Height - radius, radius, radius, 0, 90);
                path.AddArc(0, Btn_Confirmar.Height - radius, radius, radius, 90, 90);
                path.CloseFigure();
                Btn_Confirmar.Region = new Region(path);
            }
            catch { }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
            Cartelera frm = new Cartelera();
            frm.Show();
        }

        // Movimiento de Ventana
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        { // Conéctalo a tu panel si tienes
            ReleaseCapture(); SendMessage(this.Handle, 0x112, 0x0f012, 0);
        }

        // Eventos vacíos necesarios para el diseñador
        private void Salas_Load(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void comboBox_SelectedIndexChanged(object sender, EventArgs e) => Combo_SelectedIndexChanged(sender, e);
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) => Combo_SelectedIndexChanged(sender, e);
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) => Combo_SelectedIndexChanged(sender, e);
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e) => Combo_SelectedIndexChanged(sender, e);

     
        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void txtMostrarAsientos_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAtras_Click_1(object sender, EventArgs e)
        {
            // Regresamos a la venta con los datos que ya teníamos
            // Utilizamos la variable ImagenPelicula que almacenamos en el constructor
            VentaDeBoletos venta = new VentaDeBoletos(
                this.idPelicula.ToString(),
                this.tituloPelicula,
                this.ImagenPelicula // <-- PASAMOS LA IMAGEN ALMACENADA DE VUELTA
            );
            venta.Show();
            this.Close();
        }
    }
}