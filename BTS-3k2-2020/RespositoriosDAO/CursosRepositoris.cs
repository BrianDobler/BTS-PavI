using BTS_3k2_2020.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BTS_3k2_2020.RespositoriosDAO
{
    class CursosRepositoris
    {
        public List<Curso> ObtenerCursos(string nombre, long Id, bool estado)
        {
            List<Curso> cursos = new List<Curso>();
            var sentenciaSql = $"SELECT * FROM Cursos WHERE nombre like '%{nombre}%' where borrado=0";
            if (Id != 0)
            {
                sentenciaSql += $" and id_categoria={Id}";
            }
            
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

        public int RegistrarCurso(Curso c)
        {
            var sentenciaSql = $"INSERT INTO Cursos (id_curso,nombre,descripcion,fecha_vigencia,borrado) VALUES (" + c.Id + ",'" + c.Nombre + "','" + c.Descripcion + "'," + DateTime.Today.ToString() + ",0)";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);
            return filasAfectadas;

            //string consulta = "INSERT INTO Cursos (id_curso,nombre,descripcion) VALUES (" + c.Id + ",'" + c.Nombre + "','" + c.Descripcion + "')";
            //DBHelper.GetDBHelper().ConsultaSQL(consulta);

        }

        public Curso ObtenerCurso(long id)
        {
            Curso cursoResultado = null;
            var sentenciaSql = $"SELECT * FROM Cursos u JOIN Categorias c On u.id_curso=c.id_categoria where id_curso={id}";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            if (tabla.Rows.Count == 1)
            {
                var row = tabla.Rows[0];
                var cursoBD = new Curso();
                var id_curso = row["id_curso"];
                cursoBD.Id = Convert.ToInt64(id_curso.ToString());
                cursoBD.Nombre = row["nombre"].ToString();
                cursoBD.Descripcion = row["descripcion"].ToString();


                var categoria = new Categoria();
                categoria.Id = Convert.ToInt64(row["id_categoria"].ToString());
                categoria.Nombre = row["nombre"].ToString();

                cursoBD.Categoria = categoria;
                return cursoBD;
            }



            return cursoResultado;
        }

        public int ActualizarCursos(Curso c)
        {
            var sentenciaSql = $"UPDATE Cursos SET id_curso='{c.Id}', nombre='{c.Nombre}', categoria='{c.Categoria}', descripcion='{c.Descripcion}' WHERE id_usuario={c.Id}";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);
            return filasAfectadas;
        }

        public DataTable tieneCategoria(int id)
        {
            string consulta = "SELECT * FROM Cursos where id_curso=" + id + " and id_categoria is not null";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(consulta);
            return tabla;
        }

        public DataTable recuperarSinCategoria()
        {
            string consulta = "SELECT id_curso,nombre,descripcion,fecha_vigencia FROM Cursos where id_categoria is null";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(consulta);
            return tabla;
        }

        public DataTable recuperar()
        {
            string consulta = "SELECT id_curso,nombre,descripcion,fecha_vigencia from cursos where borrado=0";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(consulta);
            return tabla;
        }

        public DataTable recuperarCategorias(int id)
        {
            string consulta = "SELECT id_categoria,nombre from categorias where borrado=0";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(consulta);
            return tabla;
        }

        public void registrarModificacion(int id, string nom,string descrip,int categ)
        {
            string consulta = "UPDATE Cursos SET id_categoria=" + categ + ",nombre='" + nom + "',descripcion='" + descrip + "' where id_curso=" + id;
            DBHelper.GetDBHelper().ConsultaSQL(consulta);
        }

        public void asignarCategoria(int id_curso, int id_categ)
        {
            string consulta = "UPDATE Cursos SET id_categoria=" + id_categ + " WHERE id_curso=" + id_curso;
            DBHelper.GetDBHelper().ConsultaSQL(consulta);

        }

        public void registrarCurso(string nombre, string desc, int id_cat, int conCat)
        {
            string consultaID = "SELECT MAX(id_curso) FROM Cursos";
            var tablaID = DBHelper.GetDBHelper().ConsultaSQL(consultaID);
            var id = Convert.ToInt32(tablaID.Rows[0][0]) + 1;
            var fecha = DateTime.Today.ToString("dd/MM/yyyy");
            string consulta = "INSERT INTO Cursos (id_curso,nombre,descripcion,fecha_vigencia,id_categoria,borrado) VALUES ("+ id + ",'" + nombre + "','" + desc + "','" + fecha + "'" ;
            if (conCat == 1)
                consulta += "," + id_cat + ",0)";
            else
                consulta += ",NULL,0)";
            DBHelper.GetDBHelper().ConsultaSQL(consulta);
        }

        public void eliminarCurso(int id)
        {
            string consulta = "UPDATE Cursos SET borrado=1 where id_curso=" + id;
            DBHelper.GetDBHelper().ConsultaSQL(consulta);
        }

        public DataTable recuperarInac()
        {
            string consulta = "SELECT id_curso,nombre,descripcion,fecha_vigencia from cursos";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(consulta);
            return tabla;
        }

        public DataTable recuperarFiltrado(int nom, int cat, string nombre, int categ)
        {
            string consulta = "SELECT id_curso,nombre,descripcion,fecha_vigencia from cursos where borrado=0";
            if (nom == 0)
                consulta += " AND nombre like '%" + nombre + "%'";
            if (cat == 0)
                consulta += " AND id_categoria=" + categ;
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(consulta);
            return tabla;
        }
    }

    
}
    