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

namespace BTS_3k2_2020.Pantallas.UsuariosXCursos
{
    public partial class FrmNuevoUsuarioXCurso : Form
    {
        private UsuarioServicio _usuariosServicio;
        private UsuariosXCursosServicio _usuariosXcursosServicio;
        private UsuarioXCurso _usuarioXcurso;
        private FrmUsuariosXCursos _frmUsuariosXCursos;
        public FrmNuevoUsuarioXCurso(FrmUsuariosXCursos frmUsuariosXCursos)
        {
            _usuariosServicio = new UsuarioServicio();
            _usuariosXcursosServicio = new UsuariosXCursosServicio();
            _usuarioXcurso = new UsuarioXCurso();
            _frmUsuariosXCursos = frmUsuariosXCursos;
            InitializeComponent();
        }

        //METODO PARA ARRASTRAR EL FORMULARIO---------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void FrmNuevoUsuarioXCurso_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void FrmNuevoUsuarioXCurso_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
            CargarCursos();
        }
        private void CargarUsuarios()
        {
            var usuarios = _usuariosServicio.ObtenerUsuarios();
            var usuarioSeleccionar = new Usuario();
            usuarioSeleccionar.Nombre = "Seleccionar";
            usuarios.Add(usuarioSeleccionar);
            var conector = new BindingSource();
            conector.DataSource = usuarios;
            FormUtils.CargarCombo(ref CbUsuarios, conector, "Nombre", "Id");
            var seleccionar = usuarios.First(u => u.Id == 0);
            CbUsuarios.SelectedItem = seleccionar;

        }
        private void CargarCursos()
        {
            var cursos = _usuariosXcursosServicio.ObtenerCursos();
            var cursoSeleccionar = new Curso();
            cursoSeleccionar.Nombre = "Seleccionar";
            cursos.Add(cursoSeleccionar);
            var conector = new BindingSource();
            conector.DataSource = cursos;
            FormUtils.CargarCombo(ref CbCursos, conector, "Nombre", "Id");
            var seleccionar = cursos.First(u => u.Id == 0);
            CbCursos.SelectedItem = seleccionar;
        }

        private void btnGuardarModDesc_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ConfirmarOperacion())
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

        private bool ConfirmarOperacion()
        {
            DialogResult resultado = MessageBox.Show("Confirmar Operacion", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (resultado == DialogResult.Cancel)
                return false;
            return true;
        }

        private void ValidarUsuarioXCurso()
        {
            var usuario = (Usuario)CbUsuarios.SelectedItem;
            var curso = (Curso)CbCursos.SelectedItem;
            var puntajeIngresado = 0;
            string observacionesIngresado = " ";
            //Usuario usuarioIngresado = new Usuario();
            //Curso cursoIngresado = new Curso();
            //usuarioIngresado.Nombre = usuario.Nombre;
            //cursoIngresado.Nombre = curso.Nombre;
            var usuarioXcursoIngresado = new UsuarioXCurso();
            if (!String.IsNullOrEmpty(TxtPuntaje.Text.ToString()))
            {
                puntajeIngresado = Convert.ToInt32(TxtPuntaje.Text.ToString());
            }
            if (!String.IsNullOrEmpty(TxtObservaciones.Text.ToString()))
            {
                observacionesIngresado = TxtObservaciones.Text.ToString();
            }
            var fechaInicio = DtpFechaInicio.Value;
            var fechaFin = DtpFechaFin.Value;
            usuarioXcursoIngresado.Usuario = usuario;
            usuarioXcursoIngresado.Curso = curso;
            usuarioXcursoIngresado.Puntuacion = puntajeIngresado;
            usuarioXcursoIngresado.Observaciones = observacionesIngresado;
            usuarioXcursoIngresado.Fecha_Inicio = fechaInicio;
            usuarioXcursoIngresado.Fecha_Fin = fechaFin;
            var usuariosXcursos = _usuariosXcursosServicio.ObtenerUsuariosXCursos();
            foreach(UsuarioXCurso uxc in usuariosXcursos)
            {
                if(uxc.Curso.Id == usuarioXcursoIngresado.Curso.Id && uxc.Usuario.Id == usuarioXcursoIngresado.Usuario.Id)
                    throw new ApplicationException("No se puede asignar un usuario a un curso al cual ya fue asignado.");
            }
            _usuarioXcurso = _usuariosXcursosServicio.ValidarUsuarioXCurso(usuarioXcursoIngresado);

        }

        private void RegistrarUsuarioXCurso()
        {
            if (_usuariosXcursosServicio.RegistrarUsuarioXCurso(_usuarioXcurso))
            {
                MessageBox.Show("La operacion se realizo con exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Hubo un error.");
            }
        }

        /*private void CerrarFormulario()
        {
            _frmUsuariosXCursos.Show();
            _frmUsuariosXCursos.ConsultarUsuariosXCursos();
            this.Dispose();
        }*/

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            _frmUsuariosXCursos.Show();
            this.Dispose();
        }

        private void SalirFrmListadoUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     
    }
}
