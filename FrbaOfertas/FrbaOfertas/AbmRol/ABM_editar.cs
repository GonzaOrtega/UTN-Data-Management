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
        public ABM_editar(String nombre)
        {
            InitializeComponent();
            nombreRol = nombre;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void ABM_editar_Load(object sender, EventArgs e)
        {
            txtNombre.Text = nombreRol;
            if (rolTableAdapter1.GetDataById(nombreRol).Count != 0)
            {
                cudHabilitado.Text = "Habilitado";
            }
            else { cudHabilitado.Text = "Deshabilitado";}
            lbGlobales.DataSource = funcionalidadTableAdapter1.GetData();
            lbGlobales.ValueMember = "Descripcion";
            lbLocales.DataSource = roL_FUNCIONALIDADTableAdapter1.dameDescripcion(nombreRol);
            lbLocales.ValueMember = "Descripcion";
        }
    }
}
