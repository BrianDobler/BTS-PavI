using BTS_3k2_2020.Servicios;
using BTS_3k2_2020.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BTS_3k2_2020.RespositoriosDAO;
using Microsoft.Reporting.WinForms;
using System.Runtime.InteropServices;

namespace BTS_3k2_2020.Pantallas.Reportes.RepUsuarios
{
    
    public partial class FrmListadoUsuarios : Form
    {
        
        private ReportesRepositorio _reportesRepositorio;
        private Informes _frmPrincipal;
        private Informes informes;

        public FrmListadoUsuarios(Informes frmPrincipal)
        {
            _reportesRepositorio = new ReportesRepositorio();
            _frmPrincipal = frmPrincipal;
            InitializeComponent();
        }

        private void FrmListadoUsuarios_Load(object sender, EventArgs e)
        {
           
            CargarCombo();
            this.rwUsuarios.RefreshReport();
            TipoPerfil.SelectedIndex = -1;
            cargarReporte();
        }

        private void CargarCombo()
        {
            
            string consulta = "SELECT id_perfil,nombre FROM Perfiles ";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(consulta);
            TipoPerfil.DataSource = tabla;
            TipoPerfil.ValueMember = "id_perfil";
            TipoPerfil.DisplayMember = "nombre";

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            cargarReporte();
        }

        private void cargarReporte()
        {
            
            var idPerfil = -1;
            var nombre = this.TxtNombre.Text;
            if(TipoPerfil.SelectedIndex >-1)
                idPerfil = Convert.ToInt32(this.TipoPerfil.SelectedValue.ToString());
            var borrado = 0;
            if (this.ChkIncluirInactivos.Checked)
                borrado = 1;
            var tabla = _reportesRepositorio.RecuperarUsuarios(nombre, idPerfil, borrado);

            var ds = new ReportDataSource("InformUsuariosDS", tabla);
            this.rwUsuarios.LocalReport.DataSources.Clear();
            this.rwUsuarios.LocalReport.DataSources.Add(ds);
            var perfilUsu = " -";
            if(TipoPerfil.SelectedIndex!=-1)
                perfilUsu = this.TipoPerfil.Text;
            
            
            var pPerfilUsu = new ReportParameter("PerfilUsu", perfilUsu);
            var pFechaFen = DateTime.Today.ToString("dd/MM/yyyy");
            var parametros = new List<ReportParameter>();
            
            parametros.Add(new ReportParameter("FechaGen", pFechaFen));
            parametros.Add(pPerfilUsu);
            
            
            rwUsuarios.LocalReport.SetParameters(parametros);
            this.rwUsuarios.RefreshReport();
        }

        private void SalirFrmDescuentos_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //METODO PARA ARRASTRAR EL FORMULARIO---------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void FrmListadoUsuarios_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

    }
}
