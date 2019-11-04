using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlClient;
using FrbaOfertas.Commons;

namespace FrbaOfertas.AbmCliente
{
    public partial class CrearCliente : Form
    {
        DBAccess dB = new DBAccess();
        Cliente cliente = new Cliente();

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
            //if (MessageBox.Show("¿Está seguro que desea cancelar?", "Cancelar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //{
            //    this.Close();
            //}
            var conexion = DBConnection.getConnection();
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
                inicializoCliente();
                Inserts.insertarCliente(cliente, dB);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo ingresar el usuario. Por favor verificar datos ingresados", "Alta cliente");
                throw ex;
            }

        }

        private void inicializoCliente()
        {
            cliente.DNI = Convert.ToDouble(txtDNIAltaCliente.Text);
            cliente.CodigoPostal = Convert.ToDouble(txtCPAltaCliente.Text);
            cliente.Nombre = String.IsNullOrWhiteSpace(txtNombreAltaCliente.Text)? null : txtNombreAltaCliente.Text;
            cliente.Apellido = txtApellidoAltaCliente.Text;

            if (cbCasaODepartamento.Equals("Departamento"))
            {
                cliente.Direccion = txtDireccionAltaCliente.Text + ", Nro dpto:"
                    + txtNroDepartamentoAltaCliente.Text;
            }
            else
            {
                cliente.Direccion = txtDireccionAltaCliente.Text;
            }

            cliente.Telefono = Convert.ToDouble(txtTelefonoAltaCliente.Text);
            cliente.Email = txtMailAltaCliente.Text;
            cliente.FechaVencimiento = dtpFechaNacimientoAltaCliente.Value;
            cliente.Ciudad = txtCiudadAltaCliente.Text;
            cliente.Credito = 200; // Lo indicado por la consigna
        }
    }
}
