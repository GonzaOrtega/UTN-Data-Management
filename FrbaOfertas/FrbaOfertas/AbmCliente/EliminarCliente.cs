using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaOfertas.AbmCliente
{
    public partial class EliminarCliente : Form
    {
        Double nroCliente;

        public double NroCliente { get => nroCliente; set => nroCliente = value; }

        public EliminarCliente()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.eliminarCliente();
            MessageBox.Show("Eliminar cliente esta en construccion\n" +
                "El numero de cliente es: " + nroCliente + "\n" +
                "Para poder hacer esto falta la columna de Eliminado logico para la tabla cliente");
        }

        private void EliminarCliente_Load(object sender, EventArgs e)
        {

        }

        private void eliminarCliente()
        {
            // Para poder hacer esto falta la columna de Eliminado logico para la tabla cliente

            // Hay que crear la procedure que haga el update en la columna de Eliminado logico
        }
    }
}
