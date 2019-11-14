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
        // En un rato arreglo este quilombo de variables globales
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
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            if (esModificar)
            {
                labelOpcionEliminar.Visible = false;
                txtNroClienteAEliminar.Visible = false;
            }
            else
            {
                // Sino, el usuario eligio "Eliminar cliente"
                planillaModificarCliente.ReadOnly = true;
                txtNroClienteAEliminar.Enabled = false;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            planillaModificarCliente.CellClick += planillaModificarCliente_CellClick;
        }

        private void planillaModificarCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == planillaModificarCliente.Columns["Seleccione"].Index)
            {
                MessageBox.Show("El indice de la columna ingresada es:" + e.ColumnIndex + " y la row es: " + e.RowIndex);

                int rowIndex = e.RowIndex;
                DataGridViewRow row = planillaModificarCliente.Rows[rowIndex];
                string ejemplo = Convert.ToString(row.Cells[1].Value);
                MessageBox.Show("Lo que me muestra es:" + ejemplo);
            }
        }

        private void mostrarColumnaExtra()
        {
            DataGridViewButtonColumn seleccionar = new DataGridViewButtonColumn();
            seleccionar.Name = "Seleccione";
            seleccionar.Text = "Modificar";
            seleccionar.UseColumnTextForButtonValue = true;
            int columnIndex = 10;
            if (planillaModificarCliente.Columns["DNI_cliente"] != null)
            {
                planillaModificarCliente.Columns.Insert(columnIndex, seleccionar);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            queries.modificarTablaDeUna(query, dataTable);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            buscarClientes();
            if (!esModificar)
            {
                txtNroClienteAEliminar.Enabled = true;
                btnEliminar.Enabled = true;
            }
            else
            {
                btnModificar.Enabled = true;
            }
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

            mostrarColumnaExtra();

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
            try
            {
                if (!String.IsNullOrWhiteSpace(txtNroClienteAEliminar.Text))
                {
                    Double nroCliente = Convert.ToDouble(txtNroClienteAEliminar.Text);
                    EliminarCliente cliente = new EliminarCliente();
                    cliente.NroCliente = nroCliente;
                    cliente.Show();
                }
                else
                {
                    MessageBox.Show("Por favor ingrese el numero de fila del cliente a eliminar");
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Error al eliminar cliente\nPor favor verificar datos ingresados");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void eliminarCliente()
        {
            // Para poder hacer esto falta la columna de Eliminado logico para la tabla cliente
        }
    }
}
