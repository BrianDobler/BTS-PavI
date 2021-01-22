using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BTS_3k2_2020.Modelos;
using System.Data;

namespace BTS_3k2_2020.RespositoriosDAO
{
    class AsignacionesRepositorio
    {
        public DataTable recuperarAsignaciones()
        {
            string consulta = "SELECT id_asignacion,n_asignacion,monto FROM Asignaciones";
            var datos = DBHelper.GetDBHelper().ConsultaSQL(consulta);
            return datos;
        }

        public DataTable recuperarAsignacionesFiltradas(string nombre, string monto)
        {
            string consulta = "SELECT * FROM Asignaciones WHERE  n_asignacion LIKE '%" + nombre + "%' AND monto='" + monto + "'";
            var datos = DBHelper.GetDBHelper().ConsultaSQL(consulta);
            return datos;
        }

        public void agregarAsignacion(string nombre, string monto)
        {
            string consultaID = "SELECT MAX(id_asignacion) FROM Asignaciones";
            var tablaID = DBHelper.GetDBHelper().ConsultaSQL(consultaID);
            var id = Convert.ToInt32(tablaID.Rows[0][0]) + 1;
            string consulta = "INSERT INTO Asignaciones (id_asignacion,n_asignacion,monto) VALUES (" + id + ",'" + nombre + "','" + monto + "')";
            DBHelper.GetDBHelper().ConsultaSQL(consulta);

        }

        public void eliminarAsignacion(int idAsig)
        {
            using (var tx = DBHelper.GetDBHelper().IniciarTransaccion())
            {
                try
                {
                    string consulta = "DELETE FROM Asignaciones WHERE id_asignacion=" + idAsig;
                    DBHelper.GetDBHelper().ConsultaSQL(consulta);
                    string consulta1 = "DELETE FROM SueldoAsignaciones WHERE id_asignacion=" + idAsig;
                    DBHelper.GetDBHelper().ConsultaSQL(consulta1);
                    tx.Commit();
                }
                catch
                {
                    tx.Rollback();
                    throw new ApplicationException("No se pudo eliminar la asignacion seleccionada");
                }
                finally
                {
                    DBHelper.GetDBHelper().CloseConnection();
                }
            }
            //string consulta = "DELETE FROM Descuentos WHERE id_descuento=" + idDesc; 
            //DBHelper.GetDBHelper().ConsultaSQL(consulta);
            //string consulta2 = "DELETE FROM SueldoDescuentos WHERE id_descuento=" + idDesc;
            //DBHelper.GetDBHelper().ConsultaSQL(consulta2);
        }

        public DataTable recuperarAsignacionesPorNombre(string nombre)
        {
            string consulta = "SELECT * FROM Asignaciones WHERE n_asignacion LIKE '%" + nombre + "%'";
            var datos = DBHelper.GetDBHelper().ConsultaSQL(consulta);
            return datos;
        }

        public DataTable recuperarAsignacionesPorMonto(string monto)
        {
            string consulta = "SELECT * FROM Asignaciones WHERE monto=" + monto + "";
            var datos = DBHelper.GetDBHelper().ConsultaSQL(consulta);
            return datos;
        }

        public void modificarAsignacion(int idAsig, string nombre, string monto)
        {
            using (var tx = DBHelper.GetDBHelper().IniciarTransaccion())
            {
                try
                {
                    string consulta = "UPDATE Asignaciones SET n_asignacion='" + nombre + "',monto='" + monto + "' WHERE id_asignacion=" + idAsig;
                    DBHelper.GetDBHelper().ConsultaSQL(consulta);
                    string consulta1 = "UPDATE SueldoAsignaciones SET monto='" + monto + "' WHERE id_asignacion=" + idAsig;
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
        }

        public void asignarAsignacion(int idUsu, string fecha, int idAsig, int cant, string monto)
        {
            string consulta = "INSERT INTO SueldoAsignaciones(id_usuario, fecha, id_asignacion, cantidad, monto) VALUES(" + idUsu + ",'" + fecha + "'," + idAsig + "," + cant + ",ISNUMERIC('" + monto + "'))";
            var datos = DBHelper.GetDBHelper().ConsultaSQL(consulta);
        }

        public DataTable estaAsignado(int id)
        {
            string consulta = "select * from SueldoAsignaciones where id_asignacion=" + id;
            //string consulta = "SELECT s.id_usuario,u.usuario,CONVERT(varchar,s.fecha,23) as fecha,s.sueldo_bruto FROM Sueldos s, Usuarios u, SueldoDescuentos sd WHERE s.id_usuario=u.id_usuario AND s.id_usuario!=sd.id_usuario AND s.fecha!=sd.fecha ORDER BY s.fecha";
            var datos = DBHelper.GetDBHelper().ConsultaSQL(consulta);
            return datos;
        }
    }
}

