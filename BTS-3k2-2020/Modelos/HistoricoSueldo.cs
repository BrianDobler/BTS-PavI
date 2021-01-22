using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTS_3k2_2020.Modelos
{
    public class HistoricoSueldo
    {
        public Perfil Perfil { get; set; }
        public long Id { get; set; }
        public DateTime Fecha { get; set; }
        public double Sueldo_bruto { get; set; }
    }

}
