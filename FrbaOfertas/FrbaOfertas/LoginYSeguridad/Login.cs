﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaOfertas.GD2C2019DataSetTableAdapters;
namespace FrbaOfertas.LoginYSeguridad
{
    
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (this.uSUARIOTableAdapter.GetDataByUsuario(txtContrasenia.Text, txtUsuario.Text).Count() != 0)
            {
                DataRow usuario= this.uSUARIOTableAdapter.GetDataByUsuario(txtContrasenia.Text, txtUsuario.Text).First();
                new Funciones.Funciones(Convert.ToInt32(usuario["ID_Usuario"].ToString())).Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Contraseña o Usuario invalidos", "ERROR", MessageBoxButtons.OK);
            }


        }



        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            new Registrarse.Registrarse(this).Show();
            this.Hide();
 
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario";
                txtUsuario.ForeColor = Color.Gainsboro;
            }
        }

        private void txtContrasenia_Leave(object sender, EventArgs e)
        {
            if (txtContrasenia.Text == "")
            {
                txtContrasenia.Text = "Contraseña";
                txtContrasenia.ForeColor = Color.Gainsboro;
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            if (e.CloseReason==CloseReason.UserClosing)
            {
                if (MessageBox.Show("¿Está seguro que desea salir del sistema?", "WARNING", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
            }
        }

        private void txtContrasenia_Enter(object sender, EventArgs e)
        {
            if (txtContrasenia.Text == "Contraseña")
            {
                txtContrasenia.Text = "";
                txtContrasenia.ForeColor = Color.Black;
            }
        }
    }
}
