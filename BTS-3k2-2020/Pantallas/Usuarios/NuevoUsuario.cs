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
    public partial class NuevoUsuario : Form
    {

        private UsuarioServicio _usuarioServicio;
        private PerfilesServicio _perfilesServicio;
        private FrmUsuarios _frmUsuarios;
        private Usuario _usuario;

        public NuevoUsuario(FrmUsuarios frmUsuarios)
        {
            _usuarioServicio = new UsuarioServicio();
            _perfilesServicio = new PerfilesServicio();
            _frmUsuarios = frmUsuarios;
            InitializeComponent();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (!ConfirmarOperacion())
                return;
            if (!ValidarUsuario())
                return;
            if (RegistrarUsuario())
            {
                _frmUsuarios.Show();
                _frmUsuarios.ConsultarUsuarios();
                this.Dispose();
            }

        }

        private void FrmNuevoUsuario_Load(object sender, EventArgs e)
        {
            CargarPerfiles();
        }

        private bool ConfirmarOperacion()
        {
            DialogResult respuesta = MessageBox.Show("Confirmar operación?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Cancel)
                return false;
            return true;
        }

        private bool RegistrarUsuario()
        {
            var error = _usuarioServicio.RegistrarUsuario(_usuario);
            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            MessageBox.Show("Se registró con éxito el usuario", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }

        private bool ValidarUsuario()
        {
            var nombre = TxtNombre.Text;
            var perfil = (Perfil)CbPerfiles.SelectedItem;
            var password = TxtPassword.Text;
            var rePpassword = TxtRePassword.Text;
            var email = TxtEmail.Text;
            if (password != rePpassword)
            {
                MessageBox.Show("Contraseñas no coinciden o ambas no cumplen con poner 8 caracteres minimos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            var usuario = new Usuario { Nombre = nombre, Perfil = perfil, Password = password, Email = email };
            var error = _usuarioServicio.ValidarNuevoUsuario(usuario);
            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            _usuario = usuario;
            return true;
        }

        //private bool ValidarUsuario()
        //{
        //    var password = TxtPassword.Text;
        //    var repassword = TxtRePassword.Text;
        //    if (password != repassword)
        //    {
        //        MessageBox.Show("La constraseña no coincide", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return false;
        //    }
        //    var nombre = TxtNombre.Text;
        //    var perfil = (Perfil)CbPerfiles.SelectedItem;
        //    var email = TxtEmail.Text;
        //
        //    var usuarioIngresado = new Usuario();
        //    usuarioIngresado.Nombre = nombre;
        //    usuarioIngresado.Email = email;
        //    usuarioIngresado.Password = password;
        //    usuarioIngresado.Perfil = perfil;
        //    _usuarioServicio.ValidarUsuario(usuarioIngresado);
        //    return true;
        //}

        private void CargarPerfiles()
        {
            var perfiles = _perfilesServicio.ObtenerTodos();
            var conectorDeDatos = new BindingSource();
            conectorDeDatos.DataSource = perfiles;
            FormUtils.CargarCombo(ref CbPerfiles, conectorDeDatos, "Nombre", "Id");
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            _frmUsuarios.Show();
            this.Dispose();
        }


        private void SalirFrmModificarDescuentos_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //METODO PARA ARRASTRAR EL FORMULARIO---------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void NuevoUsuario_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnGuardarModUsuar_Click(object sender, EventArgs e)
        {
            if (!ConfirmarOperacion())
                return;
            if (!ValidarUsuario())
                return;
            if (RegistrarUsuario())
            {
                //_frmUsuarios.Show();
                _frmUsuarios.ConsultarUsuarios();
                //this.Dispose();
            }

        }

       
    }
}
