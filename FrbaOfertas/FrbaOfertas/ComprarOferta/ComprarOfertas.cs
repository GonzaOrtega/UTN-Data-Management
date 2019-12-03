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
        bool cerrado = false;
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
            string query = "SELECT * FROM GEDEDE.OFERTAS";
            this.limpiarEstructuras();
            DateTime fechaConfigFile = this.obtenerFechaConfigFile();

            try
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
            if (e.ColumnIndex == planillaComprarOfertas.Columns["Comprar"].Index && e.RowIndex!=-1)
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow row = planillaComprarOfertas.Rows[rowIndex];
                ElegirCantOfertas ofertas = new ElegirCantOfertas();
                ofertas.CodOferta = Convert.ToString(row.Cells[0].Value);
                ofertas.DniClienteOrigen = clienteId;
                ofertas.Show();
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
            if(planillaComprarOfertas.Columns.Count>0)
            planillaComprarOfertas.Columns.RemoveAt(0);
            
        }

        private bool hayCondicionesDeFiltro()
        {
            return hayCodOferta() || hayDescripcion();
        }

        private void button3_Click(object sender, EventArgs e)
        {
                cerrado = true;
                this.Close();
                new Funciones.Funciones(usuario).Show();
         
        }

        private void ComprarOfertas_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && cerrado == false && cerrado == false)
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
            limpiarEstructuras();
        }

        private void planillaComprarOfertas_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
