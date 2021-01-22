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

namespace BTS_3k2_2020.Pantallas.Usuarios
{
    public partial class FrmModificar : Form
    {

        private UsuarioServicio _usuarioServicio;
        private PerfilesServicio _perfilesServicio;
        private FrmUsuarios _frmUsuarios;
        private Usuario _usuario;

        public FrmModificar(FrmUsuarios frmUsuarios, long id)
        {
            _usuarioServicio = new UsuarioServicio();
            _perfilesServicio = new PerfilesServicio();
            _frmUsuarios = frmUsuarios;
            _usuario = _usuarioServicio.ObtenerUsuarios(id);
            InitializeComponent();
        }

        private void FrmModificar_Load(object sender, EventArgs e)
        {
            cargarDatos();
            CargarPerfiles();
        }

        private void cargarDatos()
        {

            TxtNombre.Text = _usuario.Nombre;
            TxtPassword.Text = _usuario.Password;
            TxtPassword.Text = _usuario.Password;
            TxtEmail.Text = _usuario.Email;

        }
        //METODO PARA ARRASTRAR EL FORMULARIO---------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void FrmModificar_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void CargarPerfiles()
        {
            var perfiles = _perfilesServicio.ObtenerTodos();
            var conectorDeDatos = new BindingSource();
            conectorDeDatos.DataSource = perfiles;
            FormUtils.CargarCombo(ref CbPerfiles, conectorDeDatos, "Nombre", "Id");
            var perfilSeleccionado = perfiles.First(p => p.Id == _usuario.Perfil.Id);
            CbPerfiles.SelectedItem = perfilSeleccionado;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {

            try
            {
                if (!ConfirmarOperacion())
                    return;
                if (!ValidarUsuario())
                    return;
                ActualizarUsuario();
                CerrarFormulario();
            }
            catch (ApplicationException ae)
            {
                MessageBox.Show(ae.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error. Intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CerrarFormulario()
        {
            _frmUsuarios.Show();
            _frmUsuarios.ConsultarUsuarios();
            this.Dispose();
        }

        private void ActualizarUsuario()
        {

            _usuarioServicio.ActualizarUsuario(_usuario);
            MessageBox.Show("La operación se realizó con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool ConfirmarOperacion()
        {
            DialogResult resultado = MessageBox.Show("Confirmar operación", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (resultado == DialogResult.Cancel)
                return false;
            return true;
        }

        private bool ValidarUsuario()
        {
            var password = TxtPassword.Text;
            var repassword = TxtRePassword.Text;
            if (password != repassword)
            {
                MessageBox.Show("La constraseña no coincide", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            var nombre = TxtNombre.Text;
            var perfil = (Perfil)CbPerfiles.SelectedItem;
            var email = TxtEmail.Text;

            _usuario.Nombre = nombre;
            _usuario.Email = email;
            _usuario.Password = password;
            _usuario.Perfil = perfil;

            _usuarioServicio.ValidarUsuario(_usuario);
            return true;
        }


        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            CerrarFormulario();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardarModUsuar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ConfirmarOperacion())
                    return;
                if (!ValidarUsuario())
                    return;
                ActualizarUsuario();
                //CerrarFormulario();
            }
            catch (ApplicationException ae)
            {
                MessageBox.Show(ae.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error. Intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SalirFrmModificarUsuarios_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
