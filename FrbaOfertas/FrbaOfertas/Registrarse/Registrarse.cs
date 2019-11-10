using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaOfertas.GD2C2019DataSetTableAdapters;
namespace FrbaOfertas.Registrarse
{
    public partial class Registrarse : Form
    {
        public Registrarse()
        {
            InitializeComponent();
        }
       
        private void Registrarse_Load(object sender, EventArgs e)
        {
            this.rolTableAdapter1.Fill(this.gD2C2019DataSet1.ROL);
            cbROL.DataSource = this.rolTableAdapter1.GetData();
            cbROL.ValueMember = "Nombre";
        }
    }
}
