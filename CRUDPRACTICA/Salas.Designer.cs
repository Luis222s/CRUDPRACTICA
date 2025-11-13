namespace CapaPresentacion
{
    partial class Salas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Salas));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            panel5 = new Panel();
            label4 = new Label();
            Btn_Confirmar = new Button();
            label9 = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            comboBox = new ComboBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            pictureBox5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(65, 88);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(179, 180);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(324, 88);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(179, 180);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(65, 337);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(179, 180);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(324, 337);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(179, 180);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ControlLight;
            panel5.Controls.Add(label4);
            panel5.Controls.Add(Btn_Confirmar);
            panel5.Controls.Add(label9);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(label1);
            panel5.Location = new Point(678, 169);
            panel5.Name = "panel5";
            panel5.Size = new Size(228, 232);
            panel5.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe MDL2 Assets", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 61);
            label4.Name = "label4";
            label4.Size = new Size(61, 24);
            label4.TabIndex = 9;
            label4.Text = "Lugar:";
            // 
            // Btn_Confirmar
            // 
            Btn_Confirmar.BackColor = Color.IndianRed;
            Btn_Confirmar.Cursor = Cursors.Hand;
            Btn_Confirmar.FlatAppearance.BorderSize = 0;
            Btn_Confirmar.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            Btn_Confirmar.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            Btn_Confirmar.FlatStyle = FlatStyle.Flat;
            Btn_Confirmar.Font = new Font("Segoe MDL2 Assets", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_Confirmar.ForeColor = SystemColors.Control;
            Btn_Confirmar.Location = new Point(79, 184);
            Btn_Confirmar.Name = "Btn_Confirmar";
            Btn_Confirmar.Size = new Size(82, 34);
            Btn_Confirmar.TabIndex = 8;
            Btn_Confirmar.Text = "Comprar";
            Btn_Confirmar.TextAlign = ContentAlignment.TopCenter;
            Btn_Confirmar.UseVisualStyleBackColor = false;
            Btn_Confirmar.Click += Btn_Confirmar_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI Symbol", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(14, 121);
            label9.Name = "label9";
            label9.Size = new Size(197, 30);
            label9.TabIndex = 7;
            label9.Text = "Total             $0.0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe MDL2 Assets", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Firebrick;
            label3.Location = new Point(70, 61);
            label3.Name = "label3";
            label3.Size = new Size(155, 24);
            label3.TabIndex = 1;
            label3.Text = "Downtown Center";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe MDL2 Assets", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(85, 24);
            label1.TabIndex = 0;
            label1.Text = "Su orden";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe MDL2 Assets", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(407, -2);
            label2.Name = "label2";
            label2.Size = new Size(96, 40);
            label2.TabIndex = 1;
            label2.Text = "Salas";
            // 
            // comboBox
            // 
            comboBox.Cursor = Cursors.Hand;
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox.FormattingEnabled = true;
            comboBox.Items.AddRange(new object[] { "No elegido", "G1", "G2", "G3", "G4", "G5", "G6", "G7", "G8", "G9", "G10" });
            comboBox.Location = new Point(93, 290);
            comboBox.Name = "comboBox";
            comboBox.Size = new Size(121, 23);
            comboBox.TabIndex = 17;
            comboBox.SelectedIndexChanged += comboBox_SelectedIndexChanged;
            // 
            // comboBox1
            // 
            comboBox1.Cursor = Cursors.Hand;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "No elegido", "G1", "G2", "G3", "G4", "G5", "G6", "G7", "G8", "G9", "G10" });
            comboBox1.Location = new Point(351, 290);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 18;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.Cursor = Cursors.Hand;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "No elegido", "G1", "G2", "G3", "G4", "G5", "G6", "G7", "G8", "G9", "G10" });
            comboBox2.Location = new Point(93, 530);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 19;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // comboBox3
            // 
            comboBox3.Cursor = Cursors.Hand;
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "No elegido", "G1", "G2", "G3", "G4", "G5", "G6", "G7", "G8", "G9", "G10" });
            comboBox3.Location = new Point(351, 530);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(121, 23);
            comboBox3.TabIndex = 20;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe MDL2 Assets", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(509, 88);
            label10.Name = "label10";
            label10.Size = new Size(57, 40);
            label10.TabIndex = 21;
            label10.Text = "A2";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe MDL2 Assets", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.White;
            label11.Location = new Point(2, 88);
            label11.Name = "label11";
            label11.Size = new Size(57, 40);
            label11.TabIndex = 22;
            label11.Text = "A1";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Segoe MDL2 Assets", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.White;
            label12.Location = new Point(2, 337);
            label12.Name = "label12";
            label12.Size = new Size(57, 40);
            label12.TabIndex = 23;
            label12.Text = "A3";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Segoe MDL2 Assets", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.White;
            label13.Location = new Point(509, 337);
            label13.Name = "label13";
            label13.Size = new Size(57, 40);
            label13.TabIndex = 24;
            label13.Text = "A4";
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Cursor = Cursors.Hand;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(848, 12);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(41, 43);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 25;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // Salas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(901, 565);
            Controls.Add(pictureBox5);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(comboBox);
            Controls.Add(label2);
            Controls.Add(panel5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Salas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Salas";
            Load += Salas_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Panel panel5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label9;
        private Button Btn_Confirmar;
        private ComboBox comboBox;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private PictureBox pictureBox5;
        private Label label4;
    }
}