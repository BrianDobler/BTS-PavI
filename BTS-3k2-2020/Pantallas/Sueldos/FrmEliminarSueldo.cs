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

namespace BTS_3k2_2020.Pantallas.Sueldos
{
    public partial class FrmEliminarSueldo : Form
    {
        private Sueldo _sueldo;
        private SueldosServicio _sueldoServicio;
        private FrmSueldos _frmSueldos;
        public FrmEliminarSueldo(FrmSueldos frmSueldos, long id, DateTime fecha)
        {
           
            _sueldoServicio = new SueldosServicio();
            _frmSueldos = frmSueldos;
            _sueldo = _sueldoServicio.ObtenerSueldo(id, fecha);

            InitializeComponent();
        }

        private void EliminarSueldo_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            TxtIdUsuario.Text = _sueldo.Usuario.Id.ToString();
            TxtNombreUsuario.Text = _sueldo.Usuario.Nombre;
            DtpFecha.Value = _sueldo.Fecha;
            TxtSueldo.Text = _sueldo.Sueldo_bruto.ToString();
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MessageBox.Show("Confirmar Operacion", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (resultado == DialogResult.Cancel)
                    return;
                ValidarSueldo();
                DarBajaSueldo();
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

        /*private void CerrarFormulario()
        {
            _frmSueldos.Show();
            _frmSueldos.ConsultarSueldos();
            this.Dispose();
        }*/

        private void ValidarSueldo()
        {

        }

        private void DarBajaSueldo()
        {
            _sueldoServicio.DarBajaSueldo(_sueldo);
            MessageBox.Show($"La operacion se realizo con exito.");
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            _frmSueldos.Show();
            this.Dispose();
        }

        private void btnGuardarEliminarSueldo_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MessageBox.Show("Confirmar Operacion", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (resultado == DialogResult.Cancel)
                    return;
                ValidarSueldo();
                DarBajaSueldo();
                //CerrarFormulario();
                _frmSueldos.ConsultarSueldos();
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

        private void SalirFrmNuevoUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //METODO PARA ARRASTRAR EL FORMULARIO---------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void FrmEliminarSueldo_MouseMove(object sender, MouseEventArgs e)
        {

                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);


            }
     }
}

