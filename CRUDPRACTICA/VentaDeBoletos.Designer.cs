namespace CapaPresentacion
{
    partial class VentaDeBoletos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentaDeBoletos));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            Lbl_peli1 = new Label();
            cmb_Horario1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            cmb_Tickets1 = new ComboBox();
            Btn_Confirmar1 = new Button();
            panel4 = new Panel();
            comboBox6 = new ComboBox();
            comboBox5 = new ComboBox();
            comboBox4 = new ComboBox();
            comboBox3 = new ComboBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label10 = new Label();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            cmb_entrada1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(848, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 43);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(241, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(185, 241);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // Lbl_peli1
            // 
            Lbl_peli1.AutoSize = true;
            Lbl_peli1.BackColor = Color.Transparent;
            Lbl_peli1.Font = new Font("Segoe Fluent Icons", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lbl_peli1.ForeColor = SystemColors.Control;
            Lbl_peli1.Location = new Point(482, 12);
            Lbl_peli1.Name = "Lbl_peli1";
            Lbl_peli1.Size = new Size(115, 19);
            Lbl_peli1.TabIndex = 2;
            Lbl_peli1.Text = "Normal: 125 $";
            // 
            // cmb_Horario1
            // 
            cmb_Horario1.Cursor = Cursors.Hand;
            cmb_Horario1.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Horario1.FormattingEnabled = true;
            cmb_Horario1.Items.AddRange(new object[] { "12 Nov 6:30 P.M", "12 Nov 9:00 P.M", "14 Nov 5:30 P.M", "14 Nov 8:30 P.M" });
            cmb_Horario1.Location = new Point(476, 127);
            cmb_Horario1.Name = "cmb_Horario1";
            cmb_Horario1.Size = new Size(121, 23);
            cmb_Horario1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe Fluent Icons", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(476, 105);
            label1.Name = "label1";
            label1.Size = new Size(71, 19);
            label1.TabIndex = 4;
            label1.Text = "Horarios";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe Fluent Icons", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(476, 47);
            label2.Name = "label2";
            label2.Size = new Size(152, 19);
            label2.TabIndex = 6;
            label2.Text = "Cantidad de tickets";
            // 
            // cmb_Tickets1
            // 
            cmb_Tickets1.Cursor = Cursors.Hand;
            cmb_Tickets1.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Tickets1.FormattingEnabled = true;
            cmb_Tickets1.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            cmb_Tickets1.Location = new Point(476, 69);
            cmb_Tickets1.Name = "cmb_Tickets1";
            cmb_Tickets1.Size = new Size(121, 23);
            cmb_Tickets1.TabIndex = 5;
            // 
            // Btn_Confirmar1
            // 
            Btn_Confirmar1.BackColor = SystemColors.InfoText;
            Btn_Confirmar1.Cursor = Cursors.Hand;
            Btn_Confirmar1.FlatAppearance.BorderSize = 0;
            Btn_Confirmar1.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            Btn_Confirmar1.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            Btn_Confirmar1.FlatStyle = FlatStyle.Flat;
            Btn_Confirmar1.Font = new Font("Segoe MDL2 Assets", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_Confirmar1.ForeColor = SystemColors.ControlLightLight;
            Btn_Confirmar1.Location = new Point(604, 197);
            Btn_Confirmar1.Name = "Btn_Confirmar1";
            Btn_Confirmar1.Size = new Size(79, 30);
            Btn_Confirmar1.TabIndex = 7;
            Btn_Confirmar1.Text = "Confirmar";
            Btn_Confirmar1.TextAlign = ContentAlignment.TopCenter;
            Btn_Confirmar1.UseVisualStyleBackColor = false;
            Btn_Confirmar1.Click += Btn_Confirmar1_Click;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.InfoText;
            panel4.BackgroundImageLayout = ImageLayout.None;
            panel4.Controls.Add(comboBox6);
            panel4.Controls.Add(comboBox5);
            panel4.Controls.Add(comboBox4);
            panel4.Controls.Add(comboBox3);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(pictureBox6);
            panel4.Controls.Add(pictureBox5);
            panel4.Controls.Add(pictureBox4);
            panel4.Controls.Add(pictureBox3);
            panel4.Controls.Add(label11);
            panel4.Location = new Point(-1, 281);
            panel4.Name = "panel4";
            panel4.Size = new Size(904, 290);
            panel4.TabIndex = 12;
            // 
            // comboBox6
            // 
            comboBox6.Cursor = Cursors.Hand;
            comboBox6.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox6.FormattingEnabled = true;
            comboBox6.Items.AddRange(new object[] { "0", "1", "2", "3", "4" });
            comboBox6.Location = new Point(733, 239);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(121, 23);
            comboBox6.TabIndex = 36;
            // 
            // comboBox5
            // 
            comboBox5.Cursor = Cursors.Hand;
            comboBox5.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox5.FormattingEnabled = true;
            comboBox5.Items.AddRange(new object[] { "0", "1", "2", "3", "4" });
            comboBox5.Location = new Point(497, 239);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(121, 23);
            comboBox5.TabIndex = 35;
            // 
            // comboBox4
            // 
            comboBox4.Cursor = Cursors.Hand;
            comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "0", "1", "2", "3", "4" });
            comboBox4.Location = new Point(265, 239);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(121, 23);
            comboBox4.TabIndex = 34;
            // 
            // comboBox3
            // 
            comboBox3.Cursor = Cursors.Hand;
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "0", "1", "2", "3", "4" });
            comboBox3.Location = new Point(27, 239);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(121, 23);
            comboBox3.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe MDL2 Assets", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.Control;
            label9.Location = new Point(733, 170);
            label9.Name = "label9";
            label9.Size = new Size(122, 64);
            label9.TabIndex = 33;
            label9.Text = "4 Refrescos Med \r\n2 Palomitas Gde \r\n1 Hot Dog \r\n1 Nacho";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe MDL2 Assets", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(489, 177);
            label8.Name = "label8";
            label8.Size = new Size(129, 32);
            label8.TabIndex = 32;
            label8.Text = "2 Refrescos Gde \r\n1 Palomitas X-Gde";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe MDL2 Assets", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(265, 177);
            label7.Name = "label7";
            label7.Size = new Size(132, 32);
            label7.TabIndex = 31;
            label7.Text = "1 Refresco X-Gde  \r\n1 Palomitas X-Gde";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe MDL2 Assets", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(33, 177);
            label6.Name = "label6";
            label6.Size = new Size(115, 32);
            label6.TabIndex = 30;
            label6.Text = "1 Refresco Gde \r\n1 Palomitas Gde";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe MDL2 Assets", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(765, 37);
            label5.Name = "label5";
            label5.Size = new Size(71, 24);
            label5.TabIndex = 29;
            label5.Text = "$1,100";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe MDL2 Assets", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(534, 37);
            label4.Name = "label4";
            label4.Size = new Size(54, 24);
            label4.TabIndex = 28;
            label4.Text = "$460";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe MDL2 Assets", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(304, 37);
            label3.Name = "label3";
            label3.Size = new Size(54, 24);
            label3.TabIndex = 27;
            label3.Text = "$330";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe MDL2 Assets", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.Control;
            label10.Location = new Point(52, 37);
            label10.Name = "label10";
            label10.Size = new Size(54, 24);
            label10.TabIndex = 26;
            label10.Text = "$300";
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(745, 64);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(100, 96);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 25;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(511, 64);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(100, 96);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 24;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(280, 64);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(100, 96);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 23;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(33, 64);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(100, 96);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 22;
            pictureBox3.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe MDL2 Assets", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.Control;
            label11.Location = new Point(389, 0);
            label11.Name = "label11";
            label11.Size = new Size(111, 32);
            label11.TabIndex = 21;
            label11.Text = "Combos";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Segoe Fluent Icons", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.Control;
            label12.Location = new Point(664, 12);
            label12.Name = "label12";
            label12.Size = new Size(83, 19);
            label12.TabIndex = 13;
            label12.Text = "VIP 300 $";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Segoe Fluent Icons", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = SystemColors.Control;
            label13.Location = new Point(664, 47);
            label13.Name = "label13";
            label13.Size = new Size(66, 19);
            label13.TabIndex = 15;
            label13.Text = "Entrada";
            // 
            // cmb_entrada1
            // 
            cmb_entrada1.Cursor = Cursors.Hand;
            cmb_entrada1.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_entrada1.FormattingEnabled = true;
            cmb_entrada1.Items.AddRange(new object[] { "General", "VIP" });
            cmb_entrada1.Location = new Point(664, 69);
            cmb_entrada1.Name = "cmb_entrada1";
            cmb_entrada1.Size = new Size(121, 23);
            cmb_entrada1.TabIndex = 14;
            // 
            // VentaDeBoletos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(901, 565);
            Controls.Add(label13);
            Controls.Add(cmb_entrada1);
            Controls.Add(label12);
            Controls.Add(panel4);
            Controls.Add(Btn_Confirmar1);
            Controls.Add(label2);
            Controls.Add(cmb_Tickets1);
            Controls.Add(label1);
            Controls.Add(cmb_Horario1);
            Controls.Add(Lbl_peli1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "VentaDeBoletos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VentaDeBoletos";
            Load += VentaDeBoletos_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label Lbl_peli1;
        private ComboBox cmb_Horario1;
        private Label label1;
        private Label label2;
        private ComboBox cmb_Tickets1;
        private Button Btn_Confirmar1;
        private Panel panel4;
        private ComboBox comboBox6;
        private ComboBox comboBox5;
        private ComboBox comboBox4;
        private ComboBox comboBox3;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label10;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private Label label11;
        private Label label12;
        private Label label13;
        private ComboBox cmb_entrada1;
    }
}