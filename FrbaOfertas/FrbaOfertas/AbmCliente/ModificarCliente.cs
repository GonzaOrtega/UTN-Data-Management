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
        string query = "select * from CLIENTES";
        DataTable dataTable = new DataTable();
        //DBAccess dB = new DBAccess();
        SqlDataAdapter adapter = new SqlDataAdapter();
        Dictionary<String, String> dictionary = new Dictionary<String, String>();
        Double dniglobal;

        public ModificarCliente()
        {
            InitializeComponent();
        }

        private void ModificarUsuario_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Decimal cp = Convert.ToDecimal(planillaModificarCliente.SelectedCells[1].Value);
            //string nombre = Convert.ToString(planillaModificarCliente.SelectedCells[2].Value);
            //string apellido = Convert.ToString(planillaModificarCliente.SelectedCells[3].Value);
            //string direccion = Convert.ToString(planillaModificarCliente.SelectedCells[4].Value);
            //Decimal telefono = Convert.ToDecimal(planillaModificarCliente.SelectedCells[5].Value);
            //string mail = Convert.ToString(planillaModificarCliente.SelectedCells[6].Value);
            //DateTime fechaNacimiento = Convert.ToDateTime(planillaModificarCliente.SelectedCells[7].Value);
            //string ciudad = Convert.ToString(planillaModificarCliente.SelectedCells[8].Value);
            //Decimal credito = Convert.ToDecimal(planillaModificarCliente.SelectedCells[9].Value);

            //this.cLIENTESTableAdapter.updateCliente(cp,
            //    nombre,
            //    apellido,
            //    direccion,
            //    telefono,
            //    mail,
            //    fechaNacimiento,
            //    ciudad,
            //    credito,
            //    1);

            //SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder();

            //string update = sqlCommandBuilder.GetUpdateCommand().CommandText.ToString();

            //this.cLIENTESTableAdapter.Update()

            DBConnection.getConnection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //string query = "select * from CLIENTES";
            //DBConnection.cargarPlanilla(planillaModificarCliente, query);
            ////SqlCommandBuilder DbCommandBuilder = new SqlCommandBuilder(adapter);


            //string nombre = Convert.ToString(this.cLIENTESTableAdapter
            //    .GetClienteByPalabraExacta(txtPalabraExacta.Text).NombreColumn.DefaultValue);
            //MessageBox.Show("Lo obtenido es:" + nombre);

            // TODO: This line of code loads data into the 'gD2C2019DataSet.CLIENTES' table. You can move, or remove it, as needed.
            //this.cLIENTESTableAdapter.Fill(this.gD2C2019DataSet.CLIENTES);

            //dB.readDatathroughAdapter(query, dataTable);

            this.limpiarEstructuras();
            if (this.hayCondicionesDeFiltro())
            {
                this.guardarStringEnDiccionario("Nombre", txtNombreTLibre.Text);
                this.guardarStringEnDiccionario("Apellido", txtApellidoTLibre.Text);
                this.guardarStringEnDiccionario("Mail", txtEmailTLibre.Text);

                try
                {
                    if (!String.IsNullOrWhiteSpace(txtDNIPExacta.Text))
                    {
                        dniglobal = Convert.ToDouble(txtDNIPExacta.Text);
                    }
                    this.buscar();

                }catch(System.FormatException ex)
                {
                    MessageBox.Show("DNI ingresado incorrectamente");
                }
            }
            else
            {
                MessageBox.Show("No se ingresaron condiciones de filtro");
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
            obtenerTabla();
        }

        public void limpiarEstructuras()
        {
            dictionary.Clear();
            query = "select * from CLIENTES";
            //planillaModificarCliente.Rows.Clear();
            //planillaModificarCliente.Refresh();
            planillaModificarCliente.DataSource = null;
            dataTable.Clear();
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

        public Boolean hayDNI()
        {
            return !String.IsNullOrWhiteSpace(txtDNIPExacta.Text);
        }

        public Boolean hayCondicionesDeFiltro()
        {
            return this.hayOtrasCondiciones() || this.hayDNI();
        }

        private Boolean hayOtrasCondiciones()
        {
            return !String.IsNullOrWhiteSpace(txtApellidoTLibre.Text) 
                || !String.IsNullOrWhiteSpace(txtEmailTLibre.Text)
                || !String.IsNullOrWhiteSpace(txtNombreTLibre.Text);
        }

        public void guardarStringEnDiccionario(String key, String value)
        {
            if (!String.IsNullOrWhiteSpace(value))
            {
                dictionary.Add(key, value);
            }
        }

        public void guardarDouble(String key, TextBox textBox)
        {
            Validacion.validarDoubleTxt(ref textBox);
            dniglobal = Convert.ToDouble(textBox.Text);           
        }

        private void obtenerTabla()
        {
            SqlConnection connection = DBConnection.getConnection();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = query;
            command.CommandType = CommandType.Text;

            adapter = new SqlDataAdapter(command);
            adapter.Fill(dataTable);

            planillaModificarCliente.DataSource = dataTable;
            //dB.closeConn();
        }

        private void txtEmailTLibre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
