namespace FrbaOfertas.AbmCliente
{
    partial class CrearCliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNombreAltaCliente = new System.Windows.Forms.TextBox();
            this.txtApellidoAltaCliente = new System.Windows.Forms.TextBox();
            this.txtMailAltaCliente = new System.Windows.Forms.TextBox();
            this.txtDireccionAltaCliente = new System.Windows.Forms.TextBox();
            this.dtpFechaNacimientoAltaCliente = new System.Windows.Forms.DateTimePicker();
            this.btnDarAltaCliente = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.cbCasaODepartamento = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNroDepartamentoAltaCliente = new System.Windows.Forms.TextBox();
            this.txtCiudadAltaCliente = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.udDNIAltaCliente = new System.Windows.Forms.NumericUpDown();
            this.udTelefonoAltaCliente = new System.Windows.Forms.NumericUpDown();
            this.udCPAltaCliente = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.udDNIAltaCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udTelefonoAltaCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udCPAltaCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alta cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "DNI (Obligatorio)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mail";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Telefono";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(673, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Direccion";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 352);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(196, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Codigo postal (Obligatorio)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(43, 404);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(157, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Fecha de nacimiento";
            // 
            // txtNombreAltaCliente
            // 
            this.txtNombreAltaCliente.Location = new System.Drawing.Point(273, 101);
            this.txtNombreAltaCliente.Name = "txtNombreAltaCliente";
            this.txtNombreAltaCliente.Size = new System.Drawing.Size(277, 26);
            this.txtNombreAltaCliente.TabIndex = 9;
            this.txtNombreAltaCliente.TextChanged += new System.EventHandler(this.txtNombreAltaCliente_TextChanged);
            // 
            // txtApellidoAltaCliente
            // 
            this.txtApellidoAltaCliente.Location = new System.Drawing.Point(273, 153);
            this.txtApellidoAltaCliente.Name = "txtApellidoAltaCliente";
            this.txtApellidoAltaCliente.Size = new System.Drawing.Size(277, 26);
            this.txtApellidoAltaCliente.TabIndex = 10;
            // 
            // txtMailAltaCliente
            // 
            this.txtMailAltaCliente.Location = new System.Drawing.Point(273, 256);
            this.txtMailAltaCliente.Name = "txtMailAltaCliente";
            this.txtMailAltaCliente.Size = new System.Drawing.Size(277, 26);
            this.txtMailAltaCliente.TabIndex = 12;
            // 
            // txtDireccionAltaCliente
            // 
            this.txtDireccionAltaCliente.Location = new System.Drawing.Point(788, 101);
            this.txtDireccionAltaCliente.Name = "txtDireccionAltaCliente";
            this.txtDireccionAltaCliente.Size = new System.Drawing.Size(262, 26);
            this.txtDireccionAltaCliente.TabIndex = 14;
            // 
            // dtpFechaNacimientoAltaCliente
            // 
            this.dtpFechaNacimientoAltaCliente.Location = new System.Drawing.Point(273, 404);
            this.dtpFechaNacimientoAltaCliente.Name = "dtpFechaNacimientoAltaCliente";
            this.dtpFechaNacimientoAltaCliente.Size = new System.Drawing.Size(277, 26);
            this.dtpFechaNacimientoAltaCliente.TabIndex = 16;
            this.dtpFechaNacimientoAltaCliente.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btnDarAltaCliente
            // 
            this.btnDarAltaCliente.Location = new System.Drawing.Point(917, 352);
            this.btnDarAltaCliente.Name = "btnDarAltaCliente";
            this.btnDarAltaCliente.Size = new System.Drawing.Size(133, 72);
            this.btnDarAltaCliente.TabIndex = 17;
            this.btnDarAltaCliente.Text = "Dar de alta";
            this.btnDarAltaCliente.UseVisualStyleBackColor = true;
            this.btnDarAltaCliente.Click += new System.EventHandler(this.btnDarAltaCliente_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(673, 209);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(181, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "Casa o departamento??";
            // 
            // cbCasaODepartamento
            // 
            this.cbCasaODepartamento.FormattingEnabled = true;
            this.cbCasaODepartamento.Items.AddRange(new object[] {
            "Casa",
            "Departamento"});
            this.cbCasaODepartamento.Location = new System.Drawing.Point(891, 206);
            this.cbCasaODepartamento.Name = "cbCasaODepartamento";
            this.cbCasaODepartamento.Size = new System.Drawing.Size(159, 28);
            this.cbCasaODepartamento.TabIndex = 19;
            this.cbCasaODepartamento.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(673, 261);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(138, 20);
            this.label11.TabIndex = 20;
            this.label11.Text = "Nro departamento";
            // 
            // txtNroDepartamentoAltaCliente
            // 
            this.txtNroDepartamentoAltaCliente.Location = new System.Drawing.Point(891, 259);
            this.txtNroDepartamentoAltaCliente.Name = "txtNroDepartamentoAltaCliente";
            this.txtNroDepartamentoAltaCliente.Size = new System.Drawing.Size(159, 26);
            this.txtNroDepartamentoAltaCliente.TabIndex = 21;
            this.txtNroDepartamentoAltaCliente.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtCiudadAltaCliente
            // 
            this.txtCiudadAltaCliente.Location = new System.Drawing.Point(788, 153);
            this.txtCiudadAltaCliente.Name = "txtCiudadAltaCliente";
            this.txtCiudadAltaCliente.Size = new System.Drawing.Size(262, 26);
            this.txtCiudadAltaCliente.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(673, 156);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 20);
            this.label12.TabIndex = 22;
            this.label12.Text = "Ciudad";
            // 
            // udDNIAltaCliente
            // 
            this.udDNIAltaCliente.Location = new System.Drawing.Point(273, 206);
            this.udDNIAltaCliente.Name = "udDNIAltaCliente";
            this.udDNIAltaCliente.Size = new System.Drawing.Size(277, 26);
            this.udDNIAltaCliente.TabIndex = 24;
            this.udDNIAltaCliente.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // udTelefonoAltaCliente
            // 
            this.udTelefonoAltaCliente.Location = new System.Drawing.Point(273, 301);
            this.udTelefonoAltaCliente.Name = "udTelefonoAltaCliente";
            this.udTelefonoAltaCliente.Size = new System.Drawing.Size(277, 26);
            this.udTelefonoAltaCliente.TabIndex = 25;
            // 
            // udCPAltaCliente
            // 
            this.udCPAltaCliente.Location = new System.Drawing.Point(273, 350);
            this.udCPAltaCliente.Name = "udCPAltaCliente";
            this.udCPAltaCliente.Size = new System.Drawing.Size(277, 26);
            this.udCPAltaCliente.TabIndex = 26;
            // 
            // CrearCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 456);
            this.Controls.Add(this.udCPAltaCliente);
            this.Controls.Add(this.udTelefonoAltaCliente);
            this.Controls.Add(this.udDNIAltaCliente);
            this.Controls.Add(this.txtCiudadAltaCliente);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtNroDepartamentoAltaCliente);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbCasaODepartamento);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnDarAltaCliente);
            this.Controls.Add(this.dtpFechaNacimientoAltaCliente);
            this.Controls.Add(this.txtDireccionAltaCliente);
            this.Controls.Add(this.txtMailAltaCliente);
            this.Controls.Add(this.txtApellidoAltaCliente);
            this.Controls.Add(this.txtNombreAltaCliente);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CrearCliente";
            this.Text = "Crear cliente";
            this.Load += new System.EventHandler(this.CrearCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.udDNIAltaCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udTelefonoAltaCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udCPAltaCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNombreAltaCliente;
        private System.Windows.Forms.TextBox txtApellidoAltaCliente;
        private System.Windows.Forms.TextBox txtMailAltaCliente;
        private System.Windows.Forms.TextBox txtDireccionAltaCliente;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimientoAltaCliente;
        private System.Windows.Forms.Button btnDarAltaCliente;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbCasaODepartamento;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNroDepartamentoAltaCliente;
        private System.Windows.Forms.TextBox txtCiudadAltaCliente;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown udDNIAltaCliente;
        private System.Windows.Forms.NumericUpDown udTelefonoAltaCliente;
        private System.Windows.Forms.NumericUpDown udCPAltaCliente;
    }
}