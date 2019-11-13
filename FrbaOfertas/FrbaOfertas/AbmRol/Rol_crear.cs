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
    public partial class Rol_crear : Form
    {
        AbmRol anterior;
        public Rol_crear(AbmRol ant)
        {
            InitializeComponent();
            anterior = ant;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            lbLocales.Items.Clear();
            cudHabilitado.SelectedItem = "Habilitado";
        }

        private void Rol_crear_Load(object sender, EventArgs e)
        {
            cudHabilitado.SelectedItem = "Habilitado";
            foreach (DataRow row in funcionalidadTableAdapter1.GetData().Rows)
                lbGlobales.Items.Add(row["Descripcion"]);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (lbGlobales.SelectedItem != null)
            {
                if (lbLocales.Items.Contains(lbGlobales.SelectedItem) == false)
                {
                    lbLocales.Items.Add(lbGlobales.SelectedItem);
                }
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (lbLocales.SelectedItem != null)
            {
                lbLocales.Items.Remove(lbLocales.SelectedItem);
            }

        }
        private bool chequearNombre()
        {
            if (rolTableAdapter1.GetData().Select("Nombre like '" + txtNombre.Text + "'").Count() != 0)
            {
                MessageBox.Show("Ese nombre de rol ya se encuentre", "ERROR", MessageBoxButtons.OK);
                return false;
            }

            return true;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (this.chequearNombre())
            {
                if (cudHabilitado.Text == "Habilitado")
                {
                    rolTableAdapter1.InsertQuery(txtNombre.Text, "True");
                }else
                {   rolTableAdapter1.InsertQuery(txtNombre.Text, "False"); }
                DataRow idRol = rolTableAdapter1.GetData().Select("Nombre like '" + txtNombre.Text + "'").First();
                foreach (Object item in lbLocales.Items)
                {
                    DataRow idFuncionalidad = funcionalidadTableAdapter1.GetData().Select("Descripcion like '" + item.ToString() + "'").First();
                    roL_FUNCIONALIDADTableAdapter1.InsertQuery(Convert.ToInt32(idFuncionalidad["ID_funcionalidad"]), Convert.ToInt32(idRol["ID_rol"]));
                }
                MessageBox.Show("Se ha guardado correctamente!", "FELICIDADES", MessageBoxButtons.OK);
                anterior.borrarTabla();
                this.Close();
            }
        }

        private void txtNombre_Click(object sender, EventArgs e)
        {
            if(txtNombre.Text == "Nombre de rol")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.Black;
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.Text = "Nombre de rol";
                txtNombre.ForeColor = Color.Gainsboro;
            }
        }
    }
}
