namespace CapaPresentacion
{
    partial class Registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            txtPassword = new TextBox();
            txtUsuario = new TextBox();
            txtCorreo = new TextBox();
            txtNombre = new TextBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 43);
            label1.Name = "label1";
            label1.Size = new Size(69, 18);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(29, 87);
            label2.Name = "label2";
            label2.Size = new Size(71, 18);
            label2.TabIndex = 1;
            label2.Text = "Usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(34, 128);
            label3.Name = "label3";
            label3.Size = new Size(66, 18);
            label3.TabIndex = 2;
            label3.Text = "Correo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(5, 176);
            label4.Name = "label4";
            label4.Size = new Size(101, 18);
            label4.TabIndex = 3;
            label4.Text = "Contraseña";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaptionText;
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(txtUsuario);
            groupBox1.Controls.Add(txtCorreo);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Stencil", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.ButtonHighlight;
            groupBox1.Location = new Point(64, 125);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(437, 227);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "CREA TU CUENTA AQUI";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(135, 172);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(160, 29);
            txtPassword.TabIndex = 7;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(135, 84);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(155, 29);
            txtUsuario.TabIndex = 6;
            // 
            // txtCorreo
            // 
            txtCorreo.BackColor = SystemColors.ButtonHighlight;
            txtCorreo.ForeColor = Color.Black;
            txtCorreo.Location = new Point(135, 127);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(270, 29);
            txtCorreo.TabIndex = 5;
            txtCorreo.TextChanged += txtCorreo_TextChanged;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(135, 41);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(178, 29);
            txtNombre.TabIndex = 4;
            txtNombre.KeyPress += textBox1_KeyPress;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = SystemColors.ActiveCaptionText;
            btnGuardar.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = SystemColors.ButtonHighlight;
            btnGuardar.Location = new Point(130, 437);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(133, 39);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "CREAR CUENTA";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.ActiveCaptionText;
            btnCancelar.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = SystemColors.ButtonHighlight;
            btnCancelar.Location = new Point(306, 437);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(152, 39);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "CANCELAR / MENU";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-2, -5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(556, 671);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(555, 612);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Registro";
            Text = "REGISTRO";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private GroupBox groupBox1;
        private Button btnGuardar;
        private Button btnCancelar;
        private PictureBox pictureBox1;
        private TextBox txtPassword;
        private TextBox txtUsuario;
        private TextBox txtCorreo;
        private TextBox txtNombre;
    }
}