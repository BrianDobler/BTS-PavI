using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTS_3k2_2020.RespositoriosDAO;
using Microsoft.Reporting.WinForms;

namespace BTS_3k2_2020.Pantallas.Reportes.RepSueldos
{
    public partial class FrmListadoSueldos : Form
    {
        private ReportesRepositorio _reportesRepositorio;
        private Informes _frmPrincipal;
        private Informes informes;

        public FrmListadoSueldos(Informes frmPrincipal)
        {
            _reportesRepositorio = new ReportesRepositorio();
            _frmPrincipal = frmPrincipal;
            InitializeComponent();
        }
        private void FrmListadoSueldos_Load(object sender, EventArgs e)
        {

            this.rwSueldos.RefreshReport();
            cargarReporte();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            cargarReporte();
        }
        //METODO PARA ARRASTRAR EL FORMULARIO---------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void FrmListadoSueldos_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void cargarReporte()
        {
            var band = 0;
            if (this.DtpFecha.Enabled)
                band = 1;
            var nombre = this.TxtNombreUsuario.Text;
            var sueldo = this.TxtSueldo.Text;
            var fecha = this.DtpFecha.Value;
            var tabla = _reportesRepositorio.RecuperarSueldos(nombre, fecha, sueldo,band);

            var ds = new ReportDataSource("InformSueldosDS", tabla);
            this.rwSueldos.LocalReport.DataSources.Clear();
            this.rwSueldos.LocalReport.DataSources.Add(ds);
            var fechaDesde = " -";
            if (this.DtpFecha.Enabled)
                fechaDesde = this.DtpFecha.Value.ToString("dd/MM/yyyy");
            var pFechaFen = DateTime.Today.ToString("dd/MM/yyyy");
            var pFechaDesde = new ReportParameter("FechaDesde", fechaDesde);
            var parametros = new List<ReportParameter>();
            parametros.Add(new ReportParameter("FechaGen", pFechaFen));
            parametros.Add(pFechaDesde);
            rwSueldos.LocalReport.SetParameters(parametros);
            this.rwSueldos.RefreshReport();
        }

        private void chbFiltrar_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chbFiltrar.Checked)
            {
                this.DtpFecha.Enabled = true;
            }
            else
                this.DtpFecha.Enabled = false;
        }

        private void SalirFrmDescuentos_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
