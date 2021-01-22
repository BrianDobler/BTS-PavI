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

namespace BTS_3k2_2020.Pantallas.UsuariosXCursos
{
    public partial class FrmModificarUsuarioXCurso : Form
    {
        private FrmUsuariosXCursos _frmUsuariosXCursos;
        private UsuarioXCurso _usuarioXcurso;
        private UsuariosXCursosServicio _usuariosXcursosServicio;
        public FrmModificarUsuarioXCurso(FrmUsuariosXCursos frmUsuariosXCursos, long id_usuario, long id_curso)
        {
            _frmUsuariosXCursos = frmUsuariosXCursos;
            _usuariosXcursosServicio = new UsuariosXCursosServicio();
            _usuarioXcurso = _usuariosXcursosServicio.ObtenerUsuarioXCurso(id_usuario, id_curso);
            InitializeComponent();
        }

        private void FrmModificarUsuarioXCurso_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
        private void CargarDatos()
        {
            TxtIdUsuario.Text = _usuarioXcurso.Usuario.Id.ToString();
            TxtNombreUsuario.Text = _usuarioXcurso.Usuario.Nombre.ToString();
            TxtIdCurso.Text = _usuarioXcurso.Curso.Id.ToString();
            TxtNombreCurso.Text = _usuarioXcurso.Curso.Nombre.ToString();
            TxtPuntaje.Text = _usuarioXcurso.Puntuacion.ToString();
            TxtObservaciones.Text = _usuarioXcurso.Observaciones.ToString();

        }

        private void btnGuardarModDesc_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MessageBox.Show("Confirmar Operacion", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (resultado == DialogResult.Cancel)
                    return;
                ValidarUsuarioXCurso();
                RegistrarUsuarioXCurso();
                //CerrarFormulario();
                _frmUsuariosXCursos.ConsultarUsuariosXCursos();
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
        private void FrmModificarUsuarioXCurso_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
     
        private void ValidarUsuarioXCurso()
        {

            _usuarioXcurso.Observaciones = " ";
            if (!String.IsNullOrEmpty(TxtObservaciones.Text.ToString()))
            {
                _usuarioXcurso.Observaciones = TxtObservaciones.Text.ToString();
            }
            _usuarioXcurso.Puntuacion = 0;
            if (!String.IsNullOrEmpty(TxtPuntaje.Text.ToString()))
            {
                _usuarioXcurso.Puntuacion = Convert.ToInt32(TxtPuntaje.Text.ToString());
            }
            //var fechaInicio = DtpFechaInicio.Value;
            //var fechaFin = DtpFechaFin.Value;
            _usuarioXcurso = _usuariosXcursosServicio.ValidarUsuarioXCurso(_usuarioXcurso);
        }

        private void RegistrarUsuarioXCurso()
        {
            _usuariosXcursosServicio.ActualizarUsuarioXCurso(_usuarioXcurso);
            MessageBox.Show($"La operacion se realizo con exito.");
        }

        /*private void CerrarFormulario()
        {
            _frmUsuariosXCursos.Show();
            _frmUsuariosXCursos.ConsultarUsuariosXCursos();
            this.Dispose();
        }*/

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            //CerrarFormulario();
        }

        private void SalirFrmListadoUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
