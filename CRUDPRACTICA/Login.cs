using CapaNegocio;
using CapaDatos;
using System;
using System.Data; 
using System.Drawing;
using System.Drawing.Drawing2D; 
using System.Runtime.InteropServices; 
using System.Windows.Forms;



namespace CapaPresentacion
{
    public partial class Login : Form
    {
        // Esta variable guardará quién inició sesión para usarlo en las otras pantallas
        public static UsuarioModelo UsuarioSesion;

        public Login()
        {
            InitializeComponent();
            ConfigurarDiseñoBoton();
        }

        private void ConfigurarDiseñoBoton()
        {
            try
            {
                int radius = 20;
                GraphicsPath path = new GraphicsPath();

                path.AddArc(0, 0, radius, radius, 180, 90);
                path.AddArc(btn_login.Width - radius, 0, radius, radius, 270, 90);
                path.AddArc(btn_login.Width - radius, btn_login.Height - radius, radius, radius, 0, 90);
                path.AddArc(0, btn_login.Height - radius, radius, radius, 90, 90);
                path.CloseFigure();
                btn_login.Region = new Region(path);
            }
            catch { }
        }

        // Lógica para arrastrar la ventana sin bordes
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0x0f012, 0);
        }

        private void Btn_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_Cerrar1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btn_login_Click(object sender, EventArgs e)
        {
            // 1. Validar que no estén vacíos
            if (string.IsNullOrEmpty(txt_user.Text) || string.IsNullOrEmpty(txt_password.Text))
            {
                MessageBox.Show("Por favor, ingrese usuario y contraseña.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 2. Llamamos a la Capa de Negocio (CN_Usuarios)
                CN_Usuarios negocio = new CN_Usuarios();
                DataTable resultado = negocio.ValidarLogin(txt_user.Text, txt_password.Text);

                // 3. Verificamos si la base de datos encontró al usuario
                if (resultado.Rows.Count > 0)
                {
                    // ¡Login Exitoso! Capturamos la primera fila
                    DataRow fila = resultado.Rows[0];

                    // 4. Guardamos los datos en memoria
                    UsuarioSesion = new UsuarioModelo();

                    // IMPORTANTE: Estos nombres ("Id", "Nombre", etc.) deben coincidir con tu consulta SQL
                    UsuarioSesion.Id = Guid.Parse(fila["Id"].ToString());
                    UsuarioSesion.Nombre = fila["Nombre"].ToString();
                    UsuarioSesion.NombreUsuario = fila["Usuario"].ToString();
                    UsuarioSesion.EsInvitado = Convert.ToBoolean(fila["EsInvitado"]);

                    // Capturamos el Rol para saber si es Admin o Cliente
                    string rol = fila["NombreRol"].ToString();

                    MessageBox.Show($"¡Bienvenido {UsuarioSesion.Nombre}!\nRol: {rol}", "Acceso Correcto");

                    // 5. Abrir el formulario principal (Cartelera)
                    FrmMenuPrincipal menu = new FrmMenuPrincipal();
                    menu.Show();
                    this.Hide(); // Ocultamos el login
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.\nIntenta con: admin / 1234", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar: " + ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {


           
        }

        private void btninvitado_Click(object sender, EventArgs e)
        {
            // 1. Creamos un usuario "temporal" en la memoria del programa

            UsuarioSesion = new UsuarioModelo();
            UsuarioSesion.Id = Guid.NewGuid();
            UsuarioSesion.Nombre = "Visitante";
            UsuarioSesion.NombreUsuario = "Invitado";
            UsuarioSesion.Rol = "Cliente";
            UsuarioSesion.EsInvitado = true;

            // 2. Mensaje de aviso
            MessageBox.Show("Estás entrando en Modo Invitado.\n(No se guardará historial de tus compras)",
                            "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // 3. Abrimos la Cartelera
            FrmMenuPrincipal menu = new FrmMenuPrincipal();
            menu.Show();
            this.Hide();
        }

        // Abrir el formulario de registro
        //Se cierra el formulario de login y se abre el formulario de registro
        


        private void lnkRegistro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)

        {
            Registro registroForm = new Registro();
            this.Hide(); // Oculta el formulario de login

            registroForm.ShowDialog();
            this.Show(); // Muestra el formulario de login nuevamente después de cerrar el registro


        }


    }
}