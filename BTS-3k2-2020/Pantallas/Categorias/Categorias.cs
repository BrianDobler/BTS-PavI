using BTS_3k2_2020.LogicaDeNegocio;
using BTS_3k2_2020.Modelos;
using BTS_3k2_2020.Pantallas.Perfiles2;
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

namespace BTS_3k2_2020.Pantallas.Categorias
{
    public partial class FrmCategoria : Form
    {

        private CategoriaServicio _categoriaServicio;
        private FrmMenuV2 frmMenuV2;
        private Categoria _categoria;
        private CategoriaRepositorio _categoriaRep;
        private DataTable tabla;

        public List<Categoria> categorias { get; private set; }

        public FrmCategoria(FrmMenuV2 frmMenuV2)
        {
            _categoriaServicio = new CategoriaServicio();
            _categoriaRep = new CategoriaRepositorio();
            _categoria = new Categoria();
            this.frmMenuV2 = frmMenuV2;
            //_categoria = new Categoria();
            InitializeComponent();
        }

        private bool ValidarDatos()
        {
            var nombreCategoria = TxtNombreCat.Text;
            var id_Categoria = TxtIdCat.Text;
            var descripcion = TxtDescripcion.Text;

            if (nombreCategoria == "" && id_Categoria.ToString() == "" && descripcion == "")
            {
                    return false;
            }

            return true;
        }

