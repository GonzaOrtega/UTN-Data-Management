namespace FrbaOfertas.AbmCliente
{
    partial class ABMCLiente
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.rbCrearCliente = new System.Windows.Forms.RadioButton();
            this.rbModificarClientes = new System.Windows.Forms.RadioButton();
            this.rbEliminarClientes = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(188, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "Siguiente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 255);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 38);
            this.button2.TabIndex = 4;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // rbCrearCliente
            // 
            this.rbCrearCliente.AutoSize = true;
            this.rbCrearCliente.Location = new System.Drawing.Point(38, 41);
            this.rbCrearCliente.Name = "rbCrearCliente";
            this.rbCrearCliente.Size = new System.Drawing.Size(123, 24);
            this.rbCrearCliente.TabIndex = 5;
            this.rbCrearCliente.TabStop = true;
            this.rbCrearCliente.Text = "Crear cliente";
            this.rbCrearCliente.UseVisualStyleBackColor = true;
            this.rbCrearCliente.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbModificarClientes
            // 
            this.rbModificarClientes.AutoSize = true;
            this.rbModificarClientes.Location = new System.Drawing.Point(38, 108);
            this.rbModificarClientes.Name = "rbModificarClientes";
            this.rbModificarClientes.Size = new System.Drawing.Size(156, 24);
            this.rbModificarClientes.TabIndex = 6;
            this.rbModificarClientes.TabStop = true;
            this.rbModificarClientes.Text = "Modificar clientes";
            this.rbModificarClientes.UseVisualStyleBackColor = true;
            // 
            // rbEliminarClientes
            // 
            this.rbEliminarClientes.AutoSize = true;
            this.rbEliminarClientes.Location = new System.Drawing.Point(38, 182);
            this.rbEliminarClientes.Name = "rbEliminarClientes";
            this.rbEliminarClientes.Size = new System.Drawing.Size(148, 24);
            this.rbEliminarClientes.TabIndex = 7;
            this.rbEliminarClientes.TabStop = true;
            this.rbEliminarClientes.Text = "Eliminar clientes";
            this.rbEliminarClientes.UseVisualStyleBackColor = true;
            // 
            // ABMCLiente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 305);
            this.Controls.Add(this.rbEliminarClientes);
            this.Controls.Add(this.rbModificarClientes);
            this.Controls.Add(this.rbCrearCliente);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "ABMCLiente";
            this.Text = "ABMCLiente";
            this.Load += new System.EventHandler(this.ABMCLiente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton rbCrearCliente;
        private System.Windows.Forms.RadioButton rbModificarClientes;
        private System.Windows.Forms.RadioButton rbEliminarClientes;
    }
}