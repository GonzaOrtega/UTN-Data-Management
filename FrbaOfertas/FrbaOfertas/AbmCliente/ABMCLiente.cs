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
    public partial class ABMCliente : Form
    {
        // En un rato arreglo este quilombo de variables globales
        string query = "select * from CLIENTES";
        DataTable dataTable = new DataTable();
        Dictionary<String, String> dictionary = new Dictionary<String, String>();
        Double dniglobal;
        bool esModificar = true;

        public bool EsModificar { get => esModificar; set => esModificar = value; }

        public ABMCliente()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            planillaModificarCliente.CellClick += planillaModificarCliente_CellClick;
        }

        int usuario;
        public ABMCliente(int usu)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            usuario = usu;
            planillaModificarCliente.CellClick += planillaModificarCliente_CellClick; // Para que se cargue el evento de hacer click
        }

        private void ModificarUsuario_Load(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            planillaModificarCliente.CellClick -= planillaModificarCliente_CellClick;
            planillaModificarCliente.CellClick += planillaModificarCliente_CellClick;
        }

        private void planillaModificarCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == planillaModificarCliente.Columns["Seleccione"].Index)
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow row = planillaModificarCliente.Rows[rowIndex];
                Cliente cliente = cargarClienteParaModificar(row);
                if (esModificar)
                {
                    CrearYModificarCliente modificarCliente = new CrearYModificarCliente();
                    modificarCliente.Cliente = cliente;
                    modificarCliente.EsModificado = true;
                    modificarCliente.BuscarCliente = this;
                    modificarCliente.Show();
                }
                else
                {
                    MessageBox.Show("Esta seguro que desea eliminar el Cliente: " + 
                        row.Cells[0].Value + "?", "Eliminar cliente", MessageBoxButtons.YesNo);
                    dniglobal = Convert.ToDouble(row.Cells[0].Value);

                    // Nos olvidamos que al eliminar un cliente hay que eliminarlo de todos lados!!!
                    Queries.eliminarCliente(dniglobal);
                    MessageBox.Show("El cliente se ha borrado correctamente", "Eliminar cliente");
                    limpiarTodo();
                }
            }
        }

        private Cliente cargarClienteParaModificar(DataGridViewRow row)
        {
            Cliente cliente = new Cliente();

            cliente.DNI = Convert.ToDouble(row.Cells[0].Value);
            validarCP(row, cliente);
            cliente.Nombre = Convert.ToString(row.Cells[2].Value);
            cliente.Apellido = Convert.ToString(row.Cells[3].Value);
            cliente.Direccion = Convert.ToString(row.Cells[4].Value);
            validarTelefono(row, cliente);
            cliente.Email = Convert.ToString(row.Cells[6].Value);
            validarFecha(row, cliente);
            cliente.Ciudad = Convert.ToString(row.Cells[8].Value);
            cliente.Credito = Convert.ToDouble(row.Cells[9].Value);

            return cliente;
        }

        private void validarCP(DataGridViewRow row, Cliente cliente)
        {
            if (row.Cells[1].Value.Equals(DBNull.Value))
            {
                cliente.CodigoPostal = 0;
            }
            else
            {
                cliente.CodigoPostal = Convert.ToDouble(row.Cells[1].Value);
            }
        }

        private void validarFecha(DataGridViewRow row, Cliente cliente)
        {
            if (row.Cells[7].Value.Equals(DBNull.Value))
            {
                cliente.FechaVencimiento = DateTime.Now;
            }
            else
            {
                cliente.FechaVencimiento = Convert.ToDateTime(row.Cells[7].Value);
            }
        }

        private void validarTelefono(DataGridViewRow row, Cliente cliente)
        {
            if (row.Cells[5].Value.Equals(DBNull.Value))
            {
                cliente.Telefono = 0;
            }
            else
            {
                cliente.Telefono = Convert.ToDouble(row.Cells[5].Value);
            }
        }

        private void mostrarColumnasModificarYModificar()
        {
            agregarColumnaModificar(11, "Modificar");
            agregarColumnaModificar(12, "Eliminar");
        }

        private void agregarColumnaModificar(int columnIndex, string textoDeBoton)
        {
            DataGridViewButtonColumn seleccionar = new DataGridViewButtonColumn();
            seleccionar.Name = "Seleccione";
            seleccionar.Text = textoDeBoton;
            seleccionar.UseColumnTextForButtonValue = true;
            if (planillaModificarCliente.Columns["DNI_cliente"] != null)
            {
                planillaModificarCliente.Columns.Insert(columnIndex, seleccionar);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            buscarClientes();
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
            limpiarTodo();
        }

        public void limpiarTodo()
        {
            txtApellidoTLibre.Clear();
            txtDNIPExacta.Clear();
            txtEmailTLibre.Clear();
            txtNombreTLibre.Clear();
            limpiarEstructuras();
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
                }
                this.buscar();

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
            if (hayCondicionesDeFiltro())
            {
                query = query + " WHERE ";
            }
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
            Queries queries = new Queries();
            queries.obtenerTabla(query, dataTable);
            planillaModificarCliente.DataSource = dataTable;
            this.setRowNumber(planillaModificarCliente);

            mostrarColumnasModificarYModificar();

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

        public void limpiarEstructuras()
        {
            dictionary.Clear();
            query = "select * from CLIENTES";
            planillaModificarCliente.DataSource = null;
            planillaModificarCliente.Columns.Clear();
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new CrearYModificarCliente().Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea cancelar?", "Cancelar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
                new Funciones.Funciones(usuario).Show();
            }
        }
    }
}
