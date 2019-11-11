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

        Credito credito = new Credito();
        Tarjeta tarjeta = new Tarjeta();

        public CargarInfoTarjeta()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (hayDatosIngresados() && vencimientoMayorAHoy())
            {
                try
                {
                    credito.NroTarjeta = Convert.ToDouble(txtNroTarjeta.Text);

                    // Importante que la fecha de vencimeiento sea mayor a la fecha de hoy
                    tarjeta.FechaVencimiento = dtpFechaVencimiento.Value;
                    tarjeta.TipoTarjeta = Convert.ToString(cbTipoTarjeta.Text);
                    tarjeta.Titular = txtTitular.Text;
                    if (tarjeta.TipoTarjeta.Equals(credito.TipoPago))
                    {
                        //Queries.insertarTarjeta(tarjeta);
                        //Queries.insertarCarga(credito);
                    }
                    else
                    {
                        MessageBox.Show("Error: Tipo de pago especificado es distinto al tipo de tarjeta");
                    }
                    //DateTime fechaSistema = Convert.ToDateTime(ConfigurationManager.AppSettings["fecha"].ToString());
                    //MessageBox.Show("Prueba de fecha en archivo de config: " + fechaSistema);
                    
                    this.Close();
                }catch(Exception ex)
                {
                    MessageBox.Show("Error en los datos ingresados");
                }
            }
            else
            {
                MessageBox.Show("No hay datos ingresados");
            }
        }

        private bool vencimientoMayorAHoy()
        {
            // TODO: Cambiar la "fecha de hoy" por la que esta en el archivo de configuracion
            return DateTime.Compare(dtpFechaVencimiento.Value, DateTime.Today) != 0;
        }

        private void CargarInfoTarjeta_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void obtenerCredito(Credito creditoRecibido)
        {
            credito = creditoRecibido;
        }

        private bool hayDatosIngresados()
        {
            return !String.IsNullOrWhiteSpace(txtTitular.Text) &&
                !String.IsNullOrWhiteSpace(cbTipoTarjeta.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
