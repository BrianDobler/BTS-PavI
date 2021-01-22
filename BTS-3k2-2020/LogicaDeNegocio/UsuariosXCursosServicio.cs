using BTS_3k2_2020.Modelos;
using BTS_3k2_2020.RespositoriosDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTS_3k2_2020.LogicaDeNegocio
{
    public class UsuariosXCursosServicio
    {
        private UsuariosXCursosRepositorio _usuariosXcursosRepositorio;
        public UsuariosXCursosServicio()
        {
            _usuariosXcursosRepositorio = new UsuariosXCursosRepositorio();
        }
        public List<UsuarioXCurso> ObtenerUsuariosXCursos(string nombreUsuario, long cursoId, long puntuacion)
        {
            return _usuariosXcursosRepositorio.ObtenerUsuariosXCursos(nombreUsuario, cursoId, puntuacion);
        }

        public List<UsuarioXCurso> ObtenerUsuariosXCursos()
        {
            return _usuariosXcursosRepositorio.ObtenerUsuariosXCursos();
        }

        public UsuarioXCurso ObtenerUsuarioXCurso(long id_usuario, long id_curso)
        {
            return _usuariosXcursosRepositorio.ObtenerUsuarioXCurso(id_usuario, id_curso);
        }

        public List<Curso> ObtenerCursos()
        {
            return _usuariosXcursosRepositorio.ObtenerCursos();
        }

        public UsuarioXCurso ValidarUsuarioXCurso(UsuarioXCurso uxc)
        {
            uxc.ValidarUsuario();
            uxc.ValidarCurso();
            uxc.ValidarPuntuacion();
            uxc.ValidarFecha();
            return uxc;

        }
        public bool RegistrarUsuarioXCurso(UsuarioXCurso usuarioXcurso)
        {
            var filasAfectadas = _usuariosXcursosRepositorio.RegistrarUsuarioXCurso(usuarioXcurso);
            if (filasAfectadas == 1)
                return true;
            return false;
        }

        public void ActualizarUsuarioXCurso(UsuarioXCurso uxc)
        {
            var filasAfectadas = _usuariosXcursosRepositorio.ActualizarUsuarioXCurso(uxc);
            if (filasAfectadas != 1)
                throw new ApplicationException("Hubo un problema al actualizar.");
        }

        public void DarBajaUsuarioXCurso(UsuarioXCurso uxc)
        {
            var filasAfectadas = _usuariosXcursosRepositorio.DarBajaUsuarioXCurso(uxc);
            if (filasAfectadas != 1)
                throw new ApplicationException("Hubo un problema al actualizar.");
        }
    }
}
