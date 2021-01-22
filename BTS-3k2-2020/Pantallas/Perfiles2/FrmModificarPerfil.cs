using BTS_3k2_2020.Modelos;
using BTS_3k2_2020.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BTS_3k2_2020.Pantallas.Perfiles2
{
    public partial class FrmModificarPerfil : Form
    {
        private long idPerfil;
        private Perfil perfil;
        private PerfilesServicio _perfilesServicio;
        public FrmModificarPerfil(long id)
        {
            idPerfil = id;
            
            InitializeComponent();
        }

        private void FrmModificarPerfil_Load(object sender, EventArgs e)
        {
            perfil = new Perfil();
            perfil.Id = idPerfil;
            perfil.Nombre = "";

            var _perfilesServicio = new PerfilesServicio();
            var perfiles = _perfilesServicio.ConsultarPerfil(perfil.Nombre.ToString(), perfil.Id.ToString());

            foreach (var perfil in perfiles)
            {
                txtNombreActual.Text = perfil.Nombre.ToString();
                txtNombreActual.ReadOnly = true;
            }

        }


        //METODO PARA ARRASTRAR EL FORMULARIO---------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void FrmModificarPerfil_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SalirFrmNuevoUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardarModDesc_Click(object sender, EventArgs e)
        {
            if (txtNuevoNombre.Text.ToString() == "")
            {
                MessageBox.Show("Ingrese un nombre");
            }
            else
            {
                var _perfilesServicio = new PerfilesServicio();
                var nuevoNombre = txtNuevoNombre.Text;
                if (_perfilesServicio.ModificarPerfil(perfil.Id, nuevoNombre.ToString()) > 0)
                {
                    MessageBox.Show("Nombre de registros con ID " + perfil.Id + " modificados");
                }
                
            }
        }

        private void txtNuevoNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombreActual_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
