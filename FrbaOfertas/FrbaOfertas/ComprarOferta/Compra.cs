using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertas.ComprarOferta
{
    public class Compra
    {
        //String codOferta;
        //Double dniCliente;
        //int cantCompra;
        //DateTime fechaCompra;
        //Double numFactura;

        //// Lo pongo a pesar de que no pertenece al dominio
        //Double precioTotal;

        public string CodOferta { get; set; }
        public double DniCliente { get; set; }
        public int CantCompra { get; set; }
        public DateTime FechaCompra { get; set; }
        public double NumFactura { get; set; }
        public double PrecioTotal { get; set; }
    }
}
