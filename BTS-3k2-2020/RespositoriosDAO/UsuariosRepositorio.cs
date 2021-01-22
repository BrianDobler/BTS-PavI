using BTS_3k2_2020.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace BTS_3k2_2020.RespositoriosDAO
{
    public class UsuariosRepositorio
    {

        public Usuario LoginSinBD(Usuario usuario)
        {
            var usuarioSistema = this.ObtenerUsuarioAdmin();
            if (usuario.Nombre == usuarioSistema.Nombre && usuario.Password == usuarioSistema.Password)
            {
                return usuarioSistema;
            }
            return null;
        }

        private Usuario ObtenerUsuarioAdmin()
        {
            var usuario = new Usuario();
            usuario.Nombre = "admin";
            usuario.Password = "123456789";

            var perfil = new Perfil();
            perfil.Nombre = "Administrador";

            usuario.Perfil = perfil;
            return usuario;
        }

        public Usuario Login(Usuario usuario)
        {
            Usuario usuarioResultado = null;
            var sentenciaSql = $"SELECT * FROM Usuarios where usuario='{usuario.Nombre}' and password='{usuario.Password}'";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            if (tabla.Rows.Count > 0)
            {
                var row = tabla.Rows[0];
                var usuarioRsultado = new Usuario();
                var id_usuario = row["id_usuario"];
                usuarioRsultado.Id = Convert.ToInt32(id_usuario.ToString());
                usuarioRsultado.Nombre = row["usuario"].ToString();
                usuarioRsultado.Password = row["password"].ToString();
                return usuarioRsultado;
            }

            return usuarioResultado;
        }

        public List<Usuario> ObtenerUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();
            var sentenciaSql = "SELECT * FROM Usuarios where estado='S'";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tabla.Rows)
            {
                var usuario = new Usuario();
                usuario.Id = Convert.ToInt32(fila["id_usuario"].ToString());
                usuario.Nombre = fila["usuario"].ToString();
                usuario.Email = fila["email"].ToString();
                usuarios.Add(usuario);
            }
            return usuarios;
        }

        public List<Usuario> ObtenerUsuarios(string nombre, long perfilId, bool filtrarPorEstado)
        {
            List<Usuario> usuarios = new List<Usuario>();
            var sentenciaSql = $"SELECT * FROM Usuarios WHERE usuario like '{nombre}%'";
            if (!filtrarPorEstado)
            {
                sentenciaSql += $" and estado='S'";
            }
            if (perfilId != 0)
            {
                sentenciaSql += $" and id_perfil = {perfilId}";
            }
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tabla.Rows)
            {
                var usuario = new Usuario();
                usuario.Id = Convert.ToInt32(fila["id_usuario"].ToString());
                usuario.Nombre = fila["usuario"].ToString();
                usuario.Email = fila["email"].ToString();
                usuarios.Add(usuario);
            }
            return usuarios;
        }

        public int RegistrarUsuario(Usuario u)
        {
            var sentenciaSql = $"INSERT INTO Usuarios (id_perfil, usuario, password, email, estado) VALUES({u.Perfil.Id}, '{u.Nombre}', '{u.Password}', '{u.Email}', 'S'); ";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);
            return filasAfectadas;
        }

        public Usuario ObtenerUsuario(long id)
        {
            var sentenciaSql = $"SELECT * FROM Usuarios u JOIN Perfiles p On u.id_perfil=p.id_perfil where id_usuario={id}";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            if (tabla.Rows.Count > 0)
            {
                var row = tabla.Rows[0];
                var usuarioRsultado = new Usuario();
                var id_usuario = row["id_usuario"];
                usuarioRsultado.Id = Convert.ToInt32(id_usuario.ToString());
                usuarioRsultado.Nombre = row["usuario"].ToString();
                usuarioRsultado.Password = row["password"].ToString();
                usuarioRsultado.Email = row["email"].ToString();

                var estado = row["estado"]?.ToString();
                usuarioRsultado.Estado = !string.IsNullOrEmpty(estado) && estado == "S";

                var perfil = new Perfil();
                perfil.Id = Convert.ToInt32(row["id_perfil"].ToString());
                perfil.Nombre = row["nombre"].ToString();
                usuarioRsultado.Perfil = perfil;
                return usuarioRsultado;
            }
            return null;
        }

        public int ActualizarrUsuario(Usuario u)
        {
            var sentenciaSql = $"UPDATE Usuarios SET id_perfil='{u.Perfil.Id}', password='{u.Password}', email='{u.Email}' WHERE id_usuario={u.Id}";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);
            return filasAfectadas;
        }

        public int DarBajaUsuario(Usuario u)
        {
            var sentenciaSql = $"UPDATE Usuarios SET estado='{u.EstadoABD()}' WHERE id_usuario={u.Id}";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);
            return filasAfectadas;
        }
        public DataTable recuperar()
        {
            string consulta = "SELECT id_usuario,usuario,email from usuarios where estado='S'";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(consulta);
            return tabla;
        }
    }
}
