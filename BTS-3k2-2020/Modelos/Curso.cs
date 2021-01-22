using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTS_3k2_2020.Modelos
{
    public class Curso
    {
        public long Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string fecha_vigencia { get; set; }

        public Categoria Categoria { get; set; }
        public bool Estado { get; set; }

    }



}
