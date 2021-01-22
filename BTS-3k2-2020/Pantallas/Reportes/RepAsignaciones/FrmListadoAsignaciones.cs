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

namespace BTS_3k2_2020.Pantallas.Reportes.RepAsignaciones
{
    public partial class FrmListadoAsignaciones : Form
    {
        private Informes _frmPrincipal;
        private ReportesRepositorio _reportesRepositorio;
        private Informes informes;

        public FrmListadoAsignaciones(Informes frmPrincipal)
        {
            _reportesRepositorio = new ReportesRepositorio();
            _frmPrincipal = frmPrincipal;
            InitializeComponent();
        }


        private void FrmListadoAsignaciones_Load(object sender, EventArgs e)
        {

            this.rwAsignaciones.RefreshReport();
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
        private void FrmListadoAsignaciones_MouseMove(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void cargarReporte()
        {

            var nomPar = " -";
            var monPar = " -";
            if (!string.IsNullOrEmpty(this.txtNombre.Text))
                nomPar = this.txtNombre.Text;
            if (!string.IsNullOrEmpty(this.txtMonto.Text))
                monPar = "Igual a " + this.txtMonto.Text + "$";
            var nombre = this.txtNombre.Text;
            var monto = this.txtMonto.Text;
            var tabla = _reportesRepositorio.recuperarAsignaciones(nombre, monto);
            
            var ds = new ReportDataSource("InformAsigDS", tabla);
            this.rwAsignaciones.LocalReport.DataSources.Clear();
            this.rwAsignaciones.LocalReport.DataSources.Add(ds);
            var pMonPar = new ReportParameter("Monto", monPar);
            var pNomPar = new ReportParameter("NombreAsig", nomPar);
            var pFechaFen = DateTime.Today.ToString("dd/MM/yyyy");
            var parametros = new List<ReportParameter>();
            parametros.Add(new ReportParameter("FechaGen", pFechaFen));
            parametros.Add(pMonPar);
            parametros.Add(pNomPar);
            rwAsignaciones.LocalReport.SetParameters(parametros);
            this.rwAsignaciones.RefreshReport();

        }

        private void SalirFrmDescuentos_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SalirFrmDescuentos_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
