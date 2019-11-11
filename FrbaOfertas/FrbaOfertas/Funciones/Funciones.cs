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
    public partial class Funciones : Form
    {
        int usuario;
        public Funciones(int ID_Usuario)
        {
            InitializeComponent();
            usuario = ID_Usuario;
            cbFunciones.DataSource = this.funcionalidadTableAdapter1.dameFunciones(ID_Usuario);
            cbFunciones.ValueMember = "Descripcion";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (cbFunciones.Text) {
                case "ConfeccionarOferta":
                    DataRow tipo = tipO_USUARIOTableAdapter1.GetDataByUsuario(usuario).First();
                    if (tipo["CUIT_proveedor"] == null)
                    {
                        new CrearOferta.IngresaProveedor(this).Show();
                    }
                    else
                    {
                        new CrearOferta.CrearOferta(tipo["CUIT_proveedor"].ToString(), tipo["Razon_social"].ToString(), this, null).Show();
                    }
                    Hide();
                    break;
            }
        }
    }
}
