﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaOfertas.AbmCliente
{
    public partial class IngresarCliente : Form
    {
        bool cerrado = false;
        public IngresarCliente()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        int usuario;
        public IngresarCliente(int usu)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            usuario = usu;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            cerrado = true;   
                this.Close();
                new Funciones.Funciones(usuario).Show();
            
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            try
            {
                new ComprarOferta.ComprarOfertas(Convert.ToDouble(txtDNI.Text) ,usuario).Show();
                cerrado = true;
                this.Close();

            }catch(Exception ex)
            {
                MessageBox.Show("Error: el DNI ingresado no es correcto");
            }
        }

        private void txtDNI_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDNI_Enter(object sender, EventArgs e)
        {
            if(txtDNI.ForeColor == Color.Gainsboro)
            {
                txtDNI.Text = "";
                txtDNI.ForeColor = Color.Black;
            }
        }

        private void txtDNI_Leave(object sender, EventArgs e)
        {
            if (txtDNI.Text == "")
            {
                txtDNI.Text = "DNI";
                txtDNI.ForeColor = Color.Gainsboro;
            }
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void IngresarCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && cerrado == false)
            {
                if (MessageBox.Show("¿Está seguro que desea salir del sistema?", "WARNING", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    Application.Exit();
                }
            }
        }
    }
}
