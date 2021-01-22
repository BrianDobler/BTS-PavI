using BTS_3k2_2020.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTS_3k2_2020.RespositoriosDAO
{
    public class PerfilesRepositorio
    {
        public List<Perfil> ObtenerTodos()
        {
            List<Perfil> perfiles = new List<Perfil>();
            var sentenciaSql = "SELECT * FROM Perfiles where borrado=0";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tabla.Rows)
            {
                var perfil = new Perfil();
                perfil.Id = Convert.ToInt32(fila["id_perfil"].ToString());
                perfil.Nombre = fila["nombre"].ToString();
                perfiles.Add(perfil);
            }
            return perfiles;
        }

        public DataTable recuperarPerfiles()
        {
            string consulta = "SELECT id_perfil,nombre from Perfiles where borrado=0";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(consulta);
            return tabla;
        }
        public DataTable recuperarPerfInac()
        {
            string consulta = "select id_perfil,nombre from Perfiles where borrado=1";
            var datos = DBHelper.GetDBHelper().ConsultaSQL(consulta);
            return datos;
        }
        public List<Perfil> ConsultarPerfil(string nombre, string id)
        {
            List<Perfil> perfiles = new List<Perfil>();
            var sentenciaSql = $"SELECT * FROM Perfiles where nombre like '%{nombre}%' and id_perfil='{id}'";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tabla.Rows)
            {
                var perfil = new Perfil();
                perfil.Id = Convert.ToInt32(fila["id_perfil"].ToString());
                perfil.Nombre = fila["nombre"].ToString();
                perfiles.Add(perfil);
            }
            return perfiles;
        }

        public List<Perfil> ConsultarPerfilExacto(string nombre, string id)
        {
            List<Perfil> perfiles = new List<Perfil>();
            var sentenciaSql = $"SELECT * FROM Perfiles where nombre like '{nombre}' and id_perfil='{id}'";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tabla.Rows)
            {
                var perfil = new Perfil();
                perfil.Id = Convert.ToInt32(fila["id_perfil"].ToString());
                perfil.Nombre = fila["nombre"].ToString();
                perfiles.Add(perfil);
            }
            return perfiles;
        }

        public List<Perfil> ConsultarPerfil(string nombre)
        {
            List<Perfil> perfiles = new List<Perfil>();
            var sentenciaSql = $"SELECT * FROM Perfiles WHERE nombre like '%{nombre}%'";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tabla.Rows)
            {
                var perfil = new Perfil();
                perfil.Id = Convert.ToInt32(fila["id_perfil"].ToString());
                perfil.Nombre = fila["nombre"].ToString();
                perfiles.Add(perfil);
            }
            return perfiles;
        }

        public List<Perfil> ConsultarPerfilExacto(string nombre)
        {
            List<Perfil> perfiles = new List<Perfil>();
            var sentenciaSql = $"SELECT * FROM Perfiles WHERE nombre like '{nombre}'";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tabla.Rows)
            {
                var perfil = new Perfil();
                perfil.Id = Convert.ToInt32(fila["id_perfil"].ToString());
                perfil.Nombre = fila["nombre"].ToString();
                perfiles.Add(perfil);
            }
            return perfiles;
        }

        public List<Perfil> ConsultarPerfil(long id)
        {
            List<Perfil> perfiles = new List<Perfil>();
            var sentenciaSql = $"SELECT * FROM Perfiles where id_perfil='{id}'";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tabla.Rows)
            {
                var perfil = new Perfil();
                perfil.Id = Convert.ToInt32(fila["id_perfil"].ToString());
                perfil.Nombre = fila["nombre"].ToString();
                perfiles.Add(perfil);
            }
            return perfiles;
        }

        public int RegistrarPerfil(string nombre, long id)
        {
            var sentenciaSql = $"INSERT INTO Perfiles (id_perfil, nombre) VALUES ({id}, '{nombre}')";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);
            return filasAfectadas;
        }

        public int RegistrarPerfil(string nombre)
        {
            var sentenciaSql = $"INSERT INTO Perfiles (nombre) VALUES ('{nombre}')";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);
            return filasAfectadas;
        }

        public int EliminarPerfil(long id)
        {
            var sentenciaSql = $"DELETE FROM Perfiles WHERE id_perfil = {id}";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);
            return filasAfectadas;
        }


        public int ModificarPerfil(long id, string nuevoNombre)
        {
            var sentenciaSql = $"UPDATE Perfiles SET nombre = '{nuevoNombre}' WHERE id_perfil = {id}";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);
            return filasAfectadas;
        }
    }
}