using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaOfertas.ComprarOferta;
using FrbaOfertas.CrearOferta;

namespace FrbaOfertas.CrearOferta
{
    public partial class CrearOferta : Form
    {
        IngresaProveedor anterior;
        Funciones.Funciones funciones;
        String cuit;
        String razonSocial;
        bool cerrar = false;
        public CrearOferta(String cuitP,String razonSocialP,Funciones.Funciones funcion, IngresaProveedor formularioAnterior)
        {
            InitializeComponent();
            anterior = formularioAnterior;
            funciones = funcion;
            cuit = cuitP;
            razonSocial = razonSocialP;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            if (anterior != null)
            {
                new IngresaProveedor(funciones).Show();
            }
            else
            {
                funciones.Show();
            }
            cerrar = true;
            Close();
        }
        private bool fechasValidas()
        {
            if (ElegirCantOfertas.obtenerFechaConfigFile() > dtpPublicacion.Value.Date)
            {
                MessageBox.Show("La fecha de publicacion no puede ser anterior a la fecha actual", "ERROR", MessageBoxButtons.OK);
                return false;
            }
            if (dtpPublicacion.Value.Date > dtpVencimiento.Value.Date) {
                MessageBox.Show("La fecha de vencimiento no puede ser anterior a la fecha de publicacion", "ERROR", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }
        private String crearStringAleatorio()
        {
            int longitud = 11;
            Guid miGuid = Guid.NewGuid();
            string token = Convert.ToBase64String(miGuid.ToByteArray());
            token = token.Replace("=", "").Replace("+", "").Replace("/", "");
            token.Substring(0, longitud).ToUpper();
            while( oFERTASTableAdapter.GetData().FindByCodigo_oferta(token)!=null){
                 longitud = 11;
                 miGuid = Guid.NewGuid();
                 token = Convert.ToBase64String(miGuid.ToByteArray());
                 token.Replace("=", "").Replace("+", "").Replace("/", "");
             }
            return token.Substring(0, longitud).ToUpper();
        }
        private bool preciosValidos()
        {
            if(txtPrecioLista.Text == "Precio de lista" || txtPrecioOferta.Text == "Precio de oferta")
            {
                MessageBox.Show("Precios no validos", "Error", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }
        private void btnCrear_Click(object sender, EventArgs e)
        {
            //validar
            //crearlo, etc
            if (this.fechasValidas()&& this.preciosValidos()){
                oFERTASTableAdapter.InsertQuery(this.crearStringAleatorio(), Convert.ToDecimal(txtPrecioOferta.Text), dtpPublicacion.Value, dtpVencimiento.Value,ndStock.Value,txtDescripcion.Text,Convert.ToDecimal(txtPrecioLista.Text),ndMaxima.Value,cuit,razonSocial);

                if (MessageBox.Show("Se ha creado una oferta ¿Desea crear otra?", "Cancelar", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    funciones.Show();
                    cerrar = true;
                    this.Close();
                }
            }
            
        }

       
        private void tbPrecioOferta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)&&!Char.IsControl(e.KeyChar)&&e.KeyChar!=',')
            {
                e.Handled = true;
            }
        }

        private void tbPrecioLista_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void txtDescripcion_Leave(object sender, EventArgs e)
        {
            if (txtDescripcion.Text == "")
            {
                txtDescripcion.Text = "Descripción";
                txtDescripcion.ForeColor = Color.Gainsboro;
            }
        }

        private void txtPrecioOferta_Leave(object sender, EventArgs e)
        {
            if (txtPrecioOferta.Text == "")
            {
                txtPrecioOferta.Text = "Precio de oferta";
                txtPrecioOferta.ForeColor = Color.Gainsboro;
            }
        }

        private void txtPrecioLista_Leave(object sender, EventArgs e)
        {
            if (txtPrecioLista.Text == "")
            {
                txtPrecioLista.Text = "Precio de lista";
                txtPrecioOferta.ForeColor = Color.Gainsboro;
            }
        }

        private void CrearOferta_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && cerrar == false)
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

        private void txtDescripcion_Enter(object sender, EventArgs e)
        {
            if (txtDescripcion.Text == "Descripción")
            {
                txtDescripcion.Text = "";
                txtDescripcion.ForeColor = Color.Black;
            }
        }

        private void txtPrecioOferta_Enter(object sender, EventArgs e)
        {
            if (txtPrecioOferta.Text == "Precio de oferta")
            {
                txtPrecioOferta.Text = "";
                txtPrecioOferta.ForeColor = Color.Black;
            }
        }

        private void txtPrecioLista_Enter(object sender, EventArgs e)
        {
            if (txtPrecioLista.Text == "Precio de lista")
            {
                txtPrecioLista.Text = "";
                txtPrecioLista.ForeColor = Color.Black;
            }
        }
    }
}
