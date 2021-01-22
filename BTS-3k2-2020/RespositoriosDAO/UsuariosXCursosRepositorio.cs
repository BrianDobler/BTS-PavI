using BTS_3k2_2020.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTS_3k2_2020.RespositoriosDAO
{
    class UsuariosXCursosRepositorio
    {
        public List<Curso> ObtenerCursos()
        {
            List<Curso> cursos = new List<Curso>();
            var sentenciaSql = "SELECT * FROM Cursos where borrado=0";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tabla.Rows)
            {
                var curso = new Curso();
                curso.Id = Convert.ToInt32(fila["id_curso"].ToString());
                curso.Nombre = fila["nombre"].ToString();
                curso.Descripcion = fila["descripcion"].ToString();
                cursos.Add(curso);
            }
            return cursos;
        }
        public List<UsuarioXCurso> ObtenerUsuariosXCursos()
        {
            List<UsuarioXCurso> usuariosXcursos = new List<UsuarioXCurso>();
            var sentenciaSql = $"SELECT uxc.*, u.usuario, c.nombre FROM UsuariosCurso uxc, Cursos c, Usuarios u WHERE uxc.id_usuario = u.id_usuario and uxc.id_curso = c.id_curso and c.borrado=0";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tabla.Rows)
            {
                var usuarioXcurso = new UsuarioXCurso();
                var usuario = new Usuario();
                var curso = new Curso();
                usuario.Id = Convert.ToInt32(fila["id_usuario"].ToString());
                usuario.Nombre = fila["usuario"].ToString();
                curso.Id = Convert.ToInt32(fila["id_curso"].ToString());
                curso.Nombre = fila["nombre"].ToString();
                usuarioXcurso.Usuario = usuario;
                usuarioXcurso.Curso = curso;
                usuarioXcurso.Puntuacion = Convert.ToInt32(fila["puntuacion"].ToString());
                usuarioXcurso.Observaciones = fila["observaciones"].ToString();
                usuarioXcurso.Fecha_Inicio = Convert.ToDateTime(fila["fecha_inicio"].ToString());
                usuarioXcurso.Fecha_Fin = Convert.ToDateTime(fila["fecha_fin"].ToString());
                usuariosXcursos.Add(usuarioXcurso);
            }
            return usuariosXcursos;

        }

        public List<UsuarioXCurso> ObtenerUsuariosXCursos(string nombreUsuario, long cursoId, long puntuacion)
        {
            List<UsuarioXCurso> usuariosXcursos = new List<UsuarioXCurso>();
            //var sentenciaSql = "SELECT * FROM Sueldos s LEFT JOIN usuarios u ON s.id_usuario = u.id_usuario WHERE u.usuario like '%%'";
            //DateTime fechaMinima = new DateTime(1900, 01, 01);
            var sentenciaSql = $"SELECT uxc.*, u.usuario, c.nombre FROM UsuariosCurso uxc JOIN Usuarios u ON uxc.id_usuario = u.id_usuario JOIN Cursos c ON uxc.id_curso = c.id_curso WHERE";
            //var sentenciaSql = "SELECT s.*, u.usuario FROM  s LEFT JOIN usuarios u ON s.id_usuario = u.id_usuario WHERE";
            sentenciaSql += $" u.usuario like '%{nombreUsuario}%'";
            //fecha = new DateTime(fecha.Value.Year, fecha.Value.Month, fecha.Value.Day);
            //if (fecha != fechaMinima)
            //  sentenciaSql += $" and s.fecha = '{fecha.Value.ToString("yyyy-MM-dd")}'";
            if (cursoId != 0)
                sentenciaSql += $" and uxc.id_curso = {cursoId}";
            if (puntuacion != 0)
                sentenciaSql += $" and uxc.puntuacion = {puntuacion}";

            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tabla.Rows)
            {
                var usuarioXcurso = new UsuarioXCurso();
                var usuario = new Usuario();
                var curso = new Curso();
                usuario.Id = Convert.ToInt32(fila["id_usuario"].ToString());
                usuario.Nombre = fila["usuario"].ToString();
                curso.Id = Convert.ToInt32(fila["id_curso"].ToString());
                curso.Nombre = fila["nombre"].ToString();
                usuarioXcurso.Usuario = usuario;
                usuarioXcurso.Curso = curso;
                usuarioXcurso.Puntuacion = Convert.ToInt32(fila["puntuacion"].ToString());
                usuarioXcurso.Observaciones = fila["observaciones"].ToString();
                usuarioXcurso.Fecha_Inicio = Convert.ToDateTime(fila["fecha_inicio"].ToString());
                usuarioXcurso.Fecha_Fin = Convert.ToDateTime(fila["fecha_fin"].ToString());
                usuariosXcursos.Add(usuarioXcurso);
            }
            return usuariosXcursos;
        }


        public int RegistrarUsuarioXCurso(UsuarioXCurso uxc)
        {
            var sentenciaSql = $"INSERT INTO UsuariosCurso (id_usuario, id_curso, puntuacion, observaciones, fecha_inicio, fecha_fin) VALUES({uxc.Usuario.Id}, {uxc.Curso.Id}, {uxc.Puntuacion}, '{uxc.Observaciones}', {uxc.Fecha_Inicio.ToString("yyyy-MM-dd")}, {uxc.Fecha_Fin.ToString("yyyy-MM-dd")})";
            //var sentenciaSql = $"INSERT INTO UsuariosCurso (id_usuario, id_curso, puntuacion, observaciones, fecha_inicio, fecha_fin) VALUES({uxc.Usuario.Id}, {uxc.Curso.Id}, {uxc.Puntuacion}, '{uxc.Observaciones}', '10/08/2020', '21/10/2020')";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);
            return filasAfectadas;
        }

        public UsuarioXCurso ObtenerUsuarioXCurso(long id_usuario, long id_curso)
        {
            UsuarioXCurso usuarioXcursoResultado = null;
            //tiene que ver con el error. Falta agregar fecha COMO PARAMETRO
            var sentenciaSql = $"SELECT uxc.*, u.usuario, c.nombre FROM UsuariosCurso uxc LEFT JOIN Usuarios u ON uxc.id_usuario = u.id_usuario LEFT JOIN Cursos c ON uxc.id_curso = c.id_curso WHERE uxc.id_usuario = {id_usuario} and uxc.id_curso = {id_curso}";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            if (tabla.Rows.Count == 1)
            {
                var row = tabla.Rows[0];
                var usuarioXcursoBD = new UsuarioXCurso();
                var usuario = new Usuario();
                var curso = new Curso();
                usuario.Id = Convert.ToInt64(row["id_usuario"].ToString());
                usuario.Nombre = row["usuario"].ToString();
                curso.Id = Convert.ToInt64(row["id_curso"].ToString());
                curso.Nombre = row["nombre"].ToString();
                usuarioXcursoBD.Usuario = usuario;
                usuarioXcursoBD.Curso = curso;
                usuarioXcursoBD.Puntuacion = Convert.ToInt32(row["puntuacion"].ToString());
                usuarioXcursoBD.Observaciones = row["observaciones"].ToString();
                usuarioXcursoBD.Fecha_Inicio = Convert.ToDateTime(row["fecha_inicio"].ToString());
                usuarioXcursoBD.Fecha_Fin = Convert.ToDateTime(row["fecha_fin"].ToString());
                return usuarioXcursoBD;

            }
            return usuarioXcursoResultado;
        }

        public int ActualizarUsuarioXCurso(UsuarioXCurso uxc)
        {
            var sentenciaSql = $"UPDATE UsuariosCurso SET puntuacion = {uxc.Puntuacion}, observaciones='{uxc.Observaciones}' WHERE id_usuario={uxc.Usuario.Id} and id_curso = {uxc.Curso.Id}";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);
            return filasAfectadas;
        }

        public int DarBajaUsuarioXCurso(UsuarioXCurso uxc)
        {
            var sentenciaSql = $"DELETE FROM UsuariosCurso WHERE id_usuario = {uxc.Usuario.Id} and id_curso = {uxc.Curso.Id}";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);
            return filasAfectadas;

        }
    }
}
