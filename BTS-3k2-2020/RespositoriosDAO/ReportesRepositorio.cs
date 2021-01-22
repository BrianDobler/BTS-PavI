using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTS_3k2_2020.RespositoriosDAO
{
    public class ReportesRepositorio
    {
        public DataTable recuperarAsignaciones(string nombre, string monto)
        {
            string consulta = "SELECT * FROM Asignaciones WHERE  id_asignacion BETWEEN 0 AND 9999999999";
            if (!string.IsNullOrEmpty(nombre))
                consulta += " AND n_asignacion LIKE '%" + nombre + "%'";
            if (!string.IsNullOrEmpty(monto))
                consulta += " AND monto='" + monto + "'";
            var datos = DBHelper.GetDBHelper().ConsultaSQL(consulta);
            return datos;
        }

        public DataTable recuperarDescuentos(string nombre, string monto)
        {
            string consulta = "SELECT * FROM Descuentos WHERE  id_descuento BETWEEN 0 AND 9999999999";
            if (!string.IsNullOrEmpty(nombre))
                consulta += " AND n_descuento LIKE '%" + nombre + "%'";
            if (!string.IsNullOrEmpty(monto))
                consulta += " AND monto='" + monto + "'";
            var datos = DBHelper.GetDBHelper().ConsultaSQL(consulta);
            return datos;
        }

        public DataTable recuperarCategorias(string nombre, int borrado)
        {
            string consulta = "SELECT id_categoria,nombre,descripcion FROM Categorias WHERE  id_categoria BETWEEN 0 AND 9999999999";
            if (!string.IsNullOrEmpty(nombre))
                consulta += " AND nombre LIKE '%" + nombre + "%'";
            if (borrado == 0)
                consulta += " AND borrado=0";
            var datos = DBHelper.GetDBHelper().ConsultaSQL(consulta);
            return datos;
        }

        public DataTable RecuperarCursos(string nombre, long Id, int borrado)
        {
            string consulta = "SELECT c.id_curso,c.nombre as nombreCurso,cat.nombre as nombreCategoria  FROM Cursos c, Categorias cat WHERE id_curso BETWEEN 0 AND 9999999999 AND c.id_categoria=cat.id_categoria";
            if (!string.IsNullOrEmpty(nombre))
                consulta += " AND c.nombre LIKE '%" + nombre + "%'";
            if (Id != -1)
                consulta += " AND c.id_categoria=" + Id;
            if (borrado == 0)
                consulta += " AND (c.borrado=0 OR c.borrado is null)";
            var datos = DBHelper.GetDBHelper().ConsultaSQL(consulta);
            return datos;
            
        }

        public DataTable RecuperarObjetivos(string nombreC, string nombreL, int borrado)
        {
            string consulta = "SELECT id_objetivo,nombre_corto,nombre_largo FROM Objetivos WHERE  id_objetivo BETWEEN 0 AND 9999999999";
            if (!string.IsNullOrEmpty(nombreC))
                consulta += " AND nombre_corto LIKE '%" + nombreC + "%'";
            if (!string.IsNullOrEmpty(nombreL))
                consulta += " AND nombre_largo LIKE '%" + nombreL + "%'";
            if (borrado == 0)
                consulta += " AND (borrado=0 OR borrado is null)";
            var datos = DBHelper.GetDBHelper().ConsultaSQL(consulta);
            return datos;
            
        }

        public DataTable RecuperarPerfiles(string nombre, int borrado)
        {
            string consulta = "SELECT id_perfil,nombre FROM Perfiles WHERE  id_perfil BETWEEN 0 AND 9999999999";
            if (!string.IsNullOrEmpty(nombre))
                consulta += " AND nombre LIKE '%" + nombre + "%'";
            if (borrado == 0)
                consulta += " AND (borrado=0 OR borrado is null)";
            var datos = DBHelper.GetDBHelper().ConsultaSQL(consulta);
            return datos;

        }

        public DataTable RecuperarSueldos(string nombre_usuario, DateTime? fecha, string sueldo_bruto, int band)
        {
            
            DateTime fechaMinima = new DateTime(1900, 01, 01);
            var consulta = "SELECT s.id_usuario,s.fecha,s.sueldo_bruto, u.usuario as nombreUsuario FROM Sueldos s, Usuarios u WHERE s.id_usuario BETWEEN 0 AND 99999999 AND s.id_usuario=u.id_usuario ";
            if(!string.IsNullOrEmpty(nombre_usuario))
                consulta += $" AND u.usuario like '%{nombre_usuario}%'";
            fecha = new DateTime(fecha.Value.Year, fecha.Value.Month, fecha.Value.Day);
            if (band == 1)
                consulta += $" AND s.fecha >= '{fecha.Value.ToString("yyyy-MM-dd")}'";
            if (!string.IsNullOrEmpty(sueldo_bruto))
                consulta += $" AND s.sueldo_bruto = {sueldo_bruto}";

            var datos = DBHelper.GetDBHelper().ConsultaSQL(consulta);
            
            return datos;
        }

        public DataTable RecuperarUsuarios(string nombre, long perfilId, int borrado)
        {
            string consulta = "SELECT u.id_usuario,u.usuario as nombreUsuario,u.email,u.estado,p.nombre as nombrePerfil FROM Usuarios u, Perfiles p WHERE  id_usuario BETWEEN 0 AND 9999999999 AND u.id_perfil=p.id_perfil";
            if (!string.IsNullOrEmpty(nombre))
                consulta += " AND u.usuario LIKE '%" + nombre + "%'";
            if (perfilId != -1)
                consulta += " AND u.id_perfil=" + perfilId;
            if (borrado == 0)
                consulta += " AND (u.borrado=0 OR u.borrado is null)";
            var datos = DBHelper.GetDBHelper().ConsultaSQL(consulta);
            return datos;

        }

        public DataTable recuperarEstAsignacionMayor(string monto)
        {
            string consulta = "select n_asignacion as Asignacion, n_asignacion as Cantidad from Asignaciones WHERE id_asignacion BETWEEN 0 AND 9999999999";
            if (!string.IsNullOrEmpty(monto))
                consulta += " AND monto>=" + monto;
            var datos = DBHelper.GetDBHelper().ConsultaSQL(consulta);
            return datos;
        }

        public DataTable recuperarEstAsignacionMenor(string monto)
        {
            string consulta = "select n_asignacion as Asignacion, n_asignacion as Cantidad from Asignaciones WHERE  id_asignacion BETWEEN 0 AND 9999999999";
            if (!string.IsNullOrEmpty(monto))
                consulta += " AND monto<=" + monto;
            var datos = DBHelper.GetDBHelper().ConsultaSQL(consulta);
            return datos;
        }

        public DataTable recuperarEstCategorias(int ban)
        {
            //string consulta = "select nombre as Categoria, nombre as Cantidad from Categorias";
            string consulta = "select cat.nombre as Categoria, c.nombre as Cantidad from Categorias cat, cursos c where cat.id_categoria=c.id_categoria";
            if (ban == 0)
                consulta += " AND cat.borrado=0 and c.borrado=0";
            var datos = DBHelper.GetDBHelper().ConsultaSQL(consulta);
            return datos;
        }

        public DataTable RecuperarEstCursos(int ban)
        {
            //string consulta = "select nombre as Curso, nombre as Cantidad from Cursos";           
            string consulta = "select descripcion as curso, nombre as cantidad from cursos where id_curso between 0 and 10000000";
            if (ban == 0)
                consulta += " and borrado=0";
            var datos = DBHelper.GetDBHelper().ConsultaSQL(consulta);
            return datos;

        }

        public DataTable recuperarEstDescuentoMayor(string monto)
        {
            string consulta = "select n_descuento as Descuento, n_descuento as Cantidad from Descuentos WHERE  id_descuento BETWEEN 0 AND 9999999999";
            if (!string.IsNullOrEmpty(monto))
                consulta += " AND monto>=" + monto;
            var datos = DBHelper.GetDBHelper().ConsultaSQL(consulta);
            return datos;
        }

        public DataTable recuperarEstDescuentoMenor(string monto)
        {
            string consulta = "select n_descuento as Descuento, n_descuento as Cantidad from Descuentos WHERE  id_descuento BETWEEN 0 AND 9999999999";
            if (!string.IsNullOrEmpty(monto))
                consulta += " AND monto<=" + monto;
            var datos = DBHelper.GetDBHelper().ConsultaSQL(consulta);
            return datos;
        }

        public DataTable RecuperarEstObjetivos()
        {
            string consulta = "select nombre_corto as NombreC, nombre_corto as Cantidad from Objetivos";
            var datos = DBHelper.GetDBHelper().ConsultaSQL(consulta);
            return datos;

        }

        public DataTable RecuperarEstPerfiles()
        {
            string consulta = "select p.nombre as Perfil, u.id_perfil as CantUsuarios  from Usuarios u, Perfiles p where p.id_perfil=u.id_perfil";
            var datos = DBHelper.GetDBHelper().ConsultaSQL(consulta);
            return datos;
        }

        public DataTable RecuperarEstSueldos(DateTime? fecha, int ban)
        {

            DateTime fechaMinima = new DateTime(1900, 01, 01);
            var consulta = "select u.usuario as Usuario, u.id_usuario as Cantidad from sueldos s, usuarios u where u.id_usuario=s.id_usuario";      
            fecha = new DateTime(fecha.Value.Year, fecha.Value.Month, fecha.Value.Day);
            if (ban == 1)
                consulta += $" AND s.fecha >= '{fecha.Value.ToString("yyyy-MM-dd")}'";           
            var datos = DBHelper.GetDBHelper().ConsultaSQL(consulta);

            return datos;
        }

        public DataTable RecuperarEstUsuarios()
        {
            string consulta = "select estado as Estado, estado as Cantidad from Usuarios";
            var datos = DBHelper.GetDBHelper().ConsultaSQL(consulta);
            return datos;

        }




    }


}
