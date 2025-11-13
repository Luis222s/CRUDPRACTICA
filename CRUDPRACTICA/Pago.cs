using CRUDPRACTICA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using Microsoft.IdentityModel.Tokens;

namespace CapaPresentacion
{
    public partial class Pago : Form
    {
        CN_Negocio CN = new CN_Negocio();
        private string IdProducto = null;
        private bool Editar = false;
        public Cartelera FormPrincipal { get; set; }
        public Pago()
        {
            InitializeComponent();

            Pelicula pelicula = new Pelicula();
            pelicula.GenerarBoleto();

            MessageBox.Show($"CÓDIGO DE BOLETO:\n{pelicula.CodigoBoleto}", "Boleto generado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            int radius = 20;

            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(Btn_guardar.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(Btn_guardar.Width - radius, Btn_guardar.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, Btn_guardar.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            Btn_guardar.Region = new Region(path);

            GraphicsPath path1 = new GraphicsPath();
            path1.AddArc(0, 0, radius, radius, 180, 90);
            path1.AddArc(Btn_editar.Width - radius, 0, radius, radius, 270, 90);
            path1.AddArc(Btn_editar.Width - radius, Btn_editar.Height - radius, radius, radius, 0, 90);
            path1.AddArc(0, Btn_editar.Height - radius, radius, radius, 90, 90);
            path1.CloseFigure();
            Btn_editar.Region = new Region(path);

            GraphicsPath path2 = new GraphicsPath();
            path2.AddArc(0, 0, radius, radius, 180, 90);
            path2.AddArc(Btn_eliminar.Width - radius, 0, radius, radius, 270, 90);
            path2.AddArc(Btn_eliminar.Width - radius, Btn_eliminar.Height - radius, radius, radius, 0, 90);
            path2.AddArc(0, Btn_eliminar.Height - radius, radius, radius, 90, 90);
            path2.CloseFigure();
            Btn_eliminar.Region = new Region(path);
        }

        private void MostrarDatos()
        {
            CN_Negocio Ney = new CN_Negocio();
            dataGridView1.DataSource = Ney.MostrarDatos();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Cartelera go = new Cartelera();
            go.Show();
            this.Close();

        }

        private void Pago_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_nombre.Text) ||
                string.IsNullOrWhiteSpace(txt_email.Text) ||
                string.IsNullOrWhiteSpace(txt_telefono.Text) ||
                string.IsNullOrWhiteSpace(cmb_metodo.Text) ||
                string.IsNullOrWhiteSpace(txt_cedula.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos antes de continuar.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Editar == false)
            {

                try
                {
                    CN.InsertarProd(txt_nombre.Text, txt_email.Text, txt_telefono.Text, cmb_metodo.Text, txt_cedula.Text);
                    MessageBox.Show("Compra completada correctamente, Recibiras un correo con tu recibo en tu bandeja", "Pago confirmado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarDatos();
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se puede por" + ex.Message);
                }
            }
            if (Editar == true)
            {
                try
                {
                    CN.EditarProd(txt_nombre.Text, txt_email.Text, txt_telefono.Text, cmb_metodo.Text, txt_cedula.Text, IdProducto);
                    MessageBox.Show("Se editó correctamente, Recibiras un correo con tu recibo en tu bandeja", "Pago confirmado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarDatos();
                    Editar = false;
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se puede por" + ex.Message);
                }
            }

        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Editar = true;
                txt_nombre.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                txt_email.Text = dataGridView1.CurrentRow.Cells["Email"].Value.ToString();
                txt_telefono.Text = dataGridView1.CurrentRow.Cells["Telefono"].Value.ToString();
                cmb_metodo.Text = dataGridView1.CurrentRow.Cells["MetodoPago"].Value.ToString();
                txt_cedula.Text = dataGridView1.CurrentRow.Cells["Cedula"].Value.ToString();
                IdProducto = dataGridView1.CurrentRow.Cells["id"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Debes seleccionar una fila para editarla", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void LimpiarCampos()
        {
            txt_nombre.Clear();
            txt_email.Clear();
            txt_telefono.Clear();
            txt_cedula.Clear();
            cmb_metodo.SelectedIndex = -1;
        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {

                if (dataGridView1.SelectedRows.Count > 0)
                {
                    IdProducto = dataGridView1.CurrentRow.Cells["id"].Value.ToString();
                    CN.EliminarProd(IdProducto);
                    MessageBox.Show("Se eliminó correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarDatos();
                }
                else
                {
                    MessageBox.Show("Debes seleccionar una fila para eliminarla", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo completar la accion porque" + ex);
            }
        }
    }
}
