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
            cmbHorario = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            cmbCantidad = new ComboBox();
            btnConfirmar = new Button();
            panel4 = new Panel();
            cmbCombo4 = new ComboBox();
            cmbCombo3 = new ComboBox();
            cmbCombo2 = new ComboBox();
            cmbCombo1 = new ComboBox();
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
            cmbEntrada = new ComboBox();
            btnAtras = new Button();
            pictureBox7 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(969, 3);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(47, 57);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(273, 33);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(222, 300);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // Lbl_peli1
            // 
            Lbl_peli1.AutoSize = true;
            Lbl_peli1.BackColor = Color.Transparent;
            Lbl_peli1.Font = new Font("Segoe Fluent Icons", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lbl_peli1.ForeColor = SystemColors.Control;
            Lbl_peli1.Location = new Point(551, 16);
            Lbl_peli1.Name = "Lbl_peli1";
            Lbl_peli1.Size = new Size(139, 24);
            Lbl_peli1.TabIndex = 2;
            Lbl_peli1.Text = "Normal: 125 $";
            // 
            // cmbHorario
            // 
            cmbHorario.Cursor = Cursors.Hand;
            cmbHorario.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbHorario.FormattingEnabled = true;
            cmbHorario.Location = new Point(544, 169);
            cmbHorario.Margin = new Padding(3, 4, 3, 4);
            cmbHorario.Name = "cmbHorario";
            cmbHorario.Size = new Size(138, 28);
            cmbHorario.TabIndex = 3;
            cmbHorario.SelectedIndexChanged += cmbHorario_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe Fluent Icons", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(544, 140);
            label1.Name = "label1";
            label1.Size = new Size(86, 24);
            label1.TabIndex = 4;
            label1.Text = "Horarios";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe Fluent Icons", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(544, 63);
            label2.Name = "label2";
            label2.Size = new Size(186, 24);
            label2.TabIndex = 6;
            label2.Text = "Cantidad de tickets";
            // 
            // cmbCantidad
            // 
            cmbCantidad.Cursor = Cursors.Hand;
            cmbCantidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCantidad.FormattingEnabled = true;
            cmbCantidad.Location = new Point(544, 92);
            cmbCantidad.Margin = new Padding(3, 4, 3, 4);
            cmbCantidad.Name = "cmbCantidad";
            cmbCantidad.Size = new Size(138, 28);
            cmbCantidad.TabIndex = 5;
            cmbCantidad.SelectedIndexChanged += cmbCantidad_SelectedIndexChanged;
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = SystemColors.ButtonHighlight;
            btnConfirmar.Cursor = Cursors.Hand;
            btnConfirmar.FlatAppearance.BorderSize = 0;
            btnConfirmar.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            btnConfirmar.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnConfirmar.FlatStyle = FlatStyle.Flat;
            btnConfirmar.Font = new Font("Segoe MDL2 Assets", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmar.ForeColor = SystemColors.ActiveCaptionText;
            btnConfirmar.Location = new Point(790, 263);
            btnConfirmar.Margin = new Padding(3, 4, 3, 4);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(107, 40);
            btnConfirmar.TabIndex = 7;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.TextAlign = ContentAlignment.TopCenter;
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.InfoText;
            panel4.BackgroundImageLayout = ImageLayout.None;
            panel4.Controls.Add(cmbCombo4);
            panel4.Controls.Add(cmbCombo3);
            panel4.Controls.Add(cmbCombo2);
            panel4.Controls.Add(cmbCombo1);
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
            panel4.Location = new Point(-1, 375);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(1033, 387);
            panel4.TabIndex = 12;
            // 
            // cmbCombo4
            // 
            cmbCombo4.Cursor = Cursors.Hand;
            cmbCombo4.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCombo4.FormattingEnabled = true;
            cmbCombo4.Location = new Point(838, 319);
            cmbCombo4.Margin = new Padding(3, 4, 3, 4);
            cmbCombo4.Name = "cmbCombo4";
            cmbCombo4.Size = new Size(138, 28);
            cmbCombo4.TabIndex = 36;
            // 
            // cmbCombo3
            // 
            cmbCombo3.Cursor = Cursors.Hand;
            cmbCombo3.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCombo3.FormattingEnabled = true;
            cmbCombo3.Location = new Point(568, 319);
            cmbCombo3.Margin = new Padding(3, 4, 3, 4);
            cmbCombo3.Name = "cmbCombo3";
            cmbCombo3.Size = new Size(138, 28);
            cmbCombo3.TabIndex = 35;
            // 
            // cmbCombo2
            // 
            cmbCombo2.Cursor = Cursors.Hand;
            cmbCombo2.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCombo2.FormattingEnabled = true;
            cmbCombo2.Location = new Point(303, 319);
            cmbCombo2.Margin = new Padding(3, 4, 3, 4);
            cmbCombo2.Name = "cmbCombo2";
            cmbCombo2.Size = new Size(138, 28);
            cmbCombo2.TabIndex = 34;
            cmbCombo2.SelectedIndexChanged += cmbCombo2_SelectedIndexChanged_1;
            // 
            // cmbCombo1
            // 
            cmbCombo1.Cursor = Cursors.Hand;
            cmbCombo1.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCombo1.FormattingEnabled = true;
            cmbCombo1.Location = new Point(31, 319);
            cmbCombo1.Margin = new Padding(3, 4, 3, 4);
            cmbCombo1.Name = "cmbCombo1";
            cmbCombo1.Size = new Size(138, 28);
            cmbCombo1.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe MDL2 Assets", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.Control;
            label9.Location = new Point(851, 226);
            label9.Name = "label9";
            label9.Size = new Size(146, 80);
            label9.TabIndex = 33;
            label9.Text = "4 Refrescos Med \r\n2 Palomitas Gde \r\n1 Hot Dog \r\n1 Nacho";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe MDL2 Assets", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(568, 236);
            label8.Name = "label8";
            label8.Size = new Size(153, 40);
            label8.TabIndex = 32;
            label8.Text = "2 Refrescos Gde \r\n1 Palomitas X-Gde";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe MDL2 Assets", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(303, 236);
            label7.Name = "label7";
            label7.Size = new Size(159, 40);
            label7.TabIndex = 31;
            label7.Text = "1 Refresco X-Gde  \r\n1 Palomitas X-Gde";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe MDL2 Assets", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(31, 236);
            label6.Name = "label6";
            label6.Size = new Size(136, 40);
            label6.TabIndex = 30;
            label6.Text = "1 Refresco Gde \r\n1 Palomitas Gde";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe MDL2 Assets", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(874, 49);
            label5.Name = "label5";
            label5.Size = new Size(85, 30);
            label5.TabIndex = 29;
            label5.Text = "$1,100";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe MDL2 Assets", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(610, 49);
            label4.Name = "label4";
            label4.Size = new Size(65, 30);
            label4.TabIndex = 28;
            label4.Text = "$460";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe MDL2 Assets", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(347, 49);
            label3.Name = "label3";
            label3.Size = new Size(65, 30);
            label3.TabIndex = 27;
            label3.Text = "$330";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe MDL2 Assets", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.Control;
            label10.Location = new Point(59, 49);
            label10.Name = "label10";
            label10.Size = new Size(65, 30);
            label10.TabIndex = 26;
            label10.Text = "$300";
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(851, 85);
            pictureBox6.Margin = new Padding(3, 4, 3, 4);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(114, 128);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 25;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(584, 85);
            pictureBox5.Margin = new Padding(3, 4, 3, 4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(114, 128);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 24;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(320, 85);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(114, 128);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 23;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(38, 85);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(114, 128);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 22;
            pictureBox3.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe MDL2 Assets", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.Control;
            label11.Location = new Point(442, 12);
            label11.Name = "label11";
            label11.Size = new Size(133, 40);
            label11.TabIndex = 21;
            label11.Text = "Combos";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Segoe Fluent Icons", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.Control;
            label12.Location = new Point(759, 16);
            label12.Name = "label12";
            label12.Size = new Size(101, 24);
            label12.TabIndex = 13;
            label12.Text = "VIP 300 $";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Segoe Fluent Icons", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = SystemColors.Control;
            label13.Location = new Point(759, 63);
            label13.Name = "label13";
            label13.Size = new Size(80, 24);
            label13.TabIndex = 15;
            label13.Text = "Entrada";
            // 
            // cmbEntrada
            // 
            cmbEntrada.Cursor = Cursors.Hand;
            cmbEntrada.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEntrada.FormattingEnabled = true;
            cmbEntrada.Location = new Point(759, 92);
            cmbEntrada.Margin = new Padding(3, 4, 3, 4);
            cmbEntrada.Name = "cmbEntrada";
            cmbEntrada.Size = new Size(138, 28);
            cmbEntrada.TabIndex = 14;
            cmbEntrada.SelectedIndexChanged += cmbEntrada_SelectedIndexChanged;
            // 
            // btnAtras
            // 
            btnAtras.BackColor = SystemColors.ButtonHighlight;
            btnAtras.Cursor = Cursors.Hand;
            btnAtras.FlatAppearance.BorderSize = 0;
            btnAtras.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            btnAtras.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnAtras.FlatStyle = FlatStyle.Flat;
            btnAtras.Font = new Font("Segoe MDL2 Assets", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAtras.ForeColor = SystemColors.ActiveCaptionText;
            btnAtras.Location = new Point(609, 263);
            btnAtras.Margin = new Padding(3, 4, 3, 4);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(107, 40);
            btnAtras.TabIndex = 16;
            btnAtras.Text = "Atras";
            btnAtras.TextAlign = ContentAlignment.TopCenter;
            btnAtras.UseVisualStyleBackColor = false;
            btnAtras.Click += btnAtras_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.LOGO;
            pictureBox7.Location = new Point(30, 33);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(176, 141);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 17;
            pictureBox7.TabStop = false;
            // 
            // VentaDeBoletos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Captura_de_pantalla_2025_12_07_2005172;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1030, 753);
            Controls.Add(pictureBox7);
            Controls.Add(btnAtras);
            Controls.Add(label13);
            Controls.Add(cmbEntrada);
            Controls.Add(label12);
            Controls.Add(panel4);
            Controls.Add(btnConfirmar);
            Controls.Add(label2);
            Controls.Add(cmbCantidad);
            Controls.Add(label1);
            Controls.Add(cmbHorario);
            Controls.Add(Lbl_peli1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label Lbl_peli1;
        private ComboBox cmbHorario;
        private Label label1;
        private Label label2;
        private ComboBox cmbCantidad;
        private Button btnConfirmar;
        private Panel panel4;
        private ComboBox cmbCombo4;
        private ComboBox cmbCombo3;
        private ComboBox cmbCombo2;
        private ComboBox cmbCombo1;
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
        private ComboBox cmbEntrada;
        private Button btnAtras;
        private PictureBox pictureBox7;
    }
}