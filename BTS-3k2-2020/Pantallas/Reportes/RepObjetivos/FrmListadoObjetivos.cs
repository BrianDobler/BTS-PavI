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

namespace BTS_3k2_2020.Pantallas.Reportes.RepObjetivos
{
    public partial class FrmListadoObjetivos : Form
    {
        private Informes _frmPrincipal;
        private ReportesRepositorio _reportesRepositorio;
        private Informes informes;

        public FrmListadoObjetivos(Informes frmPrincipal)
        {
            _reportesRepositorio = new ReportesRepositorio();
            _frmPrincipal = frmPrincipal;
            this.informes = informes;
            InitializeComponent();
        }

        private void FrmListadoObjetivos_Load(object sender, EventArgs e)
        {

            this.rwObjetivos.RefreshReport();
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
        private void FrmListadoObjetivos_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void cargarReporte()
        {
            var inac = " No";
            if (this.ChkIncluirInactivos.Checked)
                inac = " Si";
            var nombreC = this.txtNombreCorto.Text;
            var nombreL = this.txtNombreLargo.Text;
            var borrado = 0;
            if (this.ChkIncluirInactivos.Checked)
                borrado = 1;
            var tabla = _reportesRepositorio.RecuperarObjetivos(nombreC, nombreL, borrado);

            var ds = new ReportDataSource("InformObjDS", tabla);
            this.rwObjetivos.LocalReport.DataSources.Clear();
            this.rwObjetivos.LocalReport.DataSources.Add(ds);
            var pInac = new ReportParameter("Inactivos", inac);
            var pFechaFen = DateTime.Today.ToString("dd/MM/yyyy");
            var parametros = new List<ReportParameter>();
            parametros.Add(new ReportParameter("FechaGen", pFechaFen));
            parametros.Add(pInac);
            rwObjetivos.LocalReport.SetParameters(parametros);
            this.rwObjetivos.RefreshReport();
        }

        private void SalirFrmDescuentos_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
