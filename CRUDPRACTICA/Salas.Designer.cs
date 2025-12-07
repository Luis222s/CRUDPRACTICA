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
            panel5 = new Panel();
            txtMostrarAsientos = new TextBox();
            label4 = new Label();
            Btn_Confirmar = new Button();
            label9 = new Label();
            label1 = new Label();
            label2 = new Label();
            comboBox = new ComboBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            pictureBox5 = new PictureBox();
            btnAtras = new Button();
            panel1 = new Panel();
            label3 = new Label();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ControlLight;
            panel5.Controls.Add(txtMostrarAsientos);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(Btn_Confirmar);
            panel5.Controls.Add(label9);
            panel5.Controls.Add(label1);
            panel5.Location = new Point(717, 149);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(290, 309);
            panel5.TabIndex = 4;
            // 
            // txtMostrarAsientos
            // 
            txtMostrarAsientos.Location = new Point(16, 117);
            txtMostrarAsientos.Name = "txtMostrarAsientos";
            txtMostrarAsientos.ReadOnly = true;
            txtMostrarAsientos.Size = new Size(255, 27);
            txtMostrarAsientos.TabIndex = 10;
            txtMostrarAsientos.TextChanged += txtMostrarAsientos_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe MDL2 Assets", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(16, 70);
            label4.Name = "label4";
            label4.Size = new Size(103, 30);
            label4.TabIndex = 9;
            label4.Text = "Asientos:";
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
            Btn_Confirmar.Location = new Point(83, 241);
            Btn_Confirmar.Margin = new Padding(3, 4, 3, 4);
            Btn_Confirmar.Name = "Btn_Confirmar";
            Btn_Confirmar.Size = new Size(128, 39);
            Btn_Confirmar.TabIndex = 8;
            Btn_Confirmar.Text = "COMPRAR";
            Btn_Confirmar.TextAlign = ContentAlignment.TopCenter;
            Btn_Confirmar.UseVisualStyleBackColor = false;
            Btn_Confirmar.Click += Btn_Confirmar_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI Symbol", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(16, 161);
            label9.Name = "label9";
            label9.Size = new Size(241, 37);
            label9.TabIndex = 7;
            label9.Text = "Total             $0.0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe MDL2 Assets", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(103, 30);
            label1.TabIndex = 0;
            label1.Text = "Su orden";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe MDL2 Assets", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(465, -3);
            label2.Name = "label2";
            label2.Size = new Size(121, 50);
            label2.TabIndex = 1;
            label2.Text = "Salas";
            // 
            // comboBox
            // 
            comboBox.Cursor = Cursors.Hand;
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox.FlatStyle = FlatStyle.Popup;
            comboBox.FormattingEnabled = true;
            comboBox.Location = new Point(31, 42);
            comboBox.Margin = new Padding(3, 4, 3, 4);
            comboBox.Name = "comboBox";
            comboBox.Size = new Size(138, 28);
            comboBox.TabIndex = 17;
            comboBox.SelectedIndexChanged += comboBox_SelectedIndexChanged;
            // 
            // comboBox1
            // 
            comboBox1.Cursor = Cursors.Hand;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FlatStyle = FlatStyle.Popup;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(31, 102);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(138, 28);
            comboBox1.TabIndex = 18;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.Cursor = Cursors.Hand;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FlatStyle = FlatStyle.Popup;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(31, 161);
            comboBox2.Margin = new Padding(3, 4, 3, 4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(138, 28);
            comboBox2.TabIndex = 19;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // comboBox3
            // 
            comboBox3.Cursor = Cursors.Hand;
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.FlatStyle = FlatStyle.Popup;
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(31, 219);
            comboBox3.Margin = new Padding(3, 4, 3, 4);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(138, 28);
            comboBox3.TabIndex = 20;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Cursor = Cursors.Hand;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(969, 16);
            pictureBox5.Margin = new Padding(3, 4, 3, 4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(47, 57);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 25;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // btnAtras
            // 
            btnAtras.BackColor = SystemColors.ActiveCaptionText;
            btnAtras.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAtras.ForeColor = SystemColors.ButtonHighlight;
            btnAtras.Location = new Point(817, 514);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(94, 37);
            btnAtras.TabIndex = 26;
            btnAtras.Text = "ATRAS";
            btnAtras.UseVisualStyleBackColor = false;
            btnAtras.Click += btnAtras_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GrayText;
            panel1.BackgroundImage = Properties.Resources.IMAGEN_PARA_LOGIN1;
            panel1.Controls.Add(comboBox);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(comboBox3);
            panel1.Location = new Point(30, 149);
            panel1.Name = "panel1";
            panel1.Size = new Size(605, 312);
            panel1.TabIndex = 27;
            panel1.Paint += panel1_Paint_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(156, 100);
            label3.Name = "label3";
            label3.Size = new Size(354, 35);
            label3.TabIndex = 28;
            label3.Text = "PANTALLA DE ASIENTOS";
            // 
            // Salas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1030, 753);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(btnAtras);
            Controls.Add(pictureBox5);
            Controls.Add(label2);
            Controls.Add(panel5);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Salas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Salas";
            Load += Salas_Load;
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel5;
        private Label label1;
        private Label label2;
        private Label label9;
        private Button Btn_Confirmar;
        private ComboBox comboBox;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private PictureBox pictureBox5;
        private Label label4;
        private TextBox txtMostrarAsientos;
        private Button btnAtras;
        private Panel panel1;
        private Label label3;
    }
}