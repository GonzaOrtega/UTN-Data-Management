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
        LoginYSeguridad.Login login;
        bool cerrado = false;
        public Funciones(int ID_Usuario,LoginYSeguridad.Login principal)
        {
            InitializeComponent();
            usuario = ID_Usuario;
            cbFunciones.DataSource = this.funcionalidadTableAdapter1.dameFunciones(ID_Usuario);
            cbFunciones.ValueMember = "Descripcion";
            login = principal;
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
                case "FacturarProveedor":
                    new Facturar.Facturar(this).Show();
                    Hide();
                    break;
                case "ListadoEstadistico":
                    new ListadoEstadistico.ListadoEstadistico(this).Show();
                    Hide();
                    break;
                case "ABM_ROL":
                    new AbmRol.AbmRol(this).Show();
                    Hide();
                    break;
                case "ABM_CLIENTES":
                    new AbmCliente.ABMCLiente().Show();
                    Close();
                    break;
                case "ABM_PROVEEDOR":
                    new AbmProveedor.ListadoProveedor().Show();
                    Close();
                    break;
                case "BajarOferta":
                    new ConsumoOferta.ConsumoOfertas().Show();
                    Close();
                    break;
                case "ComprarOferta":
                    new ComprarOferta.ComprarOfertas(usuario).Show();
                    Close();
                    break;
                case "CargarCredito":
                    new CargaCredito.CargarCredito().Show();
                    Close();
                    break;
            }
        }

        private void Funciones_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && cerrado ==false)
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Realmente desea salir de la sesion?", "WARNING!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                login.Show();
                cerrado = true;
                Close();
            }
        }
    }
}
