using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using CapaNegocio;
using System.Linq; // Necesario para la búsqueda con Linq (aunque ya no se usa, lo dejamos por si acaso)

namespace CapaPresentacion
{
    public partial class FrmEditarTicket : Form
    {
        // ========== COLORES DEL TEMA CINEMAX ==========
        private Color primaryDark = Color.FromArgb(15, 23, 42);
        private Color secondaryDark = Color.FromArgb(30, 41, 59);
        private Color accentGold = Color.FromArgb(251, 191, 36);
        private Color accentRed = Color.FromArgb(185, 28, 28);
        private Color textLight = Color.FromArgb(241, 245, 249);
        private Color borderColor = Color.FromArgb(71, 85, 105);

        // ========== DECLARACIÓN DE CONTROLES ==========
        private Panel headerPanel;
        private Label titleLabel;
        private Button closeButton;
        private Panel contentPanel;
        private Panel footerPanel;
        private TextBox txtCódigo;
        private ComboBox cmbHorario;
        private TextBox txtPrecio;
        private Button btnActualizar;
        private Button btnCancelar;
        private Label lblCodigo;
        private ComboBox cmbPelicula;
        private Label lblPelicula;
        private Label lblHorario;
        private Label lblPrecio;

        private System.ComponentModel.IContainer components = null;

        // =======================================================
        // ========== CONSTRUCTORES (ELIMINANDO DUPLICADOS Y CÓDIGO VIEJO) ==========
        // =======================================================

        // CONSTRUCTOR PRINCIPAL (ACEPTA 5 ARGUMENTOS)
        // Este es el único constructor con 5 argumentos que debe existir.
        public FrmEditarTicket(string codigo, string pelicula, string horario, string precio, string idPelicula)
        {
            InitializeCustomComponents();
            ApplyCustomDesign();

            // 1. Cargar todas las películas y seleccionar la actual, usando el ID
            CargarPeliculas(idPelicula);

            // 2. Llenar y seleccionar Horario
            LlenarHorarios();
            cmbHorario.Text = horario;

            // 3. Cargar Precio y Código
            txtCódigo.Text = codigo;
            txtCódigo.ReadOnly = true;
            txtPrecio.Text = precio;
        }

        // CONSTRUCTOR VACÍO (Para el diseñador si fuera necesario)
        public FrmEditarTicket()
        {
            InitializeCustomComponents();
            ApplyCustomDesign();
        }

        // CÓDIGO PARA LIMPIEZA DE MEMORIA (Debe existir)
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        // =======================================================
        // ========== MÉTODOS DE DATOS Y LÓGICA ==========
        // =======================================================

        private void CargarPeliculas(string idPeliculaActual)
        {
            CN_Peliculas negocio = new CN_Peliculas();
            DataTable dtPeliculas = negocio.ObtenerListaPeliculas();

            cmbPelicula.DataSource = dtPeliculas;
            cmbPelicula.DisplayMember = "Titulo";
            cmbPelicula.ValueMember = "IdPelicula";

            if (dtPeliculas.Rows.Count > 0 && !string.IsNullOrEmpty(idPeliculaActual))
            {
                cmbPelicula.SelectedValue = Convert.ToInt32(idPeliculaActual);
            }
        }

        private void LlenarHorarios()
        {
            cmbHorario.Items.Clear();
            cmbHorario.Items.Add("3:00 PM");
            cmbHorario.Items.Add("6:00 PM");
            cmbHorario.Items.Add("9:00 PM");
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtPrecio.Text) || cmbHorario.SelectedIndex == -1)
                {
                    ShowCustomMessageBox("Faltan campos importantes.", "Error", MessageBoxIcon.Warning);
                    return;
                }

                string nuevoIdPelicula = cmbPelicula.SelectedValue.ToString();

                CN_Tickets negocio = new CN_Tickets();
                negocio.EditarTicket(txtCódigo.Text, cmbHorario.Text, txtPrecio.Text, nuevoIdPelicula);

                ShowCustomMessageBox("¡Ticket actualizado correctamente!", "Éxito", MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                ShowCustomMessageBox("Error al actualizar: " + ex.Message, "Error", MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowCustomMessageBox(string message, string title, MessageBoxIcon icon)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, icon);
        }

        // =======================================================
        // ========== CÓDIGO DE DISEÑO DINÁMICO (CREACIÓN DE CONTROLES) ==========
        // =======================================================

        private void InitializeCustomComponents()
        {
            // Configuración del formulario base
            this.Text = "Editar Ticket - Cinemax";
            this.Size = new Size(650, 680);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = primaryDark;
            this.Padding = new Padding(2);

            // ===== HEADER PANEL =====
            headerPanel = new Panel
            {
                Dock = DockStyle.Top,
                Height = 90,
                BackColor = secondaryDark
            };

            titleLabel = new Label
            {
                Text = "🎬 EDITAR TICKET",
                Font = new Font("Segoe UI", 22, FontStyle.Bold),
                ForeColor = accentGold,
                Location = new Point(30, 30),
                AutoSize = true
            };

            closeButton = new Button
            {
                Text = "✕",
                Font = new Font("Segoe UI", 16, FontStyle.Bold),
                ForeColor = textLight,
                BackColor = Color.Transparent,
                FlatStyle = FlatStyle.Flat,
                Size = new Size(45, 45),
                Location = new Point(585, 23),
                Cursor = Cursors.Hand
            };
            closeButton.FlatAppearance.BorderSize = 0;
            closeButton.FlatAppearance.MouseOverBackColor = accentRed;
            closeButton.Click += (s, e) => this.Close();

            headerPanel.Controls.Add(titleLabel);
            headerPanel.Controls.Add(closeButton);

            // ===== CONTENT PANEL =====
            contentPanel = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = primaryDark,
                Padding = new Padding(40, 30, 40, 30),
                AutoScroll = true
            };

