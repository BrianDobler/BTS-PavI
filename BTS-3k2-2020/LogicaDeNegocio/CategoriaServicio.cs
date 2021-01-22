using BTS_3k2_2020.Modelos;
using BTS_3k2_2020.RespositoriosDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BTS_3k2_2020.LogicaDeNegocio
{
    public class CategoriaServicio
    {
        private CategoriaRepositorio _repositorio;

        public CategoriaServicio()
        {
            _repositorio = new CategoriaRepositorio();
        }

        /*
        public List<Categoria> ConsultarCategoria(string nombre, string id, string descripcion)
        {
            if (nombre == "" && id.ToString() != "" && descripcion == "")
            {
                var id_categoria = (long)Convert.ToInt64(id);
                var categorias = _repositorio.ConsultarCategoria(id_categoria);
                return categorias;
            }
            else
            {
                if (nombre != "" && id.ToString() != "")
                {
                    var perfiles = _repositorio.ConsultarCategoria(nombre, id);
                    return perfiles;
                }
                else
                {
                    var perfiles = _repositorio.ConsultarCategoria(nombre);
                    return perfiles;
                }
            }
        }
        */

        public List<Categoria> ObtenerCategoria()
        {
            return _repositorio.ObtenerTodos();
        }

        /*
        public List<Categoria> ConsultarCategoriaExacta(string nombre, string id)
        {
            if (nombre == "" && id.ToString() != "")
            {
                var idCategoria = (long)Convert.ToInt64(id);
                var categorias = _repositorio.ConsultarCategoria(idCategoria);
                return categorias;
            }
            else
            {
                if (nombre != "" && id.ToString() != "")
                {
                    var categorias = _repositorio.ConsultarCategoriaExacta(nombre, id);
                    return categorias;
                }
                else
                {
                    var categorias = _repositorio.ConsultarCategoriaExacta(nombre);
                    return categorias;
                }
            }

        }
        */
        //public int RegistrarCategoria(Categoria categoria)
        //{
            
        //    DataTable tabla = _repositorio.RegistrarCategoria(categoria.Nombre,categoria.Id,categoria.Descripcion);
        //    return tabla;
        //}
        public void RegistrarSueldo(Categoria categoria)
        {
            _repositorio.RegistrarCategoria(categoria);
        }
        public List<Categoria> ObtenerTodos()
        {
            var usuarios = _repositorio.ObtenerTodos();
            return usuarios;
        }

        public int EliminarCategoria(Categoria categoria)
        {
            var filasAfectadas = _repositorio.EliminarCategoria(categoria.Id);
            return filasAfectadas;
        }


        public List<Categoria> ConsultarCategoria(string id, string nombre, string descripcion)
        {

            if (id != "")
            {
                var categorias = _repositorio.ConsultarCategoria(id, nombre, descripcion);
                return categorias;
            }
            else
            {
                var categorias = _repositorio.ConsultarCategoria(nombre, descripcion);
                return categorias;
            }
        }

    }
}