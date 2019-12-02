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
            this.lblCrea = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtPrecioLista = new System.Windows.Forms.TextBox();
            this.txtPrecioOferta = new System.Windows.Forms.TextBox();
            this.dtpPublicacion = new System.Windows.Forms.DateTimePicker();
            this.dtpVencimiento = new System.Windows.Forms.DateTimePicker();
            this.ndStock = new System.Windows.Forms.NumericUpDown();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.ndMaxima = new System.Windows.Forms.NumericUpDown();
            this.lblPublicacion = new System.Windows.Forms.Label();
            this.lblVencimiento = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblMaxima = new System.Windows.Forms.Label();
            this.oFERTASTableAdapter = new FrbaOfertas.GD2C2019DataSetTableAdapters.OFERTASTableAdapter();
            this.tableAdapterManager = new FrbaOfertas.GD2C2019DataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.ndStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndMaxima)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCrea
            // 
            this.lblCrea.AutoSize = true;
            this.lblCrea.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrea.Location = new System.Drawing.Point(225, 39);
            this.lblCrea.Name = "lblCrea";
            this.lblCrea.Size = new System.Drawing.Size(341, 38);
            this.lblCrea.TabIndex = 0;
            this.lblCrea.Text = "Crea una nueva oferta";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtDescripcion.Location = new System.Drawing.Point(161, 123);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(477, 34);
            this.txtDescripcion.TabIndex = 1;
            this.txtDescripcion.Text = "Descripción";
            this.txtDescripcion.Enter += new System.EventHandler(this.txtDescripcion_Enter);
            this.txtDescripcion.Leave += new System.EventHandler(this.txtDescripcion_Leave);
            // 
            // txtPrecioLista
            // 
            this.txtPrecioLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioLista.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtPrecioLista.Location = new System.Drawing.Point(160, 445);
            this.txtPrecioLista.Name = "txtPrecioLista";
            this.txtPrecioLista.Size = new System.Drawing.Size(477, 34);
            this.txtPrecioLista.TabIndex = 2;
            this.txtPrecioLista.Text = "Precio de lista";
            this.txtPrecioLista.Enter += new System.EventHandler(this.txtPrecioLista_Enter);
            this.txtPrecioLista.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPrecioLista_KeyPress);
            this.txtPrecioLista.Leave += new System.EventHandler(this.txtPrecioLista_Leave);
            // 
            // txtPrecioOferta
            // 
            this.txtPrecioOferta.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioOferta.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtPrecioOferta.Location = new System.Drawing.Point(160, 370);
            this.txtPrecioOferta.Name = "txtPrecioOferta";
            this.txtPrecioOferta.Size = new System.Drawing.Size(477, 34);
            this.txtPrecioOferta.TabIndex = 3;
            this.txtPrecioOferta.Text = "Precio de oferta";
            this.txtPrecioOferta.Enter += new System.EventHandler(this.txtPrecioOferta_Enter);
            this.txtPrecioOferta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPrecioOferta_KeyPress);
            this.txtPrecioOferta.Leave += new System.EventHandler(this.txtPrecioOferta_Leave);
            // 
            // dtpPublicacion
            // 
            this.dtpPublicacion.CalendarMonthBackground = System.Drawing.Color.OliveDrab;
            this.dtpPublicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPublicacion.Location = new System.Drawing.Point(161, 212);
            this.dtpPublicacion.Name = "dtpPublicacion";
            this.dtpPublicacion.Size = new System.Drawing.Size(477, 34);
            this.dtpPublicacion.TabIndex = 4;
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
            // ndStock
            // 
            this.ndStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ndStock.Location = new System.Drawing.Point(160, 538);
            this.ndStock.Name = "ndStock";
            this.ndStock.Size = new System.Drawing.Size(477, 34);
            this.ndStock.TabIndex = 7;
            // 
            // btnAtras
            // 
            this.btnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Location = new System.Drawing.Point(160, 708);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(199, 43);
            this.btnAtras.TabIndex = 8;
            this.btnAtras.Text = "ATRÁS";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.Location = new System.Drawing.Point(438, 708);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(199, 43);
            this.btnCrear.TabIndex = 9;
            this.btnCrear.Text = "CREAR";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // ndMaxima
            // 
            this.ndMaxima.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ndMaxima.Location = new System.Drawing.Point(160, 630);
            this.ndMaxima.Name = "ndMaxima";
            this.ndMaxima.Size = new System.Drawing.Size(477, 34);
            this.ndMaxima.TabIndex = 10;
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
            // oFERTASTableAdapter
            // 
            this.oFERTASTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CARGATableAdapter = null;
            this.tableAdapterManager.CLIENTESTableAdapter = null;
            this.tableAdapterManager.COMPRATableAdapter = null;
            this.tableAdapterManager.CUPONTableAdapter = null;
            this.tableAdapterManager.FACTURATableAdapter = null;
            this.tableAdapterManager.FUNCIONALIDADTableAdapter = null;
            this.tableAdapterManager.ITEM_FACTURATableAdapter = null;
            this.tableAdapterManager.MaestraTableAdapter = null;
            this.tableAdapterManager.OFERTASTableAdapter = this.oFERTASTableAdapter;
            this.tableAdapterManager.PROVEEDORTableAdapter = null;
            this.tableAdapterManager.ROL_FUNCIONALIDADTableAdapter = null;
            this.tableAdapterManager.ROLTableAdapter = null;
            this.tableAdapterManager.RUBROTableAdapter = null;
            this.tableAdapterManager.TARJETATableAdapter = null;
            this.tableAdapterManager.TIPO_USUARIOTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = FrbaOfertas.GD2C2019DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USUARIO_ROLTableAdapter = null;
            this.tableAdapterManager.USUARIOTableAdapter = null;
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
            this.Controls.Add(this.ndMaxima);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.ndStock);
            this.Controls.Add(this.dtpVencimiento);
            this.Controls.Add(this.dtpPublicacion);
            this.Controls.Add(this.txtPrecioOferta);
            this.Controls.Add(this.txtPrecioLista);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblCrea);
            this.Name = "CrearOferta";
            this.Text = "OfertaNueva";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CrearOferta_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ndStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndMaxima)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCrea;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtPrecioLista;
        private System.Windows.Forms.TextBox txtPrecioOferta;
        private System.Windows.Forms.DateTimePicker dtpPublicacion;
        private System.Windows.Forms.DateTimePicker dtpVencimiento;
        private System.Windows.Forms.NumericUpDown ndStock;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.NumericUpDown ndMaxima;
        private System.Windows.Forms.Label lblPublicacion;
        private System.Windows.Forms.Label lblVencimiento;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblMaxima;
        private GD2C2019DataSetTableAdapters.OFERTASTableAdapter oFERTASTableAdapter;
        private GD2C2019DataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}