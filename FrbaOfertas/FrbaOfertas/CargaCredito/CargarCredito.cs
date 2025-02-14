﻿using FrbaOfertas.Commons;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaOfertas.CargaCredito
{
    public partial class CargarCredito : Form
    {
        Credito credito = new Credito();
        CargarInfoTarjeta infoTarjeta;
        bool cerrado = false;
        public CargarCredito()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        int usuario;
        public CargarCredito(int usu)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            usuario = usu;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (seIngresaronDatos() && montoEsPositivo() && validarDNICliente())
                {
                    // Recordar que se tiene que hacer con un DNI existente en la DB, al mergear
                    credito.DniCliente = Convert.ToDouble(txtDNICliente.Text);
                    credito.Fecha = this.obtenerFechaConfigFile();
                    credito.Monto = Convert.ToDouble(txtMonto.Text);
                    credito.TipoPago = cbTipoPago.Text;

                    if (eligieronTarjeta())
                    {
                        infoTarjeta = new CargarInfoTarjeta(cbTipoPago.Text);
                        credito.HayTarjeta = true;
                        infoTarjeta.obtenerCredito(credito);
                        infoTarjeta.Show();
                    }
                    else
                    {
                        credito.HayTarjeta = false;
                        Queries.insertarCarga(credito);
                        Queries.aumentarCredito(credito.DniCliente, credito.Monto);
                        MessageBox.Show("Carga realizada satisfactoriamente", "Carga de credito");
                    }
                }
                else
                {
                    MessageBox.Show("Error en los datos ingresados\n\nPor favor, revisar");
                }

            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show("Error: Ya existe un cliente con ese DNI. Por favor ingrese otro");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar credito, revisar datos ingresados");
            }
        }

        private bool validarDNICliente()
        {
            string query = "select * from GEDEDE.CLIENTES where DNI_cliente = " + txtDNICliente.Text;
            Double dniClienteObtenido = Convert.ToDouble(Queries.obtenerDatoTabla(query, 0));
            return Convert.ToDouble(txtDNICliente.Text) == dniClienteObtenido;
        }

        private DateTime obtenerFechaConfigFile()
        {
            String fechaConfigFile = ConfigurationManager.AppSettings["fecha"].ToString();
            DateTime fecha = DateTime.ParseExact(fechaConfigFile, "yyyy-MM-dd HH:mm tt", System.Globalization.CultureInfo.InvariantCulture);
            return fecha;
        }

        private bool montoEsPositivo()
        {
            return Convert.ToDouble(txtMonto.Text) > 0;
        }

        private bool eligieronTarjeta()
        {
            return !cbTipoPago.Text.Equals("Efectivo");
        }

        private bool seIngresaronDatos()
        {
            return !String.IsNullOrEmpty(txtDNICliente.Text) && !String.IsNullOrEmpty(txtMonto.Text)
                && !String.IsNullOrEmpty(cbTipoPago.Text);
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
                cerrado = true;
                this.Close();
                new Funciones.Funciones(usuario).Show();
        }

        private void CargarCredito_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && cerrado == false)
            {
                if (MessageBox.Show("¿Está seguro que desea salir del sistema?", "WARNING", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDNICliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void CargarCredito_Load(object sender, EventArgs e)
        {

        }
    }
}
