namespace CapaPresentacion
{
    partial class Pelicula3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pelicula3));
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            Btn_Cancelar3 = new Button();
            Btn_Boletos3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe Fluent Icons", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(12, 135);
            label5.Name = "label5";
            label5.Size = new Size(238, 19);
            label5.TabIndex = 20;
            label5.Text = "Guardianes de la galaxia vol.2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe Fluent Icons", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(216, 287);
            label4.Name = "label4";
            label4.Size = new Size(332, 24);
            label4.TabIndex = 19;
            label4.Text = "Fecha de estreno: 5 mayo de 2017";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe Fluent Icons", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(216, 344);
            label3.Name = "label3";
            label3.Size = new Size(657, 76);
            label3.TabIndex = 18;
            label3.Text = resources.GetString("label3.Text");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe Fluent Icons", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(216, 230);
            label2.Name = "label2";
            label2.Size = new Size(190, 24);
            label2.TabIndex = 17;
            label2.Text = "Duración: 2 H 17 M";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe Fluent Icons", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(216, 177);
            label1.Name = "label1";
            label1.Size = new Size(545, 24);
            label1.TabIndex = 16;
            label1.Text = "Géneros: Ciencia fictición, Acción, Telerrealidad, Aventura\r\n";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(42, 167);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(159, 270);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // Btn_Cancelar3
            // 
            Btn_Cancelar3.BackColor = Color.Red;
            Btn_Cancelar3.Cursor = Cursors.Hand;
            Btn_Cancelar3.FlatAppearance.BorderSize = 0;
            Btn_Cancelar3.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            Btn_Cancelar3.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            Btn_Cancelar3.FlatStyle = FlatStyle.Flat;
            Btn_Cancelar3.Font = new Font("Segoe Fluent Icons", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_Cancelar3.ForeColor = Color.White;
            Btn_Cancelar3.Location = new Point(89, 488);
            Btn_Cancelar3.Name = "Btn_Cancelar3";
            Btn_Cancelar3.Size = new Size(105, 55);
            Btn_Cancelar3.TabIndex = 22;
            Btn_Cancelar3.Text = "Cancelar";
            Btn_Cancelar3.UseVisualStyleBackColor = false;
            Btn_Cancelar3.Click += Btn_Cancelar3_Click;
            // 
            // Btn_Boletos3
            // 
            Btn_Boletos3.BackColor = Color.Lime;
            Btn_Boletos3.Cursor = Cursors.Hand;
            Btn_Boletos3.FlatAppearance.BorderSize = 0;
            Btn_Boletos3.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 255, 128);
            Btn_Boletos3.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 128);
            Btn_Boletos3.FlatStyle = FlatStyle.Flat;
            Btn_Boletos3.Font = new Font("Segoe Fluent Icons", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_Boletos3.ForeColor = SystemColors.ButtonHighlight;
            Btn_Boletos3.Location = new Point(661, 488);
            Btn_Boletos3.Name = "Btn_Boletos3";
            Btn_Boletos3.Size = new Size(100, 55);
            Btn_Boletos3.TabIndex = 21;
            Btn_Boletos3.Text = "Comprar boletos";
            Btn_Boletos3.UseVisualStyleBackColor = false;
            Btn_Boletos3.Click += Btn_Boletos3_Click;
            // 
            // Pelicula3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(903, 567);
            Controls.Add(Btn_Cancelar3);
            Controls.Add(Btn_Boletos3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Pelicula3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pelicula3";
            Load += Pelicula3_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Button Btn_Cancelar3;
        private Button Btn_Boletos3;
    }
}