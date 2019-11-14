using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using System.Data;

namespace FrbaOfertas
{
    public static class DBConnection
    {
        private static string server = ConfigurationManager.AppSettings["server"].ToString();
        private static string user = ConfigurationManager.AppSettings["user"].ToString();
        private static string password = ConfigurationManager.AppSettings["password"].ToString();

        public static SqlConnection getConnection()
        {
            SqlConnection connection = new SqlConnection();
            //connection.ConnectionString = "Data Source=LAPTOP-10J4C3F9\\SQLEXPRESS;Initial Catalog=GD2C2019;User ID=gd;Password=gd2019";
            connection.ConnectionString = "Data Source=" + server + "\\SQLEXPRESS;Initial Catalog=GD2C2019;User ID=" + user + ";Password=" + password + "";

            // Usar esta para entregar el tp
            //connection.ConnectionString = "Data Source=localhost\\SQLSERVER2012;Initial Catalog=GD2C2019;User ID=gdCupon2019;Password=gdCupon2019";




            //connection.ConnectionString = "SERVER=" + server + "\\SQLEXPRESS; DATABASE = GD2C2016;UID=" + user + ";PASSWORD=" + password + ";";
            return connection;
        }

        public static void cargarPlanilla(DataGridView dataGridView, string consulta)
        {
            DataTable dataTable;
            SqlDataAdapter dataAdapter;

            SqlConnection connection = DBConnection.getConnection();
            connection.Open();

            try
            {
                dataAdapter = new SqlDataAdapter(consulta, connection);
                dataTable = new DataTable();

                dataGridView.DataSource = dataTable;
                dataAdapter.Fill(dataTable);
            }
            catch (Exception e)
            {
                MessageBox.Show("No se pudo realizar la consulta: \n" + e.Message);
            }
        }


    }
}