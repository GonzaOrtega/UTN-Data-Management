using FrbaOfertas.Commons;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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

        Double clienteId = 15015312;

        public ComprarOfertas()
        {
            InitializeComponent();
        }

        public ComprarOfertas(Double DNICliente)
        {
            clienteId = Convert.ToDouble(DNICliente);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            buscarOfertas();
        }

        private void buscarOfertas()
        {
            string query = "SELECT * FROM OFERTAS";
            this.limpiarEstructuras();
            DateTime fechaConfigFile = this.obtenerFechaConfigFile();

            try
            {
                if (this.hayCondicionesDeFiltro())
                {
                    // Agrego restriccion de la fecha de vencimiento
                    query = query + " WHERE Fecha_vencimiento > '" + fechaConfigFile + "' ";
                    if (hayCodOferta())
                    {
                        query = query + "AND Codigo_oferta = '" + txtCodOferta.Text + "'";
                    }
                    if (hayDescripcion())
                    {
                        query = query + "AND Description LIKE '%" + txtDescripcion.Text + "%'";
                    }

                    this.buscar(query);

                    // Si todo esta ok, le permite al usuario avanzar
                    btnSiguiente.Enabled = true;
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

        private DateTime obtenerFechaConfigFile()
        {
            String fechaConfigFile = ConfigurationManager.AppSettings["fecha"].ToString();
            DateTime fecha = DateTime.ParseExact(fechaConfigFile, "yyyy-MM-dd HH:mm tt", System.Globalization.CultureInfo.InvariantCulture);
            return fecha;
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

        // Para que quede mas lindo
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
            string nroOferta = txtNroOfertaDefinitiva.Text;
            ElegirCantOfertas ofertas = new ElegirCantOfertas();
            ofertas.CodOferta = txtNroOfertaDefinitiva.Text;
            ofertas.DniClienteOrigen = clienteId;
            ofertas.Show();
        }

        private bool eligioOferta()
        {
            return !String.IsNullOrEmpty(txtNroOfertaDefinitiva.Text);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ComprarOfertas_Load(object sender, EventArgs e)
        {
            btnSiguiente.Enabled = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
