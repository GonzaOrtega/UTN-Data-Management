using FrbaOfertas.Commons;
using FrbaOfertas.ComprarOferta;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
                if (existeCupon(Convert.ToInt32(txtNroCuponIngresado.Text)))
                {
                    cuponEsDeProveedorYNoEstaVencido();
                }
                else
                {
                    MessageBox.Show("No existe el cupon");
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Error: Verificar que los datos ingresados sean correctos");
            }
        }

        private void cuponEsDeProveedorYNoEstaVencido()
        {
            if (cuponEsDeProveedor())
            {
                //if (cuponNoEstaVencido())
                //{
                //    canjearCupon();
                //}
                //else
                //{
                //    MessageBox.Show("El cupon esta vencido");
                //}
            }
            else
            {
                MessageBox.Show("El cupon no es de este proveedor");
            }
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

        private bool existeCupon(int nroCupon)
        {
            string codOfertaObtenido = null;
            bool existe =  Queries.existeCupon(nroCupon, ref codOfertaObtenido);
            cupon.CodOferta = codOfertaObtenido;
            return existe;
        }
    }
}
