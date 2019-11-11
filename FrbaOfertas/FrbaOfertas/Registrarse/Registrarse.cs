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
            cbROL.DataSource = this.rolTableAdapter1.GetDataSinAdministrador();
            cbROL.ValueMember = "Nombre";

        }

        

        private void btnAtras_Click(object sender, EventArgs e)
        {
            log.Show();
            Close();
           
        }
        private void crearCliente()
        {
            Decimal dni = Convert.ToDecimal(txtCUIT.Text);
            if (this.clientesTableAdapter1.GetDataByDni(dni).Count != 0)
            {
                if ((int)this.tipO_USUARIOTableAdapter1.chequearExistenciaCliente(dni) == 0)
                {
                    this.tipO_USUARIOTableAdapter1.InsertarTipoUsuario(null, null, dni);
                    DataRow tipoUsuario = this.tipO_USUARIOTableAdapter1.GetDataByDni(dni).First();
                    this.usuarioTableAdapter1.InsertarUsuario(Convert.ToInt32(tipoUsuario["ID_usuario"].ToString()), txtContrasenia.Text, txtUsuario.Text);
                    MessageBox.Show("El registro ha finalizado con exito", "Felicidades", MessageBoxButtons.OK);
                    log.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("El cliente ingresado ya pertenece a un usuario", "ERROR", MessageBoxButtons.OK);
                }
            }
            else
            {
                if (MessageBox.Show("No existe un cliente con ese DNI ¿Desea crearlo?", "ERROR", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //Ir al formulario de crear cliente
                }
            }

        }
        private bool sePuedeCrearCliente() {
            if (cbROL.Text == "Cliente")
            {
                Decimal dni = Convert.ToDecimal(txtCUIT.Text);
                if (this.clientesTableAdapter1.GetDataByDni(dni).Count == 0)
                {
                    if (MessageBox.Show("No existe un cliente con ese DNI ¿Desea crearlo?", "ERROR", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        //Ir al formulario de crear cliente
                    }
                    return false;
                }
                if ((int)this.tipO_USUARIOTableAdapter1.chequearExistenciaCliente(dni) != 0)
                {
                    MessageBox.Show("El cliente ingresado ya pertenece a un usuario", "ERROR", MessageBoxButtons.OK);
                    return false;
                }
                return true;
            }
            return true;
        }
        private void asignameCliente()
        {
            if (this.sePuedeCrearCliente())
            {

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
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            //Dependiendo el rol va a in a distintos form
            //Y cuando el form me devuelva el cliente lo agregoel usuario y cliente
            if ((int)this.usuarioTableAdapter1.ExisteNombreUsuario(txtUsuario.Text) != 0)
            {
                if ((int)this.usuarioTableAdapter1.chequearUsuario(txtContrasenia.Text, txtUsuario.Text) == 0)
                {
                    MessageBox.Show("Ya existe un usuariocon ese nombre");
                }
                else
                {
                    if (this.yaPoseeEseROL())
                    {
                        MessageBox.Show("El usuario ya se le ha asignado ese ROl", "ERROR", MessageBoxButtons.OK);
                    }
                    else
                    {
                        this.asignameCliente();
                    }
                    /*if (cbROL.Text == "Cliente")
                    {
                        if ((int)this.usuarioTableAdapter1.ExisteNombreUsuario(txtUsuario.Text) == 0)
                        {
                            this.crearCliente();
                        }else{
                            if ((int)this.usuarioTableAdapter1.chequearUsuario(txtContrasenia.Text, txtUsuario.Text) != 0)
                            {
                                if ((int)this.usuarioTableAdapter1.poseeUnCliente(txtUsuario.Text) == 0)
                                {
                                    this.crearCliente();
                                }
                                else
                                {
                                    MessageBox.Show("El usuario ya se le ha asignado un cliente", "ERROR", MessageBoxButtons.OK);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Ya existe un nombre con ese usuario");
                            }
                        }
                    }*/
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

        private void txtCUIT_Click(object sender, EventArgs e)
        {
            if (txtCUIT.Text == "CUIT" || txtCUIT.Text == "DNI") txtCUIT.Text = "";
        }

        private void txtRazonSocial_Click(object sender, EventArgs e)
        {
            if (txtRazonSocial.Text == "Razón social") txtRazonSocial.Text = "";
        }

        private void txtCUIT_Leave(object sender, EventArgs e)
        {
            if (cbROL.Text == "Proveedor" && txtCUIT.Text == "") txtCUIT.Text = "CUIT";
            if (cbROL.Text == "Cliente" && txtCUIT.Text == "") txtCUIT.Text = "DNI";
        }

        private void txtRazonSocial_Leave(object sender, EventArgs e)
        {
            if (cbROL.Text == "Proveedor" && txtRazonSocial.Text == "") txtRazonSocial.Text = "Razón social";
        }

        private void txtCUIT_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
