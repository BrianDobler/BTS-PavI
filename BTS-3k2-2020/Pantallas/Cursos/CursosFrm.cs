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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTS_3k2_2020.RespositoriosDAO;

namespace BTS_3k2_2020.Pantallas.Cursos
{
    public partial class CursosFrm : Form
    {
        private Curso _curso;
        private CursoServicio _cursoServicios;
        private CategoriaServicio _categoriaServicio;
        private UsuarioServicio _usuarioServicio;
        private FrmMenuV2 _frmMenuV2;
        private Categoria _categoriaSeleccione = new Categoria() { Nombre = "Seleccione" };
        private CursosRepositoris _cursoRep;

        public CursosFrm(FrmMenuV2 frmMenuV2)
        {
            _curso = new Curso();
            _cursoRep = new CursosRepositoris();
            _cursoServicios = new CursoServicio();
            _categoriaServicio = new CategoriaServicio();
            _usuarioServicio = new UsuarioServicio();
            _frmMenuV2 = frmMenuV2;
            InitializeComponent();
        }
        private void ListadoCursos_Load(object sender, EventArgs e)
        {
            CargarCategorias();
            var tabla = ConsultarCursosInicio();
            cargarGrilla(DgvCursos, tabla);
            this.TipoCategoria.SelectedIndex = -1;
        }

        private void CargarCursos()
        {
            var categorias = _categoriaServicio.ObtenerCategoria();
            var categoriaSeleccionada = categorias.First();
            var conector = new BindingSource();
            conector.DataSource = categorias;
            TipoCategoria.DataSource = conector;
            TipoCategoria.DisplayMember = "Nombre";
            TipoCategoria.ValueMember = "Id";
            TipoCategoria.SelectedItem = categoriaSeleccionada;
        }

        
        private void CargarCategorias()
        {
            var categoraias = _categoriaServicio.ObtenerCategoria();
            categoraias.Add(_categoriaSeleccione);
            CargarCombo(categoraias);
        }


        public DataTable ConsultarCursosInicio()
        {
            var tabla = _cursoRep.recuperar();
            return tabla;
            
            //var categoria = (Categoria)TipoCategoria.SelectedItem;
            //var filtrarPorEstado = CkIncluirInactivos.Checked;
            //var cursos = _cursoServicios.ObtenerCursos(nombre, categoria.Id, filtrarPorEstado);
            //ActualizarGrilla(cursos);
        }

        private void CargarCombo(List<Categoria> categorias)
        {
            var conectorDeDatos = new BindingSource();
            conectorDeDatos.DataSource = categorias;
            TipoCategoria.DataSource = conectorDeDatos.DataSource;
            TipoCategoria.DisplayMember = "Nombre";
            TipoCategoria.ValueMember = "Id";
            TipoCategoria.SelectedItem = _categoriaSeleccione;
        }

        private void ActualizarGrilla(List<Curso> cursos)
        {
            DgvCursos.Rows.Clear();
            foreach (var curso in cursos)
            {
                var fila = new string[] {
                    curso.Id.ToString(),
                    curso.Nombre,
                    curso.Descripcion
                    
                };
                DgvCursos.Rows.Add(fila);
            }
        }
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            //_frmMenuV2.Show();
            //this.Dispose();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {

