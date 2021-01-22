
﻿using System;
using System.Collections.Generic;
﻿using BTS_3k2_2020.Modelos;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTS_3k2_2020.RespositoriosDAO
{
    public class SueldosRepositorio
    {
        public List<Sueldo> ObtenerSueldos()
        {
            List<Sueldo> sueldos = new List<Sueldo>();
            var sentenciaSql = "SELECT s.*, u.usuario FROM Sueldos s LEFT JOIN usuarios u ON s.id_usuario = u.id_usuario";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tabla.Rows)
            {
                var sueldo = new Sueldo();
                var usuario = new Usuario();
                usuario.Id = Convert.ToInt32(fila["id_usuario"].ToString());
                usuario.Nombre = fila["usuario"].ToString();
                sueldo.Usuario = usuario;
                sueldo.Fecha = Convert.ToDateTime(fila["fecha"].ToString());
                sueldo.Sueldo_bruto = Convert.ToDouble(fila["sueldo_bruto"].ToString());
                sueldos.Add(sueldo);
            }
            return sueldos;
        }
        

        public List<Sueldo> ObtenerSueldos(long id_usuario, string nombre_usuario, DateTime? fecha, double sueldo_bruto)
        {
            List<Sueldo> sueldos = new List<Sueldo>();
            //var sentenciaSql = "SELECT * FROM Sueldos s LEFT JOIN usuarios u ON s.id_usuario = u.id_usuario WHERE u.usuario like '%%'";
            DateTime fechaMinima = new DateTime(1900, 01, 01);
            var sentenciaSql = "SELECT s.*, u.usuario FROM Sueldos s LEFT JOIN usuarios u ON s.id_usuario = u.id_usuario WHERE";
            sentenciaSql += $" u.usuario like '%{nombre_usuario}%'";
            if (id_usuario != 0)
                sentenciaSql += $" and s.id_usuario = {id_usuario}";
            fecha = new DateTime(fecha.Value.Year, fecha.Value.Month, fecha.Value.Day);
            if (fecha != fechaMinima)
                sentenciaSql += $" and s.fecha = '{fecha.Value.ToString("yyyy-MM-dd")}'";
            if (sueldo_bruto != 0)
                sentenciaSql += $" and s.sueldo_bruto = {sueldo_bruto}";

            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tabla.Rows)
            {
                var sueldo = new Sueldo();
                var usuario = new Usuario();
                usuario.Id = Convert.ToInt32(fila["id_usuario"].ToString());
                usuario.Nombre = fila["usuario"].ToString();
                sueldo.Usuario = usuario;
                sueldo.Fecha = Convert.ToDateTime(fila["fecha"].ToString());
                sueldo.Sueldo_bruto = Convert.ToDouble(fila["sueldo_bruto"].ToString());
                sueldos.Add(sueldo);
            }
            return sueldos;
        }

        public Sueldo ObtenerSueldo(long id, DateTime fecha)  //ACA SE TIENE QUE PASAR FECHA COMO PARAMETRO  PORQUE LA PK TIENE TANTO SUELDO COMO FECHA
        {
            Sueldo sueldoResultado = null;
            //tiene que ver con el error. Falta agregar fecha COMO PARAMETRO
            var sentenciaSql = $"SELECT s.*, u.usuario FROM Sueldos s LEFT JOIN Usuarios u ON s.id_usuario = u.id_usuario WHERE s.id_usuario = {id} and s.fecha = '{fecha.ToString("yyyy-MM-dd")}'";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            if (tabla.Rows.Count == 1)
            {
                var row = tabla.Rows[0];
                var sueldoBD = new Sueldo();
                var usuario = new Usuario();
                var id_usuario = row["id_usuario"];
                usuario.Id = Convert.ToInt64(id_usuario.ToString());
                usuario.Nombre = row["usuario"].ToString();
                sueldoBD.Usuario = usuario;
                sueldoBD.Fecha = Convert.ToDateTime(row["fecha"].ToString());
                sueldoBD.Sueldo_bruto = Convert.ToDouble(row["sueldo_bruto"].ToString());
                return sueldoBD;

            }
            return sueldoResultado;
        }

        public void RegistrarSueldo(Sueldo s)
        {
            using (var tx = DBHelper.GetDBHelper().IniciarTransaccion())
            {
                try
                {
                    var sql = $"INSERT INTO Sueldos (id_usuario,fecha,sueldo_bruto) VALUES ({s.Usuario.Id},'{s.Fecha.ToString("yyyy-MM-dd")}',{s.Sueldo_bruto})";
                    DBHelper.GetDBHelper().EjecutarUpdateTransaccionSQL(sql);
                    long id_per = 0;
                    var sentencia = $"SELECT u.id_perfil FROM Usuarios u WHERE u.Id_usuario = {s.Usuario.Id}";
                    var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentencia);
                    if (tabla.Rows.Count == 1)
                    {
                        id_per = Convert.ToInt64(tabla.Rows[0]["id_perfil"].ToString());
                    }
                    var sentencia2 = "SELECT * FROM SueldoPerfilHistorico";
                    var tabla2 = DBHelper.GetDBHelper().ConsultaSQL(sentencia2);
                    var bandera = false;
                    foreach (DataRow fila in tabla2.Rows)
                    {
                        var id = Convert.ToInt64(fila["id_perfil"].ToString());
                        var fecha = Convert.ToDateTime(fila["fecha"].ToString());
                        DateTime fecha1 = new DateTime(fecha.Year, fecha.Month, fecha.Day);
                        DateTime fecha2 = new DateTime(s.Fecha.Year, s.Fecha.Month, s.Fecha.Day);
                        if (id == id_per && fecha1 == fecha2)
                        {
                            bandera = true;
                        }
                    }
                    if (bandera == false)
                    {
                        sql = $"INSERT INTO SueldoPerfilHistorico (id_perfil,fecha,sueldo) VALUES ({id_per},'{s.Fecha.ToString("yyyy-MM-dd")}', {s.Sueldo_bruto})";
                        DBHelper.GetDBHelper().EjecutarUpdateTransaccionSQL(sql);

                    }
                    //sql = $"INSERT INTO SueldoPerfilHistorico (id_perfil,fecha,sueldo) VALUES ({id_per},'{s.Fecha.ToString("yyyy-MM-dd")}', {s.Sueldo_bruto})";
                    //DBHelper.GetDBHelper().EjecutarUpdateTransaccionSQL(sql);
                    tx.Commit();
                }
                catch
                {
                    tx.Rollback();
                    throw new ApplicationException("No se ha podido registrar el sueldo.\n Verifique que el usuario y la fecha no coincidan a la hora de agregar un sueldo.");
                }
                finally
                {
                    DBHelper.GetDBHelper().CloseConnection();
                }
            }

            // var pru = s.Sueldo_bruto.ToString();
            //var array = pru.Split(',');
            //string var1 = array[0];
            //string var2 = array[1];
            //string resultado = var1 + "." + var2;
            //double res = double.Parse(resultado, CultureInfo.InvariantCulture);
            //var sentenciaSql = $"INSERT INTO Sueldos (id_usuario,fecha,sueldo_bruto) VALUES ({s.Id_usuario},'{s.Fecha.ToString("yyyy-MM-dd")}',{s.Sueldo_bruto})";
            //DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);


            //var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);
            //return filasAfectadas;

            //}
        }

        public void ActualizarSueldo(Sueldo s)
        {
            using (var tx = DBHelper.GetDBHelper().IniciarTransaccion())
            {
                try
                {
                    var sql = $"UPDATE Sueldos SET sueldo_bruto = {s.Sueldo_bruto} WHERE id_usuario = {s.Usuario.Id} AND fecha = '{s.Fecha.ToString("yyyy-MM-dd")}'";
                    DBHelper.GetDBHelper().EjecutarUpdateTransaccionSQL(sql);
                    long id_per = 0;
                    var sentencia = $"SELECT u.id_perfil FROM Usuarios u WHERE u.Id_usuario = {s.Usuario.Id}";
                    var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentencia);
                    if (tabla.Rows.Count == 1)
                    {
                        id_per = Convert.ToInt64(tabla.Rows[0]["id_perfil"].ToString());
                    }
                    var sentencia2 = "SELECT * FROM SueldoPerfilHistorico";
                    var tabla2 = DBHelper.GetDBHelper().ConsultaSQL(sentencia2);
                    var bandera = false;
                    foreach (DataRow fila in tabla2.Rows)
                    {
                        var id = Convert.ToInt64(fila["id_perfil"].ToString());
                        var fecha = Convert.ToDateTime(fila["fecha"].ToString());
                        DateTime fecha1 = new DateTime(fecha.Year, fecha.Month, fecha.Day);
                        DateTime fecha2 = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day);
                        if (id == id_per && fecha1 == fecha2)
                        {
                            bandera = true;
                        }
                    }
                    if (bandera == false)
                    {
                        sql = $"INSERT INTO SueldoPerfilHistorico (id_perfil,fecha,sueldo) VALUES ({id_per},'{DateTime.Today.ToString("yyyy-MM-dd")}', {s.Sueldo_bruto})";
                        DBHelper.GetDBHelper().EjecutarUpdateTransaccionSQL(sql);
                    }
                    //sql = $"INSERT INTO SueldoPerfilHistorico (id_perfil,fecha,sueldo) VALUES ({id_per},'{s.Fecha.ToString("yyyy-MM-dd")}', {s.Sueldo_bruto})";
                    //sql = $"INSERT INTO SueldoPerfilHistorico (id_perfil,fecha,sueldo) VALUES ({id_per},'{DateTime.Today.ToString("yyyy-MM-dd")}', {s.Sueldo_bruto})";
                    //DBHelper.GetDBHelper().EjecutarUpdateTransaccionSQL(sql);
                    tx.Commit();
                }
                catch
                {
                    tx.Rollback();
                    throw new ApplicationException("No se pudo modificar el sueldo.");
                }
                finally
                {
                    DBHelper.GetDBHelper().CloseConnection();
                }


            }

            //var sentenciaSql = $"UPDATE Sueldos SET sueldo_bruto = {s.Sueldo_bruto} WHERE id_usuario = {s.Id_usuario} AND fecha = '{s.Fecha.ToString("yyyy-MM-dd")}'"; 
            //var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);
            //return filasAfectadas;
        }
        public int DarBajaSueldo(Sueldo s)
        {
            var sentenciaSql = $"DELETE FROM Sueldos WHERE id_usuario = {s.Usuario.Id} and fecha = '{s.Fecha.ToString("yyyy-MM-dd")}'";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);
            return filasAfectadas;

        }

        public List<HistoricoSueldo> ObtenerHistoricoSueldos(long id)
        {
            long id_per = 0;
            var sentencia = $"SELECT u.id_perfil FROM Usuarios u WHERE u.Id_usuario = {id}";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentencia);
            if (tabla.Rows.Count == 1)
            {
                id_per = Convert.ToInt64(tabla.Rows[0]["id_perfil"].ToString());
            }
            var sentenciaSql = $"SELECT s.*, p.nombre FROM SueldoPerfilHistorico s LEFT JOIN Perfiles p ON s.id_perfil = p.id_perfil WHERE s.id_perfil = {id_per}";
            var tabla1 = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            var h_Sueldos = new List<HistoricoSueldo>();
            foreach (DataRow fila in tabla1.Rows)
            {
                var h = new HistoricoSueldo();
                var perfil = new Perfil();
                perfil.Id = Convert.ToInt64(fila["id_perfil"].ToString());
                perfil.Nombre = fila["nombre"].ToString();
                h.Perfil = perfil;
                h.Fecha = Convert.ToDateTime(fila["fecha"].ToString());
                h.Sueldo_bruto = Convert.ToDouble(fila["sueldo"].ToString());
                h_Sueldos.Add(h);
            }
            return h_Sueldos;
        }
    }
}
