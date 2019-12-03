using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertas.CargaCredito
{
    public class Credito
    {
        //DateTime fecha;
        //Double dniCliente;
        //String tipoPago;
        //Double monto;
        //bool hayTarjeta;
        //Double nroTarjeta;

        public double Monto { get; set; }
        public DateTime Fecha { get; set; }
        public double DniCliente { get; set; }
        public string TipoPago { get; set; }
        public bool HayTarjeta { get; set; }
        public double NroTarjeta { get; set; }
    }
}
