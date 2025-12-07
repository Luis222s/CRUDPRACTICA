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
            label5 = new Label();
            lblTipoSala = new TextBox();
            txtMostrarAsientos = new TextBox();
            label4 = new Label();
            Btn_Confirmar = new Button();
            label9 = new Label();
            label1 = new Label();
            label2 = new Label();
            pictureBox5 = new PictureBox();
            btnAtras = new Button();
            label3 = new Label();
            pbMapaAsientos = new PictureBox();
            label6 = new Label();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbMapaAsientos).BeginInit();
            SuspendLayout();
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ControlLight;
            panel5.Controls.Add(label5);
            panel5.Controls.Add(lblTipoSala);
            panel5.Controls.Add(txtMostrarAsientos);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(Btn_Confirmar);
            panel5.Controls.Add(label9);
            panel5.Controls.Add(label1);
            panel5.Location = new Point(925, 336);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(329, 358);
            panel5.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe MDL2 Assets", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(16, 114);
            label5.Name = "label5";
            label5.Size = new Size(294, 30);
            label5.TabIndex = 12;
            label5.Text = "TIPO DE TICKET/ASIENTO:";
            // 
            // lblTipoSala
            // 
            lblTipoSala.Location = new Point(16, 153);
            lblTipoSala.Name = "lblTipoSala";
            lblTipoSala.ReadOnly = true;
            lblTipoSala.Size = new Size(255, 27);
            lblTipoSala.TabIndex = 11;
            lblTipoSala.TextChanged += lblTipoSala_TextChanged;
            // 
            // txtMostrarAsientos
            // 
            txtMostrarAsientos.Location = new Point(16, 75);
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
            label4.Location = new Point(16, 37);
            label4.Name = "label4";
            label4.Size = new Size(266, 30);
            label4.TabIndex = 9;
            label4.Text = "CODIGO DE ASIENTOS:";
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
            Btn_Confirmar.Location = new Point(92, 299);
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
            label9.Location = new Point(41, 238);
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
            label1.Size = new Size(132, 30);
            label1.TabIndex = 0;
            label1.Text = "SU ORDEN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(614, 9);
            label2.Name = "label2";
            label2.Size = new Size(157, 60);
            label2.TabIndex = 1;
            label2.Text = "Salas";
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Cursor = Cursors.Hand;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(1252, 27);
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
            btnAtras.Location = new Point(1035, 742);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(94, 37);
            btnAtras.TabIndex = 26;
            btnAtras.Text = "ATRAS";
            btnAtras.UseVisualStyleBackColor = false;
            btnAtras.Click += btnAtras_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(233, 105);
            label3.Name = "label3";
            label3.Size = new Size(354, 35);
            label3.TabIndex = 28;
            label3.Text = "PANTALLA DE ASIENTOS";
            // 
            // pbMapaAsientos
            // 
            pbMapaAsientos.Image = Properties.Resources.Captura_de_pantalla_2025_12_07_070918;
            pbMapaAsientos.Location = new Point(31, 157);
            pbMapaAsientos.Name = "pbMapaAsientos";
            pbMapaAsientos.Size = new Size(770, 778);
            pbMapaAsientos.SizeMode = PictureBoxSizeMode.AutoSize;
            pbMapaAsientos.TabIndex = 29;
            pbMapaAsientos.TabStop = false;
            pbMapaAsientos.Click += pbMapaAsientos_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(363, 201);
            label6.Name = "label6";
            label6.Size = new Size(146, 38);
            label6.TabIndex = 30;
            label6.Text = "PANTALLA";
            // 
            // Salas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1338, 978);
            Controls.Add(label6);
            Controls.Add(pbMapaAsientos);
            Controls.Add(label3);
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
            ((System.ComponentModel.ISupportInitialize)pbMapaAsientos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel5;
        private Label label1;
        private Label label2;
        private Label label9;
        private Button Btn_Confirmar;
        private PictureBox pictureBox5;
        private Label label4;
        private TextBox txtMostrarAsientos;
        private Button btnAtras;
        private Label label3;
        private Label label5;
        private TextBox lblTipoSala;
        private PictureBox pbMapaAsientos;
        private Label label6;
    }
}