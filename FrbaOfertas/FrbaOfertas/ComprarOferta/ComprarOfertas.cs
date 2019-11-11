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
            string query = "SELECT * FROM OFERTAS";
            //Dictionary<String, String> dictionary = new Dictionary<String, String>();
            this.limpiarEstructuras();

            try
            {
                if (this.hayCondicionesDeFiltro())
                {
                    query = query + " WHERE ";
                    if (hayCodOferta())
                    {
                        query = query + "Codigo_oferta = '" + txtCodOferta.Text + "'";
                    }
                    if (hayDescripcion())
                    {
                        if (hayCodOferta())
                        {
                            query = query + " AND ";
                        }
                        query = query + "Description LIKE '%" + txtDescripcion.Text + "%'";
                    }

                    this.buscar(query);
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

        private bool hayDescripcion()
        {
            return !String.IsNullOrWhiteSpace(txtDescripcion.Text);
        }

        private bool hayCodOferta()
        {
            return !String.IsNullOrWhiteSpace(txtCodOferta.Text);
        }

        public void buscar(String query)
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
            planillaComprarOfertas.DataSource = null;
            dataTable.Clear();
        }

        private bool hayCondicionesDeFiltro()
        {
            return hayCodOferta() || hayDescripcion();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }
    }
}
