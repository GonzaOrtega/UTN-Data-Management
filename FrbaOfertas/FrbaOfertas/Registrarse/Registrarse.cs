using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaOfertas.GD2C2019DataSetTableAdapters;
using FrbaOfertas.LoginYSeguridad;

namespace FrbaOfertas.Registrarse
{
    public partial class Registrarse : Form
    {
        Login log;
        public Registrarse(Login login)
        { 
            InitializeComponent();
            log = login;
        }
       
        private void Registrarse_Load(object sender, EventArgs e)
        {
            this.rolTableAdapter1.Fill(this.gD2C2019DataSet1.ROL);
            cbROL.DataSource = this.rolTableAdapter1.GetDataBy();
            cbROL.ValueMember = "Nombre";

        }

        

        private void btnAtras_Click(object sender, EventArgs e)
        {
            log.Show();
            Close();
           
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            //Dependiendo el rol va a in a distintos form
            //Y cuando el form me devuelva el cliente lo agregoel usuario y cliente
            if (cbROL.Text == "Cliente")
            {
                lblIngrese.Text = "Me fui a crear un Cliente";
            }
            else
            {
                if (cbROL.Text == "Proveedor") { 
                    lblIngrese.Text = "Me fui a crear un Proveedor";
                }else{
                    MessageBox.Show("No es una opcion de rol correcta", "Error", MessageBoxButtons.OK);    
                }
            }
        }

        private void txtUsuario_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario") txtUsuario.Text = "";
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "") txtUsuario.Text = "Usuario";
        }

        private void txtContrasenia_Click(object sender, EventArgs e)
        {
            if (txtContrasenia.Text == "Contraseña") txtContrasenia.Text = "";
        }

        private void txtContrasenia_Leave(object sender, EventArgs e)
        {
            if (txtContrasenia.Text == "") txtContrasenia.Text = "Contraseña";
        }

        private void cbROL_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbROL.Text == "Proveedor")
            {
                txtCUIT.Text = "CUIT";
                txtRazonSocial.Visible = true;
            }
            else
            {
                txtCUIT.Text = "DNI";
                txtRazonSocial.Visible = false;
            }
        }
    }
}
