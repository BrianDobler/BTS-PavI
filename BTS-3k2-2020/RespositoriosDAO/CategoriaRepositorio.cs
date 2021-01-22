using BTS_3k2_2020.LogicaDeNegocio;
using BTS_3k2_2020.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTS_3k2_2020.RespositoriosDAO
{
    public class CategoriaRepositorio
    {
        private Categoria categoria;

        public List<Categoria> ObtenerTodos()
        {
            List<Categoria> categorias = new List<Categoria>();
            var sentenciaSql = "SELECT * FROM Categorias where borrado=0";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tabla.Rows)
            {
                var categoria = new Categoria();
                categoria.Id = Convert.ToInt32(fila["id_categoria"].ToString());
                categoria.Nombre = fila["nombre"].ToString();
                categorias.Add(categoria);
            }
            return categorias;

        }
        public void modificarCategoria(int idCategoria, string nombre, string descripcion)
        {
            string consulta = "UPDATE Categorias SET nombre ='" + nombre + "',descripcion ='" + descripcion + "' WHERE id_categoria =" + idCategoria;
            DBHelper.GetDBHelper().ConsultaSQL(consulta);
        }
        public DataTable recuperarCat()
        {
            string consulta = "select id_categoria,nombre,descripcion from Categorias where borrado=0";
            var datos = DBHelper.GetDBHelper().ConsultaSQL(consulta);
            return datos;
        }
        public DataTable recuperarCatAux()
        {
            string consulta = "select id_categoria,nombre,descripcion from Categorias";
            var datos = DBHelper.GetDBHelper().ConsultaSQL(consulta);
            return datos;
        }

        public DataTable recuperarCatInac()
        {
            string consulta = "select id_categoria,nombre,descripcion from Categorias where borrado=1";
            var datos = DBHelper.GetDBHelper().ConsultaSQL(consulta);
            return datos;
        }

        public List<Categoria> ConsultarCategoria(long id)
        {
            List<Categoria> categorias = new List<Categoria>();
            var sentenciaSql = $"SELECT * FROM Categorias where id_categoria='{id}'";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tabla.Rows)
            {
                var categoria = new Categoria();
                categoria.Id = Convert.ToInt32(fila["id_categoria"].ToString());
                categoria.Nombre = fila["nombre"].ToString();
                categoria.Descripcion = fila["descripcion"].ToString();
                categorias.Add(categoria);
            }
            return categorias;
        }


        public List<Categoria> ConsultarCategoriaExacta(string nombre, string id)
        {
            List<Categoria> categorias = new List<Categoria>();
            var sentenciaSql = $"SELECT * FROM Categorias WHERE nombre like '{nombre}'";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tabla.Rows)
            {
                var categoria = new Categoria();
                categoria.Id = Convert.ToInt32(fila["id_categoria"].ToString());
                categoria.Nombre = fila["nombre"].ToString();
                categorias.Add(categoria);
            }
            return categorias;
        }


        //public int RegistrarCategoria(string nombre)
        //{
        //    var sentenciaSql = $"INSERT INTO Categorias (nombre) VALUES ('{nombre}')";
        //    var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);
        //    return filasAfectadas;
        //}

        public  void RegistrarCategoria(int id,string nombre, string descripcion)
        {
            var sentenciaSql = $"INSERT INTO Categorias (id_categoria,nombre,descripcion,borrado) VALUES ({id},'{nombre}','{descripcion}',0)";
           
            DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            
        }

        public int EliminarCategoria(long id)
        {
            var sentenciaSql = $"UPDATE Categorias SET borrado = 1 WHERE id_categoria = {id}";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);
            return filasAfectadas;
        }

        public List<Categoria> ConsultarCategoria(string id, string nombre, string descripcion)
        {
            List<Categoria> categorias = new List<Categoria>();
            var sentenciaSql = $"SELECT * FROM Categorias where id_categoria = '{id}' and borrado=0";
            if (nombre != "")
            {
                sentenciaSql += $" and nombre like '%{nombre}%'";
            }
            if (descripcion != "")
            {
                sentenciaSql += $" and descripcion like '%{descripcion}%'";
            }
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tabla.Rows)
            {
                var categoria = new Categoria();
                categoria.Id = Convert.ToInt32(fila["id_categoria"]);
                categoria.Nombre = fila["nombre"].ToString();
                categoria.Descripcion = fila["descripcion"].ToString();
                categorias.Add(categoria);
            }
            return categorias;
        }

        public List<Categoria> ConsultarCategoria(string nombre, string descripcion)
        {
            List<Categoria> categorias = new List<Categoria>();
            var sentenciaSql = $"SELECT * FROM Categorias";

            if (nombre != "" && descripcion != "")
            {
                sentenciaSql += $" where nombre like '%{nombre}%' and descripcion like '%{descripcion}%' and borrado=0";
            }
            else
            {
                if (nombre == "" && descripcion != "")
                {
                    sentenciaSql += $" where descripcion like '%{descripcion}%' and borrado=0";
                }
                if (nombre != "" && descripcion == "")
                {
                    sentenciaSql += $" where nombre like '%{nombre}%' and borrado=0";
                }
            }

            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tabla.Rows)
            {
                var categoria = new Categoria();
                categoria.Id = Convert.ToInt32(fila["id_categoria"].ToString());
                categoria.Nombre = fila["nombre"].ToString();
                categoria.Descripcion = fila["descripcion"].ToString();
                categorias.Add(categoria);
            }
            return categorias;
        }

        public void RegistrarCategoria(Categoria categoria)
        {
            using (var tx = DBHelper.GetDBHelper().IniciarTransaccion())
            {
                try
                {
                    var consultaSql = $"INSERT INTO Categorias (id_categoria,nombre,descripcion) VALUES ({categoria.Id},'{categoria.Nombre}','{categoria.Descripcion}')";
                    DBHelper.GetDBHelper().EjecutarTransaccionSQL(consultaSql);
                    long id_per = 0;
                    var sentencia = $"SELECT c.id_categoria FROM Categorias c WHERE c.id_categoria = {categoria.Id}";
                    var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentencia);
                    if (tabla.Rows.Count == 1)
                    {
                        id_per = Convert.ToInt64(tabla.Rows[0]["id_perfil"].ToString());
                        tx.Commit();
                    }
                    
                }
                catch
                {
                    tx.Rollback();
                    throw new ApplicationException("No se pudo registrar el sueldo.");
                }
                finally
                {
                    DBHelper.GetDBHelper().CloseConnection();
                }
            }

            
        }

        public DataTable estaAsignado(int id)
        {
            string consulta = "select c.id_categoria from Cursos c, Categorias cat where c.id_categoria=" + id;
            //string consulta = "SELECT s.id_usuario,u.usuario,CONVERT(varchar,s.fecha,23) as fecha,s.sueldo_bruto FROM Sueldos s, Usuarios u, SueldoDescuentos sd WHERE s.id_usuario=u.id_usuario AND s.id_usuario!=sd.id_usuario AND s.fecha!=sd.fecha ORDER BY s.fecha";
            var datos = DBHelper.GetDBHelper().ConsultaSQL(consulta);
            return datos;
        }

    }
}

