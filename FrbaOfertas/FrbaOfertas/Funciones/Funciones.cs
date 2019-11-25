using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace FrbaOfertas.Funciones
{
    public partial class Funciones : Form
    {
        int usuario;
        bool cerrado = false;

        public int Usuario { get => usuario; set => usuario = value; }

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
                    if (tipo["CUIT_proveedor"].ToString() == "")
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
                    //new AbmCliente.ABMCLiente(usuario).Show();
                    new AbmCliente.ABMCliente(usuario).Show();
                    cerrado = true;
                    Close();
                    break;
                case "ABM_PROVEEDOR":
                    new AbmProveedor.ListadoProveedor(this).Show();
                    Hide();
                    break;
                case "BajarOferta":

                    ingresarProveedorONo();

                    //new ConsumoOferta.ConsumoOfertas(usuario).Show();
                    cerrado = true;
                    Close();
                    break;
                case "ComprarOferta":

                    ingresarClienteONo();

                    cerrado = true;
                    Close();
                    break;
                case "CargarCredito":
                    new CargaCredito.CargarCredito(usuario).Show();
                    cerrado = true;
                    Close();
                    break;
            }
        }

        private void ingresarClienteONo()
        {
            DataRow tipo2 = tipO_USUARIOTableAdapter1.GetDataByUsuario(usuario).First();
            if (tipo2["DNI_cliente"].ToString() == "")
            {
                new AbmCliente.IngresarCliente(usuario).Show();
                // Patente pendiente
            }
            else
            {
                new ComprarOferta.ComprarOfertas(Convert.ToDouble(tipo2["DNI_cliente"].ToString()), usuario).Show();
            }
        }

        private void ingresarProveedorONo()
        {
            DataRow tipo3 = tipO_USUARIOTableAdapter1.GetDataByUsuario(usuario).First();
            if (tipo3["CUIT_proveedor"].ToString() == "")
            {
                new CrearOferta.IngresaProveedor(this, "consumirOferta").Show();
            }
            else
            {
                new ConsumoOferta.ConsumoOfertas(tipo3["CUIT_proveedor"].ToString(), tipo3["Razon_social"].ToString(), usuario).Show();
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
                new LoginYSeguridad.Login().Show();
                cerrado = true;
                Close();
            }
        }

        private void cbFunciones_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Funciones_Load(object sender, EventArgs e)
        {

        }
    }
}
