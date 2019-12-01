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
            string query = "GEDEDE.insertarCliente";

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

        //public static void modificarTablaDeUna(String query, DataTable dataTable)
        //{
        //    SqlConnection connection = DBConnection.getConnection();
        //    SqlCommand command = new SqlCommand();

        //    adapter.SelectCommand.CommandText = query;
        //    adapter.SelectCommand.CommandType = CommandType.Text;
        //    SqlCommandBuilder DbCommandBuilder = new SqlCommandBuilder(adapter);

        //    string insert = DbCommandBuilder.GetInsertCommand().CommandText.ToString();
        //    string update = DbCommandBuilder.GetUpdateCommand().CommandText.ToString();
        //    string delete = DbCommandBuilder.GetDeleteCommand().CommandText.ToString();

        //    connection.Open();
        //    int modificaciones = adapter.Update(dataTable);

        //    MessageBox.Show("Cambios realizados correctamente.\nClientes modificados: " + modificaciones);
        //}

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
            string query = "GEDEDE.insertarCarga";

            var conexion = DBConnection.getConnection();
            SqlCommand comando = new SqlCommand(query, conexion);

            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@Credito", Validacion.validarDouble(credito.Monto));
            comando.Parameters.AddWithValue("@Fecha_carga",credito.Fecha);
            comando.Parameters.AddWithValue("@Tipo_pago_desc", Validacion.validarString(credito.TipoPago));

            if (credito.HayTarjeta)
            {
                string queryPosta = "select max(ID_tarjeta) from GEDEDE.TARJETA";
                int idTarjeta = Convert.ToInt32(obtenerDatoTabla(queryPosta, 0));
                comando.Parameters.AddWithValue("@ID_tarjeta", idTarjeta);
            }
            else
            {
                comando.Parameters.AddWithValue("@ID_tarjeta", DBNull.Value);
            }
            comando.Parameters.AddWithValue("@DNI_Cliente", Validacion.validarDouble(credito.DniCliente));
            

            conexion.Open();
            comando.ExecuteReader();
        }

        public static void insertarTarjeta(Tarjeta tarjeta)
        {
            string query = "GEDEDE.insertarTarjeta";

            var conexion = DBConnection.getConnection();
            SqlCommand comando = new SqlCommand(query, conexion);

            comando.CommandType = CommandType.StoredProcedure;

            
            comando.Parameters.AddWithValue("@Fecha_Vencimiento", tarjeta.FechaVencimiento);
            comando.Parameters.AddWithValue("@Nombre_tutorial", Validacion.validarString(tarjeta.Titular));
            comando.Parameters.AddWithValue("@Tipo_pago_desc", tarjeta.TipoTarjeta);
            //MessageBox.Show(Convert.ToString(Validacion.validarString(tarjeta.TipoTarjeta)));

            conexion.Open();
            comando.ExecuteReader();
        }

        public static String obtenerDatoTabla(String query, int indiceDeTabla)
        {
            String dato = null;
            var conexion = DBConnection.getConnection();
            SqlCommand SDA = new SqlCommand(query, conexion);

            conexion.Open();
            SqlDataReader data = SDA.ExecuteReader();
            if (data.Read())
            {
                dato = data.GetValue(indiceDeTabla).ToString();
            }
            return dato;
        }
        public static void insertarCompra(Compra compra)
        {
            string query = "GEDEDE.insertarCompra";

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

        public static void insertarCupon(Cupon cupon)
        {
            string query = "GEDEDE.insertarCupon";

            var conexion = DBConnection.getConnection();
            SqlCommand comando = new SqlCommand(query, conexion);

            comando.CommandType = CommandType.StoredProcedure;


            comando.Parameters.AddWithValue("@DNI_cliente_origen", Validacion.validarDouble(cupon.DniClienteOrigen));
            comando.Parameters.AddWithValue("@DNI_cliente_destino", Validacion.validarDouble(cupon.DniClienteDestino));
            comando.Parameters.AddWithValue("@Codigo_oferta", Validacion.validarString(cupon.CodOferta));

            conexion.Open();
            comando.ExecuteReader();
        }

        public static bool existeCupon(int nroCupon, ref string codOferta)
        {
            string query = "SELECT * FROM GEDEDE.CUPON WHERE Codigo_cupon = " + nroCupon;
            Cupon cupon = new Cupon();
            codOferta = obtenerDatoTabla(query, 4);
            return !String.IsNullOrWhiteSpace(codOferta);
        }

        public static void canjearCupon(Cupon cupon)
        {
            string query = "GEDEDE.canjearCupon";

            var conexion = DBConnection.getConnection();
            SqlCommand comando = new SqlCommand(query, conexion);

            comando.CommandType = CommandType.StoredProcedure;


            comando.Parameters.AddWithValue("@Entregado_fecha", cupon.FechaEntrega);
            comando.Parameters.AddWithValue("@Codigo_cupon", cupon.CodCupon);

            conexion.Open();
            comando.ExecuteReader();
        }

        public static List<String> obtenerNroCuponesDeCliente(string query)
        {
            List<String> nroCuponesObtenidos = new List<String>();

            var conexion = DBConnection.getConnection();
            SqlCommand SDA = new SqlCommand(query, conexion);

            conexion.Open();
            SqlDataReader data = SDA.ExecuteReader();
            
            if (data.HasRows)
            {
                while (data.Read())
                {
                    nroCuponesObtenidos.Add(data["Codigo_cupon"].ToString());
                }
            }
            return nroCuponesObtenidos;
        }

        public static void disminuirCreditoCliente(Double dniCliente, Double precioCompra)
        {
            string query = "GEDEDE.cobrarCompra";

            var conexion = DBConnection.getConnection();
            SqlCommand comando = new SqlCommand(query, conexion);

            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@DNI_cliente", dniCliente);
            comando.Parameters.AddWithValue("@Credito", precioCompra);

            conexion.Open();
            comando.ExecuteReader();
        }

        public static void aumentarCredito(Double dniCliente, Double precioCompra)
        {
            string query = "GEDEDE.aumentarCredito";

            var conexion = DBConnection.getConnection();
            SqlCommand comando = new SqlCommand(query, conexion);

            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@DNI_cliente", dniCliente);
            comando.Parameters.AddWithValue("@Credito", precioCompra);

            conexion.Open();
            comando.ExecuteReader();
        }

        public static void updateCliente(Cliente cliente)
        {
            string query = "GEDEDE.actualizarCliente";

            var conexion = DBConnection.getConnection();
            SqlCommand comando = new SqlCommand(query, conexion);

            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@DNI", Validacion.validarDouble(cliente.DNI));
            comando.Parameters.AddWithValue("@CP", Validacion.validarDouble(cliente.CodigoPostal));
            comando.Parameters.AddWithValue("@Nombre", Validacion.validarString(cliente.Nombre));
            comando.Parameters.AddWithValue("@Apellido", Validacion.validarString(cliente.Apellido));
            comando.Parameters.AddWithValue("@Direccion", Validacion.validarString(cliente.Direccion));
            comando.Parameters.AddWithValue("@Telefono", Validacion.validarDouble(cliente.Telefono));
            comando.Parameters.AddWithValue("@Mail", Validacion.validarString(cliente.Email));
            comando.Parameters.AddWithValue("@Ciudad", Validacion.validarString(cliente.Ciudad));
            comando.Parameters.AddWithValue("@FechaNacimiento", Validacion.validarDateTime(cliente.FechaVencimiento));

            conexion.Open();
            comando.ExecuteReader();

            MessageBox.Show("Cliente modificado satisfactoriamente", "Modificar cliente");
        }

        public static void eliminarCliente(Double dniCliente)
        {
            string query = "GEDEDE.eliminarCliente";

            var conexion = DBConnection.getConnection();
            SqlCommand comando = new SqlCommand(query, conexion);

            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@DNI_cliente", dniCliente);

            conexion.Open();
            comando.ExecuteReader();
        }
    }
}
