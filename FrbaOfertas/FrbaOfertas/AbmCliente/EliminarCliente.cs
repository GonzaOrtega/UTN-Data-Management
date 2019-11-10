using FrbaOfertas.Commons;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaOfertas.AbmCliente
{
    public partial class EliminarCliente : Form
    {
        Queries queries = new Queries();
        string query = "select * from CLIENTES";
        DataTable dataTable = new DataTable();
        Dictionary<String, String> dictionary = new Dictionary<String, String>();
        Double dniglobal;
        List<TextBox> textboxes = new List<TextBox>();
        CommonsForms commons = new CommonsForms();

        public EliminarCliente()
        {
            InitializeComponent();
        }

        private void EliminarCliente_Load(object sender, EventArgs e)
        {
            //foreach (DataGridViewRow row in planillaEliminarCliente.SelectedRows)
            //{
            //    if (!row.IsNewRow)
            //        planillaEliminarCliente.Rows.Remove(row);
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        //private void buscarClientes()
        //{
        //    this.limpiarEstructuras();
        //    try
        //    {
        //        if (this.hayCondicionesDeFiltro())
        //        {
        //            this.guardarStringEnDiccionario("Nombre", txtNombreTLibre.Text);
        //            this.guardarStringEnDiccionario("Apellido", txtApellidoTLibre.Text);
        //            this.guardarStringEnDiccionario("Mail", txtEmailTLibre.Text);
        //            this.DNIEsCorrecto();

        //            this.buscar();
        //        }
        //        else
        //        {
        //            MessageBox.Show("No se ingresaron condiciones de filtro");
        //        }

        //    }
        //    catch (System.FormatException ex)
        //    {
        //        MessageBox.Show("DNI ingresado incorrectamente");
        //    }
        //}
    }
}
