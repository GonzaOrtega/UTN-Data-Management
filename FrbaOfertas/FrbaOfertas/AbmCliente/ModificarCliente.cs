using FrbaOfertas.Commons;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaOfertas.AbmCliente
{
    public partial class ModificarCliente : Form
    {
        Queries queries = new Queries();
        string query = "select * from CLIENTES";
        DataTable dataTable = new DataTable();
        Dictionary<String, String> dictionary = new Dictionary<String, String>();
        Double dniglobal;
        List<TextBox> textboxes = new List<TextBox>();
        CommonsForms commons = new CommonsForms();
        bool esModificar = false;

        public bool EsModificar { get => esModificar; set => esModificar = value; }

        public ModificarCliente()
        {
            InitializeComponent();
        }

        private void ModificarUsuario_Load(object sender, EventArgs e)
        {
            this.cargarTextboxes();
            if (esModificar)
            {
                btnEliminar.Enabled = false;
                labelOpcionEliminar.Visible = false;
                txtIndiceClienteAEliminar.Visible = false;
            }
            else
            {
                // Sino, el usuario eligio "Eliminar cliente"
                btnModificar.Enabled = false;
                planillaModificarCliente.ReadOnly = true;
                txtIndiceClienteAEliminar.Enabled = false;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            queries.modificarTablaDeUna(query, dataTable);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            buscarClientes();
            txtIndiceClienteAEliminar.Enabled = true;
        }
       
        private void txtEmailTLibre_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            commons.limpiarTextboxes(textboxes);
        }

        private void buscarClientes()
        {
            this.limpiarEstructuras();
            try
            {
                if (this.hayCondicionesDeFiltro())
                {
                    this.guardarStringEnDiccionario("Nombre", txtNombreTLibre.Text);
                    this.guardarStringEnDiccionario("Apellido", txtApellidoTLibre.Text);
                    this.guardarStringEnDiccionario("Mail", txtEmailTLibre.Text);
                    this.DNIEsCorrecto();

                    this.buscar();
                }
                else
                {
                    MessageBox.Show("No se ingresaron condiciones de filtro");
                }

            }
            catch (System.FormatException ex)
            {
                MessageBox.Show("DNI ingresado incorrectamente");
            }
        }





        // Metodos principales

        private void setRowNumber(DataGridView dgv)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
            }
        }

        public void buscar()
        {
            query = query + " WHERE ";
            if (this.hayDNI())
            {
                query = query + "DNI_cliente = " + dniglobal;
            }
            if (this.hayOtrasCondiciones())
            {
                if (this.hayDNI())
                {
                    query = query + " AND ";
                }
                this.cargarCondiciones();
            }
            queries.obtenerTabla(query, dataTable);
            planillaModificarCliente.DataSource = dataTable;
            this.setRowNumber(planillaModificarCliente);
        }
       
        public void cargarCondiciones()
        {
            int longDiccionario = dictionary.Count;
            foreach(KeyValuePair<String, String> entry in dictionary)
            {
                query = query + entry.Key + " LIKE '%" + entry.Value + "%'";
                longDiccionario--;
                if (longDiccionario > 0)
                    query = query + " AND ";
            }
        }

        private void DNIEsCorrecto()
        {
            if (!String.IsNullOrWhiteSpace(txtDNIPExacta.Text))
            {
                dniglobal = Convert.ToDouble(txtDNIPExacta.Text);
            }
        }
        private void guardarStringEnDiccionario(String key, String value)
        {
            if (!String.IsNullOrWhiteSpace(value))
            {
                dictionary.Add(key, value);
            }
        }

        private void cargarTextboxes()
        {
            textboxes.Add(txtApellidoTLibre);
            textboxes.Add(txtDNIPExacta);
            textboxes.Add(txtEmailTLibre);
            textboxes.Add(txtNombreTLibre);
        }

        public void limpiarEstructuras()
        {
            dictionary.Clear();
            query = "select * from CLIENTES";
            planillaModificarCliente.DataSource = null;
            dataTable.Clear();
        }



        // Metodos auxiliares
        public Boolean hayDNI()
        {
            return !String.IsNullOrWhiteSpace(txtDNIPExacta.Text);
        }

        private Boolean hayCondicionesDeFiltro()
        {
            return this.hayOtrasCondiciones() || this.hayDNI();
        }

        public Boolean hayOtrasCondiciones()
        {
            return !String.IsNullOrWhiteSpace(txtApellidoTLibre.Text) 
                || !String.IsNullOrWhiteSpace(txtEmailTLibre.Text)
                || !String.IsNullOrWhiteSpace(txtNombreTLibre.Text);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
