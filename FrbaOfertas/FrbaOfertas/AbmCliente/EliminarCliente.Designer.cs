namespace FrbaOfertas.AbmCliente
{
    partial class EliminarCliente
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
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.planillaEliminarCliente = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEmailTLibre = new System.Windows.Forms.TextBox();
            this.txtDNIPExacta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtApellidoTLibre = new System.Windows.Forms.TextBox();
            this.txtNombreTLibre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.planillaEliminarCliente)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 473);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(87, 35);
            this.button4.TabIndex = 11;
            this.button4.Text = "Salir";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(536, 473);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 35);
            this.button3.TabIndex = 10;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(536, 175);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 35);
            this.button2.TabIndex = 9;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // planillaEliminarCliente
            // 
            this.planillaEliminarCliente.AllowUserToAddRows = false;
            this.planillaEliminarCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.planillaEliminarCliente.Location = new System.Drawing.Point(12, 228);
            this.planillaEliminarCliente.Name = "planillaEliminarCliente";
            this.planillaEliminarCliente.ReadOnly = true;
            this.planillaEliminarCliente.RowHeadersWidth = 62;
            this.planillaEliminarCliente.RowTemplate.Height = 28;
            this.planillaEliminarCliente.Size = new System.Drawing.Size(611, 230);
            this.planillaEliminarCliente.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEmailTLibre);
            this.groupBox1.Controls.Add(this.txtDNIPExacta);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtApellidoTLibre);
            this.groupBox1.Controls.Add(this.txtNombreTLibre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(611, 158);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de busqueda";
            // 
            // txtEmailTLibre
            // 
            this.txtEmailTLibre.Location = new System.Drawing.Point(413, 97);
            this.txtEmailTLibre.Name = "txtEmailTLibre";
            this.txtEmailTLibre.Size = new System.Drawing.Size(146, 26);
            this.txtEmailTLibre.TabIndex = 8;
            // 
            // txtDNIPExacta
            // 
            this.txtDNIPExacta.Location = new System.Drawing.Point(413, 39);
            this.txtDNIPExacta.Name = "txtDNIPExacta";
            this.txtDNIPExacta.Size = new System.Drawing.Size(146, 26);
            this.txtDNIPExacta.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(332, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(332, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "DNI";
            // 
            // txtApellidoTLibre
            // 
            this.txtApellidoTLibre.Location = new System.Drawing.Point(119, 97);
            this.txtApellidoTLibre.Name = "txtApellidoTLibre";
            this.txtApellidoTLibre.Size = new System.Drawing.Size(146, 26);
            this.txtApellidoTLibre.TabIndex = 4;
            // 
            // txtNombreTLibre
            // 
            this.txtNombreTLibre.Location = new System.Drawing.Point(119, 39);
            this.txtNombreTLibre.Name = "txtNombreTLibre";
            this.txtNombreTLibre.Size = new System.Drawing.Size(146, 26);
            this.txtNombreTLibre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // EliminarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 520);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.planillaEliminarCliente);
            this.Controls.Add(this.groupBox1);
            this.Name = "EliminarCliente";
            this.Text = "EliminarCliente";
            this.Load += new System.EventHandler(this.EliminarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.planillaEliminarCliente)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView planillaEliminarCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEmailTLibre;
        private System.Windows.Forms.TextBox txtDNIPExacta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtApellidoTLibre;
        private System.Windows.Forms.TextBox txtNombreTLibre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}