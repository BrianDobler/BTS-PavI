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
using BTS_3k2_2020.RespositoriosDAO;

namespace BTS_3k2_2020.Pantallas
{
    public partial class FrmModificarDescuento : Form
    {
        DescuentosRepositorio oDescuentoRep = new DescuentosRepositorio();
        public FrmModificarDescuento()
        {
            InitializeComponent();
        }
        public FrmModificarDescuento(int id_desc, string nom, string monto)
        {
            InitializeComponent();
            this.txtID.Text = id_desc.ToString();
            this.txtID2.Text = id_desc.ToString();
            this.txtNombre.Text = nom;
            this.txtMonto.Text = monto;
        }
        private void txtMonto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(this.txtNewNombre.Text) || string.IsNullOrEmpty(this.txtNewMonto.Text))
           // {
            //    MessageBox.Show("No ingresaron todos los datos.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
           //     this.txtNombre.Focus();
            //}
          //  else
          //  {
           //     int idDesc = Convert.ToInt32(this.txtID.Text);
           //     var nom = this.txtNewNombre.Text.ToString();
            //    var mon = this.txtNewMonto.Text.ToString();
              //  oDescuentoRep.modificarDescuento(idDesc, nom, mon);
            //    MessageBox.Show("Modificación realizada con exito\n\n (Actualice la tabla para ver el cambio.)", "Modificacion de descuento", MessageBoxButtons.OK, MessageBoxIcon.Information);
             //   this.Close();
            }

        private void btnGuardarModDesc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtNewNombre.Text) || string.IsNullOrEmpty(this.txtNewMonto.Text))
            {
                MessageBox.Show("No ingresaron todos los datos.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtNombre.Focus();
            }
            else
            {
                int idDesc = Convert.ToInt32(this.txtID.Text);
                var nom = this.txtNewNombre.Text.ToString();
                var mon = this.txtNewMonto.Text.ToString();
                oDescuentoRep.modificarDescuento(idDesc, nom, mon);
                MessageBox.Show("Modificación realizada con exito\n\n (Actualice la tabla para ver el cambio.)", "Modificacion de descuento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void SalirFrmModificarDescuentos_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        //METODO PARA ARRASTRAR EL FORMULARIO---------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void FrmModificarDescuento_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void SalirFrmModificarDescuentos_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmModificarDescuento_Load(object sender, EventArgs e)
        {

        }
    }
}
