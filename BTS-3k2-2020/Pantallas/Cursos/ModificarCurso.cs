using BTS_3k2_2020.LogicaDeNegocio;
using BTS_3k2_2020.Modelos;
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
using BTS_3k2_2020.RespositoriosDAO;
namespace BTS_3k2_2020.Pantallas.Cursos
{
    public partial class ModificarCurso : Form
    {
        private CursosRepositoris _cursoRep;
        private Curso _curso;
        private CursoServicio _cursoServicio;
        private CategoriaServicio _categoriaServicio;
        private FrmMenuV2 _ListadoCursos;
        
        public ModificarCurso(int id,string nom, string desc)
        {
            _cursoRep = new CursosRepositoris();
            //_cursoServicio = new CursoServicio();
            //_categoriaServicio = new CategoriaServicio();
            _ListadoCursos = new FrmMenuV2();
            ////_curso = _cursoServicio.ObtenerCurso(id);
            //_curso = new Curso();
            InitializeComponent();
            this.TxtDescripcion.Text = desc;
            this.TxtNombre.Text = nom;
            var tabla = _cursoRep.recuperarCategorias(id);
            this.TipoCategoria.DataSource = tabla;
            this.txtID.Text = id.ToString();
            this.TipoCategoria.ValueMember = "id_categoria";
            this.TipoCategoria.DisplayMember = "nombre";

        }





        private void FrmModificar_Load(object sender, EventArgs e)
        {

            //CargarDatos();
            //CargarCategoria();
        }

        //private void CargarDatos()
        //{
        //    TxtNombre.Text = _curso.Nombre;          
        //    TxtDescripcion.Text = _curso.Descripcion;
        //}

        //private void CargarCategoria()
        //{
        //    var categorias = _categoriaServicio.ObtenerCategoria();
        //    var conector = new BindingSource();
        //    conector.DataSource = categorias;
        //    FormUtils.CargarCombo(ref TipoCategoria, conector, "Nombre", "Id");
        //    var categoriaSeleccionado = categorias.First(p => p.Id == _curso.Categoria.Id);
        //    TipoCategoria.SelectedItem = categoriaSeleccionado;
        //}
        //METODO PARA ARRASTRAR EL FORMULARIO---------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void FrmModificar_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void CerrarFormulario()
        {
            //_ListadoCursos.Show();
            ////_ListadoCursos.ConsultarCursos();
            //this.Dispose();
        }

        //private void RegistrarCurso()
        //{
        //    _cursoServicio.ActualizarCurso(_curso);
        //    MessageBox.Show("La operación se realizó con éxito", "Información");
        //}

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            CerrarFormulario();
        }

        //private void BtnAceptar_Click_1(object sender, EventArgs e)
        //{
        //    {
        //        try
        //        {
        //            DialogResult resultado = MessageBox.Show("Confirmar operación", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        //            if (resultado == DialogResult.Cancel)
        //                return;
        //            RegistrarCurso();
        //            CerrarFormulario();
        //        }
        //        catch (ApplicationException aex)
        //        {
        //            MessageBox.Show(aex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Ha ocurrido un problema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //}
        private void btnGuardarModCurso_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    DialogResult resultado = MessageBox.Show("Confirmar operación", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (resultado == DialogResult.Cancel)
                        return;
                    var id = Convert.ToInt32(this.txtID.Text);
                    var nom = this.TxtNombre.Text;
                    var desc = this.TxtDescripcion.Text;
                    var id_Cat = Convert.ToInt32(this.TipoCategoria.SelectedValue);
                    _cursoRep.registrarModificacion(id,nom,desc,id_Cat);
                    MessageBox.Show("¡Modificación exitosa!\n Acutalice la talba para ver cambios efectuados...", "Modificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    
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
        }

        private void SalirFrmNuevoUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
