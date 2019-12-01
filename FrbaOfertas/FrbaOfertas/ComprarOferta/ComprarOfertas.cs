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
            planillaComprarOfertas.CellClick += planillaComprarOfertas_CellClick;
        }



        int usuario;
        public ComprarOfertas(Double DNICliente, int usu)
        {
            clienteId = Convert.ToDouble(DNICliente);
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            usuario = usu;
            planillaComprarOfertas.CellClick += planillaComprarOfertas_CellClick;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            buscarOfertas();
            mostrarColumnaComprar(10, "Comprar");
        }

        private void mostrarColumnaComprar(int columnIndex, string textoDeColumna)
        {
            DataGridViewButtonColumn seleccionar = new DataGridViewButtonColumn();
            seleccionar.Name = textoDeColumna;
            //seleccionar.UseColumnTextForButtonValue = true;
            if (planillaComprarOfertas.Columns["Codigo_oferta"] != null)
            {
                planillaComprarOfertas.Columns.Insert(columnIndex, seleccionar);
            }
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
                    //btnSiguiente.Enabled = true;
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

        private void planillaComprarOfertas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            planillaComprarOfertas.CellClick -= planillaComprarOfertas_CellClick;
            planillaComprarOfertas.CellClick += planillaComprarOfertas_CellClick;
        }

        private void planillaComprarOfertas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = planillaComprarOfertas.Rows[rowIndex];
            ElegirCantOfertas ofertas = new ElegirCantOfertas();
            ofertas.CodOferta = Convert.ToString(row.Cells[0].Value);
            ofertas.DniClienteOrigen = clienteId;
            ofertas.Show();
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ComprarOfertas_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea cancelar?", "Cancelar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
                new Funciones.Funciones(usuario).Show();
            }
        }
    }
}
