using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTS_3k2_2020.Pantallas.Sueldos
{
    public partial class FrmConfirmarCredencial : Form
    {
        private FrmSueldos _frmSueldos;
        private long _id;
        private DateTime _fecha;

        public FrmConfirmarCredencial(FrmSueldos frmSueldos,long id, DateTime fecha)
        {
             _frmSueldos = frmSueldos;
             _id = id;
             _fecha = fecha;
             InitializeComponent();
        }

        public string Password { get; private set; }
        
       
        private void btnGuardarModDesc_Click(object sender, EventArgs e)
        {
            var password = "HolaMundo1234";
            if (password == txtPassword.Text)
            {
                MessageBox.Show("Su credencial coincide con la del Administrador de Sueldo!!", "Eliminar Sueldo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new FrmEliminarSueldo(_frmSueldos, _id, _fecha).Show();
                this.Hide();
                
            }
            else
            {   
                MessageBox.Show("Su credencial es invalida!! Por favor asegurese de colocar bien su Credencial Administrador de Sueldos", "Eliminar Sueldo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
             
            }
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
        private void FrmConfirmarCredencial_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void FrmConfirmarCredencial_Load(object sender, EventArgs e)
        {

        }

        private void btnMostrarContraseña_Click(object sender, EventArgs e)
        {

            btnOcultarContraseña.Visible = false;
            btnMostrarContraseña.Visible = true;
            if (txtPassword.UseSystemPasswordChar == true && btnMostrarContraseña.Visible == true)
            {
                txtPassword.UseSystemPasswordChar = false;
                btnOcultarContraseña.Visible = true;
                btnMostrarContraseña.Visible = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                btnOcultarContraseña.Visible = false;
                btnMostrarContraseña.Visible = true;

            }
        }

        private void btnOcultarContraseña_Click(object sender, EventArgs e)
        {
            btnOcultarContraseña.Visible = true;
            btnMostrarContraseña.Visible = false;
            if (txtPassword.UseSystemPasswordChar == false && btnOcultarContraseña.Visible == true)
            {
                txtPassword.UseSystemPasswordChar = true;
                btnMostrarContraseña.Visible = true;
                btnOcultarContraseña.Visible = false;

            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;
                btnOcultarContraseña.Visible = true;
                btnMostrarContraseña.Visible = false;

            }
        }
    }
}

