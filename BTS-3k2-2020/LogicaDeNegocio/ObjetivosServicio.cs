using BTS_3k2_2020.Modelos;
using BTS_3k2_2020.RespositoriosDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace BTS_3k2_2020.LogicaDeNegocio
{
    class ObjetivosServicio
    {
        private ObjetivosRepositorio _repositorio;

        public ObjetivosServicio()
        {
            _repositorio = new ObjetivosRepositorio();
        }

        public List<Objetivo> ConsultarObjetivo(string id, string nombreCorto, string nombreLargo)
        {
            
            if (id != "")
            {
                var objetivos = _repositorio.ConsultarObjetivo(id, nombreCorto, nombreLargo);
                return objetivos;
            }
            else
            {
                var objetivos = _repositorio.ConsultarObjetivo(nombreCorto, nombreLargo);
                return objetivos;
            }
        }

        public List<Objetivo> ConsultarObjetivoExacto(string id, string nombreCorto, string nombreLargo)
        {

            if (id != "")
            {
                var objetivos = _repositorio.ConsultarObjetivoExacto(id, nombreCorto, nombreLargo);
                return objetivos;
            }
            else
            {
                var objetivos = _repositorio.ConsultarObjetivoExacto(nombreCorto, nombreLargo);
                return objetivos;
            }
        }


        public int EliminarObjetivo (Objetivo objetivo)
        {
            var filasAfectadas = _repositorio.EliminarObjetivo(objetivo.Id);
            return filasAfectadas;
        }

        public List<Objetivo> ObtenerTodos()
        {
            var objetivos = _repositorio.ObtenerTodos();
            return objetivos;
        }

        public int RegistrarObjetivo(Objetivo objetivo)
        {
            var filasAfectadas = 0;
            filasAfectadas = _repositorio.RegistrarObjetivo(objetivo.Id, objetivo.NombreCorto, objetivo.NombreLargo);
            return filasAfectadas;
        }

        public int ModificarObjetivo(long id, long nuevoid, string nuevoNombreCorto, string nuevoNombreLargo)
        {
            var filasAfectadas = _repositorio.ModificarObjetivo(id, nuevoid, nuevoNombreCorto, nuevoNombreLargo);
            return filasAfectadas;
        }

    }
}
