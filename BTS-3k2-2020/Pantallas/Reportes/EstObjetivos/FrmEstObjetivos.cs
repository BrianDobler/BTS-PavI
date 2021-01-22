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

namespace BTS_3k2_2020.Pantallas.Reportes.EstObjetivos
{
    public partial class FrmEstObjetivos : Form
    {
        private ReportesRepositorio _reportesRepositorio;
        private Informes _frmBotones;
        private Informes informes;

        public FrmEstObjetivos(Informes frmBotones)
        {
            _reportesRepositorio = new ReportesRepositorio();
            _frmBotones = frmBotones;
            InitializeComponent();
        }

        private void FrmEstObjetivos_Load(object sender, EventArgs e)
        {

            this.rwEstObj.RefreshReport();
            cargarReporte();
        }

        private void cargarReporte()
        {
            DataTable tabla = new DataTable();
            tabla = _reportesRepositorio.RecuperarEstObjetivos();

            var ds = new ReportDataSource("GrafObjDS", tabla);
            this.rwEstObj.LocalReport.DataSources.Clear();
            this.rwEstObj.LocalReport.DataSources.Add(ds);
            var parametros = new List<ReportParameter>();
            var pFechaGen = new ReportParameter("FechaGen", DateTime.Today.ToString("dd/MM/yyyy"));

            parametros.Add(pFechaGen);

            rwEstObj.LocalReport.SetParameters(parametros);
            this.rwEstObj.RefreshReport();

        }

        //METODO PARA ARRASTRAR EL FORMULARIO---------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void FrmEstObjetivos_MouseMove(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
       

        private void FrmEstObjetivos_FormClosing(object sender, FormClosingEventArgs e)
        {
            this._frmBotones.Show();
        }

        private void SalirFrmDescuentos_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
