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

namespace BTS_3k2_2020.Pantallas.Reportes.EstCategorias
{
    public partial class FrmEstCategorias : Form
    {
        private Informes _frmBotones;
        private ReportesRepositorio _reportesRepositorio;
        private Informes informes;

        public FrmEstCategorias(Informes frmBotones)
        {
            _reportesRepositorio = new ReportesRepositorio();
            _frmBotones = frmBotones;
            InitializeComponent();
        }

        private void FrmEstCategorias_Load(object sender, EventArgs e)
        {
            
            this.rwEstCateg.RefreshReport();
            cargarReporte();
        }

        private void cargarReporte()
        {
            var inac = " No";
            if (this.ChkIncluirInactivos.Checked)
                inac = " Si";

            var ban = 0;
            if (this.ChkIncluirInactivos.Checked)
                ban = 1;

            DataTable tabla = new DataTable();
            tabla = _reportesRepositorio.recuperarEstCategorias(ban);

            var ds = new ReportDataSource("GrafCategDS", tabla);
            this.rwEstCateg.LocalReport.DataSources.Clear();
            this.rwEstCateg.LocalReport.DataSources.Add(ds);
            var pInac = new ReportParameter("Inactivos", inac);
            var parametros = new List<ReportParameter>();
            var pFechaGen = new ReportParameter("FechaGen", DateTime.Today.ToString("dd/MM/yyyy"));
            parametros.Add(pInac);
            parametros.Add(pFechaGen);
            
            rwEstCateg.LocalReport.SetParameters(parametros);
            this.rwEstCateg.RefreshReport();

        }

        private void FrmEstCategorias_FormClosing(object sender, FormClosingEventArgs e)
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
