using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTS_3k2_2020.Modelos
{
    public class UsuarioXCurso
    {
        public Usuario Usuario { get; set; }
        public Curso Curso { get; set; }
        public int Puntuacion { get; set; }
        public string Observaciones { get; set; }
        public DateTime Fecha_Inicio { get; set; }
        public DateTime Fecha_Fin { get; set; }


        public void ValidarUsuario()
        {
            if (this.Usuario.Id == 0)
                throw new ApplicationException("No se ha seleccionado un usuario");
        }

        public void ValidarCurso()
        {
            if (this.Curso.Id == 0)
                throw new ApplicationException("No se ha seleccionado un curso");
        }

        
        public void ValidarPuntuacion()
        {
            if (String.IsNullOrEmpty(this.Puntuacion.ToString()))
                throw new ApplicationException("La puntuación es requerida.");
            if (this.Puntuacion < 1 || this.Puntuacion > 10)
                throw new ApplicationException("La puntuación tiene que ser numero entre 1 y 10.");
        }

        public void ValidarFecha()
        {
            this.Fecha_Inicio = new DateTime(this.Fecha_Inicio.Year, this.Fecha_Inicio.Month, this.Fecha_Inicio.Day);
            this.Fecha_Fin = new DateTime(this.Fecha_Fin.Year, this.Fecha_Fin.Month, this.Fecha_Fin.Day);
            if (this.Fecha_Inicio > this.Fecha_Fin)
                //MessageBox.Show("Falta fecha");
                throw new ApplicationException("La fecha de inicio tiene que ser menor que la fecha de fin.");
            if (this.Fecha_Inicio == this.Fecha_Fin)
                //MessageBox.Show("Falta fecha");
                throw new ApplicationException("La fecha de inicio y la fecha de fin no pueden ser iguales.");

        }
    }
}
