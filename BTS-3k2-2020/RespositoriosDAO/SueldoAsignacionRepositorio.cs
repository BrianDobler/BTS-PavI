using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BTS_3k2_2020.RespositoriosDAO
{
    class SueldoAsignacionRepositorio
    {
        public DataTable recuperarAsignacionesPorSueldosParaAsignar(int idUsu, string fecha, int idAsig)
        {
            string consultaPrev = "SELECT * FROM SueldoAsignaciones WHERE id_usuario=" + idUsu + " AND fecha='" + fecha + "' AND id_asignacion=" + idAsig;
            var datos = DBHelper.GetDBHelper().ConsultaSQL(consultaPrev);
            return datos;
        }

        public DataTable recuperarAsignacionesPorSueldos()
        {
            string consulta = "SELECT u.usuario, d.n_asignacion, sd.fecha, sd.cantidad, d.monto " +
                "FROM SueldoAsignaciones sd, Usuarios u, Asignaciones d " +
                "WHERE sd.id_asignacion=u.id_usuario AND sd.id_asignacion=d.id_asignacion";
            
            var datos = DBHelper.GetDBHelper().ConsultaSQL(consulta);
            return datos;
        }
        public DataTable recuperarAsignacionesPorSueldosFiltradas(string usuario, string nomAsig, string monto, string cantidad, DateTime fecha, int bandera)
        {
            string consulta = "SELECT u.usuario, d.n_asignacion, sd.fecha, sd.cantidad, d.monto " +
                "FROM SueldoAsignaciones sd, Usuarios u, Asignaciones d WHERE sd.id_usuario=u.id_usuario AND sd.id_asignacion=d.id_asignacion";
            if (!string.IsNullOrEmpty(usuario))
                consulta += " AND u.usuario LIKE'%" + usuario + "%'";
            if (!string.IsNullOrEmpty(nomAsig))
                consulta += " AND d.n_asignacion LIKE '%" + nomAsig + "%'";
            if (!string.IsNullOrEmpty(monto))
                consulta += " AND d.monto='" + monto + "'";
            if (!string.IsNullOrEmpty(cantidad))
                consulta += " AND sd.cantidad='" + cantidad + "'";
            if (bandera == 1)
                consulta += " AND sd.fecha BETWEEN '" + fecha + "' AND '" + DateTime.Today.ToString() + "'";
            //if (bandera is true)
            //    consulta += " AND sd.fecha='" + fecha + "'";
            var datos = DBHelper.GetDBHelper().ConsultaSQL(consulta);
            return datos;
            //string consulta = "SELECT u.usuario, d.n_asignacion, sd.fecha, sd.cantidad, d.monto " +
            //    "FROM SueldoAsignaciones sd, Usuarios u, Asignaciones d " +
            //    "WHERE sd.id_asignacion=u.id_usuario AND sd.id_asignacion=d.id_asignacion";
            //if (!string.IsNullOrEmpty(usuario))
            //    consulta += " AND u.usuario LIKE'%" + usuario + "%'";
            //if (!string.IsNullOrEmpty(nomAsig))
            //    consulta += " AND d.n_asignacion LIKE '%" + nomAsig + "%'";
            //if (!string.IsNullOrEmpty(monto))
            //    consulta += " AND sd.monto='" + monto + "'";
            //if (!string.IsNullOrEmpty(cantidad))
            //    consulta += " AND sd.cantidad='" + cantidad + "'";
            //if (bandera is true)
            //    consulta += " AND sd.fecha BETWEEN '" + fecha + "' AND '" + DateTime.Today.ToString() + "'";
            ////if (bandera is true)
            ////    consulta += " AND sd.fecha='" + fecha + "'";
            //var datos = DBHelper.GetDBHelper().ConsultaSQL(consulta);
            //return datos;
        }
    }


}
