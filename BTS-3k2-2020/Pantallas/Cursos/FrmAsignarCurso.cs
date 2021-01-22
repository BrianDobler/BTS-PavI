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
    public partial class FrmAsignarCurso : Form
    {
        CategoriaRepositorio _catRep;
        CursosRepositoris _cursoRep;
        public FrmAsignarCurso(int id,string nom, string desc)
        {
            _cursoRep = new CursosRepositoris();
            _catRep = new CategoriaRepositorio();
            InitializeComponent();
            this.txtCurso.Text = nom.ToString();
            this.txtDesc.Text = desc.ToString();
            this.txtID.Text = id.ToString();

        }

        private void SalirFrmModificarDescuentos_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAsignarCurso_Load(object sender, EventArgs e)
        {
            var tabla = _catRep.recuperarCat();
            this.dtbAsignarDesc.Rows.Clear();
            cargarGrilla(this.dtbAsignarDesc,tabla);
        }

        public void cargarGrilla(DataGridView grilla, DataTable tabla)
        {
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grilla.Rows.Add(tabla.Rows[i]["id_categoria"],
                    tabla.Rows[i]["nombre"],
                    tabla.Rows[i]["descripcion"]);
            }
        }

        private void btnGuardarAsigAsignac_Click(object sender, EventArgs e)
        {
            
            try
            {
                DialogResult resultado = MessageBox.Show("Confirmar operación", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (resultado == DialogResult.Cancel)
                    return;
                var id_cat = Convert.ToInt32(this.dtbAsignarDesc.CurrentRow.Cells[0].Value);
                var id_curso = Convert.ToInt32(this.txtID.Text);
                _cursoRep.asignarCategoria(id_curso, id_cat);
                MessageBox.Show("¡Asignación exitosa!", "Asignación de categoria a curso", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (ApplicationException aex)
            {
                MessageBox.Show(aex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un problema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        //METODO PARA ARRASTRAR EL FORMULARIO---------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void FrmAsignarCurso_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
       
    }
}
