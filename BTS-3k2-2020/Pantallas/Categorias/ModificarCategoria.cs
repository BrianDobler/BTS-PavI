using BTS_3k2_2020.RespositoriosDAO;
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

namespace BTS_3k2_2020.Pantallas.Categorias
{
    public partial class ModificarCategoria : Form
    {

        CategoriaRepositorio _categoriaRep = new CategoriaRepositorio();
        public ModificarCategoria(int id_Categor, string nombre,string descripcion)
        {
            InitializeComponent();
            this.txtIDCat.Text = id_Categor.ToString();
            this.txtNombreActual.Text = nombre;
            this.txtDescActual.Text = descripcion;
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
        private void ModificarCategoria_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnGuardarModDesc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtNuevoNombreCat.Text) || string.IsNullOrEmpty(this.txtNuevaDescrip.Text))
            {
                MessageBox.Show("No ingresaron todos los datos.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtNombreActual.Focus();
            }
            else
            {
                int idCategoria = Convert.ToInt32(this.txtIDCat.Text);
                var nom = this.txtNuevoNombreCat.Text.ToString();
                var des = this.txtNuevaDescrip.Text.ToString();
                _categoriaRep.modificarCategoria(idCategoria, nom, des);
                MessageBox.Show("Modificación realizada con exito\n\n (Actualice la tabla para ver el cambio.)", "Modificacion de descuento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtDescActual_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtNuevoNombreCat_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNuevaDescrip_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombreActual_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNombrePerfilActual_Click(object sender, EventArgs e)
        {

        }

        private void lblNombrePerfil_Click(object sender, EventArgs e)
        {

        }
    }
}
