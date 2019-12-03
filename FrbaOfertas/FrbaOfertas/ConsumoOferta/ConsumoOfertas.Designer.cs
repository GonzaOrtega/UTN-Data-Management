namespace FrbaOfertas.ConsumoOferta
{
    partial class ConsumoOfertas
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
            this.txtNroCuponIngresado = new System.Windows.Forms.TextBox();
            this.btnCanjear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtDNICliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese Nro de cupon";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNroCuponIngresado
            // 
            this.txtNroCuponIngresado.Location = new System.Drawing.Point(404, 35);
            this.txtNroCuponIngresado.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtNroCuponIngresado.Name = "txtNroCuponIngresado";
            this.txtNroCuponIngresado.Size = new System.Drawing.Size(225, 30);
            this.txtNroCuponIngresado.TabIndex = 1;
            // 
            // btnCanjear
            // 
            this.btnCanjear.Location = new System.Drawing.Point(477, 160);
            this.btnCanjear.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnCanjear.Name = "btnCanjear";
            this.btnCanjear.Size = new System.Drawing.Size(152, 51);
            this.btnCanjear.TabIndex = 2;
            this.btnCanjear.Text = "Canjear";
            this.btnCanjear.UseVisualStyleBackColor = true;
            this.btnCanjear.Click += new System.EventHandler(this.btnCanjear_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(45, 160);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 51);
            this.button1.TabIndex = 3;
            this.button1.Text = "Atras";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDNICliente
            // 
            this.txtDNICliente.Location = new System.Drawing.Point(404, 100);
            this.txtDNICliente.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtDNICliente.Name = "txtDNICliente";
            this.txtDNICliente.Size = new System.Drawing.Size(225, 30);
            this.txtDNICliente.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ingrese DNI Cliente";
            // 
            // ConsumoOfertas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(714, 268);
            this.Controls.Add(this.txtDNICliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCanjear);
            this.Controls.Add(this.txtNroCuponIngresado);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "ConsumoOfertas";
            this.Text = "Canjear ofertas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConsumoOfertas_FormClosing);
            this.Load += new System.EventHandler(this.ConsumoOfertas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNroCuponIngresado;
        private System.Windows.Forms.Button btnCanjear;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtDNICliente;
        private System.Windows.Forms.Label label2;
    }
}