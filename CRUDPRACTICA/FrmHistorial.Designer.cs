namespace CapaPresentacion
{
    partial class FrmHistorial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHistorial));
            dgvTickets = new DataGridView();
            Btn_guardar = new Button();
            Btn_editar = new Button();
            Btn_eliminar = new Button();
            pictureBox5 = new PictureBox();
            Btn_Minimizar = new PictureBox();
            Btn_Cerrar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvTickets).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Btn_Minimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Btn_Cerrar).BeginInit();
            SuspendLayout();
            // 
            // dgvTickets
            // 
            dgvTickets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTickets.Location = new Point(230, 96);
            dgvTickets.Margin = new Padding(3, 4, 3, 4);
            dgvTickets.Name = "dgvTickets";
            dgvTickets.ReadOnly = true;
            dgvTickets.RowHeadersWidth = 51;
            dgvTickets.Size = new Size(854, 524);
            dgvTickets.TabIndex = 0;
            dgvTickets.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Btn_guardar
            // 
            Btn_guardar.BackColor = SystemColors.ControlLightLight;
            Btn_guardar.FlatAppearance.BorderSize = 0;
            Btn_guardar.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            Btn_guardar.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            Btn_guardar.FlatStyle = FlatStyle.Flat;
            Btn_guardar.Font = new Font("Segoe MDL2 Assets", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_guardar.ForeColor = SystemColors.ActiveCaptionText;
            Btn_guardar.Location = new Point(374, 646);
            Btn_guardar.Margin = new Padding(3, 4, 3, 4);
            Btn_guardar.Name = "Btn_guardar";
            Btn_guardar.Size = new Size(93, 44);
            Btn_guardar.TabIndex = 11;
            Btn_guardar.Text = "Actualizar";
            Btn_guardar.UseVisualStyleBackColor = false;
            Btn_guardar.Click += Btn_guardar_Click;
            // 
            // Btn_editar
            // 
            Btn_editar.BackColor = SystemColors.ControlLightLight;
            Btn_editar.FlatAppearance.BorderSize = 0;
            Btn_editar.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            Btn_editar.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            Btn_editar.FlatStyle = FlatStyle.Popup;
            Btn_editar.Font = new Font("Segoe MDL2 Assets", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_editar.ForeColor = SystemColors.ActiveCaptionText;
            Btn_editar.Location = new Point(581, 646);
            Btn_editar.Margin = new Padding(3, 4, 3, 4);
            Btn_editar.Name = "Btn_editar";
            Btn_editar.Size = new Size(86, 44);
            Btn_editar.TabIndex = 12;
            Btn_editar.Text = "Editar";
            Btn_editar.UseVisualStyleBackColor = false;
            Btn_editar.Click += Btn_editar_Click;
            // 
            // Btn_eliminar
            // 
            Btn_eliminar.BackColor = SystemColors.ControlLightLight;
            Btn_eliminar.FlatAppearance.BorderSize = 0;
            Btn_eliminar.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            Btn_eliminar.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            Btn_eliminar.FlatStyle = FlatStyle.Flat;
            Btn_eliminar.Font = new Font("Segoe MDL2 Assets", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_eliminar.ForeColor = SystemColors.ActiveCaptionText;
            Btn_eliminar.Location = new Point(775, 646);
            Btn_eliminar.Margin = new Padding(3, 4, 3, 4);
            Btn_eliminar.Name = "Btn_eliminar";
            Btn_eliminar.Size = new Size(86, 44);
            Btn_eliminar.TabIndex = 13;
            Btn_eliminar.Text = "Eliminar";
            Btn_eliminar.UseVisualStyleBackColor = false;
            Btn_eliminar.Click += Btn_eliminar_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Black;
            pictureBox5.Cursor = Cursors.Hand;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(647, 13);
            pictureBox5.Margin = new Padding(3, 4, 3, 4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(67, 62);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 26;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // Btn_Minimizar
            // 
            Btn_Minimizar.BackColor = Color.Black;
            Btn_Minimizar.Cursor = Cursors.Hand;
            Btn_Minimizar.Image = (Image)resources.GetObject("Btn_Minimizar.Image");
            Btn_Minimizar.Location = new Point(1134, 13);
            Btn_Minimizar.Margin = new Padding(3, 4, 3, 4);
            Btn_Minimizar.Name = "Btn_Minimizar";
            Btn_Minimizar.Size = new Size(43, 39);
            Btn_Minimizar.SizeMode = PictureBoxSizeMode.Zoom;
            Btn_Minimizar.TabIndex = 27;
            Btn_Minimizar.TabStop = false;
            Btn_Minimizar.Click += Btn_Minimizar_Click;
            // 
            // Btn_Cerrar
            // 
            Btn_Cerrar.BackColor = Color.Black;
            Btn_Cerrar.Cursor = Cursors.Hand;
            Btn_Cerrar.Image = (Image)resources.GetObject("Btn_Cerrar.Image");
            Btn_Cerrar.Location = new Point(1213, 13);
            Btn_Cerrar.Margin = new Padding(3, 4, 3, 4);
            Btn_Cerrar.Name = "Btn_Cerrar";
            Btn_Cerrar.Size = new Size(31, 39);
            Btn_Cerrar.SizeMode = PictureBoxSizeMode.Zoom;
            Btn_Cerrar.TabIndex = 28;
            Btn_Cerrar.TabStop = false;
            Btn_Cerrar.Click += Btn_Cerrar_Click;
            // 
            // FrmHistorial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._1ba1c588_e19d_4ac0_88d0_1388c0d79770;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1304, 794);
            Controls.Add(Btn_Cerrar);
            Controls.Add(Btn_Minimizar);
            Controls.Add(pictureBox5);
            Controls.Add(Btn_eliminar);
            Controls.Add(Btn_editar);
            Controls.Add(Btn_guardar);
            Controls.Add(dgvTickets);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmHistorial";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VENTAS";
            Load += FrmHistorial_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTickets).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)Btn_Minimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)Btn_Cerrar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvTickets;
        private TextBox textBox4;
        private Button Btn_guardar;
        private Button Btn_editar;
        private Button Btn_eliminar;
        private PictureBox pictureBox5;
        private PictureBox Btn_Minimizar;
        private PictureBox Btn_Cerrar;
    }
}