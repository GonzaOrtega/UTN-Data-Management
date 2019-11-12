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

namespace FrbaOfertas.ComprarOferta
{
    public partial class ElegirCantOfertas : Form
    {
        Double clienteId;
        String codOferta;
        // Tambien hardcodeado para poner las condiciones
        Double credito = 250;

        public double ClienteId { get => clienteId; set => clienteId = value; }
        public string CodOferta { get => codOferta; set => codOferta = value; }

        public ElegirCantOfertas()
        {
            InitializeComponent();
        }

        private void ElegirCantOfertas_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int cantCompraDeseada = Convert.ToInt32(txtCantOfertas.Text);
                Double dniClienteDestino = Convert.ToDouble(txtClienteDestino.Text);

                if (creditoSeaSuficiente(cantCompraDeseada))
                {
                    //if (!cantEsMayorACantMaxima())
                    //{

                    //}
                }
                else
                {
                    MessageBox.Show("No tiene suficiente credito para realizar la transaccion");
                }

            }catch(Exception ex)
            {
                MessageBox.Show("Error: verificar datos ingresados");
            }
        }

        private bool creditoSeaSuficiente(int cantDeseada)
        {
            string query = "SELECT * FROM OFERTAS WHERE Codigo_oferta = '" + codOferta + "'";
            Double creditoLimite = Queries.obtenerCantidadCompra(query);
            return credito >= creditoLimite * cantDeseada;
        }
    }
}
