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


namespace BTS_3k2_2020.Pantallas.Reportes.EstAsignaciones
{
    public partial class FrmEstAsignaciones : Form
    {
        private ReportesRepositorio _reportesRepositorio;
        private Informes _frmBotones;
        private Informes informes;

        public FrmEstAsignaciones(Informes frmBotones)
        {
            _reportesRepositorio = new ReportesRepositorio();
            _frmBotones = frmBotones;
            InitializeComponent();
        }

        private void FrmEstAsignaciones_Load(object sender, EventArgs e)
        {

            this.rwEstAsig.RefreshReport();
            cargarReporte();
        }

        //METODO PARA ARRASTRAR EL FORMULARIO---------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void FrmEstAsignaciones_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void cargarReporte()
        {
            DataTable tabla = new DataTable();
            var monto = " -";
            if (this.rbMayor.Checked)
            {
                tabla.Clear();
                tabla = _reportesRepositorio.recuperarEstAsignacionMayor(this.txtMonto.Text);
                if (!string.IsNullOrEmpty(this.txtMonto.Text))
                    monto = " Mayor a " + this.txtMonto.Text + "$";
            }                
            else
            {
                tabla.Clear();
                tabla = _reportesRepositorio.recuperarEstAsignacionMenor(this.txtMonto.Text);
                if (!string.IsNullOrEmpty(this.txtMonto.Text))
                    monto = " Menor a " + this.txtMonto.Text + "$";
            }

            var ds = new ReportDataSource("GrafAsigDS", tabla);
            this.rwEstAsig.LocalReport.DataSources.Clear();
            this.rwEstAsig.LocalReport.DataSources.Add(ds);
            var parametros = new List<ReportParameter>();
            var pFechaGen = new ReportParameter("FechaGen",DateTime.Today.ToString("dd/MM/yyyy"));
            var pMonto = new ReportParameter("MontoAsig", monto);
            
            parametros.Add(pFechaGen);
            parametros.Add(pMonto);
            rwEstAsig.LocalReport.SetParameters(parametros);
            this.rwEstAsig.RefreshReport();

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            cargarReporte();
        }

        private void FrmEstAsignaciones_FormClosing(object sender, FormClosingEventArgs e)
        {
            this._frmBotones.Show();
        }

        private void txtMonto_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void SalirFrmDescuentos_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
