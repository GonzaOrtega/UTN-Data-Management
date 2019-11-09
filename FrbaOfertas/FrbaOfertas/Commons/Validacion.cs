using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertas.Commons
{
    class Validacion
    {
        public static object validarString(string parametro)
        {
            if (String.IsNullOrWhiteSpace(parametro))
            {
                return DBNull.Value;
            }
            return parametro;
        }

        public static object validarDouble(Double parametro)
        {
            if (parametro == 0)
            {
                return DBNull.Value;
            }
            return parametro;
        }

        public static object validarDateTime(DateTime parametro)
        {
            if (DateTime.Compare(parametro, DateTime.Today) != 0)
            {
                return DBNull.Value;
            }
            return parametro;
        }
    }
}
