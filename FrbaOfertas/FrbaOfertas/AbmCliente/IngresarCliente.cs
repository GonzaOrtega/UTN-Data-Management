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
    public partial class IngresarCliente : Form
    {
        public IngresarCliente()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        int usuario;
        public IngresarCliente(int usu)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            usuario = usu;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea cancelar?", "Cancelar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
                new Funciones.Funciones(usuario).Show();
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            try
            {
                new ComprarOferta.ComprarOfertas(Convert.ToDouble(txtDNI.Text) ,usuario).Show();
                this.Close();

            }catch(Exception ex)
            {
                MessageBox.Show("Error: el DNI ingresado no es correcto");
            }
        }
    }
}
