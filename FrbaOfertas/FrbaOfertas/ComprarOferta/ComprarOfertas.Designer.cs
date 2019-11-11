namespace FrbaOfertas.ComprarOferta
{
    partial class ComprarOfertas
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
            this.txtNroOfertaDefinitiva = new System.Windows.Forms.TextBox();
            this.labelOpcionEliminar = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.planillaComprarOfertas = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtCodOferta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.planillaComprarOfertas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNroOfertaDefinitiva
            // 
            this.txtNroOfertaDefinitiva.Location = new System.Drawing.Point(483, 481);
            this.txtNroOfertaDefinitiva.Name = "txtNroOfertaDefinitiva";
            this.txtNroOfertaDefinitiva.Size = new System.Drawing.Size(153, 26);
            this.txtNroOfertaDefinitiva.TabIndex = 17;
            // 
            // labelOpcionEliminar
            // 
            this.labelOpcionEliminar.AutoSize = true;
            this.labelOpcionEliminar.Location = new System.Drawing.Point(21, 484);
            this.labelOpcionEliminar.Name = "labelOpcionEliminar";
            this.labelOpcionEliminar.Size = new System.Drawing.Size(280, 20);
            this.labelOpcionEliminar.TabIndex = 16;
            this.labelOpcionEliminar.Text = "Ingrese el numero de oferta a comprar";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(25, 535);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(87, 35);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(549, 535);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(87, 35);
            this.btnModificar.TabIndex = 14;
            this.btnModificar.Text = "Siguiente";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(549, 177);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 35);
            this.button2.TabIndex = 13;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 35);
            this.button1.TabIndex = 12;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // planillaComprarOfertas
            // 
            this.planillaComprarOfertas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.planillaComprarOfertas.Location = new System.Drawing.Point(25, 230);
            this.planillaComprarOfertas.Name = "planillaComprarOfertas";
            this.planillaComprarOfertas.RowHeadersWidth = 62;
            this.planillaComprarOfertas.RowTemplate.Height = 28;
            this.planillaComprarOfertas.Size = new System.Drawing.Size(611, 230);
            this.planillaComprarOfertas.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Controls.Add(this.txtCodOferta);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(25, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(611, 158);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de busqueda";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(180, 97);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(216, 26);
            this.txtDescripcion.TabIndex = 4;
            // 
            // txtCodOferta
            // 
            this.txtCodOferta.Location = new System.Drawing.Point(180, 39);
            this.txtCodOferta.Name = "txtCodOferta";
            this.txtCodOferta.Size = new System.Drawing.Size(216, 26);
            this.txtCodOferta.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripcion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo de oferta";
            // 
            // ComprarOferta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 584);
            this.Controls.Add(this.txtNroOfertaDefinitiva);
            this.Controls.Add(this.labelOpcionEliminar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.planillaComprarOfertas);
            this.Controls.Add(this.groupBox1);
            this.Name = "ComprarOferta";
            this.Text = "Comprar ofertas";
            ((System.ComponentModel.ISupportInitialize)(this.planillaComprarOfertas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNroOfertaDefinitiva;
        private System.Windows.Forms.Label labelOpcionEliminar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView planillaComprarOfertas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtCodOferta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}