        public void ConsultarCategoria()
        {
            var nombreCategoria= TxtNombreCat.Text;
            var id_Categoria = TxtIdCat.Text;
            var descripcion = TxtDescripcion.Text;

        if (ValidarDatos())
            {
                if ((!string.IsNullOrEmpty(descripcion)) && (string.IsNullOrEmpty(id_Categoria) && string.IsNullOrEmpty(nombreCategoria)))
                {
                    MessageBox.Show("No puede buscar categorias solo por su descripción. \n Debe ingresar también el nombre o ID");
                    return;
                }                    
                else
                {
                    _categoriaServicio = new CategoriaServicio();
                    var categorias = _categoriaServicio.ConsultarCategoria(id_Categoria, nombreCategoria, descripcion);
                    ActualizarGrilla(categorias);
                }            
            }
            else
            {
                MessageBox.Show("No ingresa Nombre tampoco ID","",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }


        }

        private void ActualizarGrilla(List<Categoria> categorias)
        {
        DgvCategoria.Rows.Clear();
            foreach (var categoria in categorias)
            {
            var fila = new string[] { categoria.Id.ToString(), categoria.Nombre, categoria.Descripcion };
                DgvCategoria.Rows.Add(fila);
            }
        }

        private void btnBuscarCategoria_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                ConsultarCategoria();
            }
            else
            {
                MessageBox.Show("Introduzca ID o nombre corto o descripción");
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(this.TxtDescripcion.Text) || string.IsNullOrEmpty(this.TxtNombreCat.Text))
            {
                
                MessageBox.Show("No se ingresaron los datos necesarios (EL ID NO SERA TOMADO)", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.TxtNombreCat.Focus();
            }
            else
            {
                
                this.DgvCategoria.Rows.Clear();
                tabla = _categoriaRep.recuperarCat();
                var tablaAux = new DataTable();
                tablaAux = _categoriaRep.recuperarCatAux();
                var id = tablaAux.Rows.Count + 1;

                _categoriaRep.RegistrarCategoria(id,this.TxtNombreCat.Text, this.TxtDescripcion.Text);

                MessageBox.Show("Se añadio con exito", "Agregar descuento", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DgvCategoria.Rows.Clear();
                tabla = _categoriaRep.recuperarCat();
                cargarGrilla(this.DgvCategoria, tabla);
            }
            //if (ValidarDatos())
            //{
            //    if (string.IsNullOrEmpty(this.TxtIdCat.Text) || (string.IsNullOrEmpty(this.TxtNombreCat.Text)))
            //    {
            //        MessageBox.Show("Falta ingresar el nombre o el ID","",MessageBoxButtons.OK,MessageBoxIcon.Information);
            //    }
            //    else
            //    {
            //        _categoria.Id = Convert.ToInt32(TxtIdCat.Text);
            //        _categoria.Nombre = TxtNombreCat.Text;
            //        _categoria.Descripcion = TxtDescripcion.Text;
            //        try
            //        {
            //            if (!ConfirmarOperacion())
            //                return;
            //            RegistrarCategoriaNew();
            //            this.DgvCategoria.Rows.Clear();
            //            string consulta = "SELECT id_categoria,nombre,descripcion from Categorias where borrado=0";
            //            var tabla = DBHelper.GetDBHelper().ConsultaSQL(consulta);
            //            cargarGrilla(this.DgvCategoria, tabla);
            //        //ActualizarGrilla(_categoriaServicio.ObtenerCategoria());
            //    }

            //        catch (ApplicationException aex)
            //    {
            //        MessageBox.Show(aex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }

            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("Ha occurrido un problema.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}                
            //}
            //else
            //{
            //    MessageBox.Show("Ingrese todos los datos","",MessageBoxButtons.OK,MessageBoxIcon.Information);
            //}
        }

        private bool ConfirmarOperacion()
        {
            DialogResult resultado = MessageBox.Show("Confirmar Operacion", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (resultado == DialogResult.Cancel)
                return false;
            return true;
        }

        //private void RegistrarCategoria()
        //{   
        //    DataTable tabla =_categoriaServicio.RegistrarCategoria(_categoria);
        //    if(tabla.Rows.Count==1)
        //        MessageBox.Show($"La operacion se realizo con exito");

        //}
        //private void RegistrarCategoriaNew()
        //{
        //    var nombre = this.TxtNombreCat.Text;
        //    var id = Convert.ToInt32(this.TxtIdCat.Text);
        //    var descripcion = this.TxtDescripcion.Text;
        //    _categoriaRep.RegistrarCategoria(nombre,descripcion);
        //}

        public void cargarGrilla(DataGridView grilla, DataTable tabla)
        {
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grilla.Rows.Add(tabla.Rows[i]["id_categoria"],
                    tabla.Rows[i]["nombre"],
                    tabla.Rows[i]["descripcion"]);
            }
        }
        private void FrmCategorias_Load(object sender, EventArgs e)
        {
            
            DataTable tabla = _categoriaRep.recuperarCat();
            cargarGrilla(this.DgvCategoria, tabla);
            
        }

        private void BtnDarBaja_Click(object sender, EventArgs e)
        {
            var categoria = new Categoria();

            {
                if (DgvCategoria.SelectedRows.Count == 1)
                {
                    categoria.Id = Convert.ToInt32(DgvCategoria.SelectedRows[0].Cells[0].Value.ToString());
                    if (_categoriaServicio.EliminarCategoria(categoria) == 1)
                    {
                        var categorias = _categoriaServicio.ObtenerTodos();
                        MessageBox.Show("¡Eliminado con exito el ID " + categoria.Id +" !" , "Eliminar Categoria", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        var id_desc = (int)DgvCategoria.CurrentRow.Cells[0].Value;
                        this.DgvCategoria.Rows.Clear();
                        tabla = _categoriaRep.recuperarCat();
                        cargarGrilla(this.DgvCategoria, tabla);
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un por favor");
                }
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (this.DgvCategoria.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe Seleccionar la categoria que desea Modificar", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);

            }
            else
            {
                var idCategoria = (int)DgvCategoria.CurrentRow.Cells[0].Value;
                var nom = DgvCategoria.CurrentRow.Cells[1].Value.ToString();
                var des = DgvCategoria.CurrentRow.Cells[2].Value.ToString();
                ModificarCategoria formularioModificar = new ModificarCategoria(idCategoria, nom, des);
                formularioModificar.ShowDialog();
            }
        }

        private void pictureBoxRefrescar_Click(object sender, EventArgs e)
        {
            this.DgvCategoria.Rows.Clear();
            this.TxtIdCat.Clear();
            this.TxtNombreCat.Clear();
            this.TxtDescripcion.Clear();
            tabla = _categoriaRep.recuperarCat();
            cargarGrilla(this.DgvCategoria, tabla);
        }

        private void ChkIncluirInactivos_CheckedChanged(object sender, EventArgs e)
        {
            if (this.ChkIncluirInactivos.Checked)
            {
                this.DgvCategoria.Rows.Clear();
                tabla = _categoriaRep.recuperarCatInac();
                cargarGrilla(DgvCategoria, tabla);
            }
            else
            {
                this.DgvCategoria.Rows.Clear();
                tabla = _categoriaRep.recuperarCat();
                cargarGrilla(DgvCategoria, tabla);
            }
               
        }

        private void SalirFrmListadoUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtIdCat_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void BtnDarBaja_Click_1(object sender, EventArgs e)
        {
            var categoria = new Categoria();

            {
                if (DgvCategoria.SelectedRows.Count == 1)
                {
                    DialogResult confirm = MessageBox.Show("¿ESTA SEGURO QUE DESEA ELIMINAR?", "Eliminar descuento", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (confirm == DialogResult.Yes)
                    {
                        categoria.Id = Convert.ToInt32(DgvCategoria.SelectedRows[0].Cells[0].Value.ToString());
                        var id_desc = Convert.ToInt32(DgvCategoria.CurrentRow.Cells[0].Value);
                        var tablaEstaAsignado = _categoriaRep.estaAsignado(id_desc);
                        if (Convert.ToInt32(tablaEstaAsignado.Rows.Count) == 0)
                        {
                            if (_categoriaServicio.EliminarCategoria(categoria) == 1)
                            {
                                var categorias = _categoriaServicio.ObtenerTodos();
                                MessageBox.Show("¡Eliminado con exito el ID " + categoria.Id + " !", "Eliminar Categoria", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                //var id_desc = (int)DgvCategoria.CurrentRow.Cells[0].Value;
                                this.DgvCategoria.Rows.Clear();
                                tabla = _categoriaRep.recuperarCat();
                                cargarGrilla(this.DgvCategoria, tabla);
                            }
                        }
                        else
                        {
                            MessageBox.Show("¡No se puede eliminar una categoría que ya posee cursos!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un por favor");
                }
            }
        }
    }
}



