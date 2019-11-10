using FrbaOfertas.AbmCliente;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaOfertas.Commons
{
    class Queries
    {
        SqlDataAdapter adapter = new SqlDataAdapter();
        public static void insertarCliente(Cliente cliente)
        {
            string query = "dbo.insertarCliente";

            //    string query = "INSERT INTO CLIENTES VALUES (@dni, @cp, @nombre, @apellido, @direccion, "
            //+ "@telefono, @mail, @fechanacimiento, @ciudad, @credito)";

            var conexion = DBConnection.getConnection();
            SqlCommand comando = new SqlCommand(query, conexion);

            comando.CommandType = CommandType.StoredProcedure;
            //insertarCliente.CommandType - CommandType.Text;

            comando.Parameters.AddWithValue("@DNI", Validacion.validarDouble(cliente.DNI));
            comando.Parameters.AddWithValue("@CP", Validacion.validarDouble(cliente.CodigoPostal));
            comando.Parameters.AddWithValue("@Nombre", Validacion.validarString(cliente.Nombre));
            comando.Parameters.AddWithValue("@Apellido", Validacion.validarString(cliente.Apellido));
            comando.Parameters.AddWithValue("@Direccion", Validacion.validarString(cliente.Direccion));
            comando.Parameters.AddWithValue("@Telefono", Validacion.validarDouble(cliente.Telefono));
            comando.Parameters.AddWithValue("@Mail", Validacion.validarString(cliente.Email));
            comando.Parameters.AddWithValue("@Ciudad", Validacion.validarString(cliente.Ciudad));
            comando.Parameters.AddWithValue("@FechaNacimiento", Validacion.validarDateTime(cliente.FechaVencimiento));
            comando.Parameters.AddWithValue("@Credito", Validacion.validarDouble(cliente.Credito));

            conexion.Open();
            comando.ExecuteReader();

            MessageBox.Show("Cliente creado satisfactoriamente", "Alta cliente");
        }

        public void modificarTablaDeUna(String query, DataTable dataTable)
        {
            SqlConnection connection = DBConnection.getConnection();
            SqlCommand command = new SqlCommand();

            adapter.SelectCommand.CommandText = query;
            adapter.SelectCommand.CommandType = CommandType.Text;
            SqlCommandBuilder DbCommandBuilder = new SqlCommandBuilder(adapter);

            connection.Open();
            int modificaciones = adapter.Update(dataTable);

            MessageBox.Show("Cambios realizados correctamente.\nClientes modificados: " + modificaciones);
        }

        public void obtenerTabla(String query, DataTable dataTable)
        {
            SqlConnection connection = DBConnection.getConnection();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = query;
            command.CommandType = CommandType.Text;

            adapter = new SqlDataAdapter(command);
            adapter.Fill(dataTable);
        }

    }
}
