namespace CapaPresentacion
{
    partial class Pelicula4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pelicula4));
            Btn_Cancelar4 = new Button();
            Btn_Boletos4 = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Btn_Cancelar4
            // 
            Btn_Cancelar4.BackColor = Color.Red;
            Btn_Cancelar4.Cursor = Cursors.Hand;
            Btn_Cancelar4.FlatAppearance.BorderSize = 0;
            Btn_Cancelar4.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            Btn_Cancelar4.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            Btn_Cancelar4.FlatStyle = FlatStyle.Flat;
            Btn_Cancelar4.Font = new Font("Segoe Fluent Icons", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_Cancelar4.ForeColor = Color.White;
            Btn_Cancelar4.Location = new Point(130, 485);
            Btn_Cancelar4.Name = "Btn_Cancelar4";
            Btn_Cancelar4.Size = new Size(93, 58);
            Btn_Cancelar4.TabIndex = 30;
            Btn_Cancelar4.Text = "Cancelar";
            Btn_Cancelar4.UseVisualStyleBackColor = false;
            Btn_Cancelar4.Click += Btn_Cancelar4_Click;
            // 
            // Btn_Boletos4
            // 
            Btn_Boletos4.BackColor = Color.Lime;
            Btn_Boletos4.Cursor = Cursors.Hand;
            Btn_Boletos4.FlatAppearance.BorderSize = 0;
            Btn_Boletos4.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 255, 128);
            Btn_Boletos4.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 128);
            Btn_Boletos4.FlatStyle = FlatStyle.Flat;
            Btn_Boletos4.Font = new Font("Segoe Fluent Icons", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_Boletos4.ForeColor = SystemColors.ButtonHighlight;
            Btn_Boletos4.Location = new Point(622, 485);
            Btn_Boletos4.Name = "Btn_Boletos4";
            Btn_Boletos4.Size = new Size(100, 58);
            Btn_Boletos4.TabIndex = 29;
            Btn_Boletos4.Text = "Comprar boletos";
            Btn_Boletos4.UseVisualStyleBackColor = false;
            Btn_Boletos4.Click += Btn_Boletos4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe Fluent Icons", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(29, 144);
            label5.Name = "label5";
            label5.Size = new Size(194, 19);
            label5.TabIndex = 28;
            label5.Text = "Chainsaw Man: Reze Arc";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe Fluent Icons", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(231, 280);
            label4.Name = "label4";
            label4.Size = new Size(424, 24);
            label4.TabIndex = 27;
            label4.Text = "Fecha de estreno: 19 de septiembre de 2025";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe Fluent Icons", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(231, 326);
            label3.Name = "label3";
            label3.Size = new Size(635, 84);
            label3.TabIndex = 26;
            label3.Text = resources.GetString("label3.Text");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe Fluent Icons", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(231, 235);
            label2.Name = "label2";
            label2.Size = new Size(190, 24);
            label2.TabIndex = 25;
            label2.Text = "Duración: 1 H 40 M";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe Fluent Icons", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(231, 185);
            label1.Name = "label1";
            label1.Size = new Size(319, 24);
            label1.TabIndex = 24;
            label1.Text = "Géneros: Terror, Aventura, Anime\r\n";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(29, 176);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(173, 270);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // Pelicula4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(903, 567);
            Controls.Add(Btn_Cancelar4);
            Controls.Add(Btn_Boletos4);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Pelicula4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pelicula4";
            Load += Pelicula4_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Btn_Cancelar4;
        private Button Btn_Boletos4;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
    }
}