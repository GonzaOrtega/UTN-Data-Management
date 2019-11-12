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
        Cupon cupon;
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

        private static void cuponEsDeProveedorYNoEstaVencido()
        {
            //if (cuponEsDeProveedor())
            //{
            //    if (cuponNoEstaVencido())
            //    {
            //        canjearCupon();
            //    }
            //    else
            //    {
            //        MessageBox.Show("El cupon esta vencido");
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("El cupon no es de este proveedor");
            //}
        }

        private bool cuponEsDeProveedor()
        {

        }

        private bool existeCupon(int nroCupon)
        {
            bool existeCupon = false;
            cupon =  Queries.existeCupon(nroCupon, ref existeCupon);
            return existeCupon;
        }
    }
}
