using FrbaOfertas.AbmCliente;
using FrbaOfertas.CargaCredito;
using FrbaOfertas.ComprarOferta;
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

            string insert = DbCommandBuilder.GetInsertCommand().CommandText.ToString();
            string update = DbCommandBuilder.GetUpdateCommand().CommandText.ToString();
            string delete = DbCommandBuilder.GetDeleteCommand().CommandText.ToString();

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

        public static void insertarCarga(Credito credito)
        {
            string query = "dbo.insertarCarga";

            var conexion = DBConnection.getConnection();
            SqlCommand comando = new SqlCommand(query, conexion);

            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@Credito", Validacion.validarDouble(credito.Monto));
            comando.Parameters.AddWithValue("@Fecha_carga",credito.Fecha);
            comando.Parameters.AddWithValue("@Tipo_pago_desc", Validacion.validarString(credito.TipoPago));

            if (credito.HayTarjeta)
            {
                comando.Parameters.AddWithValue("@ID_tarjeta", Validacion.validarDouble(credito.NroTarjeta));
            }
            else
            {
                comando.Parameters.AddWithValue("@ID_tarjeta", DBNull.Value);
            }
            comando.Parameters.AddWithValue("@DNI_Cliente", Validacion.validarDouble(credito.DniCliente));
            

            conexion.Open();
            comando.ExecuteReader();

            MessageBox.Show("Carga creada satisfactoriamente", "Carga de credito");
        }

        public static void insertarTarjeta(Tarjeta tarjeta)
        {
            string query = "dbo.insertarTarjeta";

            var conexion = DBConnection.getConnection();
            SqlCommand comando = new SqlCommand(query, conexion);

            comando.CommandType = CommandType.StoredProcedure;

            
            comando.Parameters.AddWithValue("@Fecha_Vencimiento", tarjeta.FechaVencimiento);
            comando.Parameters.AddWithValue("@Nombre_tutorial", Validacion.validarString(tarjeta.Titular));
            comando.Parameters.AddWithValue("@Tipo_pago_desc", Validacion.validarString(tarjeta.TipoTarjeta));

            conexion.Open();
            comando.ExecuteReader();
        }

        public static object obtenerDatoOferta(String query, int indiceDeTabla)
        {
            object dato = null;
            var conexion = DBConnection.getConnection();
            SqlCommand SDA = new SqlCommand(query, conexion);

            conexion.Open();
            SqlDataReader data = SDA.ExecuteReader();
            if (data.Read())
            {
                dato = data.GetValue(indiceDeTabla).ToString();
                //MessageBox.Show("El valor obtenido es: " + dato);
            }
            return dato;
        }
        public static void insertarCompra(Compra compra)
        {
            string query = "dbo.insertarCompra";

            var conexion = DBConnection.getConnection();
            SqlCommand comando = new SqlCommand(query, conexion);

            comando.CommandType = CommandType.StoredProcedure;


            comando.Parameters.AddWithValue("@Codigo_oferta", Validacion.validarString(compra.CodOferta));
            comando.Parameters.AddWithValue("@DNI_cliente", Validacion.validarDouble(compra.DniCliente));
            comando.Parameters.AddWithValue("@Cantidad_compra", Validacion.validarDouble(compra.CantCompra));
            comando.Parameters.AddWithValue("@Fecha_compra", compra.FechaCompra);
            comando.Parameters.AddWithValue("@Num_factura", Validacion.validarDouble(compra.NumFactura));

            conexion.Open();
            comando.ExecuteReader();
        }
    }
}
