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
    public partial class ABM_editar : Form
    {
        String nombreRol;
        AbmRol anterior;
        public ABM_editar(String nombre, AbmRol ant)
        {
            InitializeComponent();
            nombreRol = nombre;
            anterior = ant;

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

        private void ABM_editar_Load(object sender, EventArgs e)
        {
            txtNombre.Text = nombreRol;
            if (rolTableAdapter1.GetDataById(nombreRol).Count != 0)
            {
                cudHabilitado.Text = "Habilitado";
            }
            else { cudHabilitado.Text = "Deshabilitado";}
            foreach (DataRow row in funcionalidadTableAdapter1.GetData().Rows)
                lbGlobales.Items.Add(row["Descripcion"]);
            foreach(DataRow row1 in roL_FUNCIONALIDADTableAdapter1.dameDescripcion(nombreRol))
                lbLocales.Items.Add(row1["Descripcion"]);
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (lbLocales.SelectedItem != null)
            {
                lbLocales.Items.Remove(lbLocales.SelectedItem);
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lbLocales.Items.Clear();
            lbGlobales.Items.Clear();
            this.ABM_editar_Load(sender,e);
        }
        private bool validarNombre()
        {
            if (rolTableAdapter1.GetData().Select("Nombre like '" + txtNombre.Text + "'").Count() !=0 && txtNombre.Text != nombreRol)
            {
                MessageBox.Show("Ese nombre de rol ya se encuentre", "ERROR", MessageBoxButtons.OK);
                return false;
            }
            
            return true;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (this.validarNombre())
            {
                rolTableAdapter1.UpdateQuery(txtNombre.Text, "True", nombreRol);
                if (cudHabilitado.Text == "Deshabilitado")
                {
                    rolTableAdapter1.DeleteQuery(txtNombre.Text);
                }
                roL_FUNCIONALIDADTableAdapter1.DeleteQuery(txtNombre.Text);
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
    }
}
