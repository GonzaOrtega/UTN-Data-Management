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
    public partial class ListadoProveedor : Form
    {
        public ListadoProveedor()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {

        }

        private String validarRazonSocial()
        {
            if (txtRazon.Text != "")
                return "Razon_social like '" + txtRazon.Text + "'";
                return "";
        }
        private String validarCUIT()
        {
            if (txtCuit.Text != "")

                return "CUIT_proveedor like '" + txtCuit.Text + "'";

            return "";
        }
        private String validarMail()
        {
            if (txtMail.Text != "")

                return "Mail like '" + txtMail.Text + "'";

            return "";
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            String expresion = this.validarRazonSocial();
            String expresion2 = this.validarCUIT();
            String expresion3 = this.validarMail();
           
            if (expresion != "" && (expresion2 != "" || expresion3 != ""))
            {
                expresion += " AND " + expresion2;
            }
            else { expresion += expresion2; }
            if (expresion2 != "" && expresion3 != "")
            {
                expresion += " AND " + expresion3;
            }
            else { expresion += expresion3; }
            dataGridView1.DataSource = proveedorTableAdapter1.abmListar().Select(expresion);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            new CrearProveedor().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
