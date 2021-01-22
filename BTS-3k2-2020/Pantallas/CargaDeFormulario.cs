using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTS_3k2_2020.Pantallas
{
    public partial class CargaDeFormulario : Form
    {
        public CargaDeFormulario()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panelDeCarga.Width += 3;
            if(panelDeCarga.Width >535)
            {
                timer1.Stop();
                this.Dispose();
            }
            
        }
    }
}
