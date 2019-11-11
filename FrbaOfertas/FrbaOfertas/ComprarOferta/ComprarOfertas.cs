using FrbaOfertas.Commons;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaOfertas.ComprarOferta
{
    public partial class ComprarOfertas : Form
    {
        DataTable dataTable = new DataTable();
        public ComprarOfertas()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            buscarOfertas();
        }

        private void buscarOfertas()
        {
            string query = "select * from OFERTAS";
            Dictionary<String, String> dictionary = new Dictionary<String, String>();
            //this.limpiarEstructuras();

            try
            {
                if (this.hayCondicionesDeFiltro())
                {
                    query = query + " where ";
                    if (!String.IsNullOrWhiteSpace(txtCodOferta.Text))
                    {
                        query = query + "Codigo_oferta = " + Convert.ToDouble(txtCodOferta.Text);
                    }
                    if (!String.IsNullOrWhiteSpace(txtDescripcion.Text))
                    {
                        query = query + "Description LIKE '%" + txtDescripcion.Text + "%'";
                    }

                    this.buscar(query, dictionary);
                }
                else
                {
                    MessageBox.Show("No se ingresaron condiciones de filtro");
                }

            }
            catch (System.FormatException ex)
            {
                MessageBox.Show("Codigo de oferta ingresado incorrectamente");
            }
        }

        public void buscar(String query, Dictionary<String, String> dictionary)
        {
            new Queries().obtenerTabla(query, dataTable);
            planillaComprarOfertas.DataSource = dataTable;
            this.setRowNumber(planillaComprarOfertas);
        }

        private void setRowNumber(DataGridView dgv)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
            }
        }

        private void limpiarEstructuras()
        {
            txtCodOferta.Clear();
            txtDescripcion.Clear();
            txtNroOfertaDefinitiva.Clear();
        }

        private bool hayCondicionesDeFiltro()
        {
            return !String.IsNullOrWhiteSpace(txtCodOferta.Text) ||
                !String.IsNullOrWhiteSpace(txtDescripcion.Text);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }
    }
}
