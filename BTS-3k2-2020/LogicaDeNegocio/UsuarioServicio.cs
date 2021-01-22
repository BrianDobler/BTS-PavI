using BTS_3k2_2020.Modelos;
using BTS_3k2_2020.RespositoriosDAO;
using System;
using System.Collections.Generic;

namespace BTS_3k2_2020.Servicios
{
    public class UsuarioServicio
    {
        private UsuariosRepositorio _usuariosRepositorio;

        public string MensajeErrorUsuarioContraseniaIncorrecta = "Usuario y/o Contraseña incorrectas";

        public static Usuario UsuarioLogueado { get; set; }



        public UsuarioServicio()
        {
            _usuariosRepositorio = new UsuariosRepositorio();
        }

        public Usuario Login(Usuario usuario)
        {
            // primero probar con LoginSinBD
            //despues con Login
            UsuarioServicio.UsuarioLogueado = _usuariosRepositorio.Login(usuario);
            return UsuarioServicio.UsuarioLogueado;
        }

        public List<Usuario> ObtenerUsuarios()
        {
            var usuarios = _usuariosRepositorio.ObtenerUsuarios();
            return usuarios;
        }

        public List<Usuario> ObtenerUsuarios(string nombre, long perfilId, bool filtrarPorEstado)
        {
            List<Usuario> usuarios;
            usuarios = _usuariosRepositorio.ObtenerUsuarios(nombre, perfilId, filtrarPorEstado);
            return usuarios;
        }

        public string ValidarNuevoUsuario(Usuario usuario)
        {
            if (!usuario.EsNombreValido())
                return "Nombre inválido";
            if (!usuario.EsPasswordValido())
                return "Contraseña inválida";
            if (!usuario.EsPerfilValido())
                return "Perfil inválido";
            return null;
        }

        public string RegistrarUsuario(Usuario usuario)
        {
            var filasAfectadas = _usuariosRepositorio.RegistrarUsuario(usuario);
            if (filasAfectadas != 1)
                return "Hubo un problema al registrar el usuario";
            return null;
        }

        public void ActualizarUsuario(Usuario usuario)
        {
            var usuarioDB = _usuariosRepositorio.ObtenerUsuario(usuario.Id);
            if (usuarioDB == null)
                throw new ApplicationException("Usuario inválido");
            usuarioDB.Perfil = usuario.Perfil;
            usuarioDB.Email = usuario.Email;
            usuarioDB.Password = usuario.Password;
            _usuariosRepositorio.ActualizarrUsuario(usuario);
        }

        public Usuario ObtenerUsuarios(long id)
        {
            var usuario = _usuariosRepositorio.ObtenerUsuario(id);
            return usuario;
        }

        public void ValidarUsuario(Usuario usuario)
        {
            usuario.ValidarNombre();
            usuario.ValidarPassword();
            usuario.ValidarEmail();
        }
        public void DarBajaUsuario(Usuario u)
        {
            var filasAfectadas = _usuariosRepositorio.DarBajaUsuario(u);
            if (filasAfectadas != 1)
                throw new ApplicationException("Hubo un problema al actualizar");
        }


    }
}
