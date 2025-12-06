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
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo letras, espacios y teclas de control (como retroceso)
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }

        }

        

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // 1. Validar campos vacíos básicos
            if (txtUsuario.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Usuario y Contraseña son obligatorios.", "Faltan Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string correo = txtCorreo.Text;

            // --- INICIO DE VALIDACIONES DE CORREO ESTRICTAS ---

            // Regla 1: Debe tener arroba y punto
            if (!correo.Contains("@") || !correo.Contains("."))
            {
                MessageBox.Show("El correo DEBE contener '@' y un punto '.' (ej: usuario@gmail.com).", "Correo Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCorreo.Focus();
                return; // SE DETIENE AQUÍ, NO GUARDA NADA
            }

            // Regla 2: No puede tener mayúsculas (Tu requisito específico)
            // Buscamos si existe alguna letra mayúscula en el texto
            if (System.Text.RegularExpressions.Regex.IsMatch(correo, "[A-Z]"))
            {
                MessageBox.Show("El correo NO puede tener mayúsculas. Escríbelo todo en minúsculas.", "Formato Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCorreo.Focus();
                return; // SE DETIENE AQUÍ
            }

            // Regla 3: Solo letras, números, @ y . (Nada de ñ, tildes, #, $, spaces, etc.)
            // La expresión "^[a-z0-9@.]+$" significa:
            // ^ = inicio, [ ] = caracteres permitidos, + = uno o más, $ = fin
            if (!System.Text.RegularExpressions.Regex.IsMatch(correo, "^[a-z0-9@.]+$"))
            {
                MessageBox.Show("El correo tiene caracteres prohibidos.\nSolo se permiten letras minúsculas, números, '@' y '.'", "Caracteres Inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCorreo.Focus();
                return; // SE DETIENE AQUÍ
            }

            // --- FIN DE VALIDACIONES ---

            try
            {
                CN_Usuarios negocio = new CN_Usuarios();
                // Si pasó todas las validaciones de arriba, recién aquí intenta guardar
                negocio.RegistrarUsuario(txtUsuario.Text, txtPassword.Text, txtNombre.Text, txtCorreo.Text);

                MessageBox.Show("¡Cuenta creada exitosamente! Ahora inicia sesión.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar en base de datos: " + ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {
            // Validamos si tiene @ Y TAMBIÉN tiene un punto .
            if (txtCorreo.Text.Contains("@") && txtCorreo.Text.Contains("."))
            {
                // Si cumple, fondo blanco (o verde suave si prefieres)
                txtCorreo.BackColor = Color.White;
                // Opcional: Color.LightGreen para confirmar visualmente
            }
            else
            {
                // Si falta algo, fondo rojizo para alertar
                txtCorreo.BackColor = Color.Red;
            }
        }
    }
}