            int yPos = 20;
            int spacing = 95;

            // ===== CÓDIGO =====
            lblCodigo = CreateStyledLabel("ID TICKET:", yPos);
            txtCódigo = CreateStyledTextBox(yPos + 35);

            yPos += spacing;

            // ===== PELÍCULA =====
            lblPelicula = CreateStyledLabel("PELÍCULA:", yPos);
            cmbPelicula = CreateStyledComboBox(yPos + 35);

            yPos += spacing;

            // ===== HORARIO =====
            lblHorario = CreateStyledLabel("HORARIO:", yPos);
            cmbHorario = CreateStyledComboBox(yPos + 35);

            yPos += spacing;

            // ===== PRECIO =====
            lblPrecio = CreateStyledLabel("PRECIO (RD$):", yPos);
            txtPrecio = CreateStyledTextBox(yPos + 35);
            txtPrecio.PlaceholderText = "0.00";

            // Agregar controles al panel de contenido
            contentPanel.Controls.AddRange(new Control[] {
                lblCodigo, txtCódigo,
                lblPelicula, cmbPelicula,
                lblHorario, cmbHorario,
                lblPrecio, txtPrecio
            });

            // ===== FOOTER PANEL =====
            footerPanel = new Panel
            {
                Dock = DockStyle.Bottom,
                Height = 100,
                BackColor = secondaryDark,
                Padding = new Padding(40, 25, 40, 25)
            };

            btnCancelar = CreateStyledButton("CANCELAR", false);
            btnCancelar.Location = new Point(340, 27);
            btnCancelar.Click += btnCancelar_Click;

            btnActualizar = CreateStyledButton("💾 GUARDAR CAMBIOS", true);
            btnActualizar.Location = new Point(40, 27);
            btnActualizar.Click += btnActualizar_Click;

            footerPanel.Controls.Add(btnActualizar);
            footerPanel.Controls.Add(btnCancelar);

            // Agregar paneles principales al formulario
            this.Controls.Add(contentPanel);
            this.Controls.Add(footerPanel);
            this.Controls.Add(headerPanel);
        }

        // ========== MÉTODOS PARA CREAR CONTROLES ESTILIZADOS ==========
        private Label CreateStyledLabel(string text, int yPos)
        {
            return new Label
            {
                Text = text,
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                ForeColor = accentGold,
                Location = new Point(40, yPos),
                AutoSize = true
            };
        }

        private TextBox CreateStyledTextBox(int yPos)
        {
            var txt = new TextBox
            {
                Location = new Point(40, yPos),
                Size = new Size(550, 40),
                Font = new Font("Segoe UI", 12),
                BackColor = secondaryDark,
                ForeColor = textLight,
                BorderStyle = BorderStyle.FixedSingle
            };

            txt.Enter += (s, e) => txt.BackColor = Color.FromArgb(40, 51, 69);
            txt.Leave += (s, e) => txt.BackColor = secondaryDark;

            return txt;
        }

        private ComboBox CreateStyledComboBox(int yPos)
        {
            var cmb = new ComboBox
            {
                Location = new Point(40, yPos),
                Size = new Size(550, 40),
                Font = new Font("Segoe UI", 12),
                BackColor = secondaryDark,
                ForeColor = textLight,
                FlatStyle = FlatStyle.Flat,
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            return cmb;
        }

        private Button CreateStyledButton(string text, bool isPrimary)
        {
            var btn = new Button
            {
                Text = text,
                Size = new Size(270, 48),
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand,
                BackColor = isPrimary ? accentGold : borderColor,
                ForeColor = isPrimary ? primaryDark : textLight
            };

            btn.FlatAppearance.BorderSize = 0;

            if (isPrimary)
            {
                btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(217, 119, 6);
                btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(180, 83, 9);
            }
            else
            {
                btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, 116, 139);
                btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(51, 65, 85);
            }

            return btn;
        }

        // ========== APLICAR DISEÑO PERSONALIZADO (Bordes y Arrastre) ==========
        private void ApplyCustomDesign()
        {
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            headerPanel.MouseDown += HeaderPanel_MouseDown;
            titleLabel.MouseDown += HeaderPanel_MouseDown;
        }

        // ========== PERMITIR ARRASTRAR EL FORMULARIO (Lógica de Movimiento) ==========
        private Point mousePoint;
        private void HeaderPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
            this.MouseMove += Form_MouseMove;
            this.MouseUp += Form_MouseUp;
        }
        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - mousePoint.X;
                this.Top += e.Y - mousePoint.Y;
            }
        }
        private void Form_MouseUp(object sender, MouseEventArgs e)
        {
            this.MouseMove -= Form_MouseMove;
            this.MouseUp -= Form_MouseUp;
        }

        // ========== FUNCIÓN EXTERNA PARA REDONDEAR ESQUINAS (Necesita System.Runtime.InteropServices) ==========
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
            int nWidthEllipse, int nHeightEllipse);

        // ========== CÓDIGO VIEJO DE DISEÑADOR (SIN USAR) ==========
        // Los siguientes métodos fueron eliminados de la lógica final para evitar conflictos

        private void InitializeComponent() { /* Mínima definición para evitar error de compilación */ }
        private void FrmEditarTicket_Load(object sender, EventArgs e) { /* Dejar vacío */ }

        // ========== EFECTO DE SOMBRA ==========
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }
    }
}