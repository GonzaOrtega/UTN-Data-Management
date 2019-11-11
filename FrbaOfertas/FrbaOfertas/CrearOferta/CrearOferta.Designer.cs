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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearOferta));
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtPrecioLista = new System.Windows.Forms.TextBox();
            this.txtPrecioOferta = new System.Windows.Forms.TextBox();
            this.dtpPublicacion = new System.Windows.Forms.DateTimePicker();
            this.dtpVencimiento = new System.Windows.Forms.DateTimePicker();
            this.nudStock = new System.Windows.Forms.NumericUpDown();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.nudMaxima = new System.Windows.Forms.NumericUpDown();
            this.lblPublicacion = new System.Windows.Forms.Label();
            this.lblVencimiento = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblMaxima = new System.Windows.Forms.Label();
            this.gD2C2019DataSet = new FrbaOfertas.GD2C2019DataSet();
            this.oFERTASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oFERTASTableAdapter = new FrbaOfertas.GD2C2019DataSetTableAdapters.OFERTASTableAdapter();
            this.tableAdapterManager = new FrbaOfertas.GD2C2019DataSetTableAdapters.TableAdapterManager();
            this.oFERTASBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.oFERTASBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.nudStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxima)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2019DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oFERTASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oFERTASBindingNavigator)).BeginInit();
            this.oFERTASBindingNavigator.SuspendLayout();
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
            this.txtDescripcion.Text = "Descripción";
            this.txtDescripcion.Click += new System.EventHandler(this.txtDescripcion_Click);
            this.txtDescripcion.Leave += new System.EventHandler(this.txtDescripcion_Leave);
            // 
            // txtPrecioLista
            // 
            this.txtPrecioLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioLista.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPrecioLista.Location = new System.Drawing.Point(160, 445);
            this.txtPrecioLista.Name = "txtPrecioLista";
            this.txtPrecioLista.Size = new System.Drawing.Size(477, 34);
            this.txtPrecioLista.TabIndex = 2;
            this.txtPrecioLista.Text = "Precio de lista";
            this.txtPrecioLista.Click += new System.EventHandler(this.txtPrecioLista_Click);
            this.txtPrecioLista.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPrecioLista_KeyPress);
            this.txtPrecioLista.Leave += new System.EventHandler(this.txtPrecioLista_Leave);
            // 
            // txtPrecioOferta
            // 
            this.txtPrecioOferta.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioOferta.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPrecioOferta.Location = new System.Drawing.Point(160, 370);
            this.txtPrecioOferta.Name = "txtPrecioOferta";
            this.txtPrecioOferta.Size = new System.Drawing.Size(477, 34);
            this.txtPrecioOferta.TabIndex = 3;
            this.txtPrecioOferta.Text = "Precio de oferta";
            this.txtPrecioOferta.Click += new System.EventHandler(this.tbPrecioOferta_Click);
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
            // nudStock
            // 
            this.nudStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudStock.Location = new System.Drawing.Point(160, 538);
            this.nudStock.Name = "nudStock";
            this.nudStock.Size = new System.Drawing.Size(477, 34);
            this.nudStock.TabIndex = 7;
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
            // gD2C2019DataSet
            // 
            this.gD2C2019DataSet.DataSetName = "GD2C2019DataSet";
            this.gD2C2019DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oFERTASBindingSource
            // 
            this.oFERTASBindingSource.DataMember = "OFERTAS";
            this.oFERTASBindingSource.DataSource = this.gD2C2019DataSet;
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
            // oFERTASBindingNavigator
            // 
            this.oFERTASBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.oFERTASBindingNavigator.BindingSource = this.oFERTASBindingSource;
            this.oFERTASBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.oFERTASBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.oFERTASBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.oFERTASBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.oFERTASBindingNavigatorSaveItem});
            this.oFERTASBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.oFERTASBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.oFERTASBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.oFERTASBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.oFERTASBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.oFERTASBindingNavigator.Name = "oFERTASBindingNavigator";
            this.oFERTASBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.oFERTASBindingNavigator.Size = new System.Drawing.Size(786, 27);
            this.oFERTASBindingNavigator.TabIndex = 15;
            this.oFERTASBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // oFERTASBindingNavigatorSaveItem
            // 
            this.oFERTASBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.oFERTASBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("oFERTASBindingNavigatorSaveItem.Image")));
            this.oFERTASBindingNavigatorSaveItem.Name = "oFERTASBindingNavigatorSaveItem";
            this.oFERTASBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.oFERTASBindingNavigatorSaveItem.Text = "Guardar datos";
            this.oFERTASBindingNavigatorSaveItem.Click += new System.EventHandler(this.oFERTASBindingNavigatorSaveItem_Click);
            // 
            // CrearOferta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(786, 915);
            this.Controls.Add(this.oFERTASBindingNavigator);
            this.Controls.Add(this.lblMaxima);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblVencimiento);
            this.Controls.Add(this.lblPublicacion);
            this.Controls.Add(this.nudMaxima);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.nudStock);
            this.Controls.Add(this.dtpVencimiento);
            this.Controls.Add(this.dtpPublicacion);
            this.Controls.Add(this.txtPrecioOferta);
            this.Controls.Add(this.txtPrecioLista);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label1);
            this.Name = "CrearOferta";
            this.Text = "OfertaNueva";
            this.Load += new System.EventHandler(this.CrearOferta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxima)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2019DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oFERTASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oFERTASBindingNavigator)).EndInit();
            this.oFERTASBindingNavigator.ResumeLayout(false);
            this.oFERTASBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtPrecioLista;
        private System.Windows.Forms.TextBox txtPrecioOferta;
        private System.Windows.Forms.DateTimePicker dtpPublicacion;
        private System.Windows.Forms.DateTimePicker dtpVencimiento;
        private System.Windows.Forms.NumericUpDown nudStock;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.NumericUpDown nudMaxima;
        private System.Windows.Forms.Label lblPublicacion;
        private System.Windows.Forms.Label lblVencimiento;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblMaxima;
        private GD2C2019DataSet gD2C2019DataSet;
        private System.Windows.Forms.BindingSource oFERTASBindingSource;
        private GD2C2019DataSetTableAdapters.OFERTASTableAdapter oFERTASTableAdapter;
        private GD2C2019DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator oFERTASBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton oFERTASBindingNavigatorSaveItem;
    }
}