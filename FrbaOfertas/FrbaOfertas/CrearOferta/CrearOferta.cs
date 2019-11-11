using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaOfertas.CrearOferta;

namespace FrbaOfertas.CrearOferta
{
    public partial class CrearOferta : Form
    {
        IngresaProveedor anterior;
        Funciones.Funciones funciones;
        public CrearOferta(String cuit,String razonSocial,Funciones.Funciones funcion, IngresaProveedor formularioAnterior)
        {
            InitializeComponent();
            anterior = formularioAnterior;
            funciones = funcion;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            if (anterior != null)
            {
                anterior.Show();
            }
            else
            {
                funciones.Show();
            }
            Close();
        }
        private bool fechasValidas()
        {
            if (DateTime.Now.Date > dtpPublicacion.Value.Date)
            {
                MessageBox.Show("La fecha de publicacion no puede ser anterior a la fecha actual", "ERROR", MessageBoxButtons.OK);
                return false;
            }
            if (dtpPublicacion.Value.Date > dtpVencimiento.Value.Date) {
                MessageBox.Show("La fecha de vencimiento no puede ser anterior a la fecha de publicacion", "ERROR", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }
        private void btnCrear_Click(object sender, EventArgs e)
        {
            //validar
            //crearlo, etc
            if (this.fechasValidas()){
                if (MessageBox.Show("Se ha creado una oferta ¿Desea crear otra?", "Cancelar", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    funciones.Show();
                    anterior.Close();
                    this.Close();
                }
            }
            
        }

        private void oFERTASBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.oFERTASBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gD2C2019DataSet);

        }

        private void CrearOferta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gD2C2019DataSet.OFERTAS' Puede moverla o quitarla según sea necesario.
            this.oFERTASTableAdapter.Fill(this.gD2C2019DataSet.OFERTAS);

        }

        private void tbPrecioOferta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)&&!Char.IsControl(e.KeyChar)&&e.KeyChar!='.')
            {
                e.Handled = true;
            }
        }

        private void tbPrecioLista_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtDescripcion_Click(object sender, EventArgs e)
        {
            if (txtDescripcion.Text == "Descripción") txtDescripcion.Text = "";
        }

        private void txtDescripcion_Leave(object sender, EventArgs e)
        {
            if (txtDescripcion.Text == "") txtDescripcion.Text = "Descripción";
        }

        private void tbPrecioOferta_Click(object sender, EventArgs e)
        {
            if (txtPrecioOferta.Text == "Precio de oferta") txtPrecioOferta.Text = "";
        }

        private void txtPrecioOferta_Leave(object sender, EventArgs e)
        {
            if (txtPrecioOferta.Text == "") txtPrecioOferta.Text = "Precio de oferta";
        }

        private void txtPrecioLista_Leave(object sender, EventArgs e)
        {
            if (txtPrecioLista.Text == "") txtPrecioLista.Text = "Precio de lista";
        }

        private void txtPrecioLista_Click(object sender, EventArgs e)
        {
            if (txtPrecioLista.Text == "Precio de lista") txtPrecioLista.Text = "";
        }
    }
}
