using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace FrbaOfertas.AbmCliente
{
    public partial class CrearCliente : Form
    {
        DBAccess dB = new DBAccess();
        Boolean estanTodos = true;
        
        public CrearCliente()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string casaODepartamento = cbCasaODepartamento.Text;

            if (casaODepartamento.Equals("Departamento"))
            {
                txtNroDepartamentoAltaCliente.Enabled = true;
            }
        }

        private void CrearCliente_Load(object sender, EventArgs e)
        {
            txtNroDepartamentoAltaCliente.Enabled = false;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnDarAltaCliente_Click(object sender, EventArgs e)
        {
            //Double DNI = Convert.ToDouble(txtDNIAltaCliente.Text);
            //Double codigoPostal = Convert.ToDouble(txtCPAltaCliente.Text);
            //string nombre = txtNombreAltaCliente.Text;
            //string apellido = txtApellidoAltaCliente.Text;
            //string direccion = txtDireccionAltaCliente.Text;
            //string telefono = txtTelefonoAltaCliente.Text;
            //string email = txtMailAltaCliente.Text;
            //DateTime fechaNacimiento = dtpFechaNacimientoAltaCliente.Value;
            //string ciudad = txtCiudadAltaCliente.Text;
            //double credito = 200;


            String nombre = null, apellido = null, direccion = null, telefono = null, email = null, ciudad= null;
            Double dni = 0, codigoPostal = 0, credito = 200;
            DateTime fechaNacimiento = new DateTime();

            this.verificarTexto(txtNombreAltaCliente.Text, ref nombre, "nombre");
            this.verificarTexto(txtApellidoAltaCliente.Text, ref apellido, "apellido");
            this.verificarTexto(txtDireccionAltaCliente.Text, ref direccion, "direccion");
            this.verificarTexto(txtTelefonoAltaCliente.Text, ref telefono, "telefono");
            this.verificarTexto(txtMailAltaCliente.Text, ref email, "mail");
            this.verificarTexto(txtCiudadAltaCliente.Text, ref ciudad, "ciudad");

            this.verificarDouble(txtDNIAltaCliente.Text, ref dni, "DNI");
            this.verificarDouble(txtCPAltaCliente.Text, ref codigoPostal, "codigo postal");
            this.verificarFecha(dtpFechaNacimientoAltaCliente.Value, ref fechaNacimiento, "fecha de nacimiento");

            if (estanTodos)
            {
                string query = "INSERT INTO CLIENTES VALUES (@DNI, @CP, @Nombre, @Apellido, @Direccion, @Telefono, @Mail,"
                    + "@FechaNacimiento, @Ciudad, @Credito)";

                //string query = "INSERT INTO CLIENTES VALUES ("

                SqlCommand insertarNuevoCliente = new SqlCommand(query);
                insertarNuevoCliente.Parameters.AddWithValue("@DNI", dni);
                insertarNuevoCliente.Parameters.AddWithValue("@CP", codigoPostal);
                insertarNuevoCliente.Parameters.AddWithValue("@Nombre", nombre);
                insertarNuevoCliente.Parameters.AddWithValue("@Apellido", apellido);
                insertarNuevoCliente.Parameters.AddWithValue("@Direccion", direccion);
                insertarNuevoCliente.Parameters.AddWithValue("@Telefono", telefono);
                insertarNuevoCliente.Parameters.AddWithValue("@Mail", email);
                insertarNuevoCliente.Parameters.AddWithValue("@Ciudad", ciudad);
                insertarNuevoCliente.Parameters.AddWithValue("@FechaNacimiento", fechaNacimiento);
                insertarNuevoCliente.Parameters.AddWithValue("@Credito", credito);

                int row = dB.executeQuery(insertarNuevoCliente); // Retorna el numero de filas afectadas

                if(row == 1)
                {
                    MessageBox.Show("Cliente creado satisfactoriamente");
                }
            }

        }

        public void verificarTexto(String contenido, ref String valueAGuardar, String tipoDeValue)
        {
            if(!contenido.Equals(""))
            {
                valueAGuardar = contenido;
            }
            else
            {
                estanTodos = false;
                MessageBox.Show("Por favor, ingrese " + tipoDeValue);
            }
        }

        public void verificarDouble(String contenido, ref Double valueAGuardar, String tipoDeValue)
        {
            try
            {
                if (!contenido.Equals(""))
                {
                    valueAGuardar = Convert.ToDouble(contenido);
                }
                else
                {
                    estanTodos = false;
                    MessageBox.Show("Por favor, ingrese " + tipoDeValue);
                }

            }catch(Exception e)
            {
                estanTodos = false;
                MessageBox.Show("Por favor, ingrese " + tipoDeValue);
            }
        }

        public void verificarFecha(DateTime contenido, ref DateTime valueAGuardar, String tipoDeValue)
        {
            if (!contenido.Equals(""))
            {
                valueAGuardar = contenido;
            }
            else
            {
                estanTodos = false;
                MessageBox.Show("Por favor, ingrese " + tipoDeValue);
            }
        }
    }
}
