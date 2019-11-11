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
                cOMPRADataGridView.DataSource = this.compraTableAdapter1.GetDataBy(txtRazonSocial.Text, txtCuit.Text,dtpInicio.Value,dtpFin.Value);
                if (cOMPRADataGridView.RowCount >1)
                    btnFacturar.Visible = true;
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            funciones.Show();
            Close();
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            double total = 0;
            foreach(DataGridViewRow row in cOMPRADataGridView.Rows)
            {
                String oferta = Convert.ToString(row.Cells["Codigo_oferta"].Value);
                if (oferta != "")
                {
                    DataRow dataRow = ofertasTableAdapter1.GetDataBy1(oferta).First();
                    total += Convert.ToInt32(row.Cells["Cantidad_compra"].Value) * Convert.ToDouble(dataRow["Precio_oferta"].ToString());
                }        
            }
            txtCuit.Text = total.ToString();
        }
    }
}
