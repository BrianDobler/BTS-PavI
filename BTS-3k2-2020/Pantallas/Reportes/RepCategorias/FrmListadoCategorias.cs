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

namespace BTS_3k2_2020.Pantallas.Reportes.RepCategorias
{
    public partial class FrmListadoCategorias : Form
    {
        private Informes _frmPrincipal;
        private ReportesRepositorio _reportesRepositorio;
        private Informes informes;

        public FrmListadoCategorias(Informes frmPrincipal)
        {
            _reportesRepositorio = new ReportesRepositorio();
            _frmPrincipal = frmPrincipal;
            InitializeComponent();
        }


        private void FrmListadoCategorias_Load(object sender, EventArgs e)
        {

            this.rwCategorias.RefreshReport();
            cargarReporte();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            cargarReporte();
        }

        private void cargarReporte()
        {
            var inac = " No";
            if (this.ChkIncluirInactivos.Checked)
                inac = " Si";
            var borrado = 0;

            if (this.ChkIncluirInactivos.Checked)
                borrado = 1;

            var nombre = this.txtNombre.Text;
            var tabla = _reportesRepositorio.recuperarCategorias(nombre, borrado);

            var ds = new ReportDataSource("InformCategDS", tabla);
            this.rwCategorias.LocalReport.DataSources.Clear();
            this.rwCategorias.LocalReport.DataSources.Add(ds);
            var pInac = new ReportParameter("Inactivos", inac);
            var pFechaFen = DateTime.Today.ToString("dd/MM/yyyy");
            var parametros = new List<ReportParameter>();
            parametros.Add(new ReportParameter("FechaGen", pFechaFen));
            parametros.Add(pInac);
            rwCategorias.LocalReport.SetParameters(parametros);
            this.rwCategorias.RefreshReport();
        }

        //METODO PARA ARRASTRAR EL FORMULARIO---------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void FrmListadoCategorias_MouseMove(object sender, MouseEventArgs e)
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
