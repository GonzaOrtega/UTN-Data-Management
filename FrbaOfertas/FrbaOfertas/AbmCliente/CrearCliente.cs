﻿using System;
using System.Windows.Forms;
using FrbaOfertas.Commons;
using System.Collections.Generic;

namespace FrbaOfertas.AbmCliente
{
    public partial class CrearCliente : Form
    {
        Cliente cliente = new Cliente();
        List<TextBox> textboxes = new List<TextBox>();
        CommonsForms commons = new CommonsForms();

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
            this.Close();
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
            if (seCargaronPKs())
            {
                try
                {
                    validarCliente();
                    inicializoCliente();
                    Queries.insertarCliente(cliente);
                    commons.limpiarTextboxes(textboxes);
                }catch(Exception ex)
                {
                    MessageBox.Show("No se pudo ingresar el usuario. Por favor verificar datos ingresados", "Alta cliente");
                    //throw ex;
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
            Validacion.validarDoubleTxt(ref txtDNIAltaCliente);
            Validacion.validarDoubleTxt(ref txtCPAltaCliente);
            Validacion.validarDoubleTxt(ref txtTelefonoAltaCliente);
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            commons.limpiarTextboxes(textboxes);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
