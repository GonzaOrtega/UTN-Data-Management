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

namespace FrbaOfertas.ComprarOferta
{
    public partial class ElegirUsuariosDestino : Form
    {
        Compra compra;
        Dictionary<String, int> dnisMasCant = new Dictionary<String, int>();
        int contadorDeCantOfertasElegidas = 0;

        public ElegirUsuariosDestino()
        {
            InitializeComponent();
            this.txtCantCupones.Maximum = 5;
        }

        public ElegirUsuariosDestino(Compra compra)
        {
            this.compra = compra;
            InitializeComponent();
            this.txtCantCupones.Maximum = compra.CantCompra;
        }

        private void btnCanjear_Click(object sender, EventArgs e)
        {
            try
            {
                if (esDNI(txtDNIDestino.Text))
                {
                    this.obtenerClientesDestino();
                }
                else
                {
                    MessageBox.Show("Error al ingresar los datos, por favor revisar");
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show("No se puede comprar esta oferta porque el usuario ya la ha comprado");
            }

        }

        private bool esDNI(String dniPotencial)
        {
            double a;
            return !String.IsNullOrWhiteSpace(dniPotencial) && Double.TryParse(dniPotencial, out a);
        }

        public void obtenerClientesDestino()
        {
            if(txtCantCupones.Value <= compra.CantCompra)
            {
                contadorDeCantOfertasElegidas += Convert.ToInt32(txtCantCupones.Value);
                if (dnisMasCant.ContainsKey(txtDNIDestino.Text))
                    dnisMasCant[txtDNIDestino.Text] += Convert.ToInt32(txtCantCupones.Value);
                else
                    dnisMasCant.Add(txtDNIDestino.Text, Convert.ToInt32(txtCantCupones.Value));

                if(contadorDeCantOfertasElegidas < compra.CantCompra)
                {
                    MessageBox.Show("Por favor ingrese mas personas para que se entreguen los " + (compra.CantCompra - contadorDeCantOfertasElegidas) + " cupones restantes");
                    this.limpiarTextboxes();
                }
            }
            if(contadorDeCantOfertasElegidas == compra.CantCompra)
            {
                this.iniciarOperacionDeCompra();
            }
            
        }

        private void iniciarOperacionDeCompra()
        {
            this.comprar();
            this.otorgarCupon(compra.CantCompra);
            this.mostrarCupones();
            this.Close();
        }

        private void limpiarTextboxes()
        {
            txtDNIDestino.Clear();
            txtCantCupones.Value = 1;
            txtCantCupones.Maximum = compra.CantCompra - contadorDeCantOfertasElegidas;
        }

        private void mostrarCupones()
        {
            List<String> nroCupones;
            string query = "SELECT * FROM GEDEDE.CUPON WHERE Codigo_oferta = '" + compra.CodOferta +
                "' AND DNI_cliente_origen = " + compra.DniCliente;
            nroCupones = Queries.obtenerNroCuponesDeCliente(query);
            mostrarCuponesEnPantalla(nroCupones);
        }

        private void mostrarCuponesEnPantalla(List<String> nroCupones)
        {
            string respuesta = "Compra realizada exitosamente\n\nLos cupones para canjear su compra son:\n";
            foreach (String nroCupon in nroCupones)
            {
                string query = "SELECT * FROM GEDEDE.CUPON WHERE Codigo_cupon = " + nroCupon;
                string dniClienteDestino = Convert.ToString(Queries.obtenerDatoTabla(query, 3));
                respuesta = respuesta + "DNI: " + dniClienteDestino + "\tCodigo de cupon: " + nroCupon + "\n";
            }
            MessageBox.Show(respuesta);
        }

        public void comprar()
        {
            compra.NumFactura = 0; // Esto indica que siempre va a ser nulo, se va a actualizar cuando se haga la facturacion

            Queries.insertarCompra(compra);

            Queries.disminuirCreditoCliente(compra.DniCliente, compra.PrecioTotal);
        }

        public static DateTime obtenerFechaConfigFile()
        {
            String fechaConfigFile = ConfigurationManager.AppSettings["fecha"].ToString();
            DateTime fecha = DateTime.ParseExact(fechaConfigFile, "yyyy-MM-dd HH:mm tt", System.Globalization.CultureInfo.InvariantCulture);
            return fecha;
        }

        private void ElegirUsuariosDestino_Load(object sender, EventArgs e)
        {

        }

        public void otorgarCupon(int cantCompraDeseada)
        {
            foreach(KeyValuePair<String, int> entry in dnisMasCant)
            {
                //for(int i = 0; i < Convert.ToInt32(entry.Value); i ++)
                //{
                    Cupon cupon = new Cupon();

                    cupon.CodOferta = compra.CodOferta;
                    cupon.DniClienteOrigen = compra.DniCliente;
                    cupon.Cantidad = Convert.ToInt32(entry.Value);
                    cupon.FechaVencimiento = compra.FechaCompra.AddDays(30);
                    cupon.DniClienteDestino = Convert.ToDouble(txtDNIDestino.Text);
                    Queries.insertarCupon(cupon);
                //}
            }


            // Insertar cupon funciona, falta probar lo de los N cupones (loop)
            //for (int i = 0; i < cantCompraDeseada; i++)
            //{
            //    Queries.insertarCupon(cupon);
            //}

            }

    }
}
