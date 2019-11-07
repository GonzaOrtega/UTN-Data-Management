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

            //    string query = "INSERT INTO CLIENTES VALUES (@dni, @cp, @nombre, @apellido, @direccion, "
            //+ "@telefono, @mail, @fechanacimiento, @ciudad, @credito)";

            var conexion = DBConnection.getConnection();
            SqlCommand insertarCliente = new SqlCommand(query, conexion);

            insertarCliente.CommandType = CommandType.StoredProcedure;
            //insertarCliente.CommandType - CommandType.Text;

            validarDouble(insertarCliente.Parameters.AddWithValue("@DNI", cliente.DNI));
            validarDouble(insertarCliente.Parameters.AddWithValue("@CP", cliente.CodigoPostal));
            validarString(insertarCliente.Parameters.AddWithValue("@Nombre", cliente.Nombre));
            validarString(insertarCliente.Parameters.AddWithValue("@Apellido", cliente.Apellido));
            validarString(insertarCliente.Parameters.AddWithValue("@Direccion", cliente.Direccion));
            validarDouble(insertarCliente.Parameters.AddWithValue("@Telefono", cliente.Telefono));
            validarString(insertarCliente.Parameters.AddWithValue("@Mail", cliente.Email));
            validarString(insertarCliente.Parameters.AddWithValue("@Ciudad", cliente.Ciudad));
            validarDateTime(insertarCliente.Parameters.AddWithValue("@FechaNacimiento", cliente.FechaVencimiento));
            validarDouble(insertarCliente.Parameters.AddWithValue("@Credito", cliente.Credito));

            conexion.Open();
            insertarCliente.ExecuteReader();

            MessageBox.Show("Cliente creado satisfactoriamente", "Alta cliente");
        }

        public static void validarString(SqlParameter sqlParameter)
        {
            if (String.IsNullOrWhiteSpace(Convert.ToString(sqlParameter.Value)))
            {
                sqlParameter.Value = DBNull.Value;
            }
        }

        public static void validarDouble(SqlParameter sqlParameter)
        {
            if (Convert.ToDouble(sqlParameter.Value) == 0)
            {
                sqlParameter.Value = DBNull.Value;
            }
        }

        public static void validarDateTime(SqlParameter sqlParameter)
        {
            if (DateTime.Compare(Convert.ToDateTime(sqlParameter.Value).Date,DateTime.Today) == 0)
            {
                sqlParameter.Value = DBNull.Value;
            }
        }

    }
}
