namespace CapaPresentacion
{
    partial class CargarPelicula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CargarPelicula));
            label3 = new Label();
            pictureBox3 = new PictureBox();
            label5 = new Label();
            txtSinopsis = new TextBox();
            label4 = new Label();
            txtDuracion = new TextBox();
            label2 = new Label();
            txtGenero = new TextBox();
            label1 = new Label();
            txtTitulo = new TextBox();
            label6 = new Label();
            dtpFecha = new DateTimePicker();
            dgvPeliculas = new DataGridView();
            pbPoster = new PictureBox();
            btnNuevo = new Button();
            btnCancela = new Button();
            label7 = new Label();
            btnQuitarImagen = new Button();
            btnSubirImagen = new Button();
            btnEditar = new Button();
            btnGuardar = new Button();
            btnEliminar = new Button();
            txtRatings = new Label();
            txtClasificacion = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPeliculas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPoster).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe Fluent Icons", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.ImageAlign = ContentAlignment.TopCenter;
            label3.Location = new Point(91, 9);
            label3.Name = "label3";
            label3.Size = new Size(121, 32);
            label3.TabIndex = 19;
            label3.Text = "Peliculas";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(11, 9);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(64, 32);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 20;
            pictureBox3.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe Fluent Icons", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(13, 322);
            label5.Name = "label5";
            label5.Size = new Size(125, 27);
            label5.TabIndex = 36;
            label5.Text = "Descripcion";
            // 
            // txtSinopsis
            // 
            txtSinopsis.Location = new Point(16, 362);
            txtSinopsis.Multiline = true;
            txtSinopsis.Name = "txtSinopsis";
            txtSinopsis.Size = new Size(222, 112);
            txtSinopsis.TabIndex = 35;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe Fluent Icons", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(13, 228);
            label4.Name = "label4";
            label4.Size = new Size(98, 27);
            label4.TabIndex = 34;
            label4.Text = "Duracion";
            // 
            // txtDuracion
            // 
            txtDuracion.Location = new Point(117, 232);
            txtDuracion.Name = "txtDuracion";
            txtDuracion.Size = new Size(121, 23);
            txtDuracion.TabIndex = 33;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe Fluent Icons", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(13, 176);
            label2.Name = "label2";
            label2.Size = new Size(83, 27);
            label2.TabIndex = 32;
            label2.Text = "Genero";
            // 
            // txtGenero
            // 
            txtGenero.Location = new Point(102, 180);
            txtGenero.Name = "txtGenero";
            txtGenero.Size = new Size(136, 23);
            txtGenero.TabIndex = 31;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe Fluent Icons", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(13, 125);
            label1.Name = "label1";
            label1.Size = new Size(66, 27);
            label1.TabIndex = 30;
            label1.Text = "Titulo";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(85, 129);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(153, 23);
            txtTitulo.TabIndex = 29;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe Fluent Icons", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(13, 477);
            label6.Name = "label6";
            label6.Size = new Size(72, 27);
            label6.TabIndex = 38;
            label6.Text = "Fecha";
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(91, 486);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(147, 23);
            dtpFecha.TabIndex = 39;
            // 
            // dgvPeliculas
            // 
            dgvPeliculas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPeliculas.Location = new Point(292, 243);
            dgvPeliculas.Name = "dgvPeliculas";
            dgvPeliculas.Size = new Size(367, 224);
            dgvPeliculas.TabIndex = 40;
            // 
            // pbPoster
            // 
            pbPoster.Location = new Point(292, 52);
            pbPoster.Name = "pbPoster";
            pbPoster.Size = new Size(145, 175);
            pbPoster.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPoster.TabIndex = 41;
            pbPoster.TabStop = false;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.YellowGreen;
            btnNuevo.FlatAppearance.BorderSize = 0;
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.Font = new Font("Segoe Fluent Icons", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevo.ForeColor = Color.White;
            btnNuevo.Location = new Point(11, 63);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(81, 37);
            btnNuevo.TabIndex = 42;
            btnNuevo.Text = "Habilitar";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnCancela
            // 
            btnCancela.BackColor = Color.IndianRed;
            btnCancela.FlatAppearance.BorderSize = 0;
            btnCancela.FlatStyle = FlatStyle.Flat;
            btnCancela.Font = new Font("Segoe Fluent Icons", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancela.ForeColor = SystemColors.ButtonFace;
            btnCancela.Location = new Point(113, 63);
            btnCancela.Name = "btnCancela";
            btnCancela.Size = new Size(87, 37);
            btnCancela.TabIndex = 43;
            btnCancela.Text = "Desactivar";
            btnCancela.UseVisualStyleBackColor = false;
            btnCancela.Click += btnCancela_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe Fluent Icons", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(292, 14);
            label7.Name = "label7";
            label7.Size = new Size(87, 27);
            label7.TabIndex = 44;
            label7.Text = "Portada";
            // 
            // btnQuitarImagen
            // 
            btnQuitarImagen.BackColor = Color.Gray;
            btnQuitarImagen.FlatAppearance.BorderSize = 0;
            btnQuitarImagen.FlatStyle = FlatStyle.Flat;
            btnQuitarImagen.Font = new Font("Segoe Fluent Icons", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQuitarImagen.ForeColor = SystemColors.ButtonFace;
            btnQuitarImagen.Location = new Point(458, 112);
            btnQuitarImagen.Name = "btnQuitarImagen";
            btnQuitarImagen.Size = new Size(144, 37);
            btnQuitarImagen.TabIndex = 46;
            btnQuitarImagen.Text = "Quitar Imagen";
            btnQuitarImagen.UseVisualStyleBackColor = false;
            btnQuitarImagen.Click += btnQuitarImagen_Click;
            // 
            // btnSubirImagen
            // 
            btnSubirImagen.BackColor = Color.OliveDrab;
            btnSubirImagen.FlatAppearance.BorderSize = 0;
            btnSubirImagen.FlatStyle = FlatStyle.Flat;
            btnSubirImagen.Font = new Font("Segoe Fluent Icons", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubirImagen.ForeColor = Color.White;
            btnSubirImagen.Location = new Point(458, 52);
            btnSubirImagen.Name = "btnSubirImagen";
            btnSubirImagen.Size = new Size(144, 37);
            btnSubirImagen.TabIndex = 45;
            btnSubirImagen.Text = "Subir Imagen";
            btnSubirImagen.UseVisualStyleBackColor = false;
            btnSubirImagen.Click += btnSubirImagen_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.SlateGray;
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Segoe Fluent Icons", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.ForeColor = SystemColors.ButtonFace;
            btnEditar.Location = new Point(433, 478);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(87, 37);
            btnEditar.TabIndex = 48;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.SlateGray;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe Fluent Icons", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(293, 478);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(81, 37);
            btnGuardar.TabIndex = 47;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.SlateGray;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe Fluent Icons", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = SystemColors.ButtonFace;
            btnEliminar.Location = new Point(572, 478);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(87, 37);
            btnEliminar.TabIndex = 49;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtRatings
            // 
            txtRatings.AutoSize = true;
            txtRatings.BackColor = Color.Transparent;
            txtRatings.Font = new Font("Segoe Fluent Icons", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtRatings.ForeColor = SystemColors.ControlLightLight;
            txtRatings.Location = new Point(13, 276);
            txtRatings.Name = "txtRatings";
            txtRatings.Size = new Size(84, 27);
            txtRatings.TabIndex = 51;
            txtRatings.Text = "Ratings";
            // 
            // txtClasificacion
            // 
            txtClasificacion.Location = new Point(103, 280);
            txtClasificacion.Name = "txtClasificacion";
            txtClasificacion.Size = new Size(135, 23);
            txtClasificacion.TabIndex = 50;
            // 
            // CargarPelicula
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(671, 521);
            Controls.Add(txtRatings);
            Controls.Add(txtClasificacion);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnGuardar);
            Controls.Add(btnQuitarImagen);
            Controls.Add(btnSubirImagen);
            Controls.Add(label7);
            Controls.Add(btnCancela);
            Controls.Add(btnNuevo);
            Controls.Add(pbPoster);
            Controls.Add(dgvPeliculas);
            Controls.Add(dtpFecha);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtSinopsis);
            Controls.Add(label4);
            Controls.Add(txtDuracion);
            Controls.Add(label2);
            Controls.Add(txtGenero);
            Controls.Add(label1);
            Controls.Add(txtTitulo);
            Controls.Add(label3);
            Controls.Add(pictureBox3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CargarPelicula";
            Text = "CargarPeliculas";
            Load += CargarPeliculas_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPeliculas).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPoster).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private PictureBox pictureBox3;
        private Label label5;
        private TextBox txtSinopsis;
        private Label label4;
        private TextBox txtDuracion;
        private Label label2;
        private TextBox txtGenero;
        private Label label1;
        private TextBox txtTitulo;
        private Label label6;
        private DateTimePicker dtpFecha;
        private DataGridView dgvPeliculas;
        private PictureBox pbPoster;
        private Button btnNuevo;
        private Button btnCancela;
        private Label label7;
        private Button btnQuitarImagen;
        private Button btnSubirImagen;
        private Button btnEditar;
        private Button btnGuardar;
        private Button btnEliminar;
        private Label txtRatings;
        private TextBox txtClasificacion;
    }
}