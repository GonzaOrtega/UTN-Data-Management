using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaOfertas.Commons
{
    class CommonsForms
    {
        public void limpiarTextboxes(List<TextBox> textboxes)
        {
            foreach (TextBox txt in textboxes)
            {
                txt.Clear();
            }
        }
    }
}
