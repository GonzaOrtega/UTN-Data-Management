﻿namespace FrbaOfertas.Funciones
{
    partial class Funciones
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
            this.cbFunciones = new System.Windows.Forms.ComboBox();
            this.usuariO_ROLTableAdapter1 = new FrbaOfertas.GD2C2019DataSetTableAdapters.USUARIO_ROLTableAdapter();
            this.funcionalidadTableAdapter1 = new FrbaOfertas.GD2C2019DataSetTableAdapters.FUNCIONALIDADTableAdapter();
            this.lblElegir = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tipO_USUARIOTableAdapter1 = new FrbaOfertas.GD2C2019DataSetTableAdapters.TIPO_USUARIOTableAdapter();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnContrasenia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbFunciones
            // 
            this.cbFunciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFunciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFunciones.FormattingEnabled = true;
            this.cbFunciones.Location = new System.Drawing.Point(53, 127);
            this.cbFunciones.Name = "cbFunciones";
            this.cbFunciones.Size = new System.Drawing.Size(753, 37);
            this.cbFunciones.TabIndex = 0;
            this.cbFunciones.SelectedIndexChanged += new System.EventHandler(this.cbFunciones_SelectedIndexChanged);
            // 
            // usuariO_ROLTableAdapter1
            // 
            this.usuariO_ROLTableAdapter1.ClearBeforeFill = true;
            // 
            // funcionalidadTableAdapter1
            // 
            this.funcionalidadTableAdapter1.ClearBeforeFill = true;
            // 
            // lblElegir
            // 
            this.lblElegir.AutoSize = true;
            this.lblElegir.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElegir.Location = new System.Drawing.Point(46, 50);
            this.lblElegir.Name = "lblElegir";
            this.lblElegir.Size = new System.Drawing.Size(378, 38);
            this.lblElegir.TabIndex = 1;
            this.lblElegir.Text = "Elija la funcion a ejecutar";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(559, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(247, 51);
            this.button1.TabIndex = 2;
            this.button1.Text = "EJECUTAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tipO_USUARIOTableAdapter1
            // 
            this.tipO_USUARIOTableAdapter1.ClearBeforeFill = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(53, 219);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(247, 51);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "CERRAR SESIÓN";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnContrasenia
            // 
            this.btnContrasenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContrasenia.Location = new System.Drawing.Point(306, 219);
            this.btnContrasenia.Name = "btnContrasenia";
            this.btnContrasenia.Size = new System.Drawing.Size(247, 51);
            this.btnContrasenia.TabIndex = 4;
            this.btnContrasenia.Text = "AJUSTES";
            this.btnContrasenia.UseVisualStyleBackColor = true;
            this.btnContrasenia.Click += new System.EventHandler(this.btnContrasenia_Click);
            // 
            // Funciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(859, 310);
            this.Controls.Add(this.btnContrasenia);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblElegir);
            this.Controls.Add(this.cbFunciones);
            this.Name = "Funciones";
            this.Text = "Funciones";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Funciones_FormClosing);
            this.Load += new System.EventHandler(this.Funciones_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbFunciones;
        private GD2C2019DataSetTableAdapters.USUARIO_ROLTableAdapter usuariO_ROLTableAdapter1;
        private GD2C2019DataSetTableAdapters.FUNCIONALIDADTableAdapter funcionalidadTableAdapter1;
        private System.Windows.Forms.Label lblElegir;
        private System.Windows.Forms.Button button1;
        private GD2C2019DataSetTableAdapters.TIPO_USUARIOTableAdapter tipO_USUARIOTableAdapter1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnContrasenia;
    }
}