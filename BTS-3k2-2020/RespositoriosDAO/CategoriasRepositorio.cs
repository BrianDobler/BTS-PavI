using BTS_3k2_2020.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTS_3k2_2020.RespositoriosDAO
{
    class CategoriasRepositorio
    {
        public List<Categoria> ObtenerCategorias()
        {
            List<Categoria> categorias = new List<Categoria>();
            var sentenciaSql = "SELECT * FROM Categorias";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach(DataRow fila in tabla.Rows)
            {
                var categoria = new Categoria();
                categoria.Id = Convert.ToInt32(fila["id_categoria"].ToString());
                categoria.Nombre = fila["nombre"].ToString();
                categoria.Descripcion = fila["descripcion"].ToString();
                categorias.Add(categoria);
            }
            return categorias;
        }
    }
}
