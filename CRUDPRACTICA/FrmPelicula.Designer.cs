namespace CapaPresentacion
{
    partial class FrmPelicula
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            Btn_Cancelar1 = new Button();
            Btn_Boletos1 = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            pictureBox2 = new PictureBox();
            rtxtSinopsis = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(49, 282);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(233, 332);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightSlateGray;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Century", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(323, 282);
            label1.Name = "label1";
            label1.Size = new Size(104, 35);
            label1.TabIndex = 1;
            label1.Text = "DATO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightSlateGray;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Century", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(323, 349);
            label2.Name = "label2";
            label2.Size = new Size(104, 35);
            label2.TabIndex = 2;
            label2.Text = "DATO";
            // 
            // Btn_Cancelar1
            // 
            Btn_Cancelar1.BackColor = Color.Firebrick;
            Btn_Cancelar1.Cursor = Cursors.Hand;
            Btn_Cancelar1.FlatAppearance.BorderSize = 0;
            Btn_Cancelar1.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            Btn_Cancelar1.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            Btn_Cancelar1.FlatStyle = FlatStyle.Flat;
            Btn_Cancelar1.Font = new Font("Segoe Fluent Icons", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_Cancelar1.ForeColor = Color.White;
            Btn_Cancelar1.Location = new Point(371, 715);
            Btn_Cancelar1.Margin = new Padding(3, 4, 3, 4);
            Btn_Cancelar1.Name = "Btn_Cancelar1";
            Btn_Cancelar1.Size = new Size(125, 49);
            Btn_Cancelar1.TabIndex = 4;
            Btn_Cancelar1.Text = "ATRAS";
            Btn_Cancelar1.UseVisualStyleBackColor = false;
            Btn_Cancelar1.Click += Btn_Cancelar1_Click_1;
            // 
            // Btn_Boletos1
            // 
            Btn_Boletos1.BackColor = Color.DarkOliveGreen;
            Btn_Boletos1.Cursor = Cursors.Hand;
            Btn_Boletos1.FlatAppearance.BorderSize = 0;
            Btn_Boletos1.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 255, 128);
            Btn_Boletos1.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 128);
            Btn_Boletos1.FlatStyle = FlatStyle.Flat;
            Btn_Boletos1.Font = new Font("Segoe Fluent Icons", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_Boletos1.ForeColor = SystemColors.ButtonHighlight;
            Btn_Boletos1.Location = new Point(548, 715);
            Btn_Boletos1.Margin = new Padding(3, 4, 3, 4);
            Btn_Boletos1.Name = "Btn_Boletos1";
            Btn_Boletos1.Size = new Size(150, 49);
            Btn_Boletos1.TabIndex = 5;
            Btn_Boletos1.Text = "COMPRAR";
            Btn_Boletos1.UseVisualStyleBackColor = false;
            Btn_Boletos1.Click += Btn_Boletos1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.LightSlateGray;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Font = new Font("Century", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(323, 414);
            label4.Name = "label4";
            label4.Size = new Size(104, 35);
            label4.TabIndex = 6;
            label4.Text = "DATO";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.LightSlateGray;
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Font = new Font("Century", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.ImageAlign = ContentAlignment.TopCenter;
            label5.Location = new Point(49, 196);
            label5.Name = "label5";
            label5.Size = new Size(399, 37);
            label5.TabIndex = 7;
            label5.Text = "NOMBRE DE PELICULA";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.LightSlateGray;
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.Font = new Font("Century", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(685, 142);
            label6.Name = "label6";
            label6.Size = new Size(104, 35);
            label6.TabIndex = 8;
            label6.Text = "DATO";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.LOGO;
            pictureBox2.Location = new Point(30, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(201, 146);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // rtxtSinopsis
            // 
            rtxtSinopsis.BackColor = Color.LightSlateGray;
            rtxtSinopsis.BorderStyle = BorderStyle.FixedSingle;
            rtxtSinopsis.Font = new Font("Century", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtxtSinopsis.ForeColor = Color.Black;
            rtxtSinopsis.Location = new Point(330, 473);
            rtxtSinopsis.Name = "rtxtSinopsis";
            rtxtSinopsis.Size = new Size(637, 194);
            rtxtSinopsis.TabIndex = 10;
            rtxtSinopsis.Text = "";
            rtxtSinopsis.TextChanged += rtxtSinopsis_TextChanged;
            // 
            // FrmPelicula
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.Captura_de_pantalla_2025_12_07_230626;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1032, 809);
            Controls.Add(rtxtSinopsis);
            Controls.Add(pictureBox2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(Btn_Boletos1);
            Controls.Add(Btn_Cancelar1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmPelicula";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Pelicula1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Button Btn_Cancelar1;
        private Button Btn_Boletos1;
        private Label label4;
        private Label label5;
        private Label label6;
        private PictureBox pictureBox2;
        private RichTextBox rtxtSinopsis;
    }
}