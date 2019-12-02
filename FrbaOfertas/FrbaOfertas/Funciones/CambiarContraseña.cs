using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaOfertas.Funciones
{
    public partial class CambiarContraseña : Form
    {
        int usuario;
        ModificarUsuarios.ModificarUsuarios anterior = null;
        public CambiarContraseña(int ID_usuario)
        {
            InitializeComponent();
            usuario = ID_usuario;
        }
        public CambiarContraseña(int ID_usuario,ModificarUsuarios.ModificarUsuarios modificar)
        {
            InitializeComponent();
            usuario = ID_usuario;
            anterior = modificar;
        }
        bool validarContrasenias()
        {
            if (txtContrasenia.ForeColor == Color.Gainsboro || txtConfirmacion.ForeColor == Color.Gainsboro)
            {
                MessageBox.Show("Ingrese la contraseña nueva y su confirmacion", "ERROR", MessageBoxButtons.OK);
                return false;
            }
            if (txtConfirmacion.Text != txtContrasenia.Text)
            {
                MessageBox.Show("Contraseña y su confirmacion son distintas", "ERROR", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (validarContrasenias())
            {
                usuarioTableAdapter1.UpdateContrasenia(txtContrasenia.Text,usuario);
                MessageBox.Show("Se ha modificado correctamente", "FELICIDADES", MessageBoxButtons.OK);
                if(anterior!= null)
                {
                    anterior.actualizar();
                }
                Close();
            }
        }

        private void txtContrasenia_Enter(object sender, EventArgs e)
        {
            if(txtContrasenia.ForeColor == Color.Gainsboro)
            {
                txtContrasenia.Text = "";
                txtContrasenia.ForeColor = Color.Black;
            }
        }

        private void txtContrasenia_Leave(object sender, EventArgs e)
        {
            if (txtContrasenia.Text == "")
            {
                txtContrasenia.Text = "Contraseña nueva";
                txtContrasenia.ForeColor = Color.Gainsboro;
            }
        }

        private void txtConfirmacion_Enter(object sender, EventArgs e)
        {
            if (txtConfirmacion.ForeColor == Color.Gainsboro)
            {
                txtConfirmacion.Text = "";
                txtConfirmacion.ForeColor = Color.Black;
            }
        }

        private void txtConfirmacion_Leave(object sender, EventArgs e)
        {
            if (txtConfirmacion.Text == "")
            {
                txtConfirmacion.Text = "Confirmación de contraseña";
                txtConfirmacion.ForeColor = Color.Gainsboro;
            }
        }
    }
}
