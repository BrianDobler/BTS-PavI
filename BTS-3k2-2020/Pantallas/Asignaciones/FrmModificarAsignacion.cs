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

namespace BTS_3k2_2020.Pantallas.Asignaciones
{
    public partial class FrmModificarAsignacion : Form
    {
        AsignacionesRepositorio oAsignacionRep = new AsignacionesRepositorio();
        public FrmModificarAsignacion(int id_desc, string nom, string monto)
        {
            InitializeComponent();
            this.txtID.Text = id_desc.ToString();
            this.txtID2.Text = id_desc.ToString();
            this.txtNombre.Text = nom;
            this.txtMonto.Text = monto;
           
        }

        private void FrmModificarAsignacion_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardarModAsig_Click(object sender, EventArgs e)
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
                oAsignacionRep.modificarAsignacion(idDesc, nom, mon);
                MessageBox.Show("Modificación realizada con exito\n\n (Actualice la tabla para ver el cambio.)", "Modificacion de asignacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
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
        private void FrmModificarAsignacion_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
