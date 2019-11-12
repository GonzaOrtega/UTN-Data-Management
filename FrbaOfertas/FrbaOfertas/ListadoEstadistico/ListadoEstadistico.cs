@ -0,0 +1,101 @@
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaOfertas.ListadoEstadistico
{

    public partial class ListadoEstadistico : Form
    {
        int tipoListado = 0;
        Funciones.Funciones funciones;
        Color colorLetra;
        public ListadoEstadistico(Funciones.Funciones fun)
        {
            InitializeComponent();
            funciones = fun;
        }

        private void ListadoEstadistico_Load(object sender, EventArgs e)
        {
            colorLetra = txtAnio.ForeColor;
        }

        private void txtAnio_Click(object sender, EventArgs e)
        {
            if (txtAnio.Text == "Año")
            {
                txtAnio.Text = "";
                txtAnio.ForeColor = Color.Black;
            }
        }

        private void txtAnio_Leave(object sender, EventArgs e)
        {
            if (txtAnio.Text == "")
            {
                txtAnio.Text = "Año";
                txtAnio.ForeColor = colorLetra;
            }
        }



        private void txtAnio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void rbFrecuencia_CheckedChanged(object sender, EventArgs e)
        {
            tipoListado = 2;
        }

        private void rbDescuento_CheckedChanged(object sender, EventArgs e)
        {
            tipoListado = 1;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            funciones.Show();
            Close();
        }
        private bool validarListado()
        {
            if (tipoListado == 0)
            {
                MessageBox.Show("Selecccionar un listado", "Error", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }
        private void btnListar_Click(object sender, EventArgs e)
        {
            if (this.validarListado())
            {
                if (tipoListado == 2)
                {
                    DataGridViewTextBoxColumn columna1 = new DataGridViewTextBoxColumn();
                    columna1.HeaderText = "Total_facturas";
                    columna1.Width = 200;
                    DataGridViewTextBoxColumn columna2 = new DataGridViewTextBoxColumn();
                    columna2.HeaderText = "CUIT_proveedor";
                    columna2.Width = 200;
                    DataGridViewTextBoxColumn columna3 = new DataGridViewTextBoxColumn();
                    columna3.HeaderText = "Razon_social";
                    columna3.Width = 200;
                }
            }
        }
    }
}
