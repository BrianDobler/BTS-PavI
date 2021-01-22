using BTS_3k2_2020.Modelos;
using BTS_3k2_2020.RespositoriosDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTS_3k2_2020.LogicaDeNegocio
{
    public class SueldosServicio
    {
        private SueldosRepositorio _sueldosRepositorio;

        public SueldosServicio()
        {
            _sueldosRepositorio = new SueldosRepositorio();
        }

        public List<Sueldo> ObtenerSueldos()
        {
            var sueldos = _sueldosRepositorio.ObtenerSueldos();
            return sueldos;
        }

        public List<Sueldo> ObtenerSueldos(long id_usuario, string nombre, DateTime? fecha, double sueldo_bruto)
        {
            var sueldos = _sueldosRepositorio.ObtenerSueldos(id_usuario, nombre, fecha, sueldo_bruto);
            return sueldos;
        }

        public Sueldo ObtenerSueldo(long id, DateTime fecha)
        {
            var sueldo = _sueldosRepositorio.ObtenerSueldo(id, fecha);
            return sueldo;
        }

        public Sueldo ValidarSueldo(Sueldo s)
        {
            s.ValidarUsuario();
            s.ValidarFecha();
            s.ValidarSueldo_bruto();
            return s;
        }

        public void RegistrarSueldo(Sueldo sueldo)
        {
            //long id_per = 0;
            //var sentencia = $"SELECT u.id_perfil FROM Usuarios u WHERE u.Id_usuario = {sueldo.Id_usuario}";
            //var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentencia);
            //var filasAfectadas = _sueldosRepositorio.RegistrarSueldo(sueldo);
            //if (tabla.Rows.Count == 1)
            //{
            //  id_per = Convert.ToInt64(tabla.Rows[0]["id_perfil"].ToString());
            //}

            _sueldosRepositorio.RegistrarSueldo(sueldo);

            //if (filasAfectadas == 1)
            //  return true;
            //return false;
        }

        public void ActualizarSueldo(Sueldo sueldo)
        {
            _sueldosRepositorio.ActualizarSueldo(sueldo);
            //var filasAfectadas = _sueldosRepositorio.ActualizarSueldo(s);
            //if (filasAfectadas != 1)
            //  throw new ApplicationException("Hubo un problema al actualizar.");
        }

        public void DarBajaSueldo(Sueldo s)
        {
            var filasAfectadas = _sueldosRepositorio.DarBajaSueldo(s);
            if (filasAfectadas != 1)
                throw new ApplicationException("Hubo un problema al intentar dar de baja.");
        }

        public List<HistoricoSueldo> ObtenerHistoricoSueldos(long id)
        {

            return _sueldosRepositorio.ObtenerHistoricoSueldos(id);
        }
    }
}
