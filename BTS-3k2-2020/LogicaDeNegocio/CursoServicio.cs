using BTS_3k2_2020.Modelos;
using BTS_3k2_2020.RespositoriosDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTS_3k2_2020.LogicaDeNegocio
{
    public class CursoServicio
    {
        private CursosRepositoris _cursosRepositoris;

        public CursoServicio()
        {
            _cursosRepositoris = new CursosRepositoris();
        }

        public List<Curso> ObtenerCursos(string nombre, long Id, bool estado)
        {
            return _cursosRepositoris.ObtenerCursos(nombre, Id, estado);
        }

        
        public bool RegistrarCurso(Curso curso)
        {
            var filasAfectadas = _cursosRepositoris.RegistrarCurso(curso);
            if (filasAfectadas == 1)
                return true;
            return false;
        }

        public Curso ObtenerCurso(long id)
        {
            var curso = _cursosRepositoris.ObtenerCurso(id);
            return curso;
        }


        public void ActualizarCurso(Curso c)
        {
            var filasAfectadas = _cursosRepositoris.ActualizarCursos(c);
            if (filasAfectadas != 1)
                throw new ApplicationException("Hubo un problema al actualizar");
        }

    }



    


}
