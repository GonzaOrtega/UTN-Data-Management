using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaOfertas.Funciones;
namespace FrbaOfertas.CrearOferta
{
    public partial class IngresaProveedor : Form
    {
        Funciones.Funciones funcion;
        public IngresaProveedor(Funciones.Funciones funciones)
        {
            InitializeComponent();
            funcion = funciones;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            funcion.Show();
            Close();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (this.proveedorTableAdapter1.GetDataByPk(txtCuit.Text, txtRazonSocial.Text).Count() != 0)
            {
                new CrearOferta(txtCuit.Text, txtRazonSocial.Text, funcion,this).Show();
                Hide();
            }
            else
            {
                MessageBox.Show("CUIT o Razon social invalidos", "ERROR", MessageBoxButtons.OK);
            }
        }

        private void txtCuit_Click(object sender, EventArgs e)
        {
            if (txtCuit.Text == "CUIT") txtCuit.Text = "";
        }

        

        private void txtRazonSocial_Click(object sender, EventArgs e)
        {
            if (txtRazonSocial.Text == "Razón social") txtRazonSocial.Text = "";
        }

        private void txtCuit_Leave(object sender, EventArgs e)
        {
            if (txtCuit.Text == "") txtCuit.Text = "CUIT";
        }

        private void txtRazonSocial_Leave(object sender, EventArgs e)
        {
            if (txtRazonSocial.Text == "") txtRazonSocial.Text = "Razón social";
        }
    }
}
