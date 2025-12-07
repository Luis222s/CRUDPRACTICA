namespace CapaPresentacion
{
    partial class FrmReportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReportes));
            label1 = new Label();
            lblIngresos = new Label();
            lblTickets = new Label();
            lblPelicula = new Label();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            Btn_Cerrar = new PictureBox();
            Btn_Minimizar = new PictureBox();
            pictureBox3 = new PictureBox();
            minimizar = new PictureBox();
            pictureBox6 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Btn_Cerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Btn_Minimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)minimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(64, 64, 64);
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Century", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(156, 192);
            label1.Name = "label1";
            label1.Size = new Size(242, 42);
            label1.TabIndex = 1;
            label1.Text = "Total Vendido";
            // 
            // lblIngresos
            // 
            lblIngresos.AutoSize = true;
            lblIngresos.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIngresos.Location = new Point(415, 201);
            lblIngresos.Name = "lblIngresos";
            lblIngresos.Size = new Size(21, 23);
            lblIngresos.TabIndex = 4;
            lblIngresos.Text = "1";
            // 
            // lblTickets
            // 
            lblTickets.AutoSize = true;
            lblTickets.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTickets.Location = new Point(307, 310);
            lblTickets.Name = "lblTickets";
            lblTickets.Size = new Size(21, 23);
            lblTickets.TabIndex = 5;
            lblTickets.Text = "2";
            // 
            // lblPelicula
            // 
            lblPelicula.AutoSize = true;
            lblPelicula.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPelicula.Location = new Point(414, 425);
            lblPelicula.Name = "lblPelicula";
            lblPelicula.Size = new Size(91, 23);
            lblPelicula.TabIndex = 6;
            lblPelicula.Text = "Pelicula";
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(lblPelicula);
            panel1.Controls.Add(lblTickets);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblIngresos);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(108, 110);
            panel1.Name = "panel1";
            panel1.Size = new Size(1058, 584);
            panel1.TabIndex = 7;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.IMAGEN_DE_RESGISTRO;
            pictureBox2.Location = new Point(723, 244);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(241, 212);
            pictureBox2.TabIndex = 32;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(64, 64, 64);
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.FlatStyle = FlatStyle.Popup;
            label2.Font = new Font("Century", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(156, 414);
            label2.Name = "label2";
            label2.Size = new Size(232, 42);
            label2.TabIndex = 9;
            label2.Text = "Peliculas Top";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(64, 64, 64);
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.FlatStyle = FlatStyle.Popup;
            label4.Font = new Font("Century", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(156, 299);
            label4.Name = "label4";
            label4.Size = new Size(134, 42);
            label4.TabIndex = 8;
            label4.Text = "Tickets";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._5ff49aff_5f59_4f4f_82db_4ed9161890db;
            pictureBox1.Location = new Point(-6, -422);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1087, 1015);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // Btn_Cerrar
            // 
            Btn_Cerrar.BackColor = Color.Transparent;
            Btn_Cerrar.Cursor = Cursors.Hand;
            Btn_Cerrar.Location = new Point(1254, 34);
            Btn_Cerrar.Margin = new Padding(3, 4, 3, 4);
            Btn_Cerrar.Name = "Btn_Cerrar";
            Btn_Cerrar.Size = new Size(31, 39);
            Btn_Cerrar.SizeMode = PictureBoxSizeMode.Zoom;
            Btn_Cerrar.TabIndex = 31;
            Btn_Cerrar.TabStop = false;
            // 
            // Btn_Minimizar
            // 
            Btn_Minimizar.BackColor = Color.Transparent;
            Btn_Minimizar.Cursor = Cursors.Hand;
            Btn_Minimizar.Location = new Point(1175, 34);
            Btn_Minimizar.Margin = new Padding(3, 4, 3, 4);
            Btn_Minimizar.Name = "Btn_Minimizar";
            Btn_Minimizar.Size = new Size(43, 39);
            Btn_Minimizar.SizeMode = PictureBoxSizeMode.Zoom;
            Btn_Minimizar.TabIndex = 30;
            Btn_Minimizar.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Black;
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(1256, 34);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(31, 39);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 34;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // minimizar
            // 
            minimizar.BackColor = Color.Black;
            minimizar.Cursor = Cursors.Hand;
            minimizar.Image = (Image)resources.GetObject("minimizar.Image");
            minimizar.Location = new Point(1177, 34);
            minimizar.Margin = new Padding(3, 4, 3, 4);
            minimizar.Name = "minimizar";
            minimizar.Size = new Size(43, 39);
            minimizar.SizeMode = PictureBoxSizeMode.Zoom;
            minimizar.TabIndex = 33;
            minimizar.TabStop = false;
            minimizar.Click += pictureBox4_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Black;
            pictureBox6.Cursor = Cursors.Hand;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(656, 34);
            pictureBox6.Margin = new Padding(3, 4, 3, 4);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(67, 62);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 32;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // FrmReportes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._945f4b41_4fb5_43ca_b716_a06d5cdf1514;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1332, 767);
            Controls.Add(pictureBox3);
            Controls.Add(minimizar);
            Controls.Add(pictureBox6);
            Controls.Add(Btn_Cerrar);
            Controls.Add(Btn_Minimizar);
            Controls.Add(panel1);
            Name = "FrmReportes";
            Text = "REPORTES";
            Load += FrmReportes_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Btn_Cerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)Btn_Minimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)minimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Label lblIngresos;
        private Label lblTickets;
        private Label lblPelicula;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label4;
        private PictureBox Btn_Cerrar;
        private PictureBox Btn_Minimizar;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox minimizar;
        private PictureBox pictureBox6;
    }
}