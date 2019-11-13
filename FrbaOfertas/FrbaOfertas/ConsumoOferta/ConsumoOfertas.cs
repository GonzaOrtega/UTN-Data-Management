using FrbaOfertas.Commons;
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
        int nroCupon;
        // Valores que me los van a pasar por parametro, por ahora los hardcodeo
        string cuit = "26-50981919-5";
        string razonSocial = "Proveedor N°24S.R.L.";
        public ConsumoOfertas()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCanjear_Click(object sender, EventArgs e)
        {
            try
            {
                nroCupon = Convert.ToInt32(txtNroCuponIngresado.Text);
                if (existeCupon())
                {
                    cuponEsDeProveedorYNoEstaVencido();
                }
                else
                {
                    MessageBox.Show("No existe el cupon", "Error");
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Verificar que los datos ingresados sean correctos", "Error");
            }
        }

        private void cuponEsDeProveedorYNoEstaVencido()
        {
            if (cuponEsDeProveedor())
            {
                if (cuponEstaVencido())
                {
                    //canjearCupon();
                }
                else
                {
                    MessageBox.Show("El cupon esta vencido");
                }
            }
            else
            {
                MessageBox.Show("El cupon no es de este proveedor", "Error");
            }
        }

        private bool cuponEstaVencido()
        {
            string query = "SELECT * FROM OFERTAS WHERE Codigo_oferta = '" +
                cupon.CodOferta + "'";
            DateTime fechaVencimiento = Convert.ToDateTime(Queries.obtenerDatoTabla(query, 3));
            return DateTime.Compare(fechaVencimiento, this.obtenerFechaConfigFile()) > 0;
        }

        private DateTime obtenerFechaConfigFile()
        {
            String fechaConfigFile = ConfigurationManager.AppSettings["fecha"].ToString();
            DateTime fecha = DateTime.ParseExact(fechaConfigFile, "yyyy-MM-dd HH:mm tt", System.Globalization.CultureInfo.InvariantCulture);
            return fecha;
        }

        private bool cuponEsDeProveedor()
        {
            string query = "SELECT * FROM OFERTAS WHERE Codigo_oferta = '" +
                cupon.CodOferta + "'";
            //DateTime fechaVencimientoOferta = Convert.ToDateTime(Queries.obtenerDatoTabla(query, 3));
            string cuitObtenido = Convert.ToString(Queries.obtenerDatoTabla(query, 8));
            string razonSocialObtenida = Convert.ToString(Queries.obtenerDatoTabla(query, 9));
            return cuit.Equals(cuitObtenido) && razonSocial.Equals(razonSocialObtenida); 
        }

        private bool existeCupon()
        {
            string codOfertaObtenido = null;
            bool existe =  Queries.existeCupon(nroCupon, ref codOfertaObtenido);
            cupon.CodOferta = codOfertaObtenido;
            return existe;
        }
    }
}
