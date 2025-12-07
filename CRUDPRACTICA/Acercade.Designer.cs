namespace CapaPresentacion
{
    partial class Acercade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Acercade));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(812, 23);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(47, 57);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.RosyBrown;
            label1.Font = new Font("Segoe Fluent Icons", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(33, 138);
            label1.Name = "label1";
            label1.Size = new Size(188, 48);
            label1.TabIndex = 28;
            label1.Text = "Yenifer Colon Peña\r\n     2023-4096\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.RosyBrown;
            label2.Font = new Font("Segoe Fluent Icons", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(336, 48);
            label2.Name = "label2";
            label2.Size = new Size(172, 48);
            label2.TabIndex = 29;
            label2.Text = "Luis Aquino Mejia\r\n    2023-0685";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.RosyBrown;
            label3.Font = new Font("Segoe Fluent Icons", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(33, 48);
            label3.Name = "label3";
            label3.Size = new Size(164, 48);
            label3.TabIndex = 30;
            label3.Text = "Luis Martin Peña\r\n   2023-4341\r\n";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 128, 255);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(147, 179);
            panel1.Name = "panel1";
            panel1.Size = new Size(548, 260);
            panel1.TabIndex = 31;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.RosyBrown;
            label4.Font = new Font("Segoe Fluent Icons", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(303, 138);
            label4.Name = "label4";
            label4.Size = new Size(205, 48);
            label4.TabIndex = 31;
            label4.Text = "Julian David Vazquez\r\n2023-0715";
            // 
            // Acercade
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(903, 527);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Acercade";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Acercade";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private Label label4;
    }
}