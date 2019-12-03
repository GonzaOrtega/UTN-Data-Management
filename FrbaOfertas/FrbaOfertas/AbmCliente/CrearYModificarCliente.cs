using System;
using System.Windows.Forms;
using FrbaOfertas.Commons;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Data;

namespace FrbaOfertas.AbmCliente
{
    public partial class CrearYModificarCliente : Form
    {
        Cliente cliente = new Cliente();
        bool esModificado = false;
        ABMCliente buscarCliente = new ABMCliente();
        String nombreUsuario = null;
        String contraseniaUsuario = null;
        public Cliente Cliente { get; set; }
        public bool EsModificado { get; set; }
        public ABMCliente BuscarCliente { get; set; }

        public CrearYModificarCliente()
        {
            InitializeComponent();
        }
        public CrearYModificarCliente(String nombre, String contrasenia)
        {
            InitializeComponent();
            nombreUsuario = nombre;
            contraseniaUsuario = contrasenia;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void CrearCliente_Load(object sender, EventArgs e)
        {
            limpiarTextboxes();
            txtFechaNacimiento.Value = obtenerFechaConfigFile();


            if (esModificado)
            {
                txtApellido.Text = cliente.Apellido;
                txtCiudad.Text = cliente.Ciudad;
                txtCP.Text = Convert.ToString(cliente.CodigoPostal);
                txtDireccion.Text = cliente.Direccion;
                txtDNI.Text = Convert.ToString(cliente.DNI);
                txtMail.Text = cliente.Email;
                txtNombre.Text = cliente.Nombre;
                txtTelefono.Text = Convert.ToString(cliente.Telefono);

                txtDNI.Enabled = false;
                btnAceptar.Text = "Modificar";
            }
        }

        private DateTime obtenerFechaConfigFile()
        {
            String fechaConfigFile = ConfigurationManager.AppSettings["fecha"].ToString();
            DateTime fecha = DateTime.ParseExact(fechaConfigFile, "yyyy-MM-dd HH:mm tt", System.Globalization.CultureInfo.InvariantCulture);
            return fecha;
        }

        private void btnDarAltaCliente_Click(object sender, EventArgs e)
        {
            if (esModificado)
            {
                modificarCliente();
            }
            else
            {
                crearCliente();
            }
            buscarCliente.limpiarTodo();
           
        }

        private void modificarCliente()
        {
            validarCliente();
            inicializoCliente();
            Queries.updateCliente(cliente);
            this.Close();
        }
        void ingresarUsuario()
        {
            tipO_USUARIOTableAdapter1.InsertarTipoUsuario(null, null, Convert.ToDecimal(txtDNI.Text));
            DataRow usuario = tipO_USUARIOTableAdapter1.GetDataByDni(Convert.ToDecimal(txtDNI.Text)).First();
            int id = Convert.ToInt32(usuario["ID_usuario"].ToString());
            this.usuarioTableAdapter1.InsertarUsuario(id, contraseniaUsuario, nombreUsuario);
            DataRow rol = rolTableAdapter1.GetDataById("Cliente").First();
            usuariO_ROLTableAdapter1.InsertQuery(id, Convert.ToInt32(rol["ID_rol"]));
            MessageBox.Show("Se ha agregado exitosamente", "Felicidades", MessageBoxButtons.OK);
        }
        private void crearCliente()
        {
            if (seCargaronPKs())
            {
                try
                {
                    validarCliente();
                    inicializoCliente();
                    Queries.insertarCliente(cliente);
                    ingresarUsuario();
                    limpiarTextboxes();
                    Close();
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    MessageBox.Show("Error: Ya existe un cliente con ese DNI. Por favor ingrese otro");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo ingresar el usuario. Por favor verificar datos ingresados", "Alta cliente");
                }
            }
            else
            {
                MessageBox.Show("Por favor ingrese los campos obligatorios", "Alta cliente");
            }
        }





        // Metodos auxiliares
        public void inicializoCliente()
        {
            cliente.DNI = Convert.ToDouble(txtDNI.Text);
            cliente.CodigoPostal = Convert.ToDouble(txtCP.Text);
            cliente.Nombre = txtNombre.Text;
            cliente.Apellido = txtApellido.Text;
            cliente.Telefono = Convert.ToDouble(txtTelefono.Text);
            cliente.Email = txtMail.Text;
            cliente.FechaVencimiento = txtFechaNacimiento.Value;
            cliente.Ciudad = txtCiudad.Text;
            cliente.Direccion = txtDireccion.Text;
            cliente.Credito = 200; // Lo indicado por la consigna
        }

        public void validarCliente()
        {
            Validacion.validarDoubleTxt(ref txtDNI);
            Validacion.validarDoubleTxt(ref txtCP);
            Validacion.validarDoubleTxt(ref txtTelefono);
        }
        
        public bool seCargaronPKs()
        {
            double a;
            return !String.IsNullOrEmpty(txtDNI.Text) && Double.TryParse(txtDNI.Text, out a);
        }

        public void limpiarTextboxes()
        {
            txtApellido.Clear();
            txtCiudad.Clear();
            txtCP.Clear();
            txtDireccion.Clear();
            txtDNI.Clear();
            txtMail.Clear();
            txtNombre.Clear();
            txtTelefono.Clear();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            limpiarTextboxes();
            if (esModificado)
            {
                txtApellido.Text = cliente.Apellido;
                txtCiudad.Text = cliente.Ciudad;
                txtCP.Text = Convert.ToString(cliente.CodigoPostal);
                txtDireccion.Text = cliente.Direccion;
                txtDNI.Text = Convert.ToString(cliente.DNI);
                txtMail.Text = cliente.Email;
                txtNombre.Text = cliente.Nombre;
                txtTelefono.Text = Convert.ToString(cliente.Telefono);

                txtDNI.Enabled = false;
                btnAceptar.Text = "Modificar";

            }
          
        }

        private void txtCP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
