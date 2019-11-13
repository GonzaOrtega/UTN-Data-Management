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
            if (dataGridView1.DataSource!=null)
            ((DataTable)dataGridView1.DataSource).Clear();
        }



        private void btnAtras_Click(object sender, EventArgs e)
        {
            funciones.Show();
            cerrado = true;
            Close();
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

        private void txtNombre_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "Nombre del rol")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.Black;
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.Text = "Nombre del rol";
                txtNombre.ForeColor = Color.Gainsboro;
            }
        }

        private void txtDescripcion_Click(object sender, EventArgs e)
        {
            if (txtDescripcion.Text == "Descripción de la funcionalidad")
            {
                txtDescripcion.Text = "";
                txtDescripcion.ForeColor = Color.Black;
            }
        }

        private void txtDescripcion_Leave(object sender, EventArgs e)
        {
            if (txtDescripcion.Text == "")
            {
                txtDescripcion.Text = "Descripción de la funcionalidad";
                txtDescripcion.ForeColor = Color.Gainsboro;
            }
        }
        private String validarFiltroHabilitar()
        {
            switch (cbHabilitado.Text)
            {
                case "Ambos":
                    return "";
                case "Habilitar":
                    return "habilitado like 'True'";
                case "Deshabilitado":
                    return "habilitado like 'False'";
            }
            return "";
        }
        private String validarFiltroRol()
        {
            if(txtNombre.ForeColor == Color.Black)
            {
                return "Nombre like "+"'" + txtNombre.Text+"'";
            }
            return "";
        }
        private String validarFiltroFuncion()
        {
            if (txtDescripcion.ForeColor == Color.Black)
            {
                return "Descripcion like " + "'"+txtDescripcion.Text+"'";
            }
            return "";
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            String expresion = this.validarFiltroHabilitar();
            String expresion2 = this.validarFiltroRol();
            String expresion3 = this.validarFiltroFuncion();
            if (expresion != "" && (expresion2 != "" || expresion3 != ""))
            {
                expresion += " AND "+expresion2;
            }
            else { expresion += expresion2; }
            if (expresion2 != "" && expresion3 != "")
            {
                expresion += " AND " + expresion3;
            }
            else { expresion += expresion3; }
            foreach (DataRow row in roL_FUNCIONALIDADTableAdapter1.dameAbmRol().Select(expresion))
            {
                txtNombre.Text = "hola";
               // dataGridView1.DataSource = roL_FUNCIONALIDADTableAdapter1;
            }
        }

      
    }
}
