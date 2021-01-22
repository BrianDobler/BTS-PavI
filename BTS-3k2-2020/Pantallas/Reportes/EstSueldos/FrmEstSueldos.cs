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

namespace BTS_3k2_2020.Pantallas.Reportes.EstSueldos
{
    public partial class FrmEstSueldos : Form
    {
        private ReportesRepositorio _reportesRepositorio;
        private Informes _frmBotones;
        private Informes informes;

        public FrmEstSueldos(Informes frmBotones)
        {
            _reportesRepositorio = new ReportesRepositorio();
            _frmBotones = frmBotones;
            InitializeComponent();
        }

        private void FrmEstSueldos_Load(object sender, EventArgs e)
        {

            this.rwEstSueldo.RefreshReport();
            cargarReporte();
        }

        //METODO PARA ARRASTRAR EL FORMULARIO---------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void FrmEstSueldos_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
 

        private void cargarReporte()
        {
            DataTable tabla = new DataTable();
            var band = 0;
            if (this.DtpFecha.Enabled)
                band = 1;
            tabla = _reportesRepositorio.RecuperarEstSueldos(this.DtpFecha.Value,band);

            var ds = new ReportDataSource("GrafSueldosDS", tabla);
            this.rwEstSueldo.LocalReport.DataSources.Clear();
            this.rwEstSueldo.LocalReport.DataSources.Add(ds);
            var parametros = new List<ReportParameter>();
            var fechaDesde = " -";
            if (this.DtpFecha.Enabled)
                fechaDesde = this.DtpFecha.Value.ToString("dd/MM/yyyy");
            var pFechaGen = new ReportParameter("FechaGen", DateTime.Today.ToString("dd/MM/yyyy"));
            var pFechaDesde = new ReportParameter("FechaDesde", fechaDesde);
            parametros.Add(pFechaGen);
            parametros.Add(pFechaDesde);
            rwEstSueldo.LocalReport.SetParameters(parametros);
            this.rwEstSueldo.RefreshReport();

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

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            cargarReporte();
        }

        private void FrmEstSueldos_FormClosing(object sender, FormClosingEventArgs e)
        {
            this._frmBotones.Show();
        }

        private void SalirFrmDescuentos_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
