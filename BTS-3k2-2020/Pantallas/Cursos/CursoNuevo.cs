using BTS_3k2_2020.LogicaDeNegocio;
using BTS_3k2_2020.Modelos;
using BTS_3k2_2020.Pantallas.Usuarios;
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
using BTS_3k2_2020.RespositoriosDAO;

namespace BTS_3k2_2020.Pantallas.Cursos
{
    public partial class CursoNuevo : Form
    {
        private CursosRepositoris _cursoRep;
        private Curso _curso;
        private CursoServicio _cursoServicio;
        private CategoriaServicio _categoriaServicio;
        private CursosFrm _ListadoCursos;

        public CursoNuevo()
        {
            _cursoRep = new CursosRepositoris();
            _cursoServicio = new CursoServicio();
            _categoriaServicio = new CategoriaServicio();
            InitializeComponent();


        }



        private void BtnAceptar_Click(object sender, EventArgs e)
        {
           
        }

        private void NuevoCurso_Load(object sender, EventArgs e)
        {
            CargarCategoria();
            this.TipoCategoria.SelectedIndex = -1;
        }

        private bool ConfirmarOperacion()
        {
            DialogResult respuesta = MessageBox.Show("Confirmar operación?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Cancel)
                return false;
            return true;
        }

        private void RegistrarCurso()
        {
            
            //if (_cursoServicio.RegistrarCurso(_curso))
            //{
            //    MessageBox.Show("La operación se realizó con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    _ListadoCursos.Show();
            //    this.Dispose();
            //}
            //else
            //{
            //    MessageBox.Show("Hubo un error. Intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private bool ValidarCurso()
        {
            if (string.IsNullOrEmpty(this.TxtNombre.Text) || string.IsNullOrEmpty(this.TxtDescripcion.Text))
            {
                MessageBox.Show("¡Ingrese los datos que son obligatorios!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
            //var nombre = TxtNombre.Text;
            //var categoria = (Categoria)TipoCategoria.SelectedItem;
            //var descripcion = TxtDescripcion.Text;
            //var curso = new Curso { Nombre = nombre, Categoria = categoria, Descripcion = descripcion };
            //_curso = curso;
            //return true;
        }

        private void CargarCategoria()
        {
            var perfiles = _categoriaServicio.ObtenerCategoria();
            var conectorDeDatos = new BindingSource();
            conectorDeDatos.DataSource = perfiles;
            FormUtils.CargarCombo(ref TipoCategoria, conectorDeDatos, "Nombre", "Id");
        }
        //METODO PARA ARRASTRAR EL FORMULARIO---------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void NuevoCurso_MouseMove(object sender, MouseEventArgs e)
        {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        
        
        private void btnGuardarNuevoCurso_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ConfirmarOperacion())
                    return;
                if (!ValidarCurso())
                    return;
                var desc = this.TxtDescripcion.Text.ToString();
                var nom = this.TxtNombre.Text.ToString();
                var id_cat = Convert.ToInt32(this.TipoCategoria.SelectedValue);
                var conCat = 0;
                if (this.chkIncluirCateg.Checked)
                    conCat = 1;

                _cursoRep.registrarCurso(nom, desc, id_cat, conCat);
                //RegistrarCurso();
                MessageBox.Show("¡Curso añadido con exito!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void SalirFrmNuevoUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void chkIncluirCateg_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIncluirCateg.Checked)
            {
                TipoCategoria.Enabled = true;
                TipoCategoria.SelectedIndex = 0;
            }

            else
            {
                TipoCategoria.Enabled = false;
                TipoCategoria.SelectedIndex = -1;
            }
        }
    }
}
