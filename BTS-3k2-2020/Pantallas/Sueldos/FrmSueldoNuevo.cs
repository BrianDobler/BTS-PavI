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

namespace BTS_3k2_2020.Pantallas.Sueldos
{
    public partial class FrmSueldoNuevo : Form
    {
        private Sueldo _sueldo;
        private SueldosServicio _sueldoServicio;
        private FrmSueldos _frmSueldos;
        private UsuarioServicio _usuariosServicio;
        public FrmSueldoNuevo(FrmSueldos frmSueldos)
        {
            _sueldoServicio = new SueldosServicio();
            _usuariosServicio = new UsuarioServicio();
            _frmSueldos = frmSueldos;
            InitializeComponent();
        }

        private void FrmSueldoNuevo_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
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
            var seleccionado = usuarios.First(u => u.Id == 0);
            CbUsuarios.SelectedItem = seleccionado;

        }
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ConfirmarOperacion())
                    return;
                ValidarSueldo();
                RegistrarSueldo();
               
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

        private void ValidarSueldo()
        {
            /*var id_usuario = TxtId_usuario.Text;
             var fecha = TxtFecha.Text;
             var sueldo_bruto = TxtSueldo_bruto.Text;*/
            //var id_usuario = Convert.ToInt64(TxtId_usuario.Text.ToString());
            double? sueldo_bruto = null;
            var usuario = (Usuario)CbUsuarios.SelectedItem;
            //var id_usuario = _usuario.Id;
            var fecha = DtpFecha.Value;
            if (!String.IsNullOrEmpty(TxtSueldo_bruto.Text.ToString()))
            {
                //double sueldo_bruto;
                //sueldo_bruto = double.Parse(TxtSueldo_bruto.Text.ToString(), CultureInfo.NumberFormat.CurrencyGroupSeparator = ".");
                // sueldo_bruto = Double.Parse(TxtSueldo_bruto.Text.ToString().Replace(',', '.'), CultureInfo.InvariantCulture);
                //sueldo_bruto = double.Parse(TxtSueldo_bruto.Text.ToString(), CultureInfo.InvariantCulture);
                sueldo_bruto = double.Parse(TxtSueldo_bruto.Text.ToString());
            }
            var sueldoIngresado = new Sueldo();
            //sueldoIngresado.Usuario = id_usuario;
            sueldoIngresado.Usuario = usuario;
            sueldoIngresado.Fecha = fecha;
            sueldoIngresado.Sueldo_bruto = sueldo_bruto;
            _sueldo = _sueldoServicio.ValidarSueldo(sueldoIngresado);

        }

        private void RegistrarSueldo()
        {
            //if (_sueldoServicio.RegistrarSueldo(_sueldo))
            //{
            //  MessageBox.Show("La operacion se realizo con exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else
            //{
            //  MessageBox.Show("Hubo un error.");
            //}
            _sueldoServicio.RegistrarSueldo(_sueldo);
            //double prueba = 3.54;
            MessageBox.Show("La operacion se realizo con exito.","Agregar Sueldo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //this.Close();
            //MessageBox.Show($"{prueba}");
            //_sueldo.Sueldo_bruto.ToString().Split('.');
            //MessageBox.Show($"{_sueldo.Sueldo_bruto.ToString().Split('.')}");
            //MessageBox.Show($"{_sueldo.Sueldo_bruto.ToString()}");
        }

        /*private void CerrarFormulario()
        {
            _frmSueldos.Show();
            _frmSueldos.ConsultarSueldos();
            this.Dispose();
        }*/

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            _frmSueldos.Show();
            this.Dispose();
        }

        private void btnGuardarModDesc_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ConfirmarOperacion())
                    return;
                ValidarSueldo();
                RegistrarSueldo();
                _frmSueldos.ConsultarSueldos();

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

        private void SalirFrmNuevoUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //METODO PARA ARRASTRAR EL FORMULARIO---------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void FrmSueldoNuevo_MouseMove(object sender, MouseEventArgs e)
        {

                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);


        }
        
    }
}
