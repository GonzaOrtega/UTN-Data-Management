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

namespace FrbaOfertas.ComprarOferta
{
    public partial class ElegirCantOfertas : Form
    {
        // Variable harcodeada para poder insertar los datos, se obtiene de las otras formas
        Double credito;
        // Aclaracion, como tenemos como PK al codOferta y DNICliente => Un cliente solo puede comprar una oferta
        // (Independientemente de sus cantidades) solo una vez, porque sino no se cumple unicidad.
        // Lo cual me parece que tiene sentido ya que cuando una compra una oferta, por mas que compre muchas unidades, solo la compra una vez
        Double dniClienteOrigen;

        // Esta se obtiene por la forma ComprarOfertas
        String codOferta;

        // Estas son de esta forma
        int cantCompraDeseada;
        Double precioTotal;

        public double DniClienteOrigen { get => dniClienteOrigen; set => dniClienteOrigen = value; }
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
                cantCompraDeseada = Convert.ToInt32(txtCantOfertas.Text);

                if (cantPedidaEsMenorACantidadMaxima(cantCompraDeseada))
                {
                    if (creditoSeaSuficiente(cantCompraDeseada))
                    {
                        // Insertar Compra y Cupones correspondientes
                        // Por ahora voy a considerar que los cupones que se generan son mandados a la misma persona,
                        //      que la elije el usuario
                        
                        this.comprar();
                        this.otorgarCupon(cantCompraDeseada);
                        this.mostrarCupones();
                        this.Close();
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

            }
            catch(System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show("No se puede comprar esta oferta porque el usuario ya la ha comprado");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: verificar datos ingresados");
            }
        }

        private void mostrarCupones()
        {
            List<String> nroCupones;
            string query = "SELECT * FROM CUPON WHERE Codigo_oferta = '" + codOferta +
                "' AND DNI_cliente_origen = " + dniClienteOrigen;
            nroCupones = Queries.obtenerNroCuponesDeCliente(query);
            mostrarCuponesEnPantalla(nroCupones);
        }

        private void mostrarCuponesEnPantalla(List<String> nroCupones)
        {
            string respuesta = "Compra realizada exitosamente\n\nLos cupones para canjear su compra son:\n";
            foreach(String nroCupon in nroCupones)
            {
                respuesta = respuesta + nroCupon + "\n";
            }
            MessageBox.Show(respuesta);
        }

        public void comprar()
        {
            Compra compra = new Compra();
            compra.CantCompra = cantCompraDeseada;
            compra.CodOferta = codOferta;
            compra.DniCliente = dniClienteOrigen;
            compra.FechaCompra = obtenerFechaConfigFile();
            compra.NumFactura = 0; // Esto indica que siempre va a ser nulo, se va a actualizar cuando se haga la facturacion
            // Descontar credito al usuario por la compra

            Queries.insertarCompra(compra);

            Queries.disminuirCreditoCliente(dniClienteOrigen, precioTotal);
        }

        public static DateTime obtenerFechaConfigFile()
        {
            String fechaConfigFile = ConfigurationManager.AppSettings["fecha"].ToString();
            DateTime fecha = DateTime.ParseExact(fechaConfigFile, "yyyy-MM-dd HH:mm tt", System.Globalization.CultureInfo.InvariantCulture);
            return fecha;
        }

        public void otorgarCupon(int cantCompraDeseada)
        {
            Cupon cupon = new Cupon();

            cupon.CodOferta = codOferta;
            cupon.DniClienteOrigen = dniClienteOrigen;
            cupon.DniClienteDestino = Convert.ToDouble(txtClienteDestino.Text);

            // Insertar cupon funciona, falta probar lo de los N cupones (loop)
            for (int i = 0; i < cantCompraDeseada; i ++) { 
                Queries.insertarCupon(cupon);
            }
        }

        private DateTime diaAleatorio()
        {
            Random gen = new Random();
            DateTime start = obtenerFechaConfigFile();
            int range = (DateTime.Today - start).Days;
            return start.AddDays(gen.Next(range));
        }

        private bool creditoSeaSuficiente(int cantDeseada)
        {
            string query = "SELECT * FROM OFERTAS WHERE Codigo_oferta = '" + codOferta + "'";
            Double preciOferta = Convert.ToDouble(Queries.obtenerDatoTabla(query, 1));
            precioTotal = preciOferta * cantDeseada;

            string queryCliente = "SELECT * FROM CLIENTES WHERE DNI_Cliente = " + dniClienteOrigen;

            credito = Convert.ToDouble(Queries.obtenerDatoTabla(queryCliente, 9));

            return credito >= precioTotal;
        }

        private bool cantPedidaEsMenorACantidadMaxima(int cantDeseada)
        {
            string query = "SELECT * FROM OFERTAS WHERE Codigo_oferta = '" + codOferta + "'";
            int cantMaximaOferta = Convert.ToInt32(Queries.obtenerDatoTabla(query, 7));
            return cantDeseada <= cantMaximaOferta;
        }
    }
}
