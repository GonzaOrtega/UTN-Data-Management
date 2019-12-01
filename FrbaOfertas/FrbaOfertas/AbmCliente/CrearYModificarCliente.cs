using System;
using System.Windows.Forms;
using FrbaOfertas.Commons;
using System.Collections.Generic;
using System.Configuration;

namespace FrbaOfertas.AbmCliente
{
    public partial class CrearYModificarCliente : Form
    {
        Cliente cliente = new Cliente();
        bool esModificado = false;
        ABMCliente buscarCliente = new ABMCliente();

        public Cliente Cliente { get => cliente; set => cliente = value; }
        public bool EsModificado { get => esModificado; set => esModificado = value; }
        public ABMCliente BuscarCliente { get => buscarCliente; set => buscarCliente = value; }

        public CrearYModificarCliente()
        {
            InitializeComponent();
        }

        // Metodos de formas
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtNombreAltaCliente_TextChanged(object sender, EventArgs e)
        {
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnDarAltaCliente_Click(object sender, EventArgs e)
        {
            crearCliente();
            buscarCliente.limpiarTodo();
            limpiarTextboxes();
        }

        private void modificarCliente()
        {
            validarCliente();
            inicializoCliente();
            Queries.updateCliente(cliente);
            this.Close();
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
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
