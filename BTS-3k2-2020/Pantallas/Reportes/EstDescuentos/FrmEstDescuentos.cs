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

namespace BTS_3k2_2020.Pantallas.Reportes.EstDescuentos
{
    public partial class FrmEstDescuentos : Form
    {
        private Informes _frmBotones;
        private ReportesRepositorio _reportesRepositorio;
        private Informes informes;

        public FrmEstDescuentos(Informes frmBotones)
        {
            _reportesRepositorio = new ReportesRepositorio();
            _frmBotones = frmBotones;
            InitializeComponent();
        }

        private void FrmEstDescuentos_Load(object sender, EventArgs e)
        {

            this.rwEstDescuentos.RefreshReport();
            cargarReporte();
        }

        private void cargarReporte()
        {
            DataTable tabla = new DataTable();
            var monto = " -";
            if (this.rbMayor.Checked)
            {
                tabla.Clear();
                tabla = _reportesRepositorio.recuperarEstDescuentoMayor(this.txtMonto.Text);
                if (!string.IsNullOrEmpty(this.txtMonto.Text))
                    monto = " Mayor a " + this.txtMonto.Text + "$";
            }
            else
            {
                tabla.Clear();
                tabla = _reportesRepositorio.recuperarEstDescuentoMenor(this.txtMonto.Text);
                if (!string.IsNullOrEmpty(this.txtMonto.Text))
                    monto = " Menor a " + this.txtMonto.Text + "$";
            }

            var ds = new ReportDataSource("GrafDescDS", tabla);
            this.rwEstDescuentos.LocalReport.DataSources.Clear();
            this.rwEstDescuentos.LocalReport.DataSources.Add(ds);
            var parametros = new List<ReportParameter>();
            var pFechaGen = new ReportParameter("FechaGen", DateTime.Today.ToString("dd/MM/yyyy"));
            var pMonto = new ReportParameter("MontoDesc", monto);

            parametros.Add(pFechaGen);
            parametros.Add(pMonto);
            rwEstDescuentos.LocalReport.SetParameters(parametros);
            this.rwEstDescuentos.RefreshReport();

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            cargarReporte();
        }

        private void FrmEstDescuentos_FormClosing(object sender, FormClosingEventArgs e)
        {
            this._frmBotones.Show();
        }

        //METODO PARA ARRASTRAR EL FORMULARIO---------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void FrmEstDescuentos_MouseMove(object sender, MouseEventArgs e)
        {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
            
        

        private void SalirFrmDescuentos_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
