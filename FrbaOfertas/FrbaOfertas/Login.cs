using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaOfertas.GD2C2019DataSetTableAdapters;
namespace FrbaOfertas.LoginYSeguridad
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        private void btnIniciar_Click(object sender, EventArgs e)
        {
            int usuario = Convert.ToInt32(txtUsuario.Text);
            if (this.uSUARIOTableAdapter.chequearUsuario(usuario, txtContrasenia.Text)!=null)
            {
                ///que ingrese a la proxima pantalla
            };

        }

        private void Login_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gD2C2019DataSet.CLIENTES' Puede moverla o quitarla según sea necesario.
            this.cLIENTESTableAdapter.Fill(this.gD2C2019DataSet.CLIENTES);
            // TODO: esta línea de código carga datos en la tabla 'gD2C2019DataSet.USUARIO' Puede moverla o quitarla según sea necesario.
            this.uSUARIOTableAdapter.Fill(this.gD2C2019DataSet.USUARIO);

        }

        private void uSUARIOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.uSUARIOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gD2C2019DataSet);

        }
    }
}
