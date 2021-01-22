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
    public partial class FrmEliminarUsuarioXCurso1 : Form
    {
        private FrmUsuariosXCursos _frmUsuariosXCursos;
        private UsuarioXCurso _usuarioXcurso;
        private UsuariosXCursosServicio _usuariosXcursosServicio;
        public FrmEliminarUsuarioXCurso1(FrmUsuariosXCursos frmUsuariosXCursos, long id_usuario, long id_curso)
        {
            _frmUsuariosXCursos = frmUsuariosXCursos;
            _usuariosXcursosServicio = new UsuariosXCursosServicio();
            _usuarioXcurso = _usuariosXcursosServicio.ObtenerUsuarioXCurso(id_usuario, id_curso);
            InitializeComponent();
        }

        private void FrmEliminarUsuarioXCurso1_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            TxtNombreUsuario.Text = _usuarioXcurso.Usuario.Nombre.ToString();
            TxtNombreCurso.Text = _usuarioXcurso.Curso.Nombre.ToString();
            TxtPuntaje.Text = _usuarioXcurso.Puntuacion.ToString();
            TxtObservaciones.Text = _usuarioXcurso.Observaciones.ToString();
            DtpFechaInicio.Value = _usuarioXcurso.Fecha_Inicio;
            DtpFechaFin.Value = _usuarioXcurso.Fecha_Fin;
        }

        private void btnGuardarEliminarSueldo_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MessageBox.Show("Confirmar Operacion", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (resultado == DialogResult.Cancel)
                    return;
                DarBajaUsuarioXCurso();
                _frmUsuariosXCursos.ConsultarUsuariosXCursos();
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

        private void DarBajaUsuarioXCurso()
        {
            _usuariosXcursosServicio.DarBajaUsuarioXCurso(_usuarioXcurso);
            MessageBox.Show($"La operacion se realizo con exito.");
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            _frmUsuariosXCursos.Show();
            this.Dispose();
        }

        private void SalirFrmNuevoUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //METODO PARA ARRASTRAR EL FORMULARIO---------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void FrmEliminarUsuarioXCurso1_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

    }
}
