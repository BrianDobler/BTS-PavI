using BTS_3k2_2020.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTS_3k2_2020.RespositoriosDAO
{
    class ObjetivosRepositorio
    {
        public DataTable RecuperarObjetivos()
        {
            string consulta = "SELECT id_objetivo, nombre_corto,nombre_largo from objetivos where (borrado = 0 or borrado is null)";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(consulta);
            return tabla;
        }
        public List<Objetivo> ObtenerTodos()
        {
            List<Objetivo> objetivos = new List<Objetivo>();
            var sentenciaSql = "SELECT * FROM Objetivos where (borrado=0 or borrado is null)";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tabla.Rows)
            {
                var objetivo = new Objetivo();
                objetivo.Id = Convert.ToInt32(fila["id_objetivo"].ToString());
                objetivo.NombreCorto = fila["nombre_corto"].ToString();
                objetivo.NombreLargo = fila["nombre_largo"].ToString();
                objetivos.Add(objetivo);
            }
            return objetivos;
        }

        public List<Objetivo> ConsultarObjetivo(string id, string nombreCorto, string nombreLargo)
        {
            List<Objetivo> objetivos = new List<Objetivo>();
            var idC = Convert.ToInt32(id);
            var sentenciaSql = $"SELECT * FROM Objetivos where id_objetivo = '{idC}'";
            if (nombreCorto!="")
            {
                sentenciaSql += $" and nombre_corto like '%{nombreCorto}%'";
            }
            if (nombreLargo != "")
            {
                sentenciaSql += $" and nombre_largo like '%{nombreLargo}%'";
            }           
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tabla.Rows)
            {
                var objetivo = new Objetivo();
                objetivo.Id = Convert.ToInt32(fila["id_objetivo"].ToString());
                objetivo.NombreCorto = fila["nombre_corto"].ToString();
                objetivo.NombreLargo = fila["nombre_largo"].ToString();
                objetivos.Add(objetivo);
            }
            return objetivos;
        }

        public List<Objetivo> ConsultarObjetivoExacto(string id, string nombreCorto, string nombreLargo)
        {
            List<Objetivo> objetivos = new List<Objetivo>();
            var idC = Convert.ToInt32(id);
            var sentenciaSql = $"SELECT * FROM Objetivos where id_objetivo = '{idC}'";
            if (nombreCorto != "")
            {
                sentenciaSql += $" and nombre_corto = '{nombreCorto}'";
            }
            if (nombreLargo != "")
            {
                sentenciaSql += $" and nombre_largo = '{nombreLargo}'";
            }
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tabla.Rows)
            {
                var objetivo = new Objetivo();
                objetivo.Id = Convert.ToInt32(fila["id_objetivo"].ToString());
                objetivo.NombreCorto = fila["nombre_corto"].ToString();
                objetivo.NombreLargo = fila["nombre_largo"].ToString();
                objetivos.Add(objetivo);
            }
            return objetivos;
        }


        public List<Objetivo> ConsultarObjetivo(string nombreCorto, string nombreLargo)
        {
            List<Objetivo> objetivos = new List<Objetivo>();
            var sentenciaSql = $"SELECT * FROM Objetivos";

            if (nombreCorto != "" && nombreLargo != "")
            {
                sentenciaSql += $" where nombre_corto like '%{nombreCorto}%' and nombre_largo like '%{nombreLargo}%'";
            }
            else
            {
                if (nombreCorto == "" && nombreLargo != "")
                {
                    sentenciaSql += $" where nombre_largo like '%{nombreLargo}%'";
                }
                if (nombreCorto != "" && nombreLargo == "")
                {
                    sentenciaSql += $" where nombre_corto like '%{nombreCorto}%'";
                }
            }
            
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tabla.Rows)
            {
                var objetivo = new Objetivo();
                objetivo.Id = Convert.ToInt32(fila["id_objetivo"].ToString());
                objetivo.NombreCorto = fila["nombre_corto"].ToString();
                objetivo.NombreLargo = fila["nombre_largo"].ToString();
                objetivos.Add(objetivo);
            }
            return objetivos;
        }

        public List<Objetivo> ConsultarObjetivoExacto(string nombreCorto, string nombreLargo)
        {
            List<Objetivo> objetivos = new List<Objetivo>();
            var sentenciaSql = $"SELECT * FROM Objetivos";

            if (nombreCorto != "" && nombreLargo != "")
            {
                sentenciaSql += $" where nombre_corto = '{nombreCorto}' and nombre_largo = '{nombreLargo}'";
            }
            else
            {
                if (nombreCorto == "" && nombreLargo != "")
                {
                    sentenciaSql += $" where nombre_largo = '{nombreLargo}'";
                }
                if (nombreCorto != "" && nombreLargo == "")
                {
                    sentenciaSql += $" where nombre_corto = '{nombreCorto}'";
                }
            }

            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tabla.Rows)
            {
                var objetivo = new Objetivo();
                objetivo.Id = Convert.ToInt32(fila["id_objetivo"].ToString());
                objetivo.NombreCorto = fila["nombre_corto"].ToString();
                objetivo.NombreLargo = fila["nombre_largo"].ToString();
                objetivos.Add(objetivo);
            }
            return objetivos;
        }


        public List<Objetivo> ConsultarObjetivo(long id)
        {
            List<Objetivo> objetivos = new List<Objetivo>();
            var sentenciaSql = $"SELECT * FROM Objetivos where id_objetivo='{id}'";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tabla.Rows)
            {
                var objetivo = new Objetivo();
                objetivo.Id = Convert.ToInt32(fila["id_objetivo"].ToString());
                objetivo.NombreCorto = fila["nombre_corto"].ToString();
                objetivo.NombreLargo = fila["nombre_largo"].ToString();
                objetivos.Add(objetivo);
            }
            return objetivos;
        }

        public int EliminarObjetivo(long id)
        {
            var sentenciaSql = $"DELETE FROM Objetivos WHERE id_objetivo = {id}";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);
            return filasAfectadas;
        }

        public int RegistrarObjetivo(long id, string nombreCorto, string nombreLargo)
        {   
            var sentenciaSql = $"INSERT INTO Objetivos (id_objetivo, nombre_corto, nombre_largo) VALUES ({id},'{nombreCorto}','{nombreLargo}')";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);
            return filasAfectadas;
        }

        public int ModificarObjetivo(long id, long nuevoid, string nuevoNombreCorto, string nuevoNombreLargo)
        {
            var sentenciaSql = $"UPDATE Objetivos SET id_objetivo = {nuevoid}, nombre_corto = '{nuevoNombreCorto}', nombre_largo = '{nuevoNombreLargo}' WHERE id_objetivo = {id}";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);
            return filasAfectadas;
        }

    }
}
