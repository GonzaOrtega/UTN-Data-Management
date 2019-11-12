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
                cOMPRADataGridView.DataSource = this.cOMPRATableAdapter.GetDataBy(txtRazonSocial.Text, txtCuit.Text,dtpInicio.Value,dtpFin.Value);
                if (cOMPRADataGridView.RowCount >1)
                    btnFacturar.Visible = true;
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            funciones.Show();
            Close();
        }
        private int crearNroFactura()
        {
            var seed = Environment.TickCount;
            var random = new Random(seed);
            int nroFactura = random.Next(100000, 999999);
            while (facturaTableAdapter1.GetData().FindByNum_factura(nroFactura) !=null)
            {
                nroFactura = random.Next(100000,999999);
            }
            return nroFactura;
        }
        private void btnFacturar_Click(object sender, EventArgs e)
        {
            decimal total = 0;
            int nroFactura = this.crearNroFactura();
            foreach (DataGridViewRow row in cOMPRADataGridView.Rows)
            {
                String oferta = Convert.ToString(row.Cells["Codigo_oferta"].Value);
                if (oferta != "")
                {
                    DataRow dataRow = ofertasTableAdapter1.GetDataBy1(oferta).First();
                    total += Convert.ToInt32(row.Cells["Cantidad_compra"].Value) * Convert.ToDecimal(dataRow["Precio_oferta"].ToString());
                }       
            }
            
            facturaTableAdapter1.Insert(Convert.ToDecimal(nroFactura),DateTime.Now,total, txtCuit.Text,txtRazonSocial.Text);
            foreach (DataGridViewRow row in cOMPRADataGridView.Rows)
            {
                String oferta = Convert.ToString(row.Cells["Codigo_oferta"].Value);
                if (oferta != "")
                {
                    cOMPRATableAdapter.UpdateQuery(nroFactura, oferta, Convert.ToDecimal(row.Cells["DNI_cliente"].Value), Convert.ToDateTime(row.Cells["Fecha_compra"].Value));
            
                }
             }
            if(MessageBox.Show("Compras facturadas ¿Desea continuar facturanto?","FELICIDADES!",MessageBoxButtons.YesNo) ==DialogResult.No)
            {
                funciones.Show();
                Close();
            }
            btnFacturar.Visible = false;
        }

        private void txtCuit_TextChanged(object sender, EventArgs e)
        {
            btnFacturar.Visible = false;
        }

        private void txtRazonSocial_TextChanged(object sender, EventArgs e)
        {
            btnFacturar.Visible = false;
        }
        private void dtpInicio_ValueChanged(object sender, EventArgs e)
        {
            btnFacturar.Visible = false;
        }

        private void dtpFin_ValueChanged(object sender, EventArgs e)
        {
            btnFacturar.Visible = false;
        }

        private void Facturar_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
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
