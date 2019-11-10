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
            SqlConnection connection = DBConnection.getConnection();
            SqlCommand command = new SqlCommand();

            adapter.SelectCommand.CommandText = query;
            adapter.SelectCommand.CommandType = CommandType.Text;
            SqlCommandBuilder DbCommandBuilder = new SqlCommandBuilder(adapter);

            connection.Open();
            int modificaciones = adapter.Update(dataTable);

            MessageBox.Show("Cambios realizados correctamente.\nCambios realizados: " + modificaciones);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.limpiarEstructuras();
            try
            {
                if (this.hayCondicionesDeFiltro())
                {
                    this.guardarStringEnDiccionario("Nombre", txtNombreTLibre.Text);
                    this.guardarStringEnDiccionario("Apellido", txtApellidoTLibre.Text);
                    this.guardarStringEnDiccionario("Mail", txtEmailTLibre.Text);
                    DNIEsCorrecto();
                    this.buscar();
                }
                else
                {
                    MessageBox.Show("No se ingresaron condiciones de filtro");
                }

            }catch(System.FormatException ex)
            {
                MessageBox.Show("DNI ingresado incorrectamente");
            }
        }

        private void DNIEsCorrecto()
        {
            if (!String.IsNullOrWhiteSpace(txtDNIPExacta.Text))
            {
                dniglobal = Convert.ToDouble(txtDNIPExacta.Text);
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

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
