﻿using FrbaOfertas.Commons;
using FrbaOfertas.ComprarOferta;
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

namespace FrbaOfertas.ConsumoOferta
{
    public partial class ConsumoOfertas : Form
    {
        Cupon cupon = new Cupon();
        bool cerrado = false;
        // Valores que me los van a pasar por parametro, por ahora los hardcodeo
        string cuit = "46-76549578-5";
        string razonSocial = "Proveedor N°36S.R.L.";
        
        public ConsumoOfertas()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        int usuario;
        public ConsumoOfertas(string cuit, string razonSocial,int usu)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            usuario = usu;
            this.cuit = cuit;
            this.razonSocial = razonSocial;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCanjear_Click(object sender, EventArgs e)
        {
            if(datosIngresadosCorrectamente() && validarDNICliente())
            {
                cupon.CodCupon = Convert.ToInt32(txtNroCuponIngresado.Text);
                if (existeCupon())
                {
                    cuponEsDeProveedorYNoEstaVencido();
                }
                else
                {
                    MessageBox.Show("No existe el cupon", "Error");
                }
            }
            else
            {
                MessageBox.Show("Error al ingresar datos");
            }
        }

        private bool datosIngresadosCorrectamente()
        {
            Int32 a;
            return !String.IsNullOrWhiteSpace(txtNroCuponIngresado.Text) &&
                !String.IsNullOrWhiteSpace(txtDNICliente.Text) &&
                Int32.TryParse(txtDNICliente.Text, out a) &&
                Int32.TryParse(txtNroCuponIngresado.Text, out a);
        }

        private bool validarDNICliente()
        {
            string query = "select * from GEDEDE.CLIENTES where DNI_cliente = " + txtDNICliente.Text;
            Double dniClienteObtenido = Convert.ToDouble(Queries.obtenerDatoTabla(query, 0));
            return Convert.ToDouble(txtDNICliente.Text) == dniClienteObtenido;
        }

        private void cuponEsDeProveedorYNoEstaVencido()
        {
            if (cuponEsDeProveedor())
            {
                if (cuponEsDelCliente())
                {
                    cuponEstaVencidoYEstaCanjeado();
                }
                else
                {
                    MessageBox.Show("El cliente no puede canjear el cupon porque no le pertenece");
                }
            }
            else
            {
                MessageBox.Show("El cupon no es de este proveedor", "Error");
            }
        }

        private bool cuponEsDelCliente()
        {
            string query = "SELECT * FROM GEDEDE.CUPON WHERE Codigo_cupon = " + cupon.CodCupon;
            string DNICliente = Convert.ToString(Queries.obtenerDatoTabla(query, 3));
            return txtDNICliente.Text.Equals(DNICliente);
        }

        private void cuponEstaVencidoYEstaCanjeado()
        {
            if (cuponEstaVencido())
            {
                if (!cuponEstaCanjeado())
                {
                    canjearCupon();
                    MessageBox.Show("Cupon canjeado correctamente");
                }
                else
                {
                    MessageBox.Show("El cupon ya esta canjeado");
                }
            }
            else
            {
                MessageBox.Show("El cupon esta vencido");
            }
        }

        private bool cuponEstaCanjeado()
        {
            string query = "SELECT * FROM GEDEDE.CUPON WHERE Codigo_cupon = " + cupon.CodCupon;
            return !String.IsNullOrWhiteSpace(Queries.obtenerDatoTabla(query, 1));
        }

        private void canjearCupon()
        {
            Queries.canjearCupon(cupon);
        }

        private bool cuponEstaVencido()
        {
            string query = "SELECT * FROM GEDEDE.OFERTAS WHERE Codigo_oferta = '" +
                cupon.CodOferta + "'";
            DateTime fechaVencimiento = Convert.ToDateTime(Queries.obtenerDatoTabla(query, 3));
            cupon.FechaEntrega = this.obtenerFechaConfigFile();
            return DateTime.Compare(fechaVencimiento, cupon.FechaEntrega) > 0;
        }

        private DateTime obtenerFechaConfigFile()
        {
            String fechaConfigFile = ConfigurationManager.AppSettings["fecha"].ToString();
            DateTime fecha = DateTime.ParseExact(fechaConfigFile, "yyyy-MM-dd HH:mm tt", System.Globalization.CultureInfo.InvariantCulture);
            return fecha;
        }

        private bool cuponEsDeProveedor()
        {
            string query = "SELECT * FROM GEDEDE.OFERTAS WHERE Codigo_oferta = '" +
                cupon.CodOferta + "'";
            //DateTime fechaVencimientoOferta = Convert.ToDateTime(Queries.obtenerDatoTabla(query, 3));
            string cuitObtenido = Queries.obtenerDatoTabla(query, 8);
            string razonSocialObtenida = Queries.obtenerDatoTabla(query, 9);
            return cuit.Equals(cuitObtenido) && razonSocial.Equals(razonSocialObtenida); 
        }

        private bool existeCupon()
        {
            string codOfertaObtenido = null;
            bool existe =  Queries.existeCupon(cupon.CodCupon, ref codOfertaObtenido);
            cupon.CodOferta = codOfertaObtenido;
            return existe;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cerrado = true;
                this.Close();
                new Funciones.Funciones(usuario).Show();
            
        }

        private void ConsumoOfertas_Load(object sender, EventArgs e)
        {

        }

        private void ConsumoOfertas_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && cerrado == false)
            {
                if (MessageBox.Show("¿Está seguro que desea salir del sistema?", "WARNING", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    Application.Exit();
                }
            }
        }
    }
}
