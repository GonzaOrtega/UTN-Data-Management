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
    public partial class ComprarOferta : Form
    {
        DataTable dataTable = new DataTable();
        public ComprarOferta()
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
            this.limpiarEstructuras();

            try
            {
                if (this.hayCondicionesDeFiltro())
                {
                    this.guardarStringEnDiccionario("Codigo_oferta", txtCodOferta.Text, dictionary);
                    this.guardarStringEnDiccionario("Description", txtDescripcion.Text, dictionary);

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
            this.cargarCondiciones(query, dictionary);
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

        public void cargarCondiciones(String query, Dictionary<String, String> dictionary)
        {
            int longDiccionario = dictionary.Count;
            foreach (KeyValuePair<String, String> entry in dictionary)
            {
                query = query + entry.Key + " LIKE '%" + entry.Value + "%'";
                longDiccionario--;
                if (longDiccionario > 0)
                    query = query + " AND ";
            }
        }

        private void guardarStringEnDiccionario(String key, String value,
            Dictionary<String, String> dictionary)
        {
            if (!String.IsNullOrWhiteSpace(value))
            {
                dictionary.Add(key, value);
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
            return !String.IsNullOrEmpty(txtCodOferta.Text) &&
                !String.IsNullOrEmpty(txtDescripcion.Text);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }
    }
}
