using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace FrbaOfertas.Registrarse
{
    public partial class DatosCliente : Form
    {
        LoginYSeguridad.Login login;
        bool usuarioExistente;
        string nombre;
        string contrasenia;
        bool cerrado=false;
        public DatosCliente(LoginYSeguridad.Login log, bool existencia,String nom,string cont)
        {
            InitializeComponent();
            login = log;
            usuarioExistente = existencia;
            contrasenia = cont;
            nombre = nom;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
           new Registrarse(login).Show();
            cerrado = true;
            Close();
        }

        private void txtDni_Leave(object sender, EventArgs e)
        {
            if (txtDni.Text == "")
            {
                txtDni.Text = "DNI";
                txtDni.ForeColor = Color.Gainsboro;
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            decimal dni = Convert.ToDecimal(txtDni.Text);
            if (this.clientesTableAdapter1.GetDataByDni(dni).Count() != 0)
            {
                if (this.tipO_USUARIOTableAdapter1.GetDataByDni(dni).Count() != 0)
                {
                    MessageBox.Show("El DNI ingresado ya posee un usuario", "ERROR", MessageBoxButtons.OK);
                }
                else
                {
                    if (usuarioExistente)
                    {
                        DataRow usuario =this.usuarioTableAdapter1.GetDataByUsuario( contrasenia,nombre).First();
                        int id = Convert.ToInt32(usuario["ID_usuario"].ToString());
                        tipO_USUARIOTableAdapter1.UpdateUsuarioCliente(Convert.ToDecimal(txtDni.Text),id) ;
                        DataRow rol = rolTableAdapter1.GetDataById("Cliente").First();
                        usuariO_ROLTableAdapter1.InsertQuery(id, Convert.ToInt32(rol["ID_rol"]));
                        MessageBox.Show("Se ha agregado exitosamente", "Felicidades", MessageBoxButtons.OK);
                        login.Show();
                        cerrado = true;
                        Close();
                    }
                    else
                    {
                        tipO_USUARIOTableAdapter1.InsertarTipoUsuario(null, null, Convert.ToDecimal(txtDni.Text));
                        DataRow usuario= tipO_USUARIOTableAdapter1.GetDataByDni(Convert.ToDecimal(txtDni.Text)).First();
                        int id = Convert.ToInt32(usuario["ID_usuario"].ToString());
                        this.usuarioTableAdapter1.InsertarUsuario(id, contrasenia, nombre);                    
                        DataRow rol = rolTableAdapter1.GetDataById("Cliente").First();
                        usuariO_ROLTableAdapter1.InsertQuery(id, Convert.ToInt32(rol["ID_rol"]));
                        MessageBox.Show("Se ha agregado exitosamente", "Felicidades", MessageBoxButtons.OK);
                        login.Show();
                        cerrado = true;
                        Close();
                    }
                }
            }
            else
            {
                if(MessageBox.Show("No existe ningun cliente con ese DNI ¿Desea crear uno?", "ERROR", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    new AbmCliente.CrearYModificarCliente().Show();
                }
            }
        }

        private void DatosCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && cerrado==false)
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

        private void txtDni_Enter(object sender, EventArgs e)
        {
            if (txtDni.Text == "DNI")
            {
                txtDni.Text = "";
                txtDni.ForeColor = Color.Black;
            }
        }
    }
}
