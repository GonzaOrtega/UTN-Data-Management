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
        bool usuarioExistente;
        bool cerrado = false;
        public Registrarse(Login login)
        { 
            InitializeComponent();
            log = login;
        }
       
        private void Registrarse_Load(object sender, EventArgs e)
        {
            cbROL.DataSource = this.rolTableAdapter1.GetDataSinAdministrador();
            cbROL.ValueMember = "Nombre";
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            log.Show();
            cerrado = true;
            Close();  
        }
        private void enviarAlProximoFormulario()
        {
            if (cbROL.Text == "Cliente")
            {
                new DatosCliente(log,usuarioExistente,txtUsuario.Text,txtContrasenia.Text).Show();
                cerrado = true;
                Close();
            }
            else
            {
                if (cbROL.Text == "Proveedor")
                {
                    new DatosProveedor(log, usuarioExistente, txtUsuario.Text, txtContrasenia.Text).Show();
                    cerrado = true;
                    Close();
                }
               else
                {
                    MessageBox.Show("Todavia no esta habilitado para loguearse con ese rol", "Error", MessageBoxButtons.OK);
                }
            }
           
        }

        private bool yaPoseeEseROL()
        {
            if(cbROL.Text=="Cliente" && this.usuariO_ROLTableAdapter1.poseeRol(txtUsuario.Text,"Cliente").Count()!=0)
            return true;
            if (cbROL.Text == "Proveedor" && this.usuariO_ROLTableAdapter1.poseeRol(txtUsuario.Text, "Proveedor").Count() != 0)
                return true;
            return false;
        }
        private bool validarEntradas()
        {
            if(txtContrasenia.ForeColor == Color.Gainsboro && txtUsuario.ForeColor == Color.Gainsboro)
            {
                MessageBox.Show("Falta ingresar usuario y/o contraseña", "WARNING", MessageBoxButtons.OK);
                return true;
            }
            return true;
        }
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            //Dependiendo el rol va a in a distintos form
            //Y cuando el form me devuelva el cliente lo agregoel usuario y cliente
            if (this.validarEntradas()) {
                if ((int)this.usuarioTableAdapter1.ExisteNombreUsuario(txtUsuario.Text) != 0)
                {
                    if (this.usuarioTableAdapter1.GetDataByUsuario(txtContrasenia.Text, txtUsuario.Text).Count() == 0)
                    {
                        MessageBox.Show("Ya existe un usuario con ese nombre");
                    }
                    else
                    {
                        if (this.yaPoseeEseROL())
                        {
                            MessageBox.Show("El usuario ya se le ha asignado ese ROL", "ERROR", MessageBoxButtons.OK);
                        }
                        else
                        {
                            usuarioExistente = true;
                            this.enviarAlProximoFormulario();
                        }
                    }
                }
                else
                {
                    usuarioExistente = false;
                    this.enviarAlProximoFormulario();
                }
            }
            
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

       
        
        private void Registrarse_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && cerrado ==false&&cerrado == false)
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
