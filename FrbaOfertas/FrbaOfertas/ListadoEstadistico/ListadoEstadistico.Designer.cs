namespace FrbaOfertas.ListadoEstadistico
{
    partial class ListadoEstadistico
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dudSemestre = new System.Windows.Forms.DomainUpDown();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbFrecuencia = new System.Windows.Forms.RadioButton();
            this.rbDescuento = new System.Windows.Forms.RadioButton();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.facturaTableAdapter1 = new FrbaOfertas.GD2C2019DataSetTableAdapters.FACTURATableAdapter();
            this.ofertasTableAdapter1 = new FrbaOfertas.GD2C2019DataSetTableAdapters.OFERTASTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.dudSemestre);
            this.groupBox1.Controls.Add(this.txtAnio);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(39, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 150);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fecha";
            // 
            // dudSemestre
            // 
            this.dudSemestre.Items.Add("Primer semestre");
            this.dudSemestre.Items.Add("Segundo semestre");
            this.dudSemestre.Location = new System.Drawing.Point(31, 100);
            this.dudSemestre.Name = "dudSemestre";
            this.dudSemestre.Size = new System.Drawing.Size(290, 34);
            this.dudSemestre.TabIndex = 6;
            this.dudSemestre.Text = "Primer semestre";
            // 
            // txtAnio
            // 
            this.txtAnio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnio.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtAnio.Location = new System.Drawing.Point(31, 49);
            this.txtAnio.Margin = new System.Windows.Forms.Padding(4);
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(290, 34);
            this.txtAnio.TabIndex = 4;
            this.txtAnio.Text = "Año";
            this.txtAnio.Enter += new System.EventHandler(this.txtAnio_Enter);
            this.txtAnio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAnio_KeyPress);
            this.txtAnio.Leave += new System.EventHandler(this.txtAnio_Leave);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox2.Controls.Add(this.rbFrecuencia);
            this.groupBox2.Controls.Add(this.rbDescuento);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(394, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(397, 150);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo de listado";
            // 
            // rbFrecuencia
            // 
            this.rbFrecuencia.AutoSize = true;
            this.rbFrecuencia.Location = new System.Drawing.Point(45, 100);
            this.rbFrecuencia.Name = "rbFrecuencia";
            this.rbFrecuencia.Size = new System.Drawing.Size(222, 33);
            this.rbFrecuencia.TabIndex = 1;
            this.rbFrecuencia.TabStop = true;
            this.rbFrecuencia.Text = "Mayor facturación";
            this.rbFrecuencia.UseVisualStyleBackColor = true;
            this.rbFrecuencia.CheckedChanged += new System.EventHandler(this.rbFrecuencia_CheckedChanged);
            // 
            // rbDescuento
            // 
            this.rbDescuento.AutoSize = true;
            this.rbDescuento.Location = new System.Drawing.Point(45, 49);
            this.rbDescuento.Name = "rbDescuento";
            this.rbDescuento.Size = new System.Drawing.Size(230, 33);
            this.rbDescuento.TabIndex = 0;
            this.rbDescuento.TabStop = true;
            this.rbDescuento.Text = "Mayor descuentos";
            this.rbDescuento.UseVisualStyleBackColor = true;
            this.rbDescuento.CheckedChanged += new System.EventHandler(this.rbDescuento_CheckedChanged);
            // 
            // btnListar
            // 
            this.btnListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Location = new System.Drawing.Point(579, 247);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(212, 54);
            this.btnListar.TabIndex = 6;
            this.btnListar.Text = "BUSCAR";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Location = new System.Drawing.Point(579, 389);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(212, 54);
            this.btnAtras.TabIndex = 7;
            this.btnAtras.Text = "ATRÁS";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(39, 247);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(505, 230);
            this.dataGridView1.TabIndex = 8;
            // 
            // facturaTableAdapter1
            // 
            this.facturaTableAdapter1.ClearBeforeFill = true;
            // 
            // ofertasTableAdapter1
            // 
            this.ofertasTableAdapter1.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(579, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 54);
            this.button1.TabIndex = 9;
            this.button1.Text = "LIMPIAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ListadoEstadistico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(893, 519);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ListadoEstadistico";
            this.Text = "Listado estadístico";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ListadoEstadistico_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DomainUpDown dudSemestre;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbFrecuencia;
        private System.Windows.Forms.RadioButton rbDescuento;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtAnio;
        private GD2C2019DataSetTableAdapters.FACTURATableAdapter facturaTableAdapter1;
        private GD2C2019DataSetTableAdapters.OFERTASTableAdapter ofertasTableAdapter1;
        private System.Windows.Forms.Button button1;
    }
}