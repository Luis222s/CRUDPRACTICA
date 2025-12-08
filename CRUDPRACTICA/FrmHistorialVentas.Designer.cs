namespace CapaPresentacion
{
    partial class FrmHistorialVentas
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
            dgvVentas = new DataGridView();
            dgvDetalle = new DataGridView();
            btnCerrar = new Button();
            lblVentaTotal = new Label();
            lblDetalleVenta = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).BeginInit();
            SuspendLayout();
            // 
            // dgvVentas
            // 
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Location = new Point(280, 67);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.RowHeadersWidth = 51;
            dgvVentas.Size = new Size(813, 370);
            dgvVentas.TabIndex = 0;
            dgvVentas.CellContentClick += dgvVentas_CellContentClick;
            // 
            // dgvDetalle
            // 
            dgvDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalle.Location = new Point(280, 516);
            dgvDetalle.Name = "dgvDetalle";
            dgvDetalle.RowHeadersWidth = 51;
            dgvDetalle.Size = new Size(813, 374);
            dgvDetalle.TabIndex = 1;
            dgvDetalle.CellContentClick += dgvDetalle_CellContentClick;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.Gray;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrar.Location = new Point(90, 444);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(118, 50);
            btnCerrar.TabIndex = 2;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // lblVentaTotal
            // 
            lblVentaTotal.AutoSize = true;
            lblVentaTotal.FlatStyle = FlatStyle.Popup;
            lblVentaTotal.Font = new Font("Century", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVentaTotal.Location = new Point(553, 24);
            lblVentaTotal.Name = "lblVentaTotal";
            lblVentaTotal.Size = new Size(228, 28);
            lblVentaTotal.TabIndex = 3;
            lblVentaTotal.Text = "Ventas Realizadas";
            lblVentaTotal.Click += lblVentaTotal_Click;
            // 
            // lblDetalleVenta
            // 
            lblDetalleVenta.AutoSize = true;
            lblDetalleVenta.FlatStyle = FlatStyle.Popup;
            lblDetalleVenta.Font = new Font("Century", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDetalleVenta.Location = new Point(553, 466);
            lblDetalleVenta.Name = "lblDetalleVenta";
            lblDetalleVenta.Size = new Size(237, 28);
            lblDetalleVenta.TabIndex = 4;
            lblDetalleVenta.Text = "Detalle de la Venta";
            lblDetalleVenta.Click += lblDetalleVenta_Click;
            // 
            // FrmHistorialVentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1121, 927);
            Controls.Add(lblDetalleVenta);
            Controls.Add(lblVentaTotal);
            Controls.Add(btnCerrar);
            Controls.Add(dgvDetalle);
            Controls.Add(dgvVentas);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmHistorialVentas";
            Text = "Historial De Ventas + Tickets";
            Load += FrmHistorialVentas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvVentas;
        private DataGridView dgvDetalle;
        private Button btnCerrar;
        private Label lblVentaTotal;
        private Label lblDetalleVenta;
    }
}