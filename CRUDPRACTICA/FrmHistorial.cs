using System;
using System.Windows.Forms;
using CapaNegocio; // Conecta con CN_Tickets
using System.Data; // Necesario para DataTable

namespace CapaPresentacion
{
    public partial class FrmHistorial : Form
    {
        private CN_Tickets negocio = new CN_Tickets(); // Usamos la clase de Tickets

        public FrmHistorial()
        {
            InitializeComponent();
        }

        private void FrmHistorial_Load(object sender, EventArgs e)
        {
            CargarDatosHistorial();
        }

        private void CargarDatosHistorial()
        {
            try
            {
                // Llamamos al método nuevo que creamos
                dgvTickets.DataSource = negocio.VerHistorialVentas();

                // Ajustes visuales
                dgvTickets.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvTickets.AllowUserToAddRows = false;
                dgvTickets.ReadOnly = true;
                dgvTickets.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar historial: " + ex.Message);
            }
        }

        // --- BOTÓN VER DETALLE --- 

        //Llama a form FrmEditarTicket para editar el ticket seleccionado
        private void Btn_editar_Click(object sender, EventArgs e)
        {
            // Verificamos si hay una fila seleccionada
            if (dgvTickets.SelectedRows.Count > 0)
            {
                // 1. OBTENER DATOS DE LA FILA (OJO con los nombres de columnas)
                // Estos nombres deben coincidir con tu SELECT de SQL
                string codigo = dgvTickets.CurrentRow.Cells["CodigoTicket"].Value.ToString();
                string pelicula = dgvTickets.CurrentRow.Cells["Pelicula"].Value.ToString();
                string horario = dgvTickets.CurrentRow.Cells["Horario"].Value.ToString();
                string precio = dgvTickets.CurrentRow.Cells["PrecioTotal"].Value.ToString();
                string idPelicula = dgvTickets.CurrentRow.Cells["IdPelicula"].Value.ToString(); // El dato oculto

                // 2. ABRIR EL FORMULARIO DE EDICIÓN
                // Usamos el constructor de 5 argumentos que creaste
                FrmEditarTicket editar = new FrmEditarTicket(codigo, pelicula, horario, precio, idPelicula);

                // 3. ESPERAR Y REFRESCAR
                // Si le das a "Actualizar" en el otro form, este devuelve OK
                if (editar.ShowDialog() == DialogResult.OK)
                {
                    CargarDatosHistorial();  // Refrescamos la tabla para ver los cambios
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila para editar.");
            }
        }


        private void Btn_guardar_Click(object sender, EventArgs e) 
        {
            CargarDatosHistorial();
            MessageBox.Show("Lista actualizada correctamente.", "Sistema");
        }
        private void Btn_eliminar_Click(object sender, EventArgs e) 
        {
            if (dgvTickets.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Seguro que deseas eliminar este ticket permanentemente?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        CN_Tickets negocio = new CN_Tickets();
                        string codigo = dgvTickets.CurrentRow.Cells["CodigoTicket"].Value.ToString();

                        // Llamamos al método eliminar (asegúrate de tenerlo en CN_Tickets)
                        negocio.EliminarTicket(codigo);

                        MessageBox.Show("Ticket eliminado.");
                        CargarDatosHistorial(); // Refrescar
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecciona una fila para eliminar.");
            }
        }
        private void dgvTickets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Btn_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}