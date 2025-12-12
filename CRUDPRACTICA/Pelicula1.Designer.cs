namespace CapaPresentacion
{
    partial class Pelicula1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pelicula1));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Btn_Cancelar1 = new Button();
            Btn_Boletos1 = new Button();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(26, 162);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(159, 270);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe Fluent Icons", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(191, 191);
            label1.Name = "label1";
            label1.Size = new Size(527, 21);
            label1.TabIndex = 1;
            label1.Text = "Géneros: Cine de terror, Thriller, Comedia cinematográfica, Drama";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe Fluent Icons", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(191, 238);
            label2.Name = "label2";
            label2.Size = new Size(155, 21);
            label2.TabIndex = 2;
            label2.Text = "Duración: 2 H 1 M";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe Fluent Icons", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(191, 327);
            label3.Name = "label3";
            label3.Size = new Size(691, 48);
            label3.TabIndex = 3;
            label3.Text = resources.GetString("label3.Text");
            // 
            // Btn_Cancelar1
            // 
            Btn_Cancelar1.BackColor = Color.Red;
            Btn_Cancelar1.Cursor = Cursors.Hand;
            Btn_Cancelar1.FlatAppearance.BorderSize = 0;
            Btn_Cancelar1.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            Btn_Cancelar1.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            Btn_Cancelar1.FlatStyle = FlatStyle.Flat;
            Btn_Cancelar1.Font = new Font("Segoe Fluent Icons", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_Cancelar1.ForeColor = Color.White;
            Btn_Cancelar1.Location = new Point(131, 487);
            Btn_Cancelar1.Name = "Btn_Cancelar1";
            Btn_Cancelar1.Size = new Size(98, 56);
            Btn_Cancelar1.TabIndex = 4;
            Btn_Cancelar1.Text = "Cancelar";
            Btn_Cancelar1.UseVisualStyleBackColor = false;
            Btn_Cancelar1.Click += button1_Click;
            // 
            // Btn_Boletos1
            // 
            Btn_Boletos1.BackColor = Color.Lime;
            Btn_Boletos1.Cursor = Cursors.Hand;
            Btn_Boletos1.FlatAppearance.BorderSize = 0;
            Btn_Boletos1.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 255, 128);
            Btn_Boletos1.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 128);
            Btn_Boletos1.FlatStyle = FlatStyle.Flat;
            Btn_Boletos1.Font = new Font("Segoe Fluent Icons", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_Boletos1.ForeColor = SystemColors.ButtonHighlight;
            Btn_Boletos1.Location = new Point(690, 487);
            Btn_Boletos1.Name = "Btn_Boletos1";
            Btn_Boletos1.Size = new Size(98, 56);
            Btn_Boletos1.TabIndex = 5;
            Btn_Boletos1.Text = "Comprar boletos";
            Btn_Boletos1.UseVisualStyleBackColor = false;
            Btn_Boletos1.Click += Btn_Boletos1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe Fluent Icons", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(191, 280);
            label4.Name = "label4";
            label4.Size = new Size(323, 21);
            label4.TabIndex = 6;
            label4.Text = "Fecha de estreno: 22 de marzo de 2019";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe Fluent Icons", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(87, 133);
            label5.Name = "label5";
            label5.Size = new Size(34, 24);
            label5.TabIndex = 7;
            label5.Text = "Us";
            // 
            // Pelicula1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(903, 567);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(Btn_Boletos1);
            Controls.Add(Btn_Cancelar1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Pelicula1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Pelicula1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button Btn_Cancelar1;
        private Button Btn_Boletos1;
        private Label label4;
        private Label label5;
    }
}