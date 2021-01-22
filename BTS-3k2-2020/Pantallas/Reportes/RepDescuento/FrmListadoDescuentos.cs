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

namespace BTS_3k2_2020.Pantallas.Reportes.RepDescuento
{
    public partial class FrmListadoDescuentos : Form
    {
        private Informes _frmPrincipal;
        private ReportesRepositorio _reportesRepositorio;
        private Informes informes;

        public FrmListadoDescuentos(Informes frmPrincipal)
        {
            _reportesRepositorio = new ReportesRepositorio();
            _frmPrincipal = frmPrincipal;
            InitializeComponent();
        }
        private void FrmListadoDescuentos_Load(object sender, EventArgs e)
        {
            this.rwDescuentos.RefreshReport();
            CargarReporte();

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            CargarReporte();
            
        }

        //METODO PARA ARRASTRAR EL FORMULARIO---------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void FrmListadoDescuentos_MouseMove(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void CargarReporte()
        {
            var nomPar = " -";
            var monPar = " -";
            if (!string.IsNullOrEmpty(this.txtNombre.Text))
                nomPar = this.txtNombre.Text;
            if (!string.IsNullOrEmpty(this.txtMonto.Text))
                monPar = "Igual a " + this.txtMonto.Text + "$";

            var nombre = this.txtNombre.Text;
            var monto = this.txtMonto.Text;
            var tabla = _reportesRepositorio.recuperarDescuentos(nombre, monto);

            var ds = new ReportDataSource("InformDescDS", tabla);
            this.rwDescuentos.LocalReport.DataSources.Clear();
            this.rwDescuentos.LocalReport.DataSources.Add(ds);
            var pMonPar = new ReportParameter("Monto", monPar);
            var pNomPar = new ReportParameter("NombreDesc", nomPar);
            var pFechaFen = DateTime.Today.ToString("dd/MM/yyyy");
            var parametros = new List<ReportParameter>();
            parametros.Add(new ReportParameter("FechaGen", pFechaFen));
            parametros.Add(pMonPar);
            parametros.Add(pNomPar);
            rwDescuentos.LocalReport.SetParameters(parametros);
            this.rwDescuentos.RefreshReport();
        }

        private void SalirFrmDescuentos_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
