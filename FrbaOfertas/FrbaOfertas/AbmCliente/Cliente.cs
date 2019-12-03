using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertas.AbmCliente
{
    public class Cliente
    {
        //private Double dni;

        //private string nombre;

        //private string apellido;

        //private string direccion;

        //private Double telefono;

        //private string email;

        //DateTime fechaVencimiento;

        //string ciudad;

        //Double credito;

        //Double codigoPostal;

        // Getters y setters
        public double DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public double Telefono { get; set; }
        public string Email { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public string Ciudad { get; set; }
        public double Credito { get; set; }
        public double CodigoPostal { get; set; }
    }
}
