using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CRUDPRACTICA;

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        CD_Conexion data = new CD_Conexion();
        private static string connectionString = "Server = (local); Database=PracticaCrud;Integrated Security = True; TrustServerCertificate=True;";
        public Login()
        {
            InitializeComponent();

            int radius = 20;

            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(btn_login.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(btn_login.Width - radius, btn_login.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, btn_login.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            btn_login.Region = new Region(path);
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Btn_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_Cerrar1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0x0f012, 0);
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            // Verificar que los campos no estén vacíos
            if (string.IsNullOrEmpty(txt_user.Text) || string.IsNullOrEmpty(txt_password.Text))
            {
                MessageBox.Show("Por favor, ingrese usuario y contraseña.");
                return;
            }


            // Abrir la conexión y realizar la consulta con parámetros
            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();

                    string query = "SELECT * FROM Login WHERE Usuario = @Usuario AND Contraseña = @Contraseña";
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        // Añadir los parámetros de manera segura
                        cmd.Parameters.AddWithValue("@Usuario", txt_user.Text);
                        cmd.Parameters.AddWithValue("@Contraseña", txt_password.Text);

                        // Ejecutar la consulta y obtener los resultados
                        using (SqlDataReader Lector = cmd.ExecuteReader())
                        {
                            if (Lector.HasRows)
                            {
                                // Leer los datos del lector para asegurar que son exactamente iguales
                                while (Lector.Read())
                                {
                                    // Obtener los valores de usuario y contraseña de la base de datos
                                    string usuarioBaseDeDatos = Lector["Usuario"].ToString();
                                    string contrasenaBaseDeDatos = Lector["Contraseña"].ToString();

                                    // Comparar estrictamente los valores con los que el usuario ingresó
                                    if (txt_user.Text.Equals(usuarioBaseDeDatos) && txt_password.Text.Equals(contrasenaBaseDeDatos))
                                    {
                                        // Si los datos coinciden exactamente, iniciar sesión correctamente
                                        MessageBox.Show("Sesión iniciada de manera exitosa");

                                        // Mostrar el formulario principal
                                        Cartelera formPrincipal = new Cartelera();
                                        formPrincipal.Show();

                                        // Ocultar el formulario de login
                                        this.Hide();
                                    }
                                    else
                                    {
                                        // Si los valores no coinciden, mostrar un mensaje de error
                                        MessageBox.Show("Usuario o Contraseña incorrectos");
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Usuario o Contraseña incorrectos");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                MessageBox.Show("Error de conexión: " + ex.Message);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
