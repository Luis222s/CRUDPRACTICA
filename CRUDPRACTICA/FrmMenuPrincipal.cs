using System;
using System.Windows.Forms;
using System.Drawing; // Necesario si manipulas colores

namespace CapaPresentacion
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        //TODO:MÉTODO MAESTRO PARA ABRIR EN PANEL (Dashboard) ---
        private void AbrirFormulario(Form formularioHijo)
        {
            // 1. Si ya hay algo en el panel, lo quitamos
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);

            // 2. Configuramos el formulario para que se comporte como un control
            formularioHijo.TopLevel = false;
            formularioHijo.Dock = DockStyle.Fill; // Que llene todo el espacio
            formularioHijo.FormBorderStyle = FormBorderStyle.None; // Sin bordes de ventana

            // 3. Lo agregamos al panel y lo mostramos
            this.panelContenedor.Controls.Add(formularioHijo);
            this.panelContenedor.Tag = formularioHijo;
            formularioHijo.Show();
        }

        // --- BOTONES LATERALES (Menú Izquierdo) ---

        private void btnCartelera_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Cartelera());
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmReportes());
        }

        private void btnMantenimiento_Click(object sender, EventArgs e)
        {

            AbrirFormulario(new FrmMantPeliculas());

        }
        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Acercade());

        }
        private void btnHistorialCompleto_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmHistorialVentas());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // --- LIMPIEZA DE CÓDIGO VIEJO ---
        // Estos eventos del menú viejo (MenuStrip) ya no los necesitas si usas botones laterales.
        // Puedes dejarlos vacíos o borrarlos desde el diseño.
        private void verCarteleraToolStripMenuItem_Click(object sender, EventArgs e) { }
        private void historialToolStripMenuItem_Click(object sender, EventArgs e) { }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e) { }
        private void verCarteleraToolStripMenuItem_Click_1(object sender, EventArgs e) { }
        private void historialToolStripMenuItem_Click_1(object sender, EventArgs e) { }
        private void salirToolStripMenuItem_Click_1(object sender, EventArgs e) { }
        private void cineToolStripMenuItem_Click(object sender, EventArgs e) { }
        private void ventasToolStripMenuItem_Click(object sender, EventArgs e) { }
        private void archivoToolStripMenuItem_Click(object sender, EventArgs e) { }
        private void button2_Click(object sender, EventArgs e) { }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

    }
       

}