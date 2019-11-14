using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaOfertas.AbmProveedor
{
    public partial class CrearProveedor : Form
    {
        public CrearProveedor()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCiudad.Clear();
            txtRubro.Clear();
            txtTelefono.Clear();
            txtRazonSocial.Clear();
            txtNC.Clear();
            txtMail.Clear();
            txtDireccion.Clear();
            txtCUIT.Clear();
            txtCP.Clear();
        }
        private bool validarPk()
        {
            if(proveedorTableAdapter1.GetData().Select("CUIT_proveedor like '"+txtCUIT.Text +"' and"+"Razon_social like '"+txtRazonSocial.Text+"'").Count() != 0)
            {
                MessageBox.Show("Lo sentimos el CUIT y la razon social ya pertenecen a otro proveedor", "ERROR!", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }
        private bool validarRubro()
        {
            if(rubroTableAdapter1.GetData().Select("Descripcion like '" + txtRubro.Text + "'").Count() == 0)
            {
                MessageBox.Show("Lo sentimos el rubro no existe", "ERROR!", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (this.validarPk() && this.validarRubro()) {
                DataRow id_rubro = rubroTableAdapter1.GetData().Select("Descripcion like '" + txtRubro.Text + "'").First();
                proveedorTableAdapter1.InsertQuery(txtCUIT.Text, txtRazonSocial.Text, txtDireccion.Text, txtCiudad.Text, Convert.ToDecimal(txtTelefono.Text),Convert.ToInt32(id_rubro["ID_rubro"].ToString()), txtMail.Text, Convert.ToDecimal(txtCP.Text), txtNC.Text);
           
            }
        }

        private void txtCP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
