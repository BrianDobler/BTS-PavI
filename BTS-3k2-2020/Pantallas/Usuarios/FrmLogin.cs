using BTS_3k2_2020.Modelos;
using BTS_3k2_2020.Servicios;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace BTS_3k2_2020.Pantallas.Usuarios
{
    public partial class FrmLogin : Form
    {
        private UsuarioServicio _usuarioServicio;

        public FrmLogin()
        {
            InitializeComponent();
            _usuarioServicio = new UsuarioServicio();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //METODO PARA ARRASTRAR EL FORMULARIO---------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void FrmLogin_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //private void btnSalir_Click(object sender, EventArgs e)
        //{

        /// }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        //private void btnSalir_Click_1(object sender, EventArgs e)
        //{
          //      this.Dispose();
        //}

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnSalirCruz_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de cerrar el programa?", "Alerta!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();

            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void BtnIng_Click(object sender, EventArgs e)
        {
            var nombreIngresado = txtUsuario.Text;
            var passwordIngresado = txtContraseña.Text;
            Usuario usuario = new Usuario(nombreIngresado, passwordIngresado);
            var usuarioSistema = _usuarioServicio.Login(usuario);
            if (usuarioSistema == null) // no es usuario del sistema
            {
                MessageBox.Show("USUARIO/CONTRASEÑA INCORRECTA", "Información", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                //new FrmPrincipal(this).Show();
                this.Dispose();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void TxtPass_OnTextChange(object sender, EventArgs e)
        {
        }

      
        public FormWindowState WindowsState { get; private set; }

        private void btnMostrarContraseña_Click(object sender, EventArgs e)
        {
            btnOcultarContraseña.Visible = false;
            btnMostrarContraseña.Visible = true;
            if (txtContraseña.UseSystemPasswordChar == true && btnMostrarContraseña.Visible == true)
            {
                txtContraseña.UseSystemPasswordChar = false;
                btnOcultarContraseña.Visible = true;
                btnMostrarContraseña.Visible = false;
            }
            else
            {
                txtContraseña.UseSystemPasswordChar = true;
                btnOcultarContraseña.Visible = false;
                btnMostrarContraseña.Visible = true;


            }
        }
        
        private void btnOcultarContraseña_Click(object sender, EventArgs e)
        {
            btnOcultarContraseña.Visible = true;
            btnMostrarContraseña.Visible = false;
            if (txtContraseña.UseSystemPasswordChar == false && btnOcultarContraseña.Visible == true)
            {
                txtContraseña.UseSystemPasswordChar = true;
                btnMostrarContraseña.Visible = true;
                btnOcultarContraseña.Visible = false;

            }
            else
            {
                txtContraseña.UseSystemPasswordChar = false;
                btnOcultarContraseña.Visible = true;
                btnMostrarContraseña.Visible = false;

            }
        }
    }
}
