using System;
using System.Windows.Forms;

namespace FrbaOfertas.AbmCliente
{
    public partial class ABMCLiente : Form
    {
        int usuario;
        public ABMCLiente(int usu)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            usuario = usu;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rbCrearCliente.Checked)
            {
                new CrearYModificarCliente().Show();

            }else if (rbModificarClientes.Checked)
            {
                BuscarCliente cliente = new BuscarCliente();
                cliente.EsModificar = true;
                cliente.Show();
            }
            else if (rbEliminarClientes.Checked)
            {
                //MessageBox.Show("Eliminar clientes esta en construccion... :)");
                new BuscarCliente().Show();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea cancelar?", "Cancelar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
                new Funciones.Funciones(usuario).Show();
            }
        }
    }
}
