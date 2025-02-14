﻿
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
        bool cerrado = false;
        public ListadoEstadistico(Funciones.Funciones fun)
        {
            InitializeComponent();
            funciones = fun;
        }

        private void txtAnio_Leave(object sender, EventArgs e)
        {
            if (txtAnio.Text == "")
            {
                txtAnio.Text = "Año";
                txtAnio.ForeColor = Color.Gainsboro;
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
            cerrado = true;
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
        private bool validarAnio()
        {
            if(txtAnio.Text == "Año")
            {
                MessageBox.Show("Ingrese el año", "ERROR", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }
        private void btnListar_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            if (this.validarListado()&&this.validarAnio())
            {
                DateTime fechaInicio;
                DateTime fechaFin;
                if (dudSemestre.Text == "Primer semestre")
                {
                    fechaInicio = new DateTime(Convert.ToInt32(txtAnio.Text), 1, 1);
                    fechaFin = new DateTime(Convert.ToInt32(txtAnio.Text), 6, 30);
                }
                else
                {
                    fechaInicio = new DateTime(Convert.ToInt32(txtAnio.Text), 6, 1);
                    fechaFin = new DateTime(Convert.ToInt32(txtAnio.Text), 12, 31);
                }
                DataGridViewTextBoxColumn columna3 = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn columna2 = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn columna1 = new DataGridViewTextBoxColumn();
                columna1.Width = 100;
                columna2.Width = 100;
                columna3.Width = 100;
                if (tipoListado == 2)
                {
                    columna1.HeaderText = "Total_facturas";               
                    columna2.HeaderText = "CUIT_proveedor";
                    columna3.HeaderText = "Razon_social";
                    dataGridView1.Columns.Add(columna1);
                    dataGridView1.Columns.Add(columna2);
                    dataGridView1.Columns.Add(columna3);
                    
                    foreach (DataRow row in facturaTableAdapter1.maximaFacturacion(fechaInicio, fechaFin).Rows)
                    {
                        dataGridView1.Rows.Add(Convert.ToDecimal(row["Total_importes"]), Convert.ToString(row["CUIT_proveedor"]), Convert.ToString(row["Razon_social"]));
                       
                    }
                }
                else
                {
                    columna1.HeaderText = "Porcentaje de descuento";
                    columna2.HeaderText = "CUIT_proveedor";
                    columna3.HeaderText = "Razon_social";
                    dataGridView1.Columns.Add(columna1);
                    dataGridView1.Columns.Add(columna2);
                    dataGridView1.Columns.Add(columna3);
                    foreach (DataRow row in ofertasTableAdapter1.maximoDescuento(fechaInicio, fechaFin).Rows)
                    {
                        dataGridView1.Rows.Add(Convert.ToDecimal(row["porcentaje"]), Convert.ToString(row["CUIT_proveedor"]), Convert.ToString(row["Razon_social"]));

                    }
                }
            }
        }

        private void ListadoEstadistico_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && cerrado==false)
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

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void txtAnio_Enter(object sender, EventArgs e)
        {
            if (txtAnio.Text == "Año")
            {
                txtAnio.Text = "";
                txtAnio.ForeColor = Color.Black;
            }
        }
    }
}
