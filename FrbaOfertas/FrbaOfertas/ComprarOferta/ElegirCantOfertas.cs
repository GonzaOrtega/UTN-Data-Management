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
    public partial class ElegirCantOfertas : Form
    {
        // Variable harcodeada para poder insertar los datos, se obtiene de las otras formas
        Double credito = 250;
        // Aclaracion, como tenemos como PK al codOferta y DNICliente => Un cliente solo puede comprar una oferta
        // (Independientemente de sus cantidades) solo una vez, porque sino no se cumple unicidad.
        // Lo cual me parece que tiene sentido ya que cuando una compra una oferta, por mas que compre muchas unidades, solo la compra una vez
        // Funcionar funciona, el problema es que por las FKs y todo eso, se tiene que probar con pruebas muy bien pensadas!!
        Double dniClienteOrigen = 1;

        // Esta se obtiene por la forma ComprarOfertas
        String codOferta;

        // Estas son de esta forma
        int cantCompraDeseada;
        Double dniClienteDestino;

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
                dniClienteDestino = Convert.ToDouble(txtClienteDestino.Text);

                if (cantPedidaEsMenorACantidadMaxima(cantCompraDeseada))
                {
                    if (creditoSeaSuficiente(cantCompraDeseada))
                    {
                        // Insertar Compra y Cupones correspondientes
                        // Por ahora voy a considerar que los cupones que se generan son mandados a la misma persona,
                        //      que la elije el usuario
                        
                        this.comprar();
                        this.otorgarCupon(cantCompraDeseada);

                        //MessageBox.Show("Compra realizada correctamente");
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

            }catch(Exception ex)
            {
                MessageBox.Show("Error: verificar datos ingresados");
            }
        }

        public void comprar()
        {
            Compra compra = new Compra();
            compra.CantCompra = cantCompraDeseada;
            compra.CodOferta = codOferta;
            compra.DniCliente = dniClienteOrigen;
            compra.FechaCompra = this.obtenerFechaConfigFile();
            compra.NumFactura = 0; // Esto indica que siempre va a ser nulo, se va a actualizar cuando se haga la facturacion
            // Nota: Agregar el trigger correspondiente

            Queries.insertarCompra(compra);

        }

        private DateTime obtenerFechaConfigFile()
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
            cupon.DniClienteDestino = dniClienteDestino;

            // Insertar cupon funciona, falta probar lo de los N cupones (loop)
            for (int i = 0; i < cantCompraDeseada; i ++) { 
                Queries.insertarCupon(cupon);
            }
        }

        private DateTime diaAleatorio()
        {
            Random gen = new Random();
            DateTime start = this.obtenerFechaConfigFile();
            int range = (DateTime.Today - start).Days;
            return start.AddDays(gen.Next(range));
        }

        private bool creditoSeaSuficiente(int cantDeseada)
        {
            string query = "SELECT * FROM OFERTAS WHERE Codigo_oferta = '" + codOferta + "'";
            Double preciOferta = Convert.ToDouble(Queries.obtenerDatoTabla(query, 1));
            return credito >= preciOferta * cantDeseada;
        }

        private bool cantPedidaEsMenorACantidadMaxima(int cantDeseada)
        {
            string query = "SELECT * FROM OFERTAS WHERE Codigo_oferta = '" + codOferta + "'";
            int cantMaximaOferta = Convert.ToInt32(Queries.obtenerDatoTabla(query, 7));
            return cantDeseada <= cantMaximaOferta;
        }
    }
}
