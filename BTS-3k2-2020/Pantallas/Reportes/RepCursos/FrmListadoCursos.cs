using BTS_3k2_2020.LogicaDeNegocio;
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
using System.Runtime.InteropServices;

namespace BTS_3k2_2020.Pantallas.Reportes.RepCursos
{
    public partial class FrmListadoCursos : Form
    {
        private ReportesRepositorio _reportesRepositorio;
        private CategoriaServicio _categoriaServicio;
        private Informes _frmPrincipal;
        private Informes informes;

        public FrmListadoCursos(Informes frmPrincipal)
        {
            _categoriaServicio = new CategoriaServicio();
            _reportesRepositorio = new ReportesRepositorio();
            _frmPrincipal = frmPrincipal;
            InitializeComponent();
        }
        private void FrmListadoCursos_Load(object sender, EventArgs e)
        {

            //CargarCursos();
            CargarCombo();
            this.rwCursos.RefreshReport();
            this.cbCateg.SelectedIndex = -1;
            cargarReporte();
            
        }
        private void CargarCursos()
        {
            var categorias = _categoriaServicio.ObtenerCategoria();
            var categoriaSeleccionada = categorias.First();
            var conector = new BindingSource();
            conector.DataSource = categorias;
            this.cbCateg.DataSource = conector;
            this.cbCateg.DisplayMember = "Nombre";
            this.cbCateg.ValueMember = "Id";
            this.cbCateg.SelectedItem = categoriaSeleccionada;
        }

        //METODO PARA ARRASTRAR EL FORMULARIO---------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void FrmListadoCursos_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void CargarCombo()
        {

            string consulta = "SELECT id_categoria,nombre FROM Categorias ";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(consulta);
            cbCateg.DataSource = tabla;
            cbCateg.ValueMember = "id_categoria";
            cbCateg.DisplayMember = "nombre";

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
            var categ = " -";
            var cat = -1;
            if (cbCateg.SelectedIndex > -1)
            {
                categ = this.cbCateg.Text;
                cat = Convert.ToInt32(this.cbCateg.SelectedValue.ToString());
            }
                
            var nombreCur = this.txtNombre.Text;
            
            var borrado = 0;
            if (this.ChkIncluirInactivos.Checked)
                borrado = 1;
            var tabla = _reportesRepositorio.RecuperarCursos(nombreCur, cat, borrado);
            
            var ds = new ReportDataSource("InformCursosDS", tabla);
            this.rwCursos.LocalReport.DataSources.Clear();
            this.rwCursos.LocalReport.DataSources.Add(ds);
            
            var pFechaFen = DateTime.Today.ToString("dd/MM/yyyy");
            var pInac = new ReportParameter("Inactivos", inac);
            var pCateg = new ReportParameter("NomCateg", categ);
            var parametros = new List<ReportParameter>();
            
            parametros.Add(new ReportParameter("FechaGen", pFechaFen));
            parametros.Add(pCateg);
            parametros.Add(pInac);
            rwCursos.LocalReport.SetParameters(parametros);
            this.rwCursos.RefreshReport();
        }

        private void SalirFrmDescuentos_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
