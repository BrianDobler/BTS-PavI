using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BTS_3k2_2020.Modelos;
using System.Data;

namespace BTS_3k2_2020.RespositoriosDAO
{
    class SueldoDescuentosRepositorio
    {
        //SueldoDescuentos oSDescuento = new SueldoDescuentos();

        public DataTable recuperarDescuentosPorSueldos()
        {
            string consulta = "SELECT u.usuario, d.n_descuento, sd.fecha, sd.cantidad, d.monto " +
                "FROM SueldoDescuentos sd, Usuarios u, Descuentos d WHERE sd.id_usuario=u.id_usuario AND sd.id_descuento=d.id_descuento";
            //string consulta = "SELECT u.usuario, sd.fecha, d.n_descuento, sd.cantidad, sd.monto " +
            //    "FROM Descuentos d, Usuarios u, SueldoDescuentos sd, Sueldos s " +
            //    "WHERE d.id_descuento=sd.id_descuento AND s.id_usuario=u.id_usuario AND sd.fecha=s.fecha";
            var datos = DBHelper.GetDBHelper().ConsultaSQL(consulta);
            return datos;
        }
        public DataTable recuperarDescuentosPorSueldosFiltrados(string usuario, string nomDesc, string monto, string cantidad, DateTime fecha, int bandera )
        {
            string consulta = "SELECT u.usuario, d.n_descuento, sd.fecha, sd.cantidad, d.monto FROM SueldoDescuentos sd, Usuarios u, Descuentos d " +
                "WHERE sd.id_usuario=u.id_usuario AND sd.id_descuento=d.id_descuento";
            if (!string.IsNullOrEmpty(usuario))
                consulta += " AND u.usuario LIKE'%" + usuario + "%'";
            if (!string.IsNullOrEmpty(nomDesc))
                consulta += " AND d.n_descuento LIKE '%" + nomDesc + "%'";
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
        }
        public DataTable recuperarDescuentosPorSueldosParaAsignar(int idUsu, string fecha, int idDesc)
        {
            string consultaPrev = "SELECT * FROM SueldoDescuentos WHERE id_usuario=" + idUsu + " AND fecha='" + fecha + "' AND id_descuento=" + idDesc;
            var datos = DBHelper.GetDBHelper().ConsultaSQL(consultaPrev);
            return datos;
        }
    }
}