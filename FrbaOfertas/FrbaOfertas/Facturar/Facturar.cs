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
        bool cerrar = false;
        Funciones.Funciones funciones;
        public Facturar(Funciones.Funciones fun)
        {
            InitializeComponent();
            funciones = fun;
            btnFacturar.Visible = false;
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
            if(proveedorTableAdapter1.GetDataByPk(txtCuit.Text,txtRazonSocial.Text).Count() == 0)
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
            cerrar = true;
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
            facturaTableAdapter1.Insert(Convert.ToDecimal(nroFactura), DateTime.Now, total, txtCuit.Text, txtRazonSocial.Text);
            foreach (DataGridViewRow row in cOMPRADataGridView.Rows)
            {
                String oferta = Convert.ToString(row.Cells["Codigo_oferta"].Value);
                if (oferta != "")
                {
                    DataRow dataRow = ofertasTableAdapter1.GetData().FindByCodigo_oferta(oferta);
                    total += Convert.ToInt32(row.Cells["Cantidad_compra"].Value) * Convert.ToDecimal(dataRow["Precio_oferta"].ToString());
                    cOMPRATableAdapter.UpdateNroFactura(nroFactura, oferta, Convert.ToDecimal(row.Cells["DNI_cliente"].Value), Convert.ToDateTime(row.Cells["Fecha_compra"].Value));
                    iteM_FACTURATableAdapter1.InsertQuery(Convert.ToDecimal(row.Cells["DNI_cliente"].Value), nroFactura, Convert.ToString(row.Cells["Codigo_oferta"].Value), Convert.ToInt32(row.Cells["Cantidad_compra"].Value) * Convert.ToDecimal(dataRow["Precio_oferta"].ToString()));
                }       
            }
            facturaTableAdapter1.UpdateQuery(total, nroFactura);
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
            if (e.CloseReason == CloseReason.UserClosing &&cerrar == false)
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

        private void button1_Click(object sender, EventArgs e)
        {
            if(cOMPRADataGridView.Rows.Count > 1)
            cOMPRADataGridView.Rows.Clear();
            btnFacturar.Visible = false;
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
    }
}
