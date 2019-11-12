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

                if (cantPedidaEsMenorACantidadMaxima(cantCompraDeseada))
                {
                    if (creditoSeaSuficiente(cantCompraDeseada))
                    {
                        // Insertar Compra y Cupones correspondientes
                        // Por ahora voy a considerar que los cupones que se generan son mandados a la misma persona,
                        //      que la elije el usuario
                        
                        
                        
                    }
                    else
                    {
                        MessageBox.Show("No tiene suficiente credito para realizar la transaccion");
                    }
                }
                else
                {
                    MessageBox.Show("La cantidad deseada es mayor a la cantidad permitida por usuario");
                }

            }catch(Exception ex)
            {
                MessageBox.Show("Error: verificar datos ingresados");
            }
        }

        private bool creditoSeaSuficiente(int cantDeseada)
        {
            string query = "SELECT * FROM OFERTAS WHERE Codigo_oferta = '" + codOferta + "'";
            Double preciOferta = Convert.ToDouble(Queries.obtenerDatoOferta(query, 1));
            return credito >= preciOferta * cantDeseada;
        }

        private bool cantPedidaEsMenorACantidadMaxima(int cantDeseada)
        {
            string query = "SELECT * FROM OFERTAS WHERE Codigo_oferta = '" + codOferta + "'";
            int cantMaximaOferta = Convert.ToInt32(Queries.obtenerDatoOferta(query, 7));
            return cantDeseada <= cantMaximaOferta;
        }
    }
}
