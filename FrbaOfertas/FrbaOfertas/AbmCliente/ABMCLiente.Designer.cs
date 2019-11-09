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
            this.cbCrearCliente = new System.Windows.Forms.CheckBox();
            this.cbBorrarCliente = new System.Windows.Forms.CheckBox();
            this.cbModificarCliente = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbCrearCliente
            // 
            this.cbCrearCliente.AutoSize = true;
            this.cbCrearCliente.Location = new System.Drawing.Point(42, 30);
            this.cbCrearCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCrearCliente.Name = "cbCrearCliente";
            this.cbCrearCliente.Size = new System.Drawing.Size(110, 21);
            this.cbCrearCliente.TabIndex = 0;
            this.cbCrearCliente.Text = "Crear cliente";
            this.cbCrearCliente.UseVisualStyleBackColor = true;
            // 
            // cbBorrarCliente
            // 
            this.cbBorrarCliente.AutoSize = true;
            this.cbBorrarCliente.Location = new System.Drawing.Point(42, 146);
            this.cbBorrarCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbBorrarCliente.Name = "cbBorrarCliente";
            this.cbBorrarCliente.Size = new System.Drawing.Size(115, 21);
            this.cbBorrarCliente.TabIndex = 1;
            this.cbBorrarCliente.Text = "Borrar cliente";
            this.cbBorrarCliente.UseVisualStyleBackColor = true;
            // 
            // cbModificarCliente
            // 
            this.cbModificarCliente.AutoSize = true;
            this.cbModificarCliente.Location = new System.Drawing.Point(42, 88);
            this.cbModificarCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbModificarCliente.Name = "cbModificarCliente";
            this.cbModificarCliente.Size = new System.Drawing.Size(132, 21);
            this.cbModificarCliente.TabIndex = 2;
            this.cbModificarCliente.Text = "Modificar cliente";
            this.cbModificarCliente.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(167, 204);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "Siguiente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(11, 204);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 30);
            this.button2.TabIndex = 4;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ABMCLiente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 244);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbModificarCliente);
            this.Controls.Add(this.cbBorrarCliente);
            this.Controls.Add(this.cbCrearCliente);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ABMCLiente";
            this.Text = "ABMCLiente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbCrearCliente;
        private System.Windows.Forms.CheckBox cbBorrarCliente;
        private System.Windows.Forms.CheckBox cbModificarCliente;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}