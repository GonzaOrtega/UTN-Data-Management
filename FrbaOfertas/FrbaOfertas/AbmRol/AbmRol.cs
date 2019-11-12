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
        public AbmRol()
        {
            InitializeComponent();
        }

        private void rOLBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rOLBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gD2C2019DataSet);

        }

        private void AbmRol_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gD2C2019DataSet.ROL' Puede moverla o quitarla según sea necesario.
            this.rOLTableAdapter.Fill(this.gD2C2019DataSet.ROL);

        }
    }
}
