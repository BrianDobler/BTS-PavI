using BTS_3k2_2020.LogicaDeNegocio;
using BTS_3k2_2020.Modelos;
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

namespace BTS_3k2_2020.Pantallas.Sueldos
{
    public partial class FrmVerDetalleSueldo : Form
    {
        private FrmSueldos _frmSueldos;
        private Sueldo _sueldo;
        private SueldosServicio _sueldosServicio;
        private List<HistoricoSueldo> h_sueldo;
        public FrmVerDetalleSueldo(FrmSueldos frmSueldos, long id, DateTime fecha)
        {
            _sueldosServicio = new SueldosServicio();
            _frmSueldos = frmSueldos;
            _sueldo = _sueldosServicio.ObtenerSueldo(id, fecha);
            h_sueldo = _sueldosServicio.ObtenerHistoricoSueldos(id);
            InitializeComponent();
        }

        private void FrmVerDetalleSueldo_Load(object sender, EventArgs e)
        {
            CargarDatos();
            CargarGrilla();
        }

        private void CargarDatos()
        {
            TxtId_usuario.Text = _sueldo.Usuario.Id.ToString();
            TxtNombre.Text = _sueldo.Usuario.Nombre;
            TxtFecha.Text = _sueldo.Fecha.ToString("dd/MM/yyyy");
            TxtSueldo_bruto.Text = _sueldo.Sueldo_bruto.ToString();
        }

        private void CargarGrilla()
        {
            DgvHistoricos.Rows.Clear();
            foreach (var historico in h_sueldo)
            {
                var fila = new string[]{
                    historico.Perfil.Id.ToString(),
                    historico.Perfil.Nombre,
                    historico.Fecha.ToString("dd/MM/yyyy"),
                    historico.Sueldo_bruto.ToString()
                };
                DgvHistoricos.Rows.Add(fila);
            }
        }

        private void CerrarFormulario()
        {
        //    _frmSueldos.Show();
            //_frmSueldos.ConsultarSueldos();
           // this.Dispose();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
           // CerrarFormulario();
        }

        private void BtnSalir_Click_1(object sender, EventArgs e)
        {
            //CerrarFormulario();
        }
        //METODO PARA ARRASTRAR EL FORMULARIO---------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void FrmVerDetalleSueldo_MouseMove(object sender, MouseEventArgs e)
        {

                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
        

        }

        private void SalirFrmModificarDescuentos_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
