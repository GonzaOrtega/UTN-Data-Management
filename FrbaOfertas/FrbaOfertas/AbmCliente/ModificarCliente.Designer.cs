namespace FrbaOfertas.AbmCliente
{
    partial class ModificarCliente
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEmailTLibre = new System.Windows.Forms.TextBox();
            this.txtDNIPExacta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtApellidoTLibre = new System.Windows.Forms.TextBox();
            this.txtNombreTLibre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.planillaModificarCliente = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.cLIENTESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD2C2019DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD2C2019DataSet = new FrbaOfertas.GD2C2019DataSet();
            this.cLIENTESTableAdapter = new FrbaOfertas.GD2C2019DataSetTableAdapters.CLIENTESTableAdapter();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.labelOpcionEliminar = new System.Windows.Forms.Label();
            this.txtNroClienteAEliminar = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.planillaModificarCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2019DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2019DataSet)).BeginInit();
            this.SuspendLayout();
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
            this.groupBox1.Location = new System.Drawing.Point(23, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(611, 158);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de busqueda";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtEmailTLibre
            // 
            this.txtEmailTLibre.Location = new System.Drawing.Point(413, 97);
            this.txtEmailTLibre.Name = "txtEmailTLibre";
            this.txtEmailTLibre.Size = new System.Drawing.Size(146, 26);
            this.txtEmailTLibre.TabIndex = 8;
            this.txtEmailTLibre.TextChanged += new System.EventHandler(this.txtEmailTLibre_TextChanged);
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
            // planillaModificarCliente
            // 
            this.planillaModificarCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.planillaModificarCliente.Location = new System.Drawing.Point(23, 244);
            this.planillaModificarCliente.Name = "planillaModificarCliente";
            this.planillaModificarCliente.RowHeadersWidth = 62;
            this.planillaModificarCliente.RowTemplate.Height = 28;
            this.planillaModificarCliente.Size = new System.Drawing.Size(611, 230);
            this.planillaModificarCliente.TabIndex = 1;
            this.planillaModificarCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(547, 191);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 35);
            this.button2.TabIndex = 3;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(547, 549);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(87, 35);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.button3_Click);
            // 
            // cLIENTESBindingSource
            // 
            this.cLIENTESBindingSource.DataMember = "CLIENTES";
            this.cLIENTESBindingSource.DataSource = this.gD2C2019DataSetBindingSource;
            // 
            // gD2C2019DataSetBindingSource
            // 
            this.gD2C2019DataSetBindingSource.DataSource = this.gD2C2019DataSet;
            this.gD2C2019DataSetBindingSource.Position = 0;
            // 
            // gD2C2019DataSet
            // 
            this.gD2C2019DataSet.DataSetName = "GD2C2019DataSet";
            this.gD2C2019DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cLIENTESTableAdapter
            // 
            this.cLIENTESTableAdapter.ClearBeforeFill = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(23, 549);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(87, 35);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(436, 549);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(87, 35);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // labelOpcionEliminar
            // 
            this.labelOpcionEliminar.AutoSize = true;
            this.labelOpcionEliminar.Location = new System.Drawing.Point(19, 498);
            this.labelOpcionEliminar.Name = "labelOpcionEliminar";
            this.labelOpcionEliminar.Size = new System.Drawing.Size(280, 20);
            this.labelOpcionEliminar.TabIndex = 7;
            this.labelOpcionEliminar.Text = "Ingrese el numero de cliente a eliminar";
            // 
            // txtNroClienteAEliminar
            // 
            this.txtNroClienteAEliminar.Location = new System.Drawing.Point(436, 498);
            this.txtNroClienteAEliminar.Name = "txtNroClienteAEliminar";
            this.txtNroClienteAEliminar.Size = new System.Drawing.Size(146, 26);
            this.txtNroClienteAEliminar.TabIndex = 9;
            // 
            // ModificarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 604);
            this.Controls.Add(this.txtNroClienteAEliminar);
            this.Controls.Add(this.labelOpcionEliminar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.planillaModificarCliente);
            this.Controls.Add(this.groupBox1);
            this.Name = "ModificarCliente";
            this.Text = "Seleccione cliente";
            this.Load += new System.EventHandler(this.ModificarUsuario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.planillaModificarCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2019DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2019DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtApellidoTLibre;
        private System.Windows.Forms.TextBox txtNombreTLibre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView planillaModificarCliente;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.BindingSource gD2C2019DataSetBindingSource;
        private GD2C2019DataSet gD2C2019DataSet;
        private System.Windows.Forms.BindingSource cLIENTESBindingSource;
        private GD2C2019DataSetTableAdapters.CLIENTESTableAdapter cLIENTESTableAdapter;
        private System.Windows.Forms.TextBox txtEmailTLibre;
        private System.Windows.Forms.TextBox txtDNIPExacta;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label labelOpcionEliminar;
        private System.Windows.Forms.TextBox txtNroClienteAEliminar;
    }
}