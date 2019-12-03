using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaOfertas.AbmProveedor
{
    public partial class ListadoProveedor : Form
    {
        bool cerrado = false;
        Funciones.Funciones funciones;
        public ListadoProveedor(Funciones.Funciones fun)
        {
            InitializeComponent();
            funciones = fun;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            funciones.Show();
            cerrado = true;
            Close();
        }

        private String validarRazonSocial()
        {
            if (txtRazon.Text != "")
                return "Razon_social like '" + txtRazon.Text + "'";
                return "";
        }
        private String validarCUIT()
        {
            if (txtCuit.Text != "")

                return "CUIT_proveedor like '" + txtCuit.Text + "'";

            return "";
        }
        private String validarMail()
        {
            if (txtMail.Text != "")

                return "Mail like '" + txtMail.Text + "'";

            return "";
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            String expresion = this.validarRazonSocial();
            String expresion2 = this.validarCUIT();
            String expresion3 = this.validarMail();
            dataGridView1.Rows.Clear();
            if (expresion != "" && (expresion2 != "" || expresion3 != ""))
            {
                expresion += " AND " + expresion2;
            }
            else { expresion += expresion2; }
            if (expresion2 != "" && expresion3 != "")
            {
                expresion += " AND " + expresion3;
            }
            else { expresion += expresion3; }
            foreach(DataRow row in proveedorTableAdapter1.abmListar().Select(expresion))
            {
                dataGridView1.Rows.Add(
                    row["CUIT_proveedor"],
                    row["Razon_social"],
                    row["Domicilio"],
                    row["Ciudad"],
                    row["Telefono"],
                    row["Descripcion"],
                    row["Mail"],
                    row["Codigo_postal"],
                    row["Nombre_contacto"],
                    row["habilitado"]);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            new Registrarse.Registrarse(this).Show();
            //new CrearProveedor().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           int fila=  dataGridView1.CurrentCell.RowIndex;
           String cuit = Convert.ToString(dataGridView1.Rows[fila].Cells[0].Value);
           String razonSocial = Convert.ToString(dataGridView1.Rows[fila].Cells[1].Value);
           proveedorTableAdapter1.DeleteQuery(cuit, razonSocial);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                int fila = dataGridView1.CurrentCell.RowIndex;
                String cuit = Convert.ToString(dataGridView1.Rows[fila].Cells[0].Value);
                String razonSocial = Convert.ToString(dataGridView1.Rows[fila].Cells[1].Value);
                String direccion = Convert.ToString(dataGridView1.Rows[fila].Cells[2].Value);
                String ciudad = Convert.ToString(dataGridView1.Rows[fila].Cells[3].Value);
                Double telefono = Convert.ToDouble(dataGridView1.Rows[fila].Cells[4].Value);
                String rubro = Convert.ToString(dataGridView1.Rows[fila].Cells[5].Value);
                String mail = Convert.ToString(dataGridView1.Rows[fila].Cells[6].Value);
                Double codPostal = Convert.ToDouble(dataGridView1.Rows[fila].Cells[7].Value);
                String nombreContacto = Convert.ToString(dataGridView1.Rows[fila].Cells[8].Value);


                new CrearProveedor(cuit,
                    razonSocial, direccion, ciudad,
                    telefono, rubro, mail, codPostal,
                    nombreContacto).Show();
            }
            else
            {
                MessageBox.Show("Seleccione la fila que desea modificar", "ERROR", MessageBoxButtons.OK);
            }
        }

        private void ListadoProveedor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && cerrado == false && cerrado == false)
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
    }
}
