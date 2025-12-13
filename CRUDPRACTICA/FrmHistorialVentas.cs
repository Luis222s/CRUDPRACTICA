using System;
using System.Drawing;
using System.Windows.Forms;
using CapaNegocio;
using System.Data;
using System.Collections.Generic;
using CapaDatos;

namespace CapaPresentacion
{
    public partial class FrmHistorialVentas : Form
    {
        private CN_Ventas negocio = new CN_Ventas();

        // Colores para mantener tu estilo (puedes ajustarlos)
        private Color primaryDark = Color.FromArgb(15, 23, 42);
        private Color secondaryDark = Color.FromArgb(30, 41, 59);
        private Color textLight = Color.FromArgb(241, 245, 249);
        private Color accentGold = Color.FromArgb(251, 191, 36);

        public FrmHistorialVentas()
        {
            InitializeComponent();
            AplicarEstiloOscuro(); // Aplicamos estilo visual
        }

        private void FrmHistorialVentas_Load(object sender, EventArgs e)
        {
            // Al abrir, cargamos solo la lista de arriba (Cabeceras)
            CargarVentasCabecera();
        }

        // TODO: CARGAR LISTA DE VENTAS (ARRIBA) ---
        private void CargarVentasCabecera()
        {
            try
            {
                dgvVentas.DataSource = negocio.ObtenerVentasCabecera(); // Llama a VerHistorialVentas

                // Configuración visual de la tabla
                ConfigurarGrid(dgvVentas);

                // Ocultar columnas internas
                if (dgvVentas.Columns.Contains("IdVenta")) dgvVentas.Columns["IdVenta"].Visible = false;
                if (dgvVentas.Columns.Contains("IdUsuario")) dgvVentas.Columns["IdUsuario"].Visible = false;
                if (dgvVentas.Columns.Contains("IdPelicula")) dgvVentas.Columns["IdPelicula"].Visible = false;

                dgvVentas.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar lista: " + ex.Message);
            }
        }

        // --- 2. CARGAR DETALLE (ABAJO) ---
        private void CargarDetalleVenta(int idVenta)
        {
            try
            {
                dgvDetalle.DataSource = negocio.ObtenerVentasDetalle(idVenta); // Llama a VerDetalleVenta

                ConfigurarGrid(dgvDetalle);

                // Ocultar columnas internas
                if (dgvDetalle.Columns.Contains("IdVenta")) dgvDetalle.Columns["IdVenta"].Visible = false;
                if (dgvDetalle.Columns.Contains("IdVentaDetalle")) dgvDetalle.Columns["IdVentaDetalle"].Visible = false;

                dgvDetalle.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar detalles: " + ex.Message);
            }
        }

        // --- EVENTO CLIC EN LA TABLA DE ARRIBA ---
        private void dgvVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Validamos que sea una fila válida
            if (e.RowIndex >= 0 && dgvVentas.CurrentRow != null)
            {
                try
                {
                    // Capturamos el ID de la venta seleccionada
                    int idVenta = Convert.ToInt32(dgvVentas.CurrentRow.Cells["IdVenta"].Value);

                    // Cargamos la tabla de abajo con ese ID
                    CargarDetalleVenta(idVenta);

                    // Actualizamos título (opcional)
                    // label2 es "Detalle de la Venta"
                    lblDetalleVenta.Text = $"Detalle de la Venta #{idVenta}";
                }
                catch { }
            }
        }

        // Redirección para asegurar que funcione con cualquier clic
        private void dgvVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvVentas_CellClick(sender, e);
        }

        // --- BOTÓN CERRAR ---
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            // Opción 1: Cerrar el formulario
            //this.Close();

            // Opción 2: Solo limpiar (si prefieres no cerrar)
            dgvVentas.ClearSelection();
            dgvDetalle.DataSource = null;
        }

        // --- ESTILO VISUAL (Para que se vea como tu diseño) ---
        private void AplicarEstiloOscuro()
        {
            this.BackColor = primaryDark;

            // Títulos
            lblVentaTotal.ForeColor = accentGold;
            lblDetalleVenta.ForeColor = accentGold;

            // Botón
            btnCerrar.BackColor = Color.IndianRed;
            btnCerrar.ForeColor = Color.White;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.FlatAppearance.BorderSize = 0;
        }

        private void ConfigurarGrid(DataGridView dgv)
        {
            dgv.BackgroundColor = secondaryDark;
            dgv.BorderStyle = BorderStyle.None;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.EnableHeadersVisualStyles = false;

            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 20, 20);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            dgv.DefaultCellStyle.BackColor = secondaryDark;
            dgv.DefaultCellStyle.ForeColor = textLight;
            dgv.DefaultCellStyle.SelectionBackColor = accentGold;
            dgv.DefaultCellStyle.SelectionForeColor = Color.Black;

            dgv.RowHeadersVisible = false;
            dgv.AllowUserToAddRows = false;
            dgv.ReadOnly = true;
        }

        // Eventos vacíos del diseñador (No borrar)
        private void lblVentaTotal_Click(object sender, EventArgs e) { }
        private void lblDetalleVenta_Click(object sender, EventArgs e) { }
        private void dgvDetalle_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        //Hace un llamado al FrmEditarTicket para editar la venta seleccionada
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvVentas.CurrentRow != null)
            {
                try
                {
                    // 1. OBTENER DATOS (Usando nombres exactos del SP SQL)
                    // Usamos CodigoTicket como identificador porque es string
                    string codigo = dgvVentas.CurrentRow.Cells["CodigoTicket"].Value.ToString();
                    string pelicula = dgvVentas.CurrentRow.Cells["Pelicula"].Value.ToString();
                    string horario = dgvVentas.CurrentRow.Cells["HorarioFuncion"].Value.ToString();
                    string total = dgvVentas.CurrentRow.Cells["Total"].Value.ToString();
                    string idPelicula = dgvVentas.CurrentRow.Cells["IdPelicula"].Value.ToString();

                    // 2. ABRIR FORMULARIO DE EDICIÓN
                    // Enviamos los 5 datos que pide el constructor de FrmEditarTicket
                    FrmEditarTicket frm = new FrmEditarTicket(codigo, pelicula, horario, total, idPelicula);

                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        CargarVentasCabecera(); // Refrescar lista al volver
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al abrir edición: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor selecciona una venta.");
            }
        }
        //Eliminar venta seleccionada
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvVentas.CurrentRow != null)
            {
                try
                {
                    // Obtener el ID de la venta seleccionada
                    int idVenta = Convert.ToInt32(dgvVentas.CurrentRow.Cells["IdVenta"].Value);
                    // Confirmar eliminación
                    var confirmResult = MessageBox.Show("¿Estás seguro de eliminar esta venta?", "Confirmar eliminación", MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        // Llamar al método para eliminar la venta
                        negocio.EliminarVenta(idVenta);
                        // Refrescar la lista de ventas
                        CargarVentasCabecera();
                        dgvDetalle.DataSource = null; // Limpiar detalle
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar la venta: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor selecciona una venta.");
            }
        }
    }
}