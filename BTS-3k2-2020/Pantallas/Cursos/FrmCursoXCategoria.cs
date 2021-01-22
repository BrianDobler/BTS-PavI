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

namespace BTS_3k2_2020.Pantallas.Cursos
{
    public partial class FrmCursoXCategoria : Form
    {
        private DataTable tabla;
        private CursoPorCategoriaRepositorio _cursoXCatRep;
        public FrmCursoXCategoria()
        {
            tabla = new DataTable();
            _cursoXCatRep = new CursoPorCategoriaRepositorio();
            InitializeComponent();
        }

        //METODO PARA ARRASTRAR EL FORMULARIO---------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void FrmCursoXCategoria_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
   

        private void FrmCursoXCategoria_Load(object sender, EventArgs e)
        {
            this.dgvCurCat.Rows.Clear();
            tabla = _cursoXCatRep.recuperar();
            cargarGrilla(dgvCurCat, tabla);
        }

        private void SalirFrmModificarDescuentos_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void cargarGrilla(DataGridView grilla, DataTable tabla)
        {
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grilla.Rows.Add(tabla.Rows[i]["curso"],
                    tabla.Rows[i]["categoria"]);
            }
        }

        private void pictureBoxRefrescar_Click(object sender, EventArgs e)
        {
            this.dgvCurCat.Rows.Clear();
            this.txtNombreCategoria.Clear();
            this.txtNombreCurso.Clear();
            tabla = _cursoXCatRep.recuperar();
            cargarGrilla(this.dgvCurCat, tabla);
        }

        private void btnBuscarDescuento_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtNombreCurso.Text) && string.IsNullOrEmpty(this.txtNombreCategoria.Text))
                MessageBox.Show("Debe ingresar datos para poder realizar la busqueda", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                var contCurso = 0;
                var contCat = 0;
                if (string.IsNullOrEmpty(this.txtNombreCurso.Text))
                    contCurso = 1;
                if (string.IsNullOrEmpty(this.txtNombreCategoria.Text))
                    contCat = 1;
                string curso = this.txtNombreCurso.Text;
                string categ = this.txtNombreCategoria.Text;
                this.dgvCurCat.Rows.Clear();
                tabla = _cursoXCatRep.recuperarFiltrado(contCurso,contCat, curso, categ);
                cargarGrilla(this.dgvCurCat, tabla);
                
            }
        }


    }
}
