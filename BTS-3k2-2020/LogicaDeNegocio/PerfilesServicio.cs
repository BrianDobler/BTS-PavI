using BTS_3k2_2020.Modelos;
using BTS_3k2_2020.RespositoriosDAO;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;

namespace BTS_3k2_2020.Servicios
{
    public class PerfilesServicio
    {
        private PerfilesRepositorio _repositorio;

        public static Usuario UsuarioLogueado { get; set; }



        public PerfilesServicio()
        {
            _repositorio = new PerfilesRepositorio();
        }

        public List<Perfil> ObtenerTodos()
        {
            var usuarios = _repositorio.ObtenerTodos();
            return usuarios;
        }

        public List<Perfil> ConsultarPerfil(string nombre, string id)
        {
            if(nombre == "" && id.ToString() != "")
            {
                var idPerfil = (long)Convert.ToInt64(id);
                var perfiles = _repositorio.ConsultarPerfil(idPerfil);
                return perfiles;
            }
            else
            {
                if(nombre != "" && id.ToString() != "")
                {
                    var perfiles = _repositorio.ConsultarPerfil(nombre, id);
                    return perfiles;
                } else
                {
                    var perfiles = _repositorio.ConsultarPerfil(nombre);
                    return perfiles;
                }
            }
        }


        public List<Perfil> ConsultarPerfilExacto(string nombre, string id)
        {
            if (nombre == "" && id.ToString() != "")
            {
                var idPerfil = (long)Convert.ToInt64(id);
                var perfiles = _repositorio.ConsultarPerfil(idPerfil);
                return perfiles;
            }
            else
            {
                if (nombre != "" && id.ToString() != "")
                {
                    var perfiles = _repositorio.ConsultarPerfilExacto(nombre, id);
                    return perfiles;
                }
                else
                {
                    var perfiles = _repositorio.ConsultarPerfilExacto(nombre);
                    return perfiles;
                }
            }
        }

        public int RegistrarPerfil(Perfil perfil)
        {
            var filasAfectadas = 0;
            filasAfectadas = _repositorio.RegistrarPerfil(perfil.Nombre);
            return filasAfectadas;
        }

        public int EliminarPerfil(Perfil perfil)
        {
            var filasAfectadas = _repositorio.EliminarPerfil(perfil.Id);
            return filasAfectadas;
        }


        public int ModificarPerfil(long id, string nombre)
        {
            var filasAfectadas = _repositorio.ModificarPerfil(id, nombre);
            return filasAfectadas;
        }

    }
}
