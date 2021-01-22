using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BTS_3k2_2020.Modelos;
using System.Data;

namespace BTS_3k2_2020.RespositoriosDAO
{
    class DescuentosRepositorio
    {
        //DBHelper datos = new DBHelper();
        public DataTable recuperarDescuentos()
        {
            string consulta = "SELECT id_descuento,n_descuento,monto FROM Descuentos";
            var datos = DBHelper.GetDBHelper().ConsultaSQL(consulta);
            return datos;

        }

        public DataTable recuperarDescuentosFiltrados(string nombre, string monto)
        {
            string consulta = "SELECT * FROM Descuentos WHERE  n_descuento LIKE '%" + nombre + "%' AND monto='" + monto + "'";
            var datos = DBHelper.GetDBHelper().ConsultaSQL(consulta);
            return datos;
        }

        public DataTable recuperarDescuentosPorNombre(string nombre)
        {
            string consulta = "SELECT * FROM Descuentos WHERE n_descuento LIKE '%" + nombre + "%'";
            var datos = DBHelper.GetDBHelper().ConsultaSQL(consulta);
            return datos;
        }

        public DataTable recuperarDescuentosPorMonto(string monto)
        {
            string consulta = "SELECT * FROM Descuentos WHERE monto=" + monto + "";
            var datos = DBHelper.GetDBHelper().ConsultaSQL(consulta);
            return datos;
        }
        //public DataTable recuperarDescuentosFiltrados()
        //{
        //    string consulta = "SELECT * FROM Descuentos WHERE n_descuento='" + oDescuento.NombreDescuento + "' AND monto='" + oDescuento.MontoDescuento + "'";
        //    var datos = DBHelper.GetDBHelper().ConsultaSQL(consulta);
        //    return datos;
        //}

        public void agregarDescuento(string nombre, string monto)
        {
            string consultaID = "SELECT MAX(id_descuento) FROM Descuentos";
            var tablaID = DBHelper.GetDBHelper().ConsultaSQL(consultaID);
            var id = Convert.ToInt32(tablaID.Rows[0][0]) + 1;
            string consulta = "INSERT INTO Descuentos (id_descuento,n_descuento,monto) VALUES (" + id + ",'" + nombre + "','" + monto + "')";
            DBHelper.GetDBHelper().ConsultaSQL(consulta);

        }
        //public void agregarDescuento(string nombre, string monto)
        //{
        //    string consulta = "INSERT INTO Descuentos (n_descuento,monto) VALUES ('" + nombre + "','" + monto + "')";
        //    DBHelper.GetDBHelper().ConsultaSQL(consulta);

        //}

        //public void agregarDescuento()
        //{
        //    string consulta = "INSERT INTO Descuentos (id_descuento,n_descuento,monto) VALUES ("+ oDescuento.IdDescuento + ",'" + oDescuento.NombreDescuento + "','" + oDescuento.MontoDescuento + "')";
        //    DBHelper.GetDBHelper().ConsultaSQL(consulta);

        //}

        public void eliminarDescuento(int idDesc)
        {
            using (var tx = DBHelper.GetDBHelper().IniciarTransaccion())
            {
                try
                {
                    string consulta = "DELETE FROM Descuentos WHERE id_descuento=" + idDesc;
                    DBHelper.GetDBHelper().ConsultaSQL(consulta);
                    string consulta1 = "DELETE FROM SueldoDescuentos WHERE id_descuento=" + idDesc;
                    DBHelper.GetDBHelper().ConsultaSQL(consulta1);
                    tx.Commit();
                }
                catch
                {
                    tx.Rollback();
                    throw new ApplicationException("No se pudo eliminar el descuento seleccionado");
                }
                finally
                {
                    DBHelper.GetDBHelper().CloseConnection();
                }
            }
            
        }

        //public void eliminarDescuento()
        //{
        //    string consulta = "DELETE FROM Descuentos WHERE id_descuento=" + oDescuento.IdDescuento;
        //    DBHelper.GetDBHelper().ConsultaSQL(consulta);
        //}

        public void modificarDescuento(int idDesc, string nombre, string monto)
        {
            using (var tx = DBHelper.GetDBHelper().IniciarTransaccion())
            {
                try
                {
                    string consulta = "UPDATE Descuentos SET n_descuento='" + nombre + "',monto='" + monto + "' WHERE id_descuento=" + idDesc;
                    DBHelper.GetDBHelper().ConsultaSQL(consulta);
                    string consulta1 = "UPDATE SueldoDescuentos SET monto='" + monto + "' WHERE id_descuento=" + idDesc;
                    DBHelper.GetDBHelper().ConsultaSQL(consulta1);
                    tx.Commit();
                }
                catch
                {
                    tx.Rollback();
                    throw new ApplicationException("No se pudo modificar el descuento seleccionado");
                }
                finally
                {
                    DBHelper.GetDBHelper().CloseConnection();
                }
            }
            //string consulta = "UPDATE Descuentos SET n_descuento='" + nombre + "',monto='" + monto + "' WHERE id_descuento=" + idDesc;
            //DBHelper.GetDBHelper().ConsultaSQL(consulta);

        }




        //public void modificarDescuento()
        //{
        //    string consulta = "UPDATE Descuentos SET n_descuento='" + oDescuento.NombreDescuento + "',monto='" + oDescuento.MontoDescuento + "' WHERE id_descuento=" + oDescuento.IdDescuento;
        //    DBHelper.GetDBHelper().ConsultaSQL(consulta);

        //}
        public DataTable recuperarSueldos()
        {
            string consulta = "select distinct s.id_usuario,u.usuario, s.fecha, s.sueldo_bruto from Sueldos s, Usuarios u WHERE s.id_usuario=u.id_usuario EXCEPT SELECT s.id_usuario,u.usuario, s.fecha, s.sueldo_bruto FROM Sueldos s,SueldoDescuentos sd, Usuarios u WHERE s.id_usuario=sd.id_usuario AND s.fecha=sd.fecha";
            //string consulta = "SELECT s.id_usuario,u.usuario,CONVERT(varchar,s.fecha,23) as fecha,s.sueldo_bruto FROM Sueldos s, Usuarios u, SueldoDescuentos sd WHERE s.id_usuario=u.id_usuario AND s.id_usuario!=sd.id_usuario AND s.fecha!=sd.fecha ORDER BY s.fecha";
            var datos = DBHelper.GetDBHelper().ConsultaSQL(consulta);
            return datos;
        }
        //provisional hasta tener la clase de sueldos

        public void asignarDescuento(int idUsu, string fecha, int idDesc, int cant, string monto)
        {
            string consulta = "INSERT INTO SueldoDescuentos(id_usuario, fecha, id_descuento, cantidad, monto) VALUES(" + idUsu + ",'" + fecha + "'," + idDesc + "," + cant + ",ISNUMERIC('" + monto + "'))";
            var datos = DBHelper.GetDBHelper().ConsultaSQL(consulta);
        }
        public DataTable estaAsignado(int id)
        {
            string consulta = "select * from SueldoDescuentos where id_descuento=" + id;
            //string consulta = "SELECT s.id_usuario,u.usuario,CONVERT(varchar,s.fecha,23) as fecha,s.sueldo_bruto FROM Sueldos s, Usuarios u, SueldoDescuentos sd WHERE s.id_usuario=u.id_usuario AND s.id_usuario!=sd.id_usuario AND s.fecha!=sd.fecha ORDER BY s.fecha";
            var datos = DBHelper.GetDBHelper().ConsultaSQL(consulta);
            return datos;
        }
    }
}
