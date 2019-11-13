namespace FrbaOfertas.AbmRol
{
    partial class AbmRol
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbHabilitado = new System.Windows.Forms.ComboBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.roL_FUNCIONALIDADTableAdapter1 = new FrbaOfertas.GD2C2019DataSetTableAdapters.ROL_FUNCIONALIDADTableAdapter();
            this.rolTableAdapter1 = new FrbaOfertas.GD2C2019DataSetTableAdapters.ROLTableAdapter();
            this.Nombre_rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion_funcionalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Habilitado_rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar_rol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre_rol,
            this.Descripcion_funcionalidad,
            this.Habilitado_rol,
            this.Eliminar_rol,
            this.Editar});
            this.dataGridView1.Location = new System.Drawing.Point(60, 283);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(769, 226);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbHabilitado);
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(60, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(769, 181);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de busqueda";
            // 
            // cbHabilitado
            // 
            this.cbHabilitado.FormattingEnabled = true;
            this.cbHabilitado.Items.AddRange(new object[] {
            "Habilitados",
            "Deshabilitados",
            "Ambos"});
            this.cbHabilitado.Location = new System.Drawing.Point(23, 114);
            this.cbHabilitado.Name = "cbHabilitado";
            this.cbHabilitado.Size = new System.Drawing.Size(235, 37);
            this.cbHabilitado.TabIndex = 2;
            this.cbHabilitado.Text = "Ambos";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtDescripcion.Location = new System.Drawing.Point(301, 50);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(344, 34);
            this.txtDescripcion.TabIndex = 1;
            this.txtDescripcion.Text = "Descripción de la funcionalidad";
            this.txtDescripcion.Click += new System.EventHandler(this.txtDescripcion_Click);
            this.txtDescripcion.Leave += new System.EventHandler(this.txtDescripcion_Leave);
            // 
            // txtNombre
            // 
            this.txtNombre.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtNombre.Location = new System.Drawing.Point(23, 50);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(235, 34);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.Text = "Nombre del rol";
            this.txtNombre.Click += new System.EventHandler(this.txtNombre_Click);
            this.txtNombre.Leave += new System.EventHandler(this.txtNombre_Leave);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(846, 327);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(161, 41);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(846, 374);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(161, 41);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.Location = new System.Drawing.Point(846, 421);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(161, 41);
            this.btnCrear.TabIndex = 5;
            this.btnCrear.Text = "CREAR";
            this.btnCrear.UseVisualStyleBackColor = true;
            // 
            // btnAtras
            // 
            this.btnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Location = new System.Drawing.Point(846, 468);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(161, 41);
            this.btnAtras.TabIndex = 8;
            this.btnAtras.Text = "ATRÁS";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // roL_FUNCIONALIDADTableAdapter1
            // 
            this.roL_FUNCIONALIDADTableAdapter1.ClearBeforeFill = true;
            // 
            // rolTableAdapter1
            // 
            this.rolTableAdapter1.ClearBeforeFill = true;
            // 
            // Nombre_rol
            // 
            this.Nombre_rol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Nombre_rol.HeaderText = "Nombre_rol";
            this.Nombre_rol.MinimumWidth = 6;
            this.Nombre_rol.Name = "Nombre_rol";
            this.Nombre_rol.ReadOnly = true;
            this.Nombre_rol.ToolTipText = "NOMBRE";
            this.Nombre_rol.Width = 111;
            // 
            // Descripcion_funcionalidad
            // 
            this.Descripcion_funcionalidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Descripcion_funcionalidad.HeaderText = "Descripcion_funcionalidad";
            this.Descripcion_funcionalidad.MinimumWidth = 6;
            this.Descripcion_funcionalidad.Name = "Descripcion_funcionalidad";
            this.Descripcion_funcionalidad.ReadOnly = true;
            this.Descripcion_funcionalidad.ToolTipText = "DESCRIPCIÓN";
            this.Descripcion_funcionalidad.Width = 203;
            // 
            // Habilitado_rol
            // 
            this.Habilitado_rol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Habilitado_rol.HeaderText = "Habilitado_rol";
            this.Habilitado_rol.MinimumWidth = 6;
            this.Habilitado_rol.Name = "Habilitado_rol";
            this.Habilitado_rol.ReadOnly = true;
            this.Habilitado_rol.ToolTipText = "HABILITAR";
            this.Habilitado_rol.Width = 124;
            // 
            // Eliminar_rol
            // 
            this.Eliminar_rol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.NullValue = "X";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.Eliminar_rol.DefaultCellStyle = dataGridViewCellStyle2;
            this.Eliminar_rol.HeaderText = "Eleminar_rol";
            this.Eliminar_rol.MinimumWidth = 6;
            this.Eliminar_rol.Name = "Eliminar_rol";
            this.Eliminar_rol.ReadOnly = true;
            this.Eliminar_rol.Text = "Eliminar";
            this.Eliminar_rol.ToolTipText = "BORRAR";
            this.Eliminar_rol.Width = 93;
            // 
            // Editar
            // 
            this.Editar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = "Editar";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightCoral;
            this.Editar.DefaultCellStyle = dataGridViewCellStyle3;
            this.Editar.HeaderText = "Editar";
            this.Editar.MinimumWidth = 6;
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Text = "Editar";
            this.Editar.ToolTipText = "EDITAR";
            this.Editar.Width = 51;
            // 
            // AbmRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(1049, 540);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AbmRol";
            this.Text = "ROLES";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AbmRol_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cbHabilitado;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnAtras;
        private GD2C2019DataSetTableAdapters.ROL_FUNCIONALIDADTableAdapter roL_FUNCIONALIDADTableAdapter1;
        private GD2C2019DataSetTableAdapters.ROLTableAdapter rolTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion_funcionalidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Habilitado_rol;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar_rol;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
    }
}