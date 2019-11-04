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
                if (seCargaronPKs())
                {
                    validarCliente();
                    inicializoCliente();
                    Inserts.insertarCliente(cliente, dB);
                }
                else
                {
                    MessageBox.Show("Por favor ingrese los campos obligatorios", "Alta cliente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo ingresar el usuario. Por favor verificar datos ingresados", "Alta cliente");
                throw ex;
            }

        }

        public bool seCargaronPKs()
        {
            return !String.IsNullOrEmpty(txtDNIAltaCliente.Text) && !String.IsNullOrEmpty(txtCPAltaCliente.Text);
        }

        public void inicializoCliente()
        {
            cliente.DNI = Convert.ToDouble(txtDNIAltaCliente.Text);
            cliente.CodigoPostal = Convert.ToDouble(txtCPAltaCliente.Text);
            cliente.Nombre = txtNombreAltaCliente.Text;
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

        public bool esEntero(string texto)
        {
            int a;
            return int.TryParse(texto, out a);
        }

        public void validarCliente()
        {

            if (!this.esEntero(txtDNIAltaCliente.Text)){
                txtDNIAltaCliente.Text = "0";
            }

            if (!this.esEntero(txtCPAltaCliente.Text))
            {
                txtCPAltaCliente.Text = "0";
            }

            if (!this.esEntero(txtTelefonoAltaCliente.Text))
            {
                txtTelefonoAltaCliente.Text = "0";
            }
        }
    }
}
