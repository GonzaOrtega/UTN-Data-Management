using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            DateTime fecha = obtenerFechaConfigFile();
            if (DateTime.Compare(parametro, fecha) == 0)
            {
                return DBNull.Value;
            }
            return parametro;
        }

        public static DateTime obtenerFechaConfigFile()
        {
            String fechaConfigFile = ConfigurationManager.AppSettings["fecha"].ToString();
            DateTime fecha = DateTime.ParseExact(fechaConfigFile, "yyyy-MM-dd HH:mm tt", System.Globalization.CultureInfo.InvariantCulture);
            return fecha;
        }

        public static void validarDoubleTxt(ref TextBox textBox)
        {
            if (!String.IsNullOrWhiteSpace(textBox.Text))
            {
                Convert.ToDouble(textBox.Text);
            }
            else
            {
                textBox.Text = "0";
            }
        }
    }
}
