using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;
using System.Data;
using System.Data.SqlClient;
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

        private void txtNombreAltaCliente_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea cancelar?", "Cancelar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
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
            try
            {
                Double DNI = Convert.ToDouble(txtDNIAltaCliente.Text);
                Double codigoPostal = Convert.ToDouble(txtCPAltaCliente.Text);
                nombre = txtNombreAltaCliente.Text;
                apellido = txtApellidoAltaCliente.Text;
                direccion = txtDireccionAltaCliente.Text + txtNroDepartamentoAltaCliente.Text + txtCiudadAltaCliente.Text;
                Double telefono = Convert.ToDouble(txtTelefonoAltaCliente.Text);
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

        //static public void registarUsuario(Afiliado afiliado)
        //{

        //    var conexion = DBConnection.getConnection();

        //    SqlCommand comando = new SqlCommand("GEDDES.ingresarUsuario", conexion);

        //    comando.CommandType = CommandType.StoredProcedure;

        //    comando.Parameters.AddWithValue("@username", afiliado.getUsername());
        //    comando.Parameters.AddWithValue("@password", afiliado.getPassword());
        //    comando.Parameters.AddWithValue("@nombre", afiliado.getNombre());
        //    comando.Parameters.AddWithValue("@apellido", afiliado.getApellido());
        //    comando.Parameters.AddWithValue("@tipoDoc", afiliado.getTipoDoc());
        //    comando.Parameters.AddWithValue("@nroDoc", afiliado.getNroDoc());
        //    comando.Parameters.AddWithValue("@direccion", afiliado.getDireccion());
        //    comando.Parameters.AddWithValue("@telefono", afiliado.getTelefono());
        //    comando.Parameters.AddWithValue("@fechaNacimiento", afiliado.getFechaNac());
        //    comando.Parameters.AddWithValue("@sexo", afiliado.getSexo());

        //    if (afiliado.getMail() != null)
        //    {
        //        comando.Parameters.AddWithValue("@mail", afiliado.getMail());
        //    }
        //    else
        //    {
        //        comando.Parameters.AddWithValue("@mail", DBNull.Value);
        //    }


        //    conexion.Open();
        //    comando.ExecuteReader();

        //}
    }
}
