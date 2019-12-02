namespace FrbaOfertas.CrearOferta
{
    partial class IngresaProveedor
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
            this.lblIngrese = new System.Windows.Forms.Label();
            this.txtCuit = new System.Windows.Forms.TextBox();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.proveedorTableAdapter1 = new FrbaOfertas.GD2C2019DataSetTableAdapters.PROVEEDORTableAdapter();
            this.SuspendLayout();
            // 
            // lblIngrese
            // 
            this.lblIngrese.AutoSize = true;
            this.lblIngrese.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngrese.Location = new System.Drawing.Point(28, 38);
            this.lblIngrese.Name = "lblIngrese";
            this.lblIngrese.Size = new System.Drawing.Size(666, 29);
            this.lblIngrese.TabIndex = 0;
            this.lblIngrese.Text = "Ingrese datos del proveedor al que le quiere asignar la oferta";
            // 
            // txtCuit
            // 
            this.txtCuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuit.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtCuit.Location = new System.Drawing.Point(83, 110);
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Size = new System.Drawing.Size(540, 34);
            this.txtCuit.TabIndex = 1;
            this.txtCuit.Text = "CUIT";
            this.txtCuit.Enter += new System.EventHandler(this.txtCuit_Enter);
            this.txtCuit.Leave += new System.EventHandler(this.txtCuit_Leave);
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRazonSocial.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtRazonSocial.Location = new System.Drawing.Point(83, 165);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(540, 34);
            this.txtRazonSocial.TabIndex = 2;
            this.txtRazonSocial.Text = "Razón social";
            this.txtRazonSocial.Enter += new System.EventHandler(this.txtRazonSocial_Enter);
            this.txtRazonSocial.Leave += new System.EventHandler(this.txtRazonSocial_Leave);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.Location = new System.Drawing.Point(453, 236);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(170, 44);
            this.btnSiguiente.TabIndex = 3;
            this.btnSiguiente.Text = "SIGUIENTE";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Location = new System.Drawing.Point(83, 236);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(170, 44);
            this.btnAtras.TabIndex = 4;
            this.btnAtras.Text = "ATRÁS";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // proveedorTableAdapter1
            // 
            this.proveedorTableAdapter1.ClearBeforeFill = true;
            // 
            // IngresaProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(727, 312);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.txtRazonSocial);
            this.Controls.Add(this.txtCuit);
            this.Controls.Add(this.lblIngrese);
            this.Name = "IngresaProveedor";
            this.Text = "IngresaProveedor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.IngresaProveedor_FormClosing);
            this.Load += new System.EventHandler(this.IngresaProveedor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIngrese;
        private System.Windows.Forms.TextBox txtCuit;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnAtras;
        private GD2C2019DataSetTableAdapters.PROVEEDORTableAdapter proveedorTableAdapter1;
    }
}