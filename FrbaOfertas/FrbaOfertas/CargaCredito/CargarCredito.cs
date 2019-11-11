using FrbaOfertas.Commons;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        CargarInfoTarjeta infoTarjeta = new CargarInfoTarjeta();
        public CargarCredito()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CargarCredito_Load(object sender, EventArgs e)
        {

        }
        private void txtMonto_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (seIngresaronDatos() && montoEsPositivo())
                {
                    // Recordar que se tiene que hacer con un DNI existente en la DB
                    credito.DniCliente = Convert.ToDouble(txtDNICliente.Text);
                    credito.Fecha = dtpFecha.Value;
                    credito.Monto = Convert.ToDouble(txtMonto.Text);
                    credito.TipoPago = cbTipoPago.Text;

                    if (eligieronTarjeta())
                    {
                        credito.HayTarjeta = true;
                        infoTarjeta.obtenerCredito(credito);
                        infoTarjeta.Show();
                    }
                    else
                    {
                        credito.HayTarjeta = false;
                        Queries.insertarCarga(credito);
                    }
                }
                else
                {
                    MessageBox.Show("No se ingresaron datos o el monto es negativo\nPor favor, revisar ");
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Error al cargar credito, revisar datos ingresados");
            }
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
    }
}
