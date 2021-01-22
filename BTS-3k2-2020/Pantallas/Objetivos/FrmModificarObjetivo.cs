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

namespace BTS_3k2_2020.Pantallas.Objetivos
{
    public partial class FrmModificarObjetivo : Form
    {
        private long idObjetivo;
        private Objetivo objetivo;
        private ObjetivosServicio _objetivoServicio;
        public FrmModificarObjetivo(long id)
        {
            idObjetivo = id;
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmModificarObjetivo_Load(object sender, EventArgs e)
        {
            objetivo = new Objetivo();
            objetivo.Id = idObjetivo;
            objetivo.NombreCorto = "";
            objetivo.NombreLargo = "";

            var _objetivoServicio = new ObjetivosServicio();
            var objetivos = _objetivoServicio.ConsultarObjetivoExacto(objetivo.Id.ToString(),objetivo.NombreCorto,objetivo.NombreLargo);

            foreach (var objetivo in objetivos)
            {
                txtIDObjetivo.Text = objetivo.Id.ToString();
                txtNombreCortoActual.Text = objetivo.NombreCorto;
                txtNombreLargoActual.Text = objetivo.NombreLargo;
            }
        }
        //METODO PARA ARRASTRAR EL FORMULARIO---------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void FrmModificarObjetivo_MouseMove(object sender, MouseEventArgs e)
        {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnGuardarModUsuar_Click(object sender, EventArgs e)
        {
            if (txtNuevoID.Text == "" && txtNuevoNombreCorto.Text == "" && txtNuevoNombreLargo.Text == "")
            {
                MessageBox.Show("Por favor ingresar datos validos");
            }
            else
            {
                _objetivoServicio = new ObjetivosServicio();
                if(txtNuevoID.Text != "")
                {
                    idObjetivo = Convert.ToInt32(txtNuevoID.Text);
                }
                else
                {
                    idObjetivo = Convert.ToInt32(txtIDObjetivo.Text);
                }
                if(txtNuevoNombreCorto.Text != "")
                {
                    objetivo.NombreCorto = txtNuevoNombreCorto.Text;
                }
                else
                {
                    objetivo.NombreCorto = txtNombreCortoActual.Text;
                }
                if(txtNuevoNombreLargo.Text != "")
                {
                    objetivo.NombreLargo = txtNuevoNombreLargo.Text;
                }
                else
                {
                    objetivo.NombreLargo = txtNombreLargoActual.Text;
                }

                if (_objetivoServicio.ModificarObjetivo(objetivo.Id, idObjetivo, objetivo.NombreCorto, objetivo.NombreLargo) > 0)
                {
                    MessageBox.Show("Se ha modificado correctamente el registro con ID "+objetivo.Id);
                } 
            }
            

        }

        private void txtIDObjetivo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
