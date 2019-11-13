using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertas.ComprarOferta
{
    class Cupon
    {
        DateTime fechaEntrega;
        Double dniClienteOrigen;
        Double dniClienteDestino;
        String codOferta;
        int codCupon;

        public DateTime FechaEntrega { get => fechaEntrega; set => fechaEntrega = value; }
        public double DniClienteOrigen { get => dniClienteOrigen; set => dniClienteOrigen = value; }
        public double DniClienteDestino { get => dniClienteDestino; set => dniClienteDestino = value; }
        public string CodOferta { get => codOferta; set => codOferta = value; }
        public int CodCupon { get => codCupon; set => codCupon = value; }
    }
}
