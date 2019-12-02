using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaOfertas.ModificarUsuarios
{
    public partial class ModificarUsuarios : Form
    {
        public ModificarUsuarios()
        {
            InitializeComponent();
        }
        private void mostrarColumnasModificarYModificar()
        {
            agregarColumna(5, "Modificar");
            agregarColumna(6, "Eliminar");
        }

        private void agregarColumna(int columnIndex, string textoDeColumna)
        {
            DataGridViewButtonColumn seleccionar = new DataGridViewButtonColumn();
            seleccionar.Name = textoDeColumna;
            dataGridView1.Columns.Insert(columnIndex, seleccionar);
            
        }
        private void ModificarUsuarios_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = usuarioTableAdapter1.GetData();
            mostrarColumnasModificarYModificar();
        }

        public void actualizar()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = usuarioTableAdapter1.GetData();
            mostrarColumnasModificarYModificar();

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int columnIndex = e.ColumnIndex;        

            if (e.ColumnIndex == dataGridView1.Columns["Modificar"].Index)
            {
                new Funciones.CambiarContraseña(Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value),this).Show();
            }
            if (e.ColumnIndex == dataGridView1.Columns["Eliminar"].Index)
            {
                if (MessageBox.Show("Estas Seguro que desea eliminar este usuario", "WARNING", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    usuarioTableAdapter1.eliminarUsuario(Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value));
                    dataGridView1.Columns.Clear();
                    this.ModificarUsuarios_Load(sender, e);
                }
            }
        }
    }
}
