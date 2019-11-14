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
            this.label1.Location = new System.Drawing.Point(19, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(442, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Indique la cantidad de ofertas a comprar";
            // 
            // txtCantOfertas
            // 
            this.txtCantOfertas.Location = new System.Drawing.Point(566, 13);
            this.txtCantOfertas.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtCantOfertas.Name = "txtCantOfertas";
            this.txtCantOfertas.Size = new System.Drawing.Size(265, 35);
            this.txtCantOfertas.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(464, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingrese el DNI del destinatario de la oferta";
            // 
            // txtClienteDestino
            // 
            this.txtClienteDestino.Location = new System.Drawing.Point(566, 73);
            this.txtClienteDestino.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtClienteDestino.Name = "txtClienteDestino";
            this.txtClienteDestino.Size = new System.Drawing.Size(265, 35);
            this.txtClienteDestino.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(660, 136);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 52);
            this.button1.TabIndex = 4;
            this.button1.Text = "Siguiente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ElegirCantOfertas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(854, 215);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtClienteDestino);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCantOfertas);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
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