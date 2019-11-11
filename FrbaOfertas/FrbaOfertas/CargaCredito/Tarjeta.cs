using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertas.CargaCredito
{
    class Tarjeta
    {
        String titular;
        String tipoTarjeta;
        DateTime fechaVencimiento;

        public string Titular { get => titular; set => titular = value; }
        public string TipoTarjeta { get => tipoTarjeta; set => tipoTarjeta = value; }
        public DateTime FechaVencimiento { get => fechaVencimiento; set => fechaVencimiento = value; }
    }
}
