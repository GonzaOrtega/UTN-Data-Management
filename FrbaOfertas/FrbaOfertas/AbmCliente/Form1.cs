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
    public partial class CrearCliente : Form
    {
        public CrearCliente()
        {
            InitializeComponent();
            txtNroDepartamentoAltaCliente.Enabled = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string casaODepartamento = cbCasaODepartamento.Text;

            if (casaODepartamento.Equals("Departamento"))
            {
                txtNroDepartamentoAltaCliente.Enabled = true;
            }
        }

        private void CrearCliente_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
