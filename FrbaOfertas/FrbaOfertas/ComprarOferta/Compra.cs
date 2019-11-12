using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertas.ComprarOferta
{
    class Compra
    {
        String codOferta;
        Double dniCliente;
        int cantCompra;
        DateTime fechaCompra;
        Double numFactura;

        public string CodOferta { get => codOferta; set => codOferta = value; }
        public double DniCliente { get => dniCliente; set => dniCliente = value; }
        public int CantCompra { get => cantCompra; set => cantCompra = value; }
        public DateTime FechaCompra { get => fechaCompra; set => fechaCompra = value; }
        public double NumFactura { get => numFactura; set => numFactura = value; }
    }
}
