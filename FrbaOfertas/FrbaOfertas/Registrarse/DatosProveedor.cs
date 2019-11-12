using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaOfertas.Registrarse
{
    public partial class DatosProveedor : Form
    {
        LoginYSeguridad.Login login;
        Registrarse registro;
        bool existencia;
        String nombre;
        string contrasenia;
        public DatosProveedor(LoginYSeguridad.Login log, Registrarse reg, bool exis, String nom, string cont)
        {
            InitializeComponent();
            login= log;
            registro=reg;
            existencia=exis;
            nombre=nom;
            contrasenia=cont;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            registro.Show();
            Close();
        }

        private void txtCuit_Leave(object sender, EventArgs e)
        {
            if (txtCuit.Text == "") txtCuit.Text = "CUIT";
        }

        private void txtRazonSocial_Leave(object sender, EventArgs e)
        {
            if (txtRazonSocial.Text == "") txtRazonSocial.Text = "Razón social";
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (proveedorTableAdapter1.GetDataByCuitRazonsocial(txtCuit.Text,txtRazonSocial.Text).Count() != 0)
            {
                if (tipO_USUARIOTableAdapter1.GetDataByCuitRazonsocial(txtCuit.Text, txtRazonSocial.Text).Count() != 0)
                {
                    MessageBox.Show("El DNI ingresado ya posee un usuario", "ERROR", MessageBoxButtons.OK);
                }
                else
                {
                    if (existencia)
                    {
                        DataRow usuario = this.usuarioTableAdapter1.GetDataByUsuario(contrasenia, nombre).First();
                        int id = Convert.ToInt32(usuario["ID_usuario"].ToString());
                        tipO_USUARIOTableAdapter1.UpdateQueryProveedor(txtCuit.Text,txtRazonSocial.Text, id);
                        DataRow rol = rolTableAdapter1.GetDataById("Proveedor").First();
                        usuariO_ROLTableAdapter1.InsertQuery(id, Convert.ToInt32(rol["ID_rol"]));
                        MessageBox.Show("Se ha agregado exitosamente", "Felicidades!", MessageBoxButtons.OK);
                        registro.Close();
                        login.Show();
                        Close();
                    }
                    else
                    {
                        tipO_USUARIOTableAdapter1.InsertarTipoUsuario(txtCuit.Text, txtRazonSocial.Text,null);
                        DataRow usuario = tipO_USUARIOTableAdapter1.GetDataByCuitRazonsocial(txtCuit.Text,txtRazonSocial.Text).First();
                        int id = Convert.ToInt32(usuario["ID_usuario"].ToString());
                        this.usuarioTableAdapter1.InsertarUsuario(id, contrasenia, nombre);
                        DataRow rol = rolTableAdapter1.GetDataById("Proveedor").First();
                        usuariO_ROLTableAdapter1.InsertQuery(id, Convert.ToInt32(rol["ID_rol"]));
                        MessageBox.Show("Se ha agregado exitosamente", "Felicidades!", MessageBoxButtons.OK);
                        registro.Close();
                        login.Show();
                        Close();
                    }
                }
            }
            else
            {
                if (MessageBox.Show("No existe ningun cliente con ese DNI ¿Desea crear uno?", "ERROR", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //UNIR CON LO DE GONZA
                }
            }
        }

        private void txtCuit_Click(object sender, EventArgs e)
        {
            if (txtCuit.Text == "CUIT") txtCuit.Text = "";
        }

        private void txtRazonSocial_Click(object sender, EventArgs e)
        {
            if (txtRazonSocial.Text == "Razón social") txtRazonSocial.Text = "";
        }


        private void DatosProveedor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea salir del sistema?", "WARNING", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else { login.Close(); }
        }
    }
}
