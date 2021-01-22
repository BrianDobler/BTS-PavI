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

namespace BTS_3k2_2020.Pantallas.Usuarios
{
    public partial class FrmEliminar : Form
    {
        private Usuario _usuario;
        private UsuarioServicio _usuarioServicio;
        private PerfilesServicio _perfilesServicio;
        private FrmUsuarios _frmUsuarios;

        public FrmEliminar(FrmUsuarios frmUsuarios, long id)
        {
            _usuarioServicio = new UsuarioServicio();
            _perfilesServicio = new PerfilesServicio();
            _frmUsuarios = frmUsuarios;
            _usuario = _usuarioServicio.ObtenerUsuarios(id);
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MessageBox.Show("Confirmar operación", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (resultado == DialogResult.Cancel)
                    return;
                ValidarUsuario();
                ActualizarUsuario();
                //CerrarFormulario();
            }
            catch (ApplicationException aex)
            {
                MessageBox.Show(aex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un problema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmBajaUsuario_Load(object sender, EventArgs e)
        {
            CargarDatos();
            CargarPerfiles();
        }

        private void ActualizarUsuario()
        {
            _usuarioServicio.DarBajaUsuario(_usuario);
            MessageBox.Show("La operación se realizó con éxito", "Información");
        }


        private void ValidarUsuario()
        {
            if (RbActivo.Checked)
                _usuario.Estado = true;
            if (RbInactivo.Checked)
                _usuario.Estado = false;
        }

        private void CargarPerfiles()
        {
            var perfiles = _perfilesServicio.ObtenerTodos();
            var conector = new BindingSource();
            conector.DataSource = perfiles;
            FormUtils.CargarCombo(ref CbPerfil, conector, "Nombre", "Id");
            var perfilSeleccionado = perfiles.First(p => p.Id == _usuario.Perfil.Id);
            CbPerfil.SelectedItem = perfilSeleccionado;
        }

        private void CargarDatos()
        {
            TxtNombre.Text = _usuario.Nombre;
            TxtEmail.Text = _usuario.Email;
            if (_usuario.Estado)
                RbActivo.Checked = true;
            else
                RbInactivo.Checked = true;

        }

        private void CerrarFormulario()
        {
            _frmUsuarios.Show();
            _frmUsuarios.ConsultarUsuarios();
            this.Dispose();
        }

        private void BtnGuardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MessageBox.Show("Confirmar operación", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (resultado == DialogResult.Cancel)
                    return;
                ValidarUsuario();
                ActualizarUsuario();
                //CerrarFormulario();
            }
            catch (ApplicationException aex)
            {
                MessageBox.Show(aex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un problema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //METODO PARA ARRASTRAR EL FORMULARIO---------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void FrmEliminar_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void SalirFrmNuevoUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void btnGuardarModUsuar_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        DialogResult resultado = MessageBox.Show("Confirmar operación", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        //        if (resultado == DialogResult.Cancel)
        //            return;
        //        ValidarUsuario();
        //        ActualizarUsuario();
        //        CerrarFormulario();
        //    }
        //    catch (ApplicationException aex)
        //    {
        //        MessageBox.Show(aex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Ha ocurrido un problema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
        private void btnGuardarModUsuar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MessageBox.Show("Confirmar operación", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (resultado == DialogResult.Cancel)
                    return;
                ValidarUsuario();
                ActualizarUsuario();
                //CerrarFormulario();
            }
            catch (ApplicationException aex)
            {
                MessageBox.Show(aex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un problema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RbActivo_CheckedChanged(object sender, EventArgs e)
        {

        }


    }
}