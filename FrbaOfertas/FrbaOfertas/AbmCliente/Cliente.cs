using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertas.AbmCliente
{
    class Cliente
    {
        private Double dni;

        private string nombre;

        private string apellido;

        private string direccion;

        private Double telefono;

        private string email;

        DateTime fechaVencimiento;

        string ciudad;

        Double credito;

        Double codigoPostal;

        // Getters y setters
        public double DNI { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public double Telefono { get => telefono; set => telefono = value; }
        public string Email { get => email; set => email = value; }
        public DateTime FechaVencimiento { get => fechaVencimiento; set => fechaVencimiento = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }
        public double Credito { get => credito; set => credito = value; }
        public double CodigoPostal { get => codigoPostal; set => codigoPostal = value; }
    }
}
