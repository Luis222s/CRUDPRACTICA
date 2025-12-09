namespace CapaPresentacion
{
    partial class FrmMantPeliculas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMantPeliculas));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtTitulo = new TextBox();
            txtGenero = new TextBox();
            txtDuracion = new TextBox();
            txtClasificacion = new TextBox();
            txtSinopsis = new TextBox();
            dtpFecha = new DateTimePicker();
            btnNuevo = new Button();
            btnGuardar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            dgvPeliculas = new DataGridView();
            panel1 = new Panel();
            btnQuitarImagen = new Button();
            btnSubirImagen = new Button();
            pbPoster = new PictureBox();
            label5 = new Label();
            Btn_Cerrar = new PictureBox();
            Btn_Minimizar = new PictureBox();
            btnCancelar = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvPeliculas).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbPoster).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Btn_Cerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Btn_Minimizar).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(76, 16);
            label1.Name = "label1";
            label1.Size = new Size(71, 23);
            label1.TabIndex = 0;
            label1.Text = "Titulo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(64, 66);
            label2.Name = "label2";
            label2.Size = new Size(83, 23);
            label2.TabIndex = 1;
            label2.Text = "Genero";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(44, 111);
            label3.Name = "label3";
            label3.Size = new Size(103, 23);
            label3.TabIndex = 2;
            label3.Text = "Duracion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(11, 165);
            label4.Name = "label4";
            label4.Size = new Size(139, 23);
            label4.TabIndex = 3;
            label4.Text = "Clasificacion";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(53, 254);
            label6.Name = "label6";
            label6.Size = new Size(94, 23);
            label6.TabIndex = 5;
            label6.Text = "Sinopsis";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(81, 346);
            label7.Name = "label7";
            label7.Size = new Size(70, 23);
            label7.TabIndex = 6;
            label7.Text = "Fecha";
            // 
            // txtTitulo
            // 
            txtTitulo.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTitulo.Location = new Point(172, 14);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(250, 30);
            txtTitulo.TabIndex = 7;
            txtTitulo.TextChanged += txtTitulo_TextChanged;
            // 
            // txtGenero
            // 
            txtGenero.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGenero.Location = new Point(172, 63);
            txtGenero.Name = "txtGenero";
            txtGenero.Size = new Size(250, 30);
            txtGenero.TabIndex = 8;
            txtGenero.TextChanged += txtGenero_TextChanged;
            // 
            // txtDuracion
            // 
            txtDuracion.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDuracion.Location = new Point(172, 109);
            txtDuracion.Name = "txtDuracion";
            txtDuracion.Size = new Size(125, 30);
            txtDuracion.TabIndex = 9;
            txtDuracion.TextChanged += txtDuracion_TextChanged;
            // 
            // txtClasificacion
            // 
            txtClasificacion.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtClasificacion.Location = new Point(172, 163);
            txtClasificacion.Name = "txtClasificacion";
            txtClasificacion.Size = new Size(274, 30);
            txtClasificacion.TabIndex = 10;
            txtClasificacion.TextChanged += txtClasificacion_TextChanged;
            // 
            // txtSinopsis
            // 
            txtSinopsis.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSinopsis.Location = new Point(172, 215);
            txtSinopsis.Multiline = true;
            txtSinopsis.Name = "txtSinopsis";
            txtSinopsis.Size = new Size(274, 112);
            txtSinopsis.TabIndex = 12;
            txtSinopsis.TextChanged += txtSinopsis_TextChanged;
            // 
            // dtpFecha
            // 
            dtpFecha.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFecha.Location = new Point(172, 342);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(274, 30);
            dtpFecha.TabIndex = 13;
            dtpFecha.ValueChanged += dtpFecha_ValueChanged;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.FromArgb(128, 128, 255);
            btnNuevo.FlatAppearance.BorderSize = 0;
            btnNuevo.Location = new Point(86, 13);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(119, 58);
            btnNuevo.TabIndex = 14;
            btnNuevo.Text = "AGREGAR";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click_1;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Lime;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.ForeColor = Color.Black;
            btnGuardar.Location = new Point(26, 11);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(125, 59);
            btnGuardar.TabIndex = 15;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Yellow;
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.ForeColor = Color.Black;
            btnEditar.Location = new Point(177, 11);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(125, 59);
            btnEditar.TabIndex = 16;
            btnEditar.Text = "EDITAR";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click_1;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Red;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.ForeColor = Color.Black;
            btnEliminar.Location = new Point(332, 11);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(125, 59);
            btnEliminar.TabIndex = 17;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click_1;
            // 
            // dgvPeliculas
            // 
            dgvPeliculas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPeliculas.Location = new Point(576, 78);
            dgvPeliculas.Name = "dgvPeliculas";
            dgvPeliculas.RowHeadersWidth = 51;
            dgvPeliculas.Size = new Size(1001, 950);
            dgvPeliculas.TabIndex = 18;
            dgvPeliculas.CellContentClick += dgvPeliculas_CellContentClick;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.IMAGEN_DE_RESGISTRO;
            panel1.Controls.Add(btnQuitarImagen);
            panel1.Controls.Add(btnSubirImagen);
            panel1.Controls.Add(pbPoster);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(dtpFecha);
            panel1.Controls.Add(txtSinopsis);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtClasificacion);
            panel1.Controls.Add(txtTitulo);
            panel1.Controls.Add(txtDuracion);
            panel1.Controls.Add(txtGenero);
            panel1.Location = new Point(53, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(484, 854);
            panel1.TabIndex = 19;
            // 
            // btnQuitarImagen
            // 
            btnQuitarImagen.BackColor = Color.DarkGray;
            btnQuitarImagen.FlatAppearance.BorderSize = 0;
            btnQuitarImagen.Font = new Font("Century", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnQuitarImagen.Location = new Point(302, 633);
            btnQuitarImagen.Name = "btnQuitarImagen";
            btnQuitarImagen.Size = new Size(137, 61);
            btnQuitarImagen.TabIndex = 17;
            btnQuitarImagen.Text = "Quitar Imagen";
            btnQuitarImagen.UseVisualStyleBackColor = false;
            btnQuitarImagen.Click += btnQuitarImagen_Click;
            // 
            // btnSubirImagen
            // 
            btnSubirImagen.BackColor = Color.OliveDrab;
            btnSubirImagen.FlatAppearance.BorderSize = 0;
            btnSubirImagen.Font = new Font("Century", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSubirImagen.Location = new Point(309, 547);
            btnSubirImagen.Name = "btnSubirImagen";
            btnSubirImagen.Size = new Size(126, 61);
            btnSubirImagen.TabIndex = 16;
            btnSubirImagen.Text = "Subir Imagen";
            btnSubirImagen.UseVisualStyleBackColor = false;
            btnSubirImagen.Click += btnSubirImagen_Click;
            // 
            // pbPoster
            // 
            pbPoster.Location = new Point(26, 450);
            pbPoster.Name = "pbPoster";
            pbPoster.Size = new Size(233, 380);
            pbPoster.SizeMode = PictureBoxSizeMode.Zoom;
            pbPoster.TabIndex = 15;
            pbPoster.TabStop = false;
            pbPoster.Click += pbPoster_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(86, 415);
            label5.Name = "label5";
            label5.Size = new Size(90, 23);
            label5.TabIndex = 14;
            label5.Text = "Portada";
            // 
            // Btn_Cerrar
            // 
            Btn_Cerrar.BackColor = Color.Black;
            Btn_Cerrar.Cursor = Cursors.Hand;
            Btn_Cerrar.Image = (Image)resources.GetObject("Btn_Cerrar.Image");
            Btn_Cerrar.Location = new Point(1534, 9);
            Btn_Cerrar.Margin = new Padding(3, 4, 3, 4);
            Btn_Cerrar.Name = "Btn_Cerrar";
            Btn_Cerrar.Size = new Size(43, 39);
            Btn_Cerrar.SizeMode = PictureBoxSizeMode.Zoom;
            Btn_Cerrar.TabIndex = 31;
            Btn_Cerrar.TabStop = false;
            Btn_Cerrar.Click += Btn_Cerrar_Click;
            // 
            // Btn_Minimizar
            // 
            Btn_Minimizar.BackColor = Color.Black;
            Btn_Minimizar.Cursor = Cursors.Hand;
            Btn_Minimizar.Image = (Image)resources.GetObject("Btn_Minimizar.Image");
            Btn_Minimizar.Location = new Point(1467, 9);
            Btn_Minimizar.Margin = new Padding(3, 4, 3, 4);
            Btn_Minimizar.Name = "Btn_Minimizar";
            Btn_Minimizar.Size = new Size(43, 39);
            Btn_Minimizar.SizeMode = PictureBoxSizeMode.Zoom;
            Btn_Minimizar.TabIndex = 30;
            Btn_Minimizar.TabStop = false;
            Btn_Minimizar.Click += Btn_Minimizar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.LightGray;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.ForeColor = Color.Black;
            btnCancelar.Location = new Point(279, 13);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(119, 58);
            btnCancelar.TabIndex = 32;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click_1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(64, 64, 64);
            panel2.Controls.Add(btnCancelar);
            panel2.Controls.Add(btnNuevo);
            panel2.Location = new Point(53, 927);
            panel2.Name = "panel2";
            panel2.Size = new Size(484, 84);
            panel2.TabIndex = 34;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(64, 64, 64);
            panel3.Controls.Add(btnGuardar);
            panel3.Controls.Add(btnEditar);
            panel3.Controls.Add(btnEliminar);
            panel3.Location = new Point(53, 1033);
            panel3.Name = "panel3";
            panel3.Size = new Size(484, 84);
            panel3.TabIndex = 35;
            // 
            // FrmMantPeliculas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Captura_de_pantalla_2025_12_07_2005172;
            ClientSize = new Size(1615, 1136);
            Controls.Add(Btn_Cerrar);
            Controls.Add(Btn_Minimizar);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(dgvPeliculas);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmMantPeliculas";
            Text = "GESTIONAR PELICULAS";
            ((System.ComponentModel.ISupportInitialize)dgvPeliculas).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbPoster).EndInit();
            ((System.ComponentModel.ISupportInitialize)Btn_Cerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)Btn_Minimizar).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label7;
        private TextBox txtTitulo;
        private TextBox txtGenero;
        private TextBox txtDuracion;
        private TextBox txtClasificacion;
        private TextBox txtSinopsis;
        private DateTimePicker dtpFecha;
        private Button btnNuevo;
        private Button btnGuardar;
        private Button btnEditar;
        private Button btnEliminar;
        private DataGridView dgvPeliculas;
        private Panel panel1;
        private PictureBox Btn_Cerrar;
        private PictureBox Btn_Minimizar;
        private Button btnCancelar;
        private PictureBox pbPoster;
        private Label label5;
        private Button btnQuitarImagen;
        private Button btnSubirImagen;
        private Panel panel2;
        private Panel panel3;
    }
}