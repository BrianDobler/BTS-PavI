using BTS_3k2_2020.LogicaDeNegocio;
using BTS_3k2_2020.Modelos;
using BTS_3k2_2020.Servicios;
using BTS_3k2_2020.Utils;
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
    public partial class FrmModificarSueldo : Form
    {
        private Sueldo _sueldo;
        private UsuarioServicio _usuariosServicio;
        private SueldosServicio _sueldoServicio;
        private FrmSueldos _frmSueldos;
        public FrmModificarSueldo(FrmSueldos frmSueldos, long id, DateTime fecha)
        {
            _sueldoServicio = new SueldosServicio();
            _usuariosServicio = new UsuarioServicio();
            _frmSueldos = frmSueldos;
            _sueldo = _sueldoServicio.ObtenerSueldo(id, fecha);
            InitializeComponent();
        }

        private void FrmModificarSueldo_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
            CargarDatos();
        }

        private void CargarDatos()
        {
            TxtId_usuario.Text = _sueldo.Usuario.Id.ToString();
            //TxtNombreUsuario.Text = _sueldo.Nombre_usuario;
            DtpFecha.Value = _sueldo.Fecha;
            TxtSueldo_bruto.Text = _sueldo.Sueldo_bruto.ToString();
        }

        private void CargarUsuarios()
        {
            var usuarios = _usuariosServicio.ObtenerUsuarios();
            var conector = new BindingSource();
            conector.DataSource = usuarios;
            FormUtils.CargarCombo(ref CbUsuarios, conector, "Nombre", "Id");
            var seleccionado = usuarios.First(u => u.Id == _sueldo.Usuario.Id);
            CbUsuarios.SelectedItem = seleccionado;

        }

        /*private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MessageBox.Show("Confirmar Operacion", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (resultado == DialogResult.Cancel)
                    return;
                ValidarSueldo();
                RegistrarSueldo();
                CerrarFormulario();
            }

            catch (ApplicationException aex)
            {
                MessageBox.Show(aex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Ha occurrido un problema.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }*/

        private void ValidarSueldo()
        {
            //_sueldo.Id_usuario = Convert.ToInt64(TxtId_usuario.Text);
            //var sueldo = new Sueldo();
            var _usuario = (Usuario)CbUsuarios.SelectedItem;
            _sueldo.Usuario = _usuario;
            _sueldo.Fecha = DtpFecha.Value;
            _sueldo.Sueldo_bruto = null;
            if (!String.IsNullOrEmpty(TxtSueldo_bruto.Text.ToString()))
                _sueldo.Sueldo_bruto = Convert.ToDouble(TxtSueldo_bruto.Text);
            _sueldo = _sueldoServicio.ValidarSueldo(_sueldo);
        }

        private void RegistrarSueldo()
        {
            _sueldoServicio.ActualizarSueldo(_sueldo);
            MessageBox.Show($"La operacion se realizo con exito.");
        }

        /*private void CerrarFormulario()
        {
            _frmSueldos.Show();
            _frmSueldos.ConsultarSueldos();
            this.Dispose();
        }*/
        private void SalirFrmNuevoUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardarModDesc_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardarModSueldo_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MessageBox.Show("Confirmar Operacion", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (resultado == DialogResult.Cancel)
                    return;
                ValidarSueldo();
                RegistrarSueldo();
                _frmSueldos.ConsultarSueldos();
                //CerrarFormulario();
            }

            catch (ApplicationException aex)
            {
                MessageBox.Show(aex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Ha occurrido un problema.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //METODO PARA ARRASTRAR EL FORMULARIO---------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void FrmModificarSueldo_MouseMove(object sender, MouseEventArgs e)
        {

                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);


        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void CbUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LblNombreUsuario_Click(object sender, EventArgs e)
        {

        }

        private void DtpFecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TxtSueldo_bruto_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtId_usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblSueldo_bruto_Click(object sender, EventArgs e)
        {

        }

        private void LblFecha_Click(object sender, EventArgs e)
        {

        }

        private void LblId_usuario_Click(object sender, EventArgs e)
        {

        }
    }
}
