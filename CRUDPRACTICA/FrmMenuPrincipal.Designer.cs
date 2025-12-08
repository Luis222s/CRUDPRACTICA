namespace CapaPresentacion
{
    partial class FrmMenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnHistorialCompleto = new Button();
            button1 = new Button();
            btnMantenimiento = new Button();
            btnSalir = new Button();
            btnReportes = new Button();
            pictureBox1 = new PictureBox();
            btnCartelera = new Button();
            panelContenedor = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateBlue;
            panel1.BackgroundImage = Properties.Resources._130d7568_9401_4418_823c_abf331886b73;
            panel1.Controls.Add(btnHistorialCompleto);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnMantenimiento);
            panel1.Controls.Add(btnSalir);
            panel1.Controls.Add(btnReportes);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnCartelera);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(338, 932);
            panel1.TabIndex = 2;
            // 
            // btnHistorialCompleto
            // 
            btnHistorialCompleto.BackColor = Color.Black;
            btnHistorialCompleto.FlatAppearance.BorderColor = Color.White;
            btnHistorialCompleto.FlatAppearance.BorderSize = 2;
            btnHistorialCompleto.FlatStyle = FlatStyle.Flat;
            btnHistorialCompleto.Font = new Font("Century", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHistorialCompleto.ForeColor = Color.White;
            btnHistorialCompleto.Location = new Point(63, 464);
            btnHistorialCompleto.Name = "btnHistorialCompleto";
            btnHistorialCompleto.Size = new Size(192, 79);
            btnHistorialCompleto.TabIndex = 18;
            btnHistorialCompleto.Text = "Ventas Por Tickets";
            btnHistorialCompleto.UseVisualStyleBackColor = false;
            btnHistorialCompleto.Click += btnHistorialCompleto_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe Fluent Icons", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(103, 878);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(116, 32);
            button1.TabIndex = 17;
            button1.Text = "CREADORES";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnMantenimiento
            // 
            btnMantenimiento.BackColor = Color.Black;
            btnMantenimiento.FlatAppearance.BorderColor = Color.White;
            btnMantenimiento.FlatAppearance.BorderSize = 2;
            btnMantenimiento.FlatStyle = FlatStyle.Flat;
            btnMantenimiento.Font = new Font("Century", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMantenimiento.ForeColor = Color.White;
            btnMantenimiento.Location = new Point(63, 353);
            btnMantenimiento.Name = "btnMantenimiento";
            btnMantenimiento.Size = new Size(192, 70);
            btnMantenimiento.TabIndex = 4;
            btnMantenimiento.Text = "Peliculas";
            btnMantenimiento.UseVisualStyleBackColor = false;
            btnMantenimiento.Click += btnMantenimiento_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Black;
            btnSalir.FlatAppearance.BorderColor = Color.White;
            btnSalir.FlatAppearance.BorderSize = 2;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Century", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(63, 689);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(192, 70);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnReportes
            // 
            btnReportes.BackColor = Color.Black;
            btnReportes.FlatAppearance.BorderColor = Color.White;
            btnReportes.FlatAppearance.BorderSize = 2;
            btnReportes.FlatStyle = FlatStyle.Flat;
            btnReportes.Font = new Font("Century", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReportes.ForeColor = Color.White;
            btnReportes.Location = new Point(63, 575);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(192, 70);
            btnReportes.TabIndex = 2;
            btnReportes.Text = "Estadisticas";
            btnReportes.UseVisualStyleBackColor = false;
            btnReportes.Click += btnReportes_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.LOGO;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(346, 211);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnCartelera
            // 
            btnCartelera.BackColor = Color.Black;
            btnCartelera.FlatAppearance.BorderColor = Color.White;
            btnCartelera.FlatAppearance.BorderSize = 2;
            btnCartelera.FlatStyle = FlatStyle.Flat;
            btnCartelera.Font = new Font("Century", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCartelera.ForeColor = Color.White;
            btnCartelera.Location = new Point(63, 246);
            btnCartelera.Name = "btnCartelera";
            btnCartelera.Size = new Size(192, 70);
            btnCartelera.TabIndex = 0;
            btnCartelera.Text = "Cartelera";
            btnCartelera.UseVisualStyleBackColor = false;
            btnCartelera.Click += btnCartelera_Click;
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.Transparent;
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(338, 0);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1121, 932);
            panelContenedor.TabIndex = 3;
            panelContenedor.Paint += panelContenedor_Paint;
            // 
            // FrmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = Properties.Resources._945f4b41_4fb5_43ca_b716_a06d5cdf1514;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1459, 932);
            Controls.Add(panelContenedor);
            Controls.Add(panel1);
            Name = "FrmMenuPrincipal";
            Text = "Sistema de Cine CINELUX";
            WindowState = FormWindowState.Maximized;
            Load += FrmMenuPrincipal_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel panelContenedor;
        private Button btnCartelera;
        private PictureBox pictureBox1;
        private Button btnSalir;
        private Button btnReportes;
        private Button btnMantenimiento;
        private Button button1;
        private Button btnHistorialCompleto;
    }
}