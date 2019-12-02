namespace FrbaOfertas.Registrarse
{
    partial class DatosCliente
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
            this.txtDni = new System.Windows.Forms.TextBox();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.clientesTableAdapter1 = new FrbaOfertas.GD2C2019DataSetTableAdapters.CLIENTESTableAdapter();
            this.tipO_USUARIOTableAdapter1 = new FrbaOfertas.GD2C2019DataSetTableAdapters.TIPO_USUARIOTableAdapter();
            this.usuarioTableAdapter1 = new FrbaOfertas.GD2C2019DataSetTableAdapters.USUARIOTableAdapter();
            this.usuariO_ROLTableAdapter1 = new FrbaOfertas.GD2C2019DataSetTableAdapters.USUARIO_ROLTableAdapter();
            this.rolTableAdapter1 = new FrbaOfertas.GD2C2019DataSetTableAdapters.ROLTableAdapter();
            this.SuspendLayout();
            // 
            // lblIngrese
            // 
            this.lblIngrese.AutoSize = true;
            this.lblIngrese.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngrese.Location = new System.Drawing.Point(113, 70);
            this.lblIngrese.Name = "lblIngrese";
            this.lblIngrese.Size = new System.Drawing.Size(369, 38);
            this.lblIngrese.TabIndex = 0;
            this.lblIngrese.Text = "Ingrese datos del cliente";
            // 
            // txtDni
            // 
            this.txtDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDni.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtDni.Location = new System.Drawing.Point(120, 139);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(379, 34);
            this.txtDni.TabIndex = 2;
            this.txtDni.Text = "DNI";
            this.txtDni.Enter += new System.EventHandler(this.txtDni_Enter);
            this.txtDni.Leave += new System.EventHandler(this.txtDni_Leave);
            // 
            // btnAtras
            // 
            this.btnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Location = new System.Drawing.Point(120, 224);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(160, 50);
            this.btnAtras.TabIndex = 6;
            this.btnAtras.Text = "ATRÁS";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.Location = new System.Drawing.Point(339, 224);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(160, 50);
            this.btnSiguiente.TabIndex = 7;
            this.btnSiguiente.Text = "SIGUIENTE";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // clientesTableAdapter1
            // 
            this.clientesTableAdapter1.ClearBeforeFill = true;
            // 
            // tipO_USUARIOTableAdapter1
            // 
            this.tipO_USUARIOTableAdapter1.ClearBeforeFill = true;
            // 
            // usuarioTableAdapter1
            // 
            this.usuarioTableAdapter1.ClearBeforeFill = true;
            // 
            // usuariO_ROLTableAdapter1
            // 
            this.usuariO_ROLTableAdapter1.ClearBeforeFill = true;
            // 
            // rolTableAdapter1
            // 
            this.rolTableAdapter1.ClearBeforeFill = true;
            // 
            // DatosCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(608, 365);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.lblIngrese);
            this.Name = "DatosCliente";
            this.Text = "DatosCliente";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DatosCliente_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIngrese;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnSiguiente;
        private GD2C2019DataSetTableAdapters.CLIENTESTableAdapter clientesTableAdapter1;
        private GD2C2019DataSetTableAdapters.TIPO_USUARIOTableAdapter tipO_USUARIOTableAdapter1;
        private GD2C2019DataSetTableAdapters.USUARIOTableAdapter usuarioTableAdapter1;
        private GD2C2019DataSetTableAdapters.USUARIO_ROLTableAdapter usuariO_ROLTableAdapter1;
        private GD2C2019DataSetTableAdapters.ROLTableAdapter rolTableAdapter1;
    }
}