            CursoNuevo fcn = new CursoNuevo();
            fcn.Show();

        }


        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (this.DgvCursos.SelectedRows.Count != 1)
                MessageBox.Show("Debe seleccionar un curso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                var id = Convert.ToInt32(this.DgvCursos.CurrentRow.Cells[0].Value);
                var nombre = this.DgvCursos.CurrentRow.Cells[1].Value.ToString();
                var descrip = this.DgvCursos.CurrentRow.Cells[2].Value.ToString();
                ModificarCurso fmc = new ModificarCurso(id,nombre,descrip);
                fmc.Show();
            }
        }

        private void btnBuscarCursos_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(this.TxtCurso.Text) && TipoCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Debe ingresar los datos", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var cat = 0;
                var nom = 0;
                var nombre = this.TxtCurso.Text.ToString();
                var categ = Convert.ToInt32(this.TipoCategoria.SelectedValue);
                if (this.TipoCategoria.SelectedIndex == -1)
                    cat = 1;
                if (string.IsNullOrEmpty(this.TxtCurso.Text))
                    nom = 1;
                var tabla = _cursoRep.recuperarFiltrado(nom, cat, nombre, categ);
                this.DgvCursos.Rows.Clear();
                cargarGrilla(DgvCursos, tabla);
                    

            }

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (this.DgvCursos.SelectedRows.Count != 1)
                MessageBox.Show("Debe seleccionar un curso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                try
                {
                    DialogResult respuesta = MessageBox.Show("Confirmar operación?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (respuesta == DialogResult.Cancel)
                    {
                        var id_curso = Convert.ToInt32(this.DgvCursos.CurrentRow.Cells[0].Value);
                        _cursoRep.eliminarCurso(id_curso);
                        MessageBox.Show("¡Curso eliminado con exito!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
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

        private void SalirFrmListadoCursado_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DgvCursos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            if (this.DgvCursos.SelectedRows.Count != 1)
                MessageBox.Show("Debe seleccionar un curso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                int idCurso = Convert.ToInt32(this.DgvCursos.CurrentRow.Cells["id_curso"].Value);
                var tabla = _cursoRep.tieneCategoria(idCurso);
                if (tabla.Rows.Count == 1)
                    MessageBox.Show("El curso seleccionado ya tiene una categoria asignada", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {

                    var id = Convert.ToInt32(this.DgvCursos.CurrentRow.Cells[0].Value);
                    var nom = this.DgvCursos.CurrentRow.Cells[1].Value.ToString();
                    var desc = this.DgvCursos.CurrentRow.Cells[2].Value.ToString();
                    FrmAsignarCurso fr = new FrmAsignarCurso(id,nom,desc);
                    fr.Show();

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmCursoXCategoria fcc = new FrmCursoXCategoria();
            fcc.Show();
        }

        private void chkSinCateg_CheckedChanged(object sender, EventArgs e)
        {
            if(this.chkSinCateg.Checked)
            {
                this.DgvCursos.Rows.Clear();
                var tabla = _cursoRep.recuperarSinCategoria();
                cargarGrilla(DgvCursos, tabla);
            }
            else
            {
                this.DgvCursos.Rows.Clear();
                var tabla = _cursoRep.recuperar();
                cargarGrilla(DgvCursos, tabla);
            }
            
        }

        public void cargarGrilla(DataGridView grilla, DataTable tabla)
        {
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grilla.Rows.Add(tabla.Rows[i]["id_curso"],
                    tabla.Rows[i]["Nombre"],
                    tabla.Rows[i]["Descripcion"],
                    tabla.Rows[i]["fecha_vigencia"]);
            }
        }

        private void pictureBoxRefrescar_Click(object sender, EventArgs e)
        {
            this.DgvCursos.Rows.Clear();
            this.TxtCurso.Clear();
            this.TipoCategoria.SelectedIndex = -1;
            var tabla = _cursoRep.recuperar();
            cargarGrilla(this.DgvCursos, tabla);
        }

        private void CkIncluirInactivos_CheckedChanged(object sender, EventArgs e)
        {
            if(this.CkIncluirInactivos.Checked)
            {
                var tabla = _cursoRep.recuperarInac();
                this.DgvCursos.Rows.Clear();
                cargarGrilla(DgvCursos, tabla);
            }
            else
            {
                var tabla = _cursoRep.recuperar();
                this.DgvCursos.Rows.Clear();
                cargarGrilla(DgvCursos, tabla);
            }
        }

        //public void ConsultarCurso()
        //{
        //    var nombreIngresado = TxtCurso.Text;
        //    if (!string.IsNullOrEmpty(nombreIngresado) && nombreIngresado.Length > 50)
        //    {
        //        MessageBox.Show("Nombre inválido", "Error", MessageBoxButtons.OK);
        //        return;
        //    }
        //    Curso cursoIngresado = (Curso) TipoCategoria.SelectedItem;
        //    var incluirInactivos = CkIncluirInactivos.Checked;
        //    var cursos = _cursoServicios.ObtenerCursos(nombreIngresado, cursoIngresado.Id, incluirInactivos);
        //    CargarGrilla(cursos);
        //}


    }


        //private void CargarGrilla(List<Curso> cursos)
        //{
        //    DgvCursos.Rows.Clear();
        //    foreach (var curso in cursos)
        //    {
        //        var fila = new string[] {
        //            curso.Id.ToString(),
        //            curso.Nombre,
        //            curso.Descripcion
        //        };
        //        DgvCursos.Rows.Add(fila);
        //    }
        //}

        

        
    
}
