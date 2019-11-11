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
    public partial class ABMCLiente : Form
    {
        public ABMCLiente()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rbCrearCliente.Checked)
            {
                new CrearCliente().Show();

            }else if (rbModificarClientes.Checked)
            {
                ModificarCliente cliente = new ModificarCliente();
                cliente.EsModificar = true;
                cliente.Show();
            }
            else if (rbEliminarClientes.Checked)
            {
                //MessageBox.Show("Eliminar clientes esta en construccion... :)");
                new ModificarCliente().Show();
            }
        }

        private void ABMCLiente_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea cancelar?", "Cancelar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbModificarClientes_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
