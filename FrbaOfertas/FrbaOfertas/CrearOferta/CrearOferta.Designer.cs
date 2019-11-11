namespace FrbaOfertas.CrearOferta
{
    partial class CrearOferta
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
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.tbPrecioLista = new System.Windows.Forms.TextBox();
            this.tbPrecioOferta = new System.Windows.Forms.TextBox();
            this.dtpPublicacion = new System.Windows.Forms.DateTimePicker();
            this.dtpVencimiento = new System.Windows.Forms.DateTimePicker();
            this.nudStock = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.nudMaxima = new System.Windows.Forms.NumericUpDown();
            this.lblPublicacion = new System.Windows.Forms.Label();
            this.lblVencimiento = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblMaxima = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxima)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(225, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Crea una nueva oferta";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtDescripcion.Location = new System.Drawing.Point(161, 123);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(477, 34);
            this.txtDescripcion.TabIndex = 1;
            this.txtDescripcion.Text = "Descripcion";
            // 
            // tbPrecioLista
            // 
            this.tbPrecioLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrecioLista.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.tbPrecioLista.Location = new System.Drawing.Point(160, 445);
            this.tbPrecioLista.Name = "tbPrecioLista";
            this.tbPrecioLista.Size = new System.Drawing.Size(477, 34);
            this.tbPrecioLista.TabIndex = 2;
            this.tbPrecioLista.Text = "Precio de lista";
            // 
            // tbPrecioOferta
            // 
            this.tbPrecioOferta.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrecioOferta.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.tbPrecioOferta.Location = new System.Drawing.Point(160, 370);
            this.tbPrecioOferta.Name = "tbPrecioOferta";
            this.tbPrecioOferta.Size = new System.Drawing.Size(477, 34);
            this.tbPrecioOferta.TabIndex = 3;
            this.tbPrecioOferta.Text = "Precio Oferta";
            // 
            // dtpPublicacion
            // 
            this.dtpPublicacion.CalendarMonthBackground = System.Drawing.Color.OliveDrab;
            this.dtpPublicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPublicacion.Location = new System.Drawing.Point(161, 212);
            this.dtpPublicacion.Name = "dtpPublicacion";
            this.dtpPublicacion.Size = new System.Drawing.Size(477, 34);
            this.dtpPublicacion.TabIndex = 4;
            this.dtpPublicacion.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dtpVencimiento
            // 
            this.dtpVencimiento.CalendarMonthBackground = System.Drawing.Color.OliveDrab;
            this.dtpVencimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpVencimiento.Location = new System.Drawing.Point(160, 298);
            this.dtpVencimiento.Name = "dtpVencimiento";
            this.dtpVencimiento.Size = new System.Drawing.Size(477, 34);
            this.dtpVencimiento.TabIndex = 5;
            // 
            // nudStock
            // 
            this.nudStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudStock.Location = new System.Drawing.Point(160, 538);
            this.nudStock.Name = "nudStock";
            this.nudStock.Size = new System.Drawing.Size(477, 34);
            this.nudStock.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(160, 708);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 43);
            this.button1.TabIndex = 8;
            this.button1.Text = "ATRÁS";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(438, 708);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(199, 43);
            this.button2.TabIndex = 9;
            this.button2.Text = "CREAR";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // nudMaxima
            // 
            this.nudMaxima.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMaxima.Location = new System.Drawing.Point(160, 630);
            this.nudMaxima.Name = "nudMaxima";
            this.nudMaxima.Size = new System.Drawing.Size(477, 34);
            this.nudMaxima.TabIndex = 10;
            // 
            // lblPublicacion
            // 
            this.lblPublicacion.AutoSize = true;
            this.lblPublicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPublicacion.Location = new System.Drawing.Point(156, 184);
            this.lblPublicacion.Name = "lblPublicacion";
            this.lblPublicacion.Size = new System.Drawing.Size(197, 25);
            this.lblPublicacion.TabIndex = 11;
            this.lblPublicacion.Text = "Fecha de publicación";
            // 
            // lblVencimiento
            // 
            this.lblVencimiento.AutoSize = true;
            this.lblVencimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVencimiento.Location = new System.Drawing.Point(156, 270);
            this.lblVencimiento.Name = "lblVencimiento";
            this.lblVencimiento.Size = new System.Drawing.Size(203, 25);
            this.lblVencimiento.TabIndex = 12;
            this.lblVencimiento.Text = "Fecha de vencimiento";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(156, 510);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(62, 25);
            this.lblStock.TabIndex = 13;
            this.lblStock.Text = "Stock";
            // 
            // lblMaxima
            // 
            this.lblMaxima.AutoSize = true;
            this.lblMaxima.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxima.Location = new System.Drawing.Point(156, 602);
            this.lblMaxima.Name = "lblMaxima";
            this.lblMaxima.Size = new System.Drawing.Size(377, 25);
            this.lblMaxima.TabIndex = 14;
            this.lblMaxima.Text = "Cantidad Maxima de productos por cliente";
            // 
            // CrearOferta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(786, 915);
            this.Controls.Add(this.lblMaxima);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblVencimiento);
            this.Controls.Add(this.lblPublicacion);
            this.Controls.Add(this.nudMaxima);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nudStock);
            this.Controls.Add(this.dtpVencimiento);
            this.Controls.Add(this.dtpPublicacion);
            this.Controls.Add(this.tbPrecioOferta);
            this.Controls.Add(this.tbPrecioLista);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label1);
            this.Name = "CrearOferta";
            this.Text = "OfertaNueva";
            this.Load += new System.EventHandler(this.CrearOferta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxima)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox tbPrecioLista;
        private System.Windows.Forms.TextBox tbPrecioOferta;
        private System.Windows.Forms.DateTimePicker dtpPublicacion;
        private System.Windows.Forms.DateTimePicker dtpVencimiento;
        private System.Windows.Forms.NumericUpDown nudStock;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown nudMaxima;
        private System.Windows.Forms.Label lblPublicacion;
        private System.Windows.Forms.Label lblVencimiento;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblMaxima;
    }
}