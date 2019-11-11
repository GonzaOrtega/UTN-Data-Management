using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertas.CargaCredito
{
    public class Credito
    {
        DateTime fecha;
        Double dniCliente;
        String tipoPago;
        Double monto;
        bool hayTarjeta;
        Double nroTarjeta;

        public double Monto { get => monto; set => monto = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public double DniCliente { get => dniCliente; set => dniCliente = value; }
        public string TipoPago { get => tipoPago; set => tipoPago = value; }
        public bool HayTarjeta { get => hayTarjeta; set => hayTarjeta = value; }
        public double NroTarjeta { get => nroTarjeta; set => nroTarjeta = value; }
    }
}
