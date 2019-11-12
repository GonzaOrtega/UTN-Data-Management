namespace FrbaOfertas.ComprarOferta
{
    partial class ElegirCantOfertas
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
            this.txtCantOfertas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClienteDestino = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Indique la cantidad de ofertas a comprar";
            // 
            // txtCantOfertas
            // 
            this.txtCantOfertas.Location = new System.Drawing.Point(364, 9);
            this.txtCantOfertas.Name = "txtCantOfertas";
            this.txtCantOfertas.Size = new System.Drawing.Size(172, 26);
            this.txtCantOfertas.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(307, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingrese el DNI del destinatario de la oferta";
            // 
            // txtClienteDestino
            // 
            this.txtClienteDestino.Location = new System.Drawing.Point(364, 50);
            this.txtClienteDestino.Name = "txtClienteDestino";
            this.txtClienteDestino.Size = new System.Drawing.Size(172, 26);
            this.txtClienteDestino.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(424, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 36);
            this.button1.TabIndex = 4;
            this.button1.Text = "Siguiente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ElegirCantOfertas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 140);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtClienteDestino);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCantOfertas);
            this.Controls.Add(this.label1);
            this.Name = "ElegirCantOfertas";
            this.Text = "Comprar ofertas";
            this.Load += new System.EventHandler(this.ElegirCantOfertas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCantOfertas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtClienteDestino;
        private System.Windows.Forms.Button button1;
    }
}