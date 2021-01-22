using BTS_3k2_2020.LogicaDeNegocio;
using BTS_3k2_2020.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTS_3k2_2020.Pantallas.Sueldos
{
    public partial class FrmSueldos : Form
    {
        private SueldosServicio _sueldosServicio;
        private FrmConfirmarCredencial _frmCredencial;

        public FrmSueldos()
        {
            _sueldosServicio = new SueldosServicio();
            InitializeComponent();
        }

        private void FrmSueldos_Load(object sender, EventArgs e)
        {
            ConsultarSueldos();
        }

        public void ConsultarSueldos()
        {

            var sueldos = _sueldosServicio.ObtenerSueldos();
            CargarGrilla(sueldos);

            /*var id = Convert.ToInt64(TxtIdUsuario.Text);
            var fecha = DtpFecha.Value;
            var sueldo_bruto = Convert.ToDouble(TxtSueldo.Text);
            var sueldos = _sueldosServicio.ObtenerSueldos(id, fecha, sueldo_bruto);
            CargarGrilla(sueldos);*/

        }

        private void CargarGrilla(List<Sueldo> sueldos)
        {
            DgvSueldos.Rows.Clear();
            foreach (var sueldo in sueldos)
            {
                //sueldo.Sueldo_bruto
                var fila = new string[]{
                    sueldo.Usuario.Id.ToString(),
                    sueldo.Usuario.Nombre.ToString(),
                    sueldo.Fecha.ToString("dd/MM/yyyy"),
                    sueldo.Sueldo_bruto.ToString()
                };
                DgvSueldos.Rows.Add(fila);
            }
        }

  

        private void ConsultarSueldos(long id, string nombre, DateTime? fecha, double sueldo)
        {
            var s = _sueldosServicio.ObtenerSueldos(id, nombre, fecha, sueldo);
            CargarGrilla(s);
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            new FrmSueldoNuevo(this).Show();
            
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (DgvSueldos.SelectedRows.Count == 1)
            {
                var id = Convert.ToInt64(DgvSueldos.SelectedRows[0].Cells["Id_usuario"].Value.ToString());
                var fecha = Convert.ToDateTime(DgvSueldos.SelectedRows[0].Cells["Fecha"].Value);
                new FrmModificarSueldo(this, id, fecha).Show();
            }
            else
                MessageBox.Show("Debe seleccionar solo una fila");
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (DgvSueldos.SelectedRows.Count == 1)
            {
                
                var id = Convert.ToInt64(DgvSueldos.SelectedRows[0].Cells["Id_usuario"].Value.ToString());
                //var fecha = DgvSueldos.SelectedRows[0].Cells["Fecha"].Value.ToString();
                var fecha = Convert.ToDateTime(DgvSueldos.SelectedRows[0].Cells["Fecha"].Value.ToString());
                new FrmConfirmarCredencial(this, id, fecha).Show();
                //new FrmEliminarSueldo(this, id, fecha).Show();
            }
            else
                MessageBox.Show("Debe seleccionar solo una fila");
        }

        private void BtnVerDetalle_Click(object sender, EventArgs e)
        {
            if (DgvSueldos.SelectedRows.Count == 1)
            {
                var id = Convert.ToInt64(DgvSueldos.SelectedRows[0].Cells["Id_usuario"].Value.ToString());
                var fecha = Convert.ToDateTime(DgvSueldos.SelectedRows[0].Cells["Fecha"].Value.ToString());
                new FrmVerDetalleSueldo(this, id, fecha).Show();
                //this.Hide();
            }
            else
            {
                MessageBox.Show("Debe seleccionar solo una fila");
            }
        }

        private void SalirFrmListadoUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarSueldo_Click(object sender, EventArgs e)
        {
            long id_usuarioIngresada = 0;
            double sueldo_brutoIngresado = 0;
            string nombreIngresado = null;
            //DateTime? fechaIngresada = null;
            DateTime fechaMinima = new DateTime(1900, 01, 01);
            DateTime? fechaIngresada = fechaMinima;
            //DateTime? fechaIngresada = DateTime.MinValue;
            fechaIngresada = new DateTime(fechaIngresada.Value.Year, fechaIngresada.Value.Month, fechaIngresada.Value.Day);
            if (!String.IsNullOrEmpty(TxtId_Usuario.Text))
            {
                id_usuarioIngresada = Convert.ToInt64(TxtId_Usuario.Text);
            }
            if (!String.IsNullOrEmpty(TxtNombreUsuario.Text))
            {
                nombreIngresado = TxtNombreUsuario.Text;
            }
            //if (!String.IsNullOrEmpty(DtpFecha.Value.ToString("yyyy-MM-dd")))
            //  fechaIngresada = DtpFecha.Value;
            DateTime fechaIngresada1 = new DateTime(DtpFecha.Value.Year, DtpFecha.Value.Month, DtpFecha.Value.Day);
            if (fechaIngresada1 != fechaMinima)
            {
                fechaIngresada = DtpFecha.Value;
            }
            if (!String.IsNullOrEmpty(TxtSueldo.Text))
            {
                sueldo_brutoIngresado = Convert.ToDouble(TxtSueldo.Text);
            };
            ConsultarSueldos(id_usuarioIngresada, nombreIngresado, fechaIngresada, sueldo_brutoIngresado);
            //ConsultarSueldos();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.DgvSueldos.Rows.Clear();
            this.TxtNombreUsuario.Clear();
            this.TxtSueldo.Clear();
            this.TxtId_Usuario.Clear();
            this.DtpFecha.Value = DateTime.Today;
            ConsultarSueldos();
        }

        public void cargarGrilla(DataGridView grilla, DataTable tabla)
        {
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grilla.Rows.Add(tabla.Rows[i]["id_usuario"],
                    tabla.Rows[i]["usuario"],
                    tabla.Rows[i]["email"]);
            }
        }
    }
}
