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

namespace BTS_3k2_2020.Pantallas.Reportes.RepPerfiles
{
    public partial class FrmListadoPerfiles : Form
    {
        private Informes _frmPrincipal;
        private ReportesRepositorio _reportesRepositorio;
        private Informes informes;

        public FrmListadoPerfiles(Informes frmPrincipal)
        {
            _reportesRepositorio = new ReportesRepositorio();
            _frmPrincipal = frmPrincipal;
            InitializeComponent();
            this.informes = informes;
        }
        private void FrmListadoPerfiles_Load(object sender, EventArgs e)
        {

            this.rwPerfiles.RefreshReport();
            cargarReporte();
        }

        //METODO PARA ARRASTRAR EL FORMULARIO---------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void FrmListadoPerfiles_MouseMove(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void btnConsultar_Click(object sender, EventArgs e)
        {
            cargarReporte();
        }

        private void cargarReporte()
        {
            var nombre = this.txtNombre.Text;
            var borrado = 0;
            if (this.ChkIncluirInactivos.Checked)
                borrado = 1;
            var tabla = _reportesRepositorio.RecuperarPerfiles(nombre, borrado);

            var ds = new ReportDataSource("InformPerfilesDS", tabla);
            this.rwPerfiles.LocalReport.DataSources.Clear();
            this.rwPerfiles.LocalReport.DataSources.Add(ds);
            var perfil = " -";
            if (!string.IsNullOrEmpty(this.txtNombre.Text))
                perfil = this.txtNombre.Text;
            var pPerfil = new ReportParameter("NomPerfil", perfil);
            var pFechaFen = DateTime.Today.ToString("dd/MM/yyyy");
            var parametros = new List<ReportParameter>();
            parametros.Add(pPerfil);
            parametros.Add(new ReportParameter("FechaGen", pFechaFen));
            rwPerfiles.LocalReport.SetParameters(parametros);
            this.rwPerfiles.RefreshReport();
        }

        private void SalirFrmDescuentos_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmListadoPerfiles_MouseUp(object sender, MouseEventArgs e)
        {

        }


    }
}
