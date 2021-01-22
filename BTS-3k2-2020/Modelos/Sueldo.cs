using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTS_3k2_2020.Modelos
{
    public class Sueldo
    {
        public Usuario Usuario { get; set; }
        public DateTime Fecha { get; set; }
        public double? Sueldo_bruto { get; set; }


        public void ValidarUsuario()
        {
            if (this.Usuario.Id == 0)
                throw new ApplicationException("No se ha seleccionado un usuario");
        }
        public void ValidarFecha()
        {
            this.Fecha = new DateTime(this.Fecha.Year, this.Fecha.Month, this.Fecha.Day);
            if (this.Fecha == DateTime.MinValue)
                //MessageBox.Show("Falta fecha");
                throw new ApplicationException("La fecha es requerida.");

        }


        public void ValidarSueldo_bruto()
        {
            if (String.IsNullOrEmpty(this.Sueldo_bruto.ToString()))
                throw new ApplicationException("El sueldo bruto es requerido.");
            //if (this.Sueldo_bruto == null)
            //  throw new ApplicationException("El sueldo bruto es requerido.");
            if (this.Sueldo_bruto == 0)
                throw new ApplicationException("El sueldo bruto tiene que ser distinto de cero.");
            //MessageBox.Show("Falta suelo bruto");
        }
    }
}
