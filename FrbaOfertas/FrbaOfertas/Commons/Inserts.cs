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
    class Inserts
    {
        public static void insertarCliente(Cliente cliente, DBAccess dB)
        {
            string query = "dbo.insertarCliente";
            var conexion = DBConnection.getConnection();
            SqlCommand insertarCliente = new SqlCommand(query, conexion);

            insertarCliente.CommandType = CommandType.StoredProcedure;

            insertarCliente.Parameters.AddWithValue("@DNI", cliente.DNI);
            insertarCliente.Parameters.AddWithValue("@CP", cliente.CodigoPostal);
            insertarCliente.Parameters.AddWithValue("@Nombre", cliente.Nombre);
            insertarCliente.Parameters.AddWithValue("@Apellido", cliente.Apellido);
            insertarCliente.Parameters.AddWithValue("@Direccion", cliente.Direccion);
            insertarCliente.Parameters.AddWithValue("@Telefono", cliente.Telefono);
            insertarCliente.Parameters.AddWithValue("@Mail", cliente.Email);
            insertarCliente.Parameters.AddWithValue("@Ciudad", cliente.Ciudad);
            insertarCliente.Parameters.AddWithValue("@FechaNacimiento", cliente.FechaVencimiento);
            insertarCliente.Parameters.AddWithValue("@Credito", cliente.Credito);

            conexion.Open();
            insertarCliente.ExecuteReader();

            //// Retorna el numero de filas afectadas
            //int row = dB.executeQuery(insertarCliente, CommandType.StoredProcedure);

            //if (row == 1)
            //{
            //    MessageBox.Show("Cliente creado satisfactoriamente", "Alta cliente");
            //}
        }

    }
}
