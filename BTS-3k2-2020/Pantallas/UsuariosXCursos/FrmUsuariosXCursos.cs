using BTS_3k2_2020.LogicaDeNegocio;
using BTS_3k2_2020.Modelos;
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

namespace BTS_3k2_2020.Pantallas.UsuariosXCursos
{
    public partial class FrmUsuariosXCursos : Form
    {
        private UsuariosXCursosServicio _usuariosXcursosServicio;
        private Curso _seleccionar;
        public FrmUsuariosXCursos()
        {
            _seleccionar = new Curso();
            _usuariosXcursosServicio = new UsuariosXCursosServicio();
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmUsuariosXCursos_Load(object sender, EventArgs e)
        {
            ConsultarUsuariosXCursos();
            CargarCursos();
        }

        private void CargarCursos()
        {
            var cursos = _usuariosXcursosServicio.ObtenerCursos();
            var cursoSeleccionar = new Curso();
            cursoSeleccionar.Nombre = "Seleccionar";
            cursos.Add(cursoSeleccionar);
            var conector = new BindingSource();
            conector.DataSource = cursos;
            FormUtils.CargarCombo(ref CbCursos, conector, "Nombre", "Id");
            var seleccionar = cursos.First(u => u.Id == 0);
            _seleccionar = seleccionar;
            CbCursos.SelectedItem = seleccionar;

        }

        public void ConsultarUsuariosXCursos()
        {
            var usuariosXcursos = _usuariosXcursosServicio.ObtenerUsuariosXCursos();
            CargarGrilla(usuariosXcursos);
        }

        private void CargarGrilla(List<UsuarioXCurso> usuariosXcursos)
        {
            DgvUsuariosXCursos.Rows.Clear();
            foreach (var usuarioXcurso in usuariosXcursos)
            {
                //sueldo.Sueldo_bruto
                var fila = new string[]{
                    //usuarioXcurso.Usuario.Id.ToString(),
                    usuarioXcurso.Usuario.Id.ToString(),
                    usuarioXcurso.Usuario.Nombre.ToString(),
                    usuarioXcurso.Curso.Id.ToString(),
                    usuarioXcurso.Curso.Nombre.ToString(),
                    usuarioXcurso.Puntuacion.ToString(),
                    usuarioXcurso.Observaciones.ToString(),
                    usuarioXcurso.Fecha_Inicio.ToString("dd/MM/yyyy"),
                    usuarioXcurso.Fecha_Fin.ToString("dd/MM/yyyy"),
                };
                DgvUsuariosXCursos.Rows.Add(fila);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nombreIngresado = null;
            long cursoIdIngresado = 0;
            long puntuacionIngresada = 0;
            var cursoId = ((Curso)CbCursos.SelectedItem).Id;
            if (!String.IsNullOrEmpty(TxtNombreUsuario.Text))
            {
                nombreIngresado = TxtNombreUsuario.Text;
            }
            if (cursoId != 0)
            {
                cursoIdIngresado = cursoId;
            }
            if (!String.IsNullOrEmpty(TxtPuntaje.Text))
            {
                puntuacionIngresada = Convert.ToInt32(TxtPuntaje.Text);
            }
            ConsultarUsuariosXCursos(nombreIngresado, cursoIdIngresado, puntuacionIngresada);
        }

        private void ConsultarUsuariosXCursos(string nombreUsuario, long cursoId, long puntuacion)
        {
            var uxc = _usuariosXcursosServicio.ObtenerUsuariosXCursos(nombreUsuario, cursoId, puntuacion);
            CargarGrilla(uxc);
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            new FrmNuevoUsuarioXCurso(this).Show();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (DgvUsuariosXCursos.SelectedRows.Count == 1)
            {
                var id_usuario = Convert.ToInt32(DgvUsuariosXCursos.SelectedRows[0].Cells["id_usuario"].Value.ToString());
                var id_curso = Convert.ToInt32(DgvUsuariosXCursos.SelectedRows[0].Cells["id_curso"].Value.ToString());
                new FrmModificarUsuarioXCurso(this, id_usuario, id_curso).Show();
            }
            else
                MessageBox.Show("Debe seleccionar solo una fila");
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (DgvUsuariosXCursos.SelectedRows.Count == 1)
            {
                var id_usuario = Convert.ToInt32(DgvUsuariosXCursos.SelectedRows[0].Cells["id_usuario"].Value.ToString());
                var id_curso = Convert.ToInt32(DgvUsuariosXCursos.SelectedRows[0].Cells["id_curso"].Value.ToString());
                new FrmEliminarUsuarioXCurso1(this, id_usuario, id_curso).Show();
            }
            else
                MessageBox.Show("Debe seleccionar solo una fila");
        }

        private void DgvUsuariosXCursos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SalirFrmListadoUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxRefrescar_Click(object sender, EventArgs e)
        {
            this.DgvUsuariosXCursos.Rows.Clear();
            this.TxtNombreUsuario.Clear();
            this.CbCursos.SelectedItem = _seleccionar;
            this.TxtPuntaje.Clear();
            ConsultarUsuariosXCursos();
        }
    }
}
