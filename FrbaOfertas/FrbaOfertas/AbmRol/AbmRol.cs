using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaOfertas.AbmRol
{
    public partial class AbmRol : Form
    {
        bool cerrado = false;
        Funciones.Funciones funciones;
        public AbmRol(Funciones.Funciones fun)
        {
            InitializeComponent();
            funciones = fun;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            ((DataTable)dataGridView1.DataSource).Clear();
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {

        }

        private void AbmRol_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && cerrado == false)
            {
                if (MessageBox.Show("¿Está seguro que desea salir del sistema?", "WARNING", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    Application.Exit();
                }
            }
        }

    }
}
