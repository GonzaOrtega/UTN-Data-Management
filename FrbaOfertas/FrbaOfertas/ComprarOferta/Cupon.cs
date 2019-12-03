using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertas.ComprarOferta
{
    class Cupon
    {
        //int codCupon;
        //DateTime fechaEntrega;
        //Double dniClienteOrigen;
        //Double dniClienteDestino;
        //String codOferta;
        //DateTime fechaVencimiento;
        //int cantidad;

        public DateTime FechaEntrega { get; set; }
        public double DniClienteOrigen { get; set; }
        public double DniClienteDestino { get; set; }
        public string CodOferta { get; set; }
        public int CodCupon { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public int Cantidad { get; set; }
    }
}
