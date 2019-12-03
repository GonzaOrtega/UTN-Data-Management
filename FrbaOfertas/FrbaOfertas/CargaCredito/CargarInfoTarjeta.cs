using FrbaOfertas.Commons;
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
    public partial class CargarInfoTarjeta : Form
    {

        Credito credito;
        Tarjeta tarjeta = new Tarjeta();
        String tipoDePago;

        public CargarInfoTarjeta(String tipoPago)
        {
            InitializeComponent();
            tipoDePago = tipoPago;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (hayDatosIngresados())
            {
                verificarTiposDeDatosIngresados();
            }
            else
            {
                MessageBox.Show("No hay datos ingresados");
            }
        }

        private void verificarTiposDeDatosIngresados()
        {
            if (vencimientoMayorAHoy())
            {
                try
                {
                    credito.NroTarjeta = Convert.ToDouble(txtNroTarjeta.Text);

                    // Importante que la fecha de vencimeiento sea mayor a la fecha de hoy
                    tarjeta.FechaVencimiento = dtpFechaVencimiento.Value;
                    tarjeta.TipoTarjeta = Convert.ToString(tipoDePago);
                    tarjeta.Titular = txtTitular.Text;
                    tarjeta.NroTarjeta = Convert.ToInt32(txtNroTarjeta.Text);
                    
                    Queries.insertarTarjeta(tarjeta);
                    Queries.insertarCarga(credito);
                    Queries.aumentarCredito(credito.DniCliente, credito.Monto);
                    MessageBox.Show("Carga realizada satisfactoriamente", "Carga de credito");

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error en los datos ingresados");
                }
            }
            else
            {
                MessageBox.Show("La tarjeta esta vencida\n\nPor favor ingrese otra");
            }
        }

        private bool vencimientoMayorAHoy()
        {
            return DateTime.Compare(dtpFechaVencimiento.Value, this.obtenerFechaConfigFile()) > 0;
        }

        private DateTime obtenerFechaConfigFile()
        {
            String fechaConfigFile = ConfigurationManager.AppSettings["fecha"].ToString();
            DateTime fecha = DateTime.ParseExact(fechaConfigFile, "yyyy-MM-dd HH:mm tt", System.Globalization.CultureInfo.InvariantCulture);
            return fecha;
        }
        public void obtenerCredito(Credito creditoRecibido)
        {
            credito = creditoRecibido;
        }

        private bool hayDatosIngresados()
        {
            return !String.IsNullOrWhiteSpace(txtTitular.Text) &&
                !String.IsNullOrWhiteSpace(tipoDePago);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNroTarjeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void CargarInfoTarjeta_Load(object sender, EventArgs e)
        {

        }
    }
}
