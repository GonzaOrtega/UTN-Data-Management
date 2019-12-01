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
    public partial class ElegirUsuariosDestino : Form
    {
        Compra compra;

        public ElegirUsuariosDestino()
        {
            InitializeComponent();
        }

        public ElegirUsuariosDestino(Compra compra)
        {
            this.compra = compra;
            InitializeComponent();
        }

        private void btnCanjear_Click(object sender, EventArgs e)
        {
            this.comprar();
            //this.otorgarCupon(compra.CantCompra);
            this.mostrarCupones();
            this.Close();
        }

        private void mostrarCupones()
        {
            List<String> nroCupones;
            string query = "SELECT * FROM CUPON WHERE Codigo_oferta = '" + compra.CodOferta +
                "' AND DNI_cliente_origen = " + compra.DniCliente;
            nroCupones = Queries.obtenerNroCuponesDeCliente(query);
            mostrarCuponesEnPantalla(nroCupones);
        }

        private void mostrarCuponesEnPantalla(List<String> nroCupones)
        {
            string respuesta = "Compra realizada exitosamente\n\nLos cupones para canjear su compra son:\n";
            foreach (String nroCupon in nroCupones)
            {
                respuesta = respuesta + nroCupon + "\n";
            }
            MessageBox.Show(respuesta);
        }

        public void comprar()
        {
            
            compra.NumFactura = 0; // Esto indica que siempre va a ser nulo, se va a actualizar cuando se haga la facturacion
            // Descontar credito al usuario por la compra

            Queries.insertarCompra(compra);

            Queries.disminuirCreditoCliente(compra.DniCliente, compra.PrecioTotal);
        }

        public static DateTime obtenerFechaConfigFile()
        {
            String fechaConfigFile = ConfigurationManager.AppSettings["fecha"].ToString();
            DateTime fecha = DateTime.ParseExact(fechaConfigFile, "yyyy-MM-dd HH:mm tt", System.Globalization.CultureInfo.InvariantCulture);
            return fecha;
        }

        //public void otorgarCupon(int cantCompraDeseada)
        //{
        //    Cupon cupon = new Cupon();

        //    cupon.CodOferta = compra.CodOferta;
        //    cupon.DniClienteOrigen = compra.DniCliente;
        //    cupon.DniClienteDestino = Convert.ToDouble(txtClienteDestino.Text);

        //    // Insertar cupon funciona, falta probar lo de los N cupones (loop)
        //    for (int i = 0; i < cantCompraDeseada; i++)
        //    {
        //        Queries.insertarCupon(cupon);
        //    }
        //}

    }
}
