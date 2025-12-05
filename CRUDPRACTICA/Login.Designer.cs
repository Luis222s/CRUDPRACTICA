namespace CapaPresentacion
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            btn_login = new Button();
            txt_user = new TextBox();
            txt_password = new TextBox();
            Btn_Cerrar1 = new PictureBox();
            Btn_Minimizar = new PictureBox();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)Btn_Cerrar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Btn_Minimizar).BeginInit();
            SuspendLayout();
            // 
            // btn_login
            // 
            btn_login.BackColor = SystemColors.ActiveCaptionText;
            btn_login.Cursor = Cursors.Hand;
            btn_login.FlatAppearance.BorderSize = 0;
            btn_login.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            btn_login.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btn_login.FlatStyle = FlatStyle.Flat;
            btn_login.Font = new Font("Segoe Fluent Icons", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_login.ForeColor = SystemColors.ButtonFace;
            btn_login.Location = new Point(406, 509);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(95, 44);
            btn_login.TabIndex = 0;
            btn_login.Text = "Iniciar Sesión";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // txt_user
            // 
            txt_user.Cursor = Cursors.IBeam;
            txt_user.Location = new Point(379, 359);
            txt_user.Name = "txt_user";
            txt_user.Size = new Size(175, 23);
            txt_user.TabIndex = 1;
            // 
            // txt_password
            // 
            txt_password.Cursor = Cursors.IBeam;
            txt_password.Location = new Point(379, 436);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(175, 23);
            txt_password.TabIndex = 2;
            txt_password.UseSystemPasswordChar = true;
            // 
            // Btn_Cerrar1
            // 
            Btn_Cerrar1.BackColor = Color.Transparent;
            Btn_Cerrar1.Cursor = Cursors.Hand;
            Btn_Cerrar1.Image = (Image)resources.GetObject("Btn_Cerrar1.Image");
            Btn_Cerrar1.Location = new Point(859, 12);
            Btn_Cerrar1.Name = "Btn_Cerrar1";
            Btn_Cerrar1.Size = new Size(30, 32);
            Btn_Cerrar1.SizeMode = PictureBoxSizeMode.Zoom;
            Btn_Cerrar1.TabIndex = 0;
            Btn_Cerrar1.TabStop = false;
            Btn_Cerrar1.Click += Btn_Cerrar1_Click;
            // 
            // Btn_Minimizar
            // 
            Btn_Minimizar.BackColor = Color.Transparent;
            Btn_Minimizar.Cursor = Cursors.Hand;
            Btn_Minimizar.Image = (Image)resources.GetObject("Btn_Minimizar.Image");
            Btn_Minimizar.Location = new Point(799, 12);
            Btn_Minimizar.Name = "Btn_Minimizar";
            Btn_Minimizar.Size = new Size(38, 29);
            Btn_Minimizar.SizeMode = PictureBoxSizeMode.Zoom;
            Btn_Minimizar.TabIndex = 15;
            Btn_Minimizar.TabStop = false;
            Btn_Minimizar.Click += Btn_Minimizar_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Location = new Point(33, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(750, 27);
            panel2.TabIndex = 16;
            panel2.MouseDown += panel2_MouseDown;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(901, 565);
            Controls.Add(panel2);
            Controls.Add(Btn_Cerrar1);
            Controls.Add(Btn_Minimizar);
            Controls.Add(txt_password);
            Controls.Add(txt_user);
            Controls.Add(btn_login);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)Btn_Cerrar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Btn_Minimizar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_login;
        private TextBox txt_user;
        private TextBox txt_password;
        private PictureBox Btn_Cerrar1;
        private PictureBox Btn_Minimizar;
        private Panel panel2;
    }
}