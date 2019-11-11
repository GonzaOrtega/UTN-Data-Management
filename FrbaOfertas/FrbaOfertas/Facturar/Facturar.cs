using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaOfertas.Facturar
{
    public partial class Facturar : Form
    {
        Funciones.Funciones funciones;
        public Facturar(Funciones.Funciones fun)
        {
            InitializeComponent();
            funciones = fun;
            btnFacturar.Visible = false;
        }

        private void cOMPRABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cOMPRABindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gD2C2019DataSet);

        }

        private void txtCuit_Click(object sender, EventArgs e)
        {
            if (txtCuit.Text == "CUIT") txtCuit.Text="";
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
        private bool fechasValidas()
        {
            if(dtpInicio.Value.Date > dtpFin.Value.Date)
            {
                MessageBox.Show("Fechas invalidas", "ERROR", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }
        private bool existeProveedor()
        {
            if(proveedorTableAdapter1.GetDataByCuitRazonsocial(txtCuit.Text,txtRazonSocial.Text).Count() == 0)
            {
                MessageBox.Show("El proveedor ingresado no existe", "ERROR", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }
        private void btnVer_Click(object sender, EventArgs e)
        {
            if (this.fechasValidas() && this.existeProveedor())
            {
                cOMPRADataGridView.DataSource = this.compraTableAdapter1.GetDataBy(txtRazonSocial.Text, txtCuit.Text);
                //cOMPRADataGridView.DataBind();
               /* DataRow[] rowArray = compraTableAdapter1.GetDataBy(txtRazonSocial.Text, txtCuit.Text).Select();
                cOMPRADataGridView.Rows.AddRange((DataGridViewRow [])rowArray);*/
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            funciones.Show();
            Close();
        }
    }
}
