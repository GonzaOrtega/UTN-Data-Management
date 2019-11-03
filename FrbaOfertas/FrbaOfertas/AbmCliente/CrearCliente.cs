using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaOfertas.AbmCliente
{
    public partial class CrearCliente : Form
    {
        
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
            Double DNI = Convert.ToDouble(txtDNIAltaCliente.Text);
            Double codigoPostal = Convert.ToDouble(txtCPAltaCliente.Text);
            string nombre = txtNombreAltaCliente.Text;
            string apellido = txtApellidoAltaCliente.Text;
            string direccion = txtDireccionAltaCliente.Text;
            string telefono = txtTelefonoAltaCliente.Text;
            string email = txtMailAltaCliente.Text;
            DateTime fechaNacimiento = dtpFechaNacimientoAltaCliente.Value;
            string ciudad = txtCiudadAltaCliente.Text;
            double credito = 200;


        }
    }
}
