using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BTS_3k2_2020.RespositoriosDAO
{
    class CursoPorCategoriaRepositorio
    {
        public DataTable recuperar()
        {
            string consulta = "select c.nombre as Curso,cat.nombre as Categoria from cursos c, Categorias cat where c.id_categoria=cat.id_categoria and c.borrado=0 and cat.borrado=0";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(consulta);
            return tabla;
        }

        public DataTable recuperarFiltrado(int curso, int categ, string nomCurso, string nomCateg)
        {
            string consulta = "select c.nombre as Curso,cat.nombre as Categoria from cursos c, Categorias cat where c.id_categoria=cat.id_categoria and c.borrado=0 and cat.borrado=0";
            if (curso == 0)
                consulta += " AND c.nombre like '%" + nomCurso + "%'";
            if (categ == 0)
                consulta += " AND cat.nombre like '%" + nomCateg + "%'";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(consulta);
            return tabla;
        }

    }
}
