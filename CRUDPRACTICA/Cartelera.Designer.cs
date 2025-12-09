namespace CapaPresentacion
{
    partial class Cartelera
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cartelera));
            label1 = new Label();
            Btn_Minimizar = new PictureBox();
            Btn_Cerrar = new PictureBox();
            panel1 = new Panel();
            flowLayoutPanelCartelera = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)Btn_Minimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Btn_Cerrar).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(247, 37);
            label1.Name = "label1";
            label1.Size = new Size(658, 60);
            label1.TabIndex = 0;
            label1.Text = "EXHIBIENDOSE AHORA";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // Btn_Minimizar
            // 
            Btn_Minimizar.BackColor = Color.Transparent;
            Btn_Minimizar.Cursor = Cursors.Hand;
            Btn_Minimizar.Image = (Image)resources.GetObject("Btn_Minimizar.Image");
            Btn_Minimizar.Location = new Point(964, 13);
            Btn_Minimizar.Margin = new Padding(3, 4, 3, 4);
            Btn_Minimizar.Name = "Btn_Minimizar";
            Btn_Minimizar.Size = new Size(43, 39);
            Btn_Minimizar.SizeMode = PictureBoxSizeMode.Zoom;
            Btn_Minimizar.TabIndex = 13;
            Btn_Minimizar.TabStop = false;
            Btn_Minimizar.Click += Btn_Minimizar_Click;
            // 
            // Btn_Cerrar
            // 
            Btn_Cerrar.BackColor = Color.Transparent;
            Btn_Cerrar.Cursor = Cursors.Hand;
            Btn_Cerrar.Image = (Image)resources.GetObject("Btn_Cerrar.Image");
            Btn_Cerrar.Location = new Point(1028, 13);
            Btn_Cerrar.Margin = new Padding(3, 4, 3, 4);
            Btn_Cerrar.Name = "Btn_Cerrar";
            Btn_Cerrar.Size = new Size(39, 39);
            Btn_Cerrar.SizeMode = PictureBoxSizeMode.Zoom;
            Btn_Cerrar.TabIndex = 14;
            Btn_Cerrar.TabStop = false;
            Btn_Cerrar.Click += Btn_Cerrar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Location = new Point(185, -3);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(720, 36);
            panel1.TabIndex = 15;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // flowLayoutPanelCartelera
            // 
            flowLayoutPanelCartelera.BackColor = Color.Transparent;
            flowLayoutPanelCartelera.Location = new Point(25, 115);
            flowLayoutPanelCartelera.Name = "flowLayoutPanelCartelera";
            flowLayoutPanelCartelera.Size = new Size(1065, 819);
            flowLayoutPanelCartelera.TabIndex = 16;
            flowLayoutPanelCartelera.Paint += flowLayoutPanelCartelera_Paint;
            // 
            // Cartelera
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Captura_de_pantalla_2025_12_07_200517;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1121, 969);
            Controls.Add(flowLayoutPanelCartelera);
            Controls.Add(panel1);
            Controls.Add(Btn_Cerrar);
            Controls.Add(Btn_Minimizar);
            Controls.Add(label1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Cartelera";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CARTELERA";
            Load += Cartelera_Load;
            ((System.ComponentModel.ISupportInitialize)Btn_Minimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)Btn_Cerrar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox Btn_Minimizar;
        private PictureBox Btn_Cerrar;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanelCartelera;
    }
}
