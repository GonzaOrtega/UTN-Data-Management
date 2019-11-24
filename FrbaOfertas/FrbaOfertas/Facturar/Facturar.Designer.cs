namespace FrbaOfertas.Facturar
{
    partial class Facturar
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
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.txtCuit = new System.Windows.Forms.TextBox();
            this.cOMPRADataGridView = new System.Windows.Forms.DataGridView();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.btnVer = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.cOMPRATableAdapter = new FrbaOfertas.GD2C2019DataSetTableAdapters.COMPRATableAdapter();
            this.proveedorTableAdapter1 = new FrbaOfertas.GD2C2019DataSetTableAdapters.PROVEEDORTableAdapter();
            this.ofertasTableAdapter1 = new FrbaOfertas.GD2C2019DataSetTableAdapters.OFERTASTableAdapter();
            this.facturaTableAdapter1 = new FrbaOfertas.GD2C2019DataSetTableAdapters.FACTURATableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.iteM_FACTURATableAdapter1 = new FrbaOfertas.GD2C2019DataSetTableAdapters.ITEM_FACTURATableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPRADataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpFin);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpInicio);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(29, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 144);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Periodo de facturación";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "Fin:";
            // 
            // dtpFin
            // 
            this.dtpFin.CalendarMonthBackground = System.Drawing.Color.OliveDrab;
            this.dtpFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFin.Location = new System.Drawing.Point(100, 94);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(477, 34);
            this.dtpFin.TabIndex = 8;
            this.dtpFin.ValueChanged += new System.EventHandler(this.dtpFin_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Inicio:";
            // 
            // dtpInicio
            // 
            this.dtpInicio.CalendarMonthBackground = System.Drawing.Color.OliveDrab;
            this.dtpInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInicio.Location = new System.Drawing.Point(100, 54);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(477, 34);
            this.dtpInicio.TabIndex = 6;
            this.dtpInicio.ValueChanged += new System.EventHandler(this.dtpInicio_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox2.Controls.Add(this.txtRazonSocial);
            this.groupBox2.Controls.Add(this.txtCuit);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(635, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(336, 144);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Proveedor";
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtRazonSocial.Location = new System.Drawing.Point(27, 94);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(282, 34);
            this.txtRazonSocial.TabIndex = 1;
            this.txtRazonSocial.Text = "Razón social";
            this.txtRazonSocial.TextChanged += new System.EventHandler(this.txtRazonSocial_TextChanged);
            this.txtRazonSocial.Enter += new System.EventHandler(this.txtRazonSocial_Enter);
            this.txtRazonSocial.Leave += new System.EventHandler(this.txtRazonSocial_Leave);
            // 
            // txtCuit
            // 
            this.txtCuit.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtCuit.Location = new System.Drawing.Point(27, 54);
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Size = new System.Drawing.Size(282, 34);
            this.txtCuit.TabIndex = 0;
            this.txtCuit.Text = "CUIT";
            this.txtCuit.TextChanged += new System.EventHandler(this.txtCuit_TextChanged);
            this.txtCuit.Enter += new System.EventHandler(this.txtCuit_Enter);
            this.txtCuit.Leave += new System.EventHandler(this.txtCuit_Leave);
            // 
            // cOMPRADataGridView
            // 
            this.cOMPRADataGridView.AllowUserToAddRows = false;
            this.cOMPRADataGridView.AllowUserToDeleteRows = false;
            this.cOMPRADataGridView.BackgroundColor = System.Drawing.Color.YellowGreen;
            this.cOMPRADataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cOMPRADataGridView.GridColor = System.Drawing.Color.DarkOliveGreen;
            this.cOMPRADataGridView.Location = new System.Drawing.Point(29, 244);
            this.cOMPRADataGridView.MultiSelect = false;
            this.cOMPRADataGridView.Name = "cOMPRADataGridView";
            this.cOMPRADataGridView.ReadOnly = true;
            this.cOMPRADataGridView.RowHeadersWidth = 51;
            this.cOMPRADataGridView.RowTemplate.Height = 24;
            this.cOMPRADataGridView.Size = new System.Drawing.Size(552, 209);
            this.cOMPRADataGridView.TabIndex = 3;
            // 
            // btnFacturar
            // 
            this.btnFacturar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturar.Location = new System.Drawing.Point(682, 344);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(227, 42);
            this.btnFacturar.TabIndex = 4;
            this.btnFacturar.Text = "FACTURAR";
            this.btnFacturar.UseVisualStyleBackColor = true;
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click);
            // 
            // btnVer
            // 
            this.btnVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVer.Location = new System.Drawing.Point(682, 294);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(227, 44);
            this.btnVer.TabIndex = 5;
            this.btnVer.Text = "BUSCAR";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Location = new System.Drawing.Point(682, 392);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(227, 44);
            this.btnAtras.TabIndex = 6;
            this.btnAtras.Text = "ATRÁS";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // cOMPRATableAdapter
            // 
            this.cOMPRATableAdapter.ClearBeforeFill = true;
            // 
            // proveedorTableAdapter1
            // 
            this.proveedorTableAdapter1.ClearBeforeFill = true;
            // 
            // ofertasTableAdapter1
            // 
            this.ofertasTableAdapter1.ClearBeforeFill = true;
            // 
            // facturaTableAdapter1
            // 
            this.facturaTableAdapter1.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(682, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(227, 44);
            this.button1.TabIndex = 7;
            this.button1.Text = "LIMPIAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // iteM_FACTURATableAdapter1
            // 
            this.iteM_FACTURATableAdapter1.ClearBeforeFill = true;
            // 
            // Facturar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(991, 476);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.btnFacturar);
            this.Controls.Add(this.cOMPRADataGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Name = "Facturar";
            this.Text = "Facturar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Facturar_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPRADataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.TextBox txtCuit;
        private GD2C2019DataSetTableAdapters.COMPRATableAdapter cOMPRATableAdapter;
        private System.Windows.Forms.DataGridView cOMPRADataGridView;
        private System.Windows.Forms.Button btnFacturar;
        private System.Windows.Forms.Button btnVer;
        private GD2C2019DataSetTableAdapters.PROVEEDORTableAdapter proveedorTableAdapter1;
        private System.Windows.Forms.Button btnAtras;
        private GD2C2019DataSetTableAdapters.OFERTASTableAdapter ofertasTableAdapter1;
        private GD2C2019DataSetTableAdapters.FACTURATableAdapter facturaTableAdapter1;
        private System.Windows.Forms.Button button1;
        private GD2C2019DataSetTableAdapters.ITEM_FACTURATableAdapter iteM_FACTURATableAdapter1;
    }
}