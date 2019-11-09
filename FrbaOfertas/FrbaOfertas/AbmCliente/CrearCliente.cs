using System;
using System.Windows.Forms;
using FrbaOfertas.Commons;
using System.Collections.Generic;

namespace FrbaOfertas.AbmCliente
{
    public partial class CrearCliente : Form
    {
        DBAccess dB = new DBAccess();
        Cliente cliente = new Cliente();
        List<TextBox> textboxes = new List<TextBox>();

        public CrearCliente()
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
            agregarTextboxes();
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
                    Queries.insertarCliente(cliente, dB);
                    limpiarTextboxes();
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





        // Metodos auxiliares
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
        
        public bool esEntero(string texto)
        {
            int a;
            return int.TryParse(texto, out a);
        }
        
        public bool seCargaronPKs()
        {
            return !String.IsNullOrEmpty(txtDNIAltaCliente.Text);
        }

        public void agregarTextboxes()
        {
            textboxes.Add(txtApellidoAltaCliente);
            textboxes.Add(txtCiudadAltaCliente);
            textboxes.Add(txtCPAltaCliente);
            textboxes.Add(txtDireccionAltaCliente);
            textboxes.Add(txtDNIAltaCliente);
            textboxes.Add(txtMailAltaCliente);
            textboxes.Add(txtNombreAltaCliente);
            textboxes.Add(txtNroDepartamentoAltaCliente);
            textboxes.Add(txtTelefonoAltaCliente);
        }
        
        public void limpiarTextboxes()
        {
            foreach(TextBox txt in textboxes) {
                txt.Clear();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.limpiarTextboxes();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
