using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTS_3k2_2020.Modelos
{
    class Descuento
    {
        private string nombreDescuento;
        private string montoDescuento;

        public string NombreDescuento { get => nombreDescuento; set => nombreDescuento = value; }
        public string  MontoDescuento { get => montoDescuento; set => montoDescuento = value; }
    }
}
