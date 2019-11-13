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

        private void ABM_editar_Load(object sender, EventArgs e)
        {

        }
    }
}
