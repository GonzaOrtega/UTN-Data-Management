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
        public string nombre, apellido, direccion, email, ciudad;
        DBAccess dB = new DBAccess();

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

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtNombreAltaCliente_TextChanged(object sender, EventArgs e)
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
            udDNIAltaCliente.Controls.RemoveAt(0);
            udDNIAltaCliente.Text = "";
            udCPAltaCliente.Controls.RemoveAt(0);
            udCPAltaCliente.Text = "";
            udTelefonoAltaCliente.Controls.RemoveAt(0);
            udTelefonoAltaCliente.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnDarAltaCliente_Click(object sender, EventArgs e)
        {
            try
            {
                Decimal DNI = udDNIAltaCliente.Value;
                Decimal codigoPostal = udCPAltaCliente.Value;
                nombre = txtNombreAltaCliente.Text;
                apellido = txtApellidoAltaCliente.Text;
                direccion = txtDireccionAltaCliente.Text + txtNroDepartamentoAltaCliente.Text + txtCiudadAltaCliente.Text;
                Decimal telefono = udTelefonoAltaCliente.Value;
                email = txtMailAltaCliente.Text;
                DateTime fechaNacimiento = dtpFechaNacimientoAltaCliente.Value;
                ciudad = txtCiudadAltaCliente.Text;
                double credito = 200;

                string query = "INSERT INTO CLIENTES VALUES (@dni, @cp, @nombre, @apellido, @direccion, @telefono, @mail,"
                    + "@fechanacimiento, @ciudad, @credito)";

                //string query = "INSERT INTO CLIENTES VALUES ('"+DNI+"', '"+codigoPostal+"', '"+nombre+"','"+apellido+"', '"+
                //    direccion+"', '"+telefono+"', '"+email+"', '"+fechaNacimiento+"', '"+ciudad+"', '"+credito+"')";

                SqlCommand insertarNuevoCliente = new SqlCommand(query);
                insertarNuevoCliente.Parameters.AddWithValue("@DNI", DNI);
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

                if (row == 1)
                {
                    MessageBox.Show("Cliente creado satisfactoriamente");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo ingresar el usuario. Por favor verificar datos ingresados");
            }

        }
    }
}
