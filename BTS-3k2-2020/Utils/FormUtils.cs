using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTS_3k2_2020.Utils
{
    public class FormUtils
    {
        public static void CargarCombo(ref ComboBox combo, BindingSource conectorDeDatos, string displayMember, string valueMember)
        {
            combo.DataSource = conectorDeDatos.DataSource;
            combo.DisplayMember = displayMember;
            combo.ValueMember = valueMember;
        }
    }
}
