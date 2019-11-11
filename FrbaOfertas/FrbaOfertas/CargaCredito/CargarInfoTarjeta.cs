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
    public partial class CargarInfoTarjeta : Form
    {

        Credito credito = new Credito();

        public CargarInfoTarjeta()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (hayDatosIngresados())
            {
                try
                {
                    credito.NroTarjeta = Convert.ToDouble(txtNroTarjeta.Text);
                    Queries.insertarCarga(credito);
                    this.Close();
                }catch(Exception ex)
                {
                    MessageBox.Show("Error al cargar credito, revisar datos ingresados");
                }
            }
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
    }
}
