using BTS_3k2_2020.Pantallas;
using BTS_3k2_2020.Pantallas.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTS_3k2_2020.Pantallas.Reportes;
namespace BTS_3k2_2020
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMenuV2());
            //Application.Run(new CargaDeFormulario());
        }
    }
}
