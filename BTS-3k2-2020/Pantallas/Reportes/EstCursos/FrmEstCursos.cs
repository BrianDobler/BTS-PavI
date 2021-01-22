using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTS_3k2_2020.RespositoriosDAO;
using Microsoft.Reporting.WinForms;

namespace BTS_3k2_2020.Pantallas.Reportes.EstCursos
{
    public partial class FrmEstCursos : Form
    {
        
        private Informes _frmBotones;
        private ReportesRepositorio _reportesRepositorio;
        private Informes informes;

        public FrmEstCursos(Informes frmBotones)
        {
            _reportesRepositorio = new ReportesRepositorio();
            _frmBotones = frmBotones;
            InitializeComponent();
        }

        private void FrmEstCursos_Load(object sender, EventArgs e)
        {

            this.rwEstCursos.RefreshReport();
            cargarReporte();
        }

        private void cargarReporte()
        {
            DataTable tabla = new DataTable();
            var inac = " No";
            if (this.ChkIncluirInactivos.Checked)
                inac = " Si";
            var ban = 0;
            if (this.ChkIncluirInactivos.Checked)
                ban = 1;
            tabla = _reportesRepositorio.RecuperarEstCursos(ban);

            var ds = new ReportDataSource("GrafCursosDS", tabla);
            this.rwEstCursos.LocalReport.DataSources.Clear();
            this.rwEstCursos.LocalReport.DataSources.Add(ds);
            var parametros = new List<ReportParameter>();
            var pInac = new ReportParameter("Inactivos", inac);
            var pFechaGen = new ReportParameter("FechaGen", DateTime.Today.ToString("dd/MM/yyyy"));

            parametros.Add(pFechaGen);
            parametros.Add(pInac);

            rwEstCursos.LocalReport.SetParameters(parametros);
            this.rwEstCursos.RefreshReport();

        }

        private void FrmEstCursos_FormClosing(object sender, FormClosingEventArgs e)
        {
            this._frmBotones.Show();
        }

        private void ChkIncluirInactivos_CheckedChanged(object sender, EventArgs e)
        {
            cargarReporte();
        }

        private void SalirFrmDescuentos_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
