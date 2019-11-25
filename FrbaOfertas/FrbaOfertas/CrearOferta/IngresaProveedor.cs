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
        bool cerrar = false;
        string tipo = null;

        public IngresaProveedor(Funciones.Funciones funciones)
        {
            InitializeComponent();
            funcion = funciones;
        }

        public IngresaProveedor(Funciones.Funciones funciones, string tipo)
        {
            this.tipo = tipo;
            InitializeComponent();
            funcion = funciones;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            funcion.Show();
            cerrar = true;
            Close();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (this.proveedorTableAdapter1.GetDataByPk(txtCuit.Text, txtRazonSocial.Text).Count() != 0)
            {
                if (tipo == "consumirOferta")
                {
                    new ConsumoOferta.ConsumoOfertas(txtCuit.Text, txtRazonSocial.Text,funcion.Usuario).Show();
                }
                else
                {
                    new CrearOferta(txtCuit.Text, txtRazonSocial.Text, funcion,this).Show();
                }
                cerrar = true;
                Close();
            }
            else
            {
                MessageBox.Show("CUIT o Razon social invalidos", "ERROR", MessageBoxButtons.OK);
            }
        }

        private void txtCuit_Leave(object sender, EventArgs e)
        {
            if (txtCuit.Text == "")
            {
                txtCuit.Text = "CUIT";
                txtCuit.ForeColor = Color.Gainsboro;
            }
        }

        private void txtRazonSocial_Leave(object sender, EventArgs e)
        {
            if (txtRazonSocial.Text == "")
            {
                txtRazonSocial.Text = "Razón social";
                txtRazonSocial.ForeColor = Color.Gainsboro;
            }
        }

        private void IngresaProveedor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && cerrar == false)
            {
                if (MessageBox.Show("¿Está seguro que desea salir del sistema?", "WARNING", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else { Application.Exit(); }
            }
        }

        private void txtCuit_Enter(object sender, EventArgs e)
        {
            if (txtCuit.Text == "CUIT")
            {
                txtCuit.Text = "";
                txtCuit.ForeColor = Color.Black;
            }
        }

        private void txtRazonSocial_Enter(object sender, EventArgs e)
        {
            if (txtRazonSocial.Text == "Razón social")
            {
                txtRazonSocial.Text = "";
                txtRazonSocial.ForeColor = Color.Black;
            }
        }

        private void IngresaProveedor_Load(object sender, EventArgs e)
        {

        }
    }
}
