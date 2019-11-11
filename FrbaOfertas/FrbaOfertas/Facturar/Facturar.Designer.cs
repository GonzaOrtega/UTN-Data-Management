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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Facturar));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.txtCuit = new System.Windows.Forms.TextBox();
            this.cOMPRABindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.cOMPRABindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cOMPRADataGridView = new System.Windows.Forms.DataGridView();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.btnVer = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.cOMPRABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD2C2019DataSet = new FrbaOfertas.GD2C2019DataSet();
            this.cOMPRATableAdapter = new FrbaOfertas.GD2C2019DataSetTableAdapters.COMPRATableAdapter();
            this.tableAdapterManager = new FrbaOfertas.GD2C2019DataSetTableAdapters.TableAdapterManager();
            this.proveedorTableAdapter1 = new FrbaOfertas.GD2C2019DataSetTableAdapters.PROVEEDORTableAdapter();
            this.compraTableAdapter1 = new FrbaOfertas.GD2C2019DataSetTableAdapters.COMPRATableAdapter();
            this.ofertasTableAdapter1 = new FrbaOfertas.GD2C2019DataSetTableAdapters.OFERTASTableAdapter();
            this.Codigo_oferta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad_compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPRABindingNavigator)).BeginInit();
            this.cOMPRABindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPRADataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPRABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2019DataSet)).BeginInit();
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
            this.txtRazonSocial.Click += new System.EventHandler(this.txtRazonSocial_Click);
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
            this.txtCuit.Click += new System.EventHandler(this.txtCuit_Click);
            this.txtCuit.Leave += new System.EventHandler(this.txtCuit_Leave);
            // 
            // cOMPRABindingNavigator
            // 
            this.cOMPRABindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cOMPRABindingNavigator.BindingSource = this.cOMPRABindingSource;
            this.cOMPRABindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cOMPRABindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cOMPRABindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cOMPRABindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.cOMPRABindingNavigatorSaveItem});
            this.cOMPRABindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cOMPRABindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cOMPRABindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cOMPRABindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cOMPRABindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cOMPRABindingNavigator.Name = "cOMPRABindingNavigator";
            this.cOMPRABindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cOMPRABindingNavigator.Size = new System.Drawing.Size(991, 31);
            this.cOMPRABindingNavigator.TabIndex = 2;
            this.cOMPRABindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 28);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
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
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // cOMPRABindingNavigatorSaveItem
            // 
            this.cOMPRABindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cOMPRABindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cOMPRABindingNavigatorSaveItem.Image")));
            this.cOMPRABindingNavigatorSaveItem.Name = "cOMPRABindingNavigatorSaveItem";
            this.cOMPRABindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.cOMPRABindingNavigatorSaveItem.Text = "Guardar datos";
            this.cOMPRABindingNavigatorSaveItem.Click += new System.EventHandler(this.cOMPRABindingNavigatorSaveItem_Click);
            // 
            // cOMPRADataGridView
            // 
            this.cOMPRADataGridView.AutoGenerateColumns = false;
            this.cOMPRADataGridView.BackgroundColor = System.Drawing.Color.YellowGreen;
            this.cOMPRADataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cOMPRADataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo_oferta,
            this.DNI_cliente,
            this.Cantidad_compra,
            this.Fecha_compra});
            this.cOMPRADataGridView.DataSource = this.cOMPRABindingSource;
            this.cOMPRADataGridView.GridColor = System.Drawing.Color.DarkOliveGreen;
            this.cOMPRADataGridView.Location = new System.Drawing.Point(29, 244);
            this.cOMPRADataGridView.Name = "cOMPRADataGridView";
            this.cOMPRADataGridView.RowHeadersWidth = 51;
            this.cOMPRADataGridView.RowTemplate.Height = 24;
            this.cOMPRADataGridView.Size = new System.Drawing.Size(555, 209);
            this.cOMPRADataGridView.TabIndex = 3;
            // 
            // btnFacturar
            // 
            this.btnFacturar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturar.Location = new System.Drawing.Point(682, 331);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(227, 53);
            this.btnFacturar.TabIndex = 4;
            this.btnFacturar.Text = "FACTURAR";
            this.btnFacturar.UseVisualStyleBackColor = true;
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click);
            // 
            // btnVer
            // 
            this.btnVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVer.Location = new System.Drawing.Point(682, 244);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(227, 53);
            this.btnVer.TabIndex = 5;
            this.btnVer.Text = "VER COMPRAS";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Location = new System.Drawing.Point(682, 407);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(227, 46);
            this.btnAtras.TabIndex = 6;
            this.btnAtras.Text = "ATRÁS";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // cOMPRABindingSource
            // 
            this.cOMPRABindingSource.DataMember = "COMPRA";
            this.cOMPRABindingSource.DataSource = this.gD2C2019DataSet;
            // 
            // gD2C2019DataSet
            // 
            this.gD2C2019DataSet.DataSetName = "GD2C2019DataSet";
            this.gD2C2019DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cOMPRATableAdapter
            // 
            this.cOMPRATableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CARGATableAdapter = null;
            this.tableAdapterManager.CLIENTESTableAdapter = null;
            this.tableAdapterManager.COMPRATableAdapter = this.cOMPRATableAdapter;
            this.tableAdapterManager.CUPONTableAdapter = null;
            this.tableAdapterManager.FACTURATableAdapter = null;
            this.tableAdapterManager.FUNCIONALIDADTableAdapter = null;
            this.tableAdapterManager.MaestraTableAdapter = null;
            this.tableAdapterManager.OFERTASTableAdapter = null;
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
            // proveedorTableAdapter1
            // 
            this.proveedorTableAdapter1.ClearBeforeFill = true;
            // 
            // compraTableAdapter1
            // 
            this.compraTableAdapter1.ClearBeforeFill = true;
            // 
            // ofertasTableAdapter1
            // 
            this.ofertasTableAdapter1.ClearBeforeFill = true;
            // 
            // Codigo_oferta
            // 
            this.Codigo_oferta.DataPropertyName = "Codigo_oferta";
            this.Codigo_oferta.HeaderText = "Codigo_oferta";
            this.Codigo_oferta.MinimumWidth = 6;
            this.Codigo_oferta.Name = "Codigo_oferta";
            this.Codigo_oferta.Width = 125;
            // 
            // DNI_cliente
            // 
            this.DNI_cliente.DataPropertyName = "DNI_cliente";
            this.DNI_cliente.HeaderText = "DNI_cliente";
            this.DNI_cliente.MinimumWidth = 6;
            this.DNI_cliente.Name = "DNI_cliente";
            this.DNI_cliente.Width = 125;
            // 
            // Cantidad_compra
            // 
            this.Cantidad_compra.DataPropertyName = "Cantidad_compra";
            this.Cantidad_compra.HeaderText = "Cantidad_compra";
            this.Cantidad_compra.MinimumWidth = 6;
            this.Cantidad_compra.Name = "Cantidad_compra";
            this.Cantidad_compra.Width = 125;
            // 
            // Fecha_compra
            // 
            this.Fecha_compra.DataPropertyName = "Fecha_compra";
            this.Fecha_compra.HeaderText = "Fecha_compra";
            this.Fecha_compra.MinimumWidth = 6;
            this.Fecha_compra.Name = "Fecha_compra";
            this.Fecha_compra.Width = 125;
            // 
            // Facturar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(991, 476);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.btnFacturar);
            this.Controls.Add(this.cOMPRADataGridView);
            this.Controls.Add(this.cOMPRABindingNavigator);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Name = "Facturar";
            this.Text = "Facturar";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPRABindingNavigator)).EndInit();
            this.cOMPRABindingNavigator.ResumeLayout(false);
            this.cOMPRABindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPRADataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPRABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2019DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private GD2C2019DataSet gD2C2019DataSet;
        private System.Windows.Forms.BindingSource cOMPRABindingSource;
        private GD2C2019DataSetTableAdapters.COMPRATableAdapter cOMPRATableAdapter;
        private GD2C2019DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cOMPRABindingNavigator;
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
        private System.Windows.Forms.ToolStripButton cOMPRABindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView cOMPRADataGridView;
        private System.Windows.Forms.Button btnFacturar;
        private System.Windows.Forms.Button btnVer;
        private GD2C2019DataSetTableAdapters.PROVEEDORTableAdapter proveedorTableAdapter1;
        private System.Windows.Forms.Button btnAtras;
        private GD2C2019DataSetTableAdapters.COMPRATableAdapter compraTableAdapter1;
        private GD2C2019DataSetTableAdapters.OFERTASTableAdapter ofertasTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_oferta;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad_compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_compra;
    }
}