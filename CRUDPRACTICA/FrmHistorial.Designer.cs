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
            dataGridView1 = new DataGridView();
            Btn_guardar = new Button();
            Btn_editar = new Button();
            Btn_eliminar = new Button();
            pictureBox5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(274, 88);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(546, 348);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Btn_guardar
            // 
            Btn_guardar.BackColor = SystemColors.InfoText;
            Btn_guardar.FlatAppearance.BorderSize = 0;
            Btn_guardar.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            Btn_guardar.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            Btn_guardar.FlatStyle = FlatStyle.Flat;
            Btn_guardar.Font = new Font("Segoe MDL2 Assets", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_guardar.ForeColor = SystemColors.ControlLightLight;
            Btn_guardar.Location = new Point(302, 460);
            Btn_guardar.Margin = new Padding(3, 4, 3, 4);
            Btn_guardar.Name = "Btn_guardar";
            Btn_guardar.Size = new Size(86, 44);
            Btn_guardar.TabIndex = 11;
            Btn_guardar.Text = "Guardar";
            Btn_guardar.UseVisualStyleBackColor = false;
            Btn_guardar.Click += Btn_guardar_Click;
            // 
            // Btn_editar
            // 
            Btn_editar.BackColor = SystemColors.InfoText;
            Btn_editar.FlatAppearance.BorderSize = 0;
            Btn_editar.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            Btn_editar.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            Btn_editar.FlatStyle = FlatStyle.Flat;
            Btn_editar.Font = new Font("Segoe MDL2 Assets", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_editar.ForeColor = SystemColors.ControlLightLight;
            Btn_editar.Location = new Point(497, 460);
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
            Btn_eliminar.BackColor = SystemColors.InfoText;
            Btn_eliminar.FlatAppearance.BorderSize = 0;
            Btn_eliminar.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            Btn_eliminar.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            Btn_eliminar.FlatStyle = FlatStyle.Flat;
            Btn_eliminar.Font = new Font("Segoe MDL2 Assets", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_eliminar.ForeColor = SystemColors.ControlLightLight;
            Btn_eliminar.Location = new Point(685, 460);
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
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Cursor = Cursors.Hand;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(892, 13);
            pictureBox5.Margin = new Padding(3, 4, 3, 4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(47, 57);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 26;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // FrmHistorial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1030, 557);
            Controls.Add(pictureBox5);
            Controls.Add(Btn_eliminar);
            Controls.Add(Btn_editar);
            Controls.Add(Btn_guardar);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmHistorial";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmHistorial";
            Load += FrmHistorial_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBox4;
        private Button Btn_guardar;
        private Button Btn_editar;
        private Button Btn_eliminar;
        private PictureBox pictureBox5;
    }
}