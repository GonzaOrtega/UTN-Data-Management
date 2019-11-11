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
        public Funciones(int ID_Usuario)
        {
            InitializeComponent();
           
            cbFunciones.DataSource = this.funcionalidadTableAdapter1.dameFunciones(ID_Usuario);
            cbFunciones.ValueMember = "Descripcion";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(cbFunciones.Text == "ConfeccionarOferta"){
                new CrearOferta.IngresaProveedor(this).Show();
                Hide();
            }
            /*   FIJARME COMO HACER EL SWITCH ACA DESPUES PORQUE NO TENGO INTERNET :D
            switch (cbFunciones.Text)
            {*/
        
        }
    }}
