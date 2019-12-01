namespace FrbaOfertas.ComprarOferta
{
    partial class ElegirUsuariosDestino
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDNIDestino = new System.Windows.Forms.TextBox();
            this.btnCanjear = new System.Windows.Forms.Button();
            this.txtCantCupones = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantCupones)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(618, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingrese el usuario al que le quiera enviar el/los cupon/es";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dni usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(86, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cant cupones";
            // 
            // txtDNIDestino
            // 
            this.txtDNIDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNIDestino.Location = new System.Drawing.Point(306, 77);
            this.txtDNIDestino.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtDNIDestino.Name = "txtDNIDestino";
            this.txtDNIDestino.Size = new System.Drawing.Size(225, 35);
            this.txtDNIDestino.TabIndex = 5;
            // 
            // btnCanjear
            // 
            this.btnCanjear.Location = new System.Drawing.Point(379, 217);
            this.btnCanjear.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnCanjear.Name = "btnCanjear";
            this.btnCanjear.Size = new System.Drawing.Size(152, 51);
            this.btnCanjear.TabIndex = 7;
            this.btnCanjear.Text = "Canjear";
            this.btnCanjear.UseVisualStyleBackColor = true;
            this.btnCanjear.Click += new System.EventHandler(this.btnCanjear_Click);
            // 
            // txtCantCupones
            // 
            this.txtCantCupones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantCupones.Location = new System.Drawing.Point(306, 147);
            this.txtCantCupones.Name = "txtCantCupones";
            this.txtCantCupones.Size = new System.Drawing.Size(225, 35);
            this.txtCantCupones.TabIndex = 8;
            this.txtCantCupones.Minimum = 1;
            // 
            // ElegirUsuariosDestino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(649, 290);
            this.Controls.Add(this.txtCantCupones);
            this.Controls.Add(this.btnCanjear);
            this.Controls.Add(this.txtDNIDestino);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ElegirUsuariosDestino";
            this.Text = "Elegir usuarios";
            this.Load += new System.EventHandler(this.ElegirUsuariosDestino_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtCantCupones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDNIDestino;
        private System.Windows.Forms.Button btnCanjear;
        public System.Windows.Forms.NumericUpDown txtCantCupones;
    }
}