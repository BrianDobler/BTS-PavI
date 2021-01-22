using BTS_3k2_2020.Modelos;
using BTS_3k2_2020.Servicios;
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

namespace BTS_3k2_2020.Pantallas.Usuarios
{
    public partial class FrmUsuarios : Form
    {
        private UsuarioServicio _usuarioServicio;
        private PerfilesServicio _perfilesServicio;
        private UsuariosRepositorio _usuarioRep;
        private Perfil _perfilSeleccione = new Perfil() { Nombre = "Seleccione" };

        private FrmMenuV2 frmMenuV2;
        private DataTable tabla;

        public FrmUsuarios(FrmMenuV2 frmMenuV2)
        {
            _usuarioRep = new UsuariosRepositorio();
            _usuarioServicio = new UsuarioServicio();
            _perfilesServicio = new PerfilesServicio();


            this.frmMenuV2 = frmMenuV2;
            InitializeComponent();
        }

        private void DgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            CargarPerfiles();
            ConsultarUsuarios();
        }

        //private void CargarPerfiles()
        //{
        //    var perfiles = _perfilesServicio.ObtenerTodos();
        //    var conector = new BindingSource();
        //    conector.DataSource = perfiles;
        //    TipoPerfil.DataSource = conector;
        //    TipoPerfil.DisplayMember = "Nombre";
        //    TipoPerfil.ValueMember = "Id";
        //    
        //    //perfiles.Add(_perfilSeleccione);
        //    //CargarCombo(perfiles);
        //}

        private void CargarPerfiles()
        {
            var perfiles = _perfilesServicio.ObtenerTodos();
            perfiles.Add(_perfilSeleccione);
            CargarCombo(perfiles);
        }

        public void ConsultarUsuarios()
        {
            var nombre = TxtNombre.Text;
            var perfil = (Perfil)TipoPerfil.SelectedItem;
            if (string.IsNullOrEmpty(TxtNombre.Text) && TipoPerfil.SelectedIndex == -1)
                MessageBox.Show("¡Debe ingresar algun dato o seleccionar un perfil!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                var filtrarPorEstado = ChkIncluirInactivos.Checked;
                
                var usuarios = _usuarioServicio.ObtenerUsuarios(nombre, perfil.Id, filtrarPorEstado);
                ActualizarGrilla(usuarios);
            }
            
        }



        private void CargarCombo(List<Perfil> perfiles)
        {
            var conectorDeDatos = new BindingSource();
            conectorDeDatos.DataSource = perfiles;
            TipoPerfil.DataSource = conectorDeDatos.DataSource;
            TipoPerfil.DisplayMember = "Nombre";
            TipoPerfil.ValueMember = "Id";
            TipoPerfil.SelectedItem = _perfilSeleccione;
        }

        private void ActualizarGrilla(List<Usuario> usuarios)
        {
            DgvCursos.Rows.Clear();
            foreach (var usuario in usuarios)
            {
                var fila = new string[] {
                    usuario.Id.ToString(),
                    usuario.Nombre,
                    usuario.Email
                };
                DgvCursos.Rows.Add(fila);
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (DgvCursos.SelectedRows.Count == 1)
            {
                var id = Convert.ToInt64(DgvCursos.SelectedRows[0].Cells["Id"].Value.ToString());
                new FrmModificar(this, id).Show();
                //this.Hide();
            }
            else
                MessageBox.Show("Debe seleccionar un usuario", "Información");
        }

        private void ChkIncluirInactivos_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void BtnDarBaja_Click(object sender, EventArgs e)
        {
            
                if (DgvCursos.SelectedRows.Count == 1)
                {
                    var id = Convert.ToInt64(DgvCursos.CurrentRow.Cells["Id"].Value.ToString());
                    //var id = Convert.ToInt64(DgvCursos.SelectedRows[0].Cells["Id"].Value.ToString());
                    new FrmEliminar(this, id).Show();
                    //this.Hide();
                }
                else
                    MessageBox.Show("Debe seleccionar solo una fila", "Información");
            
        }

        private void lblNombreUs_Click(object sender, EventArgs e)
        {

        }

        private void btnSalirUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
          
        }
        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            ConsultarUsuarios();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new NuevoUsuario(this).Show();
            //this.Hide();
        }

        private void PanelUser_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.DgvCursos.Rows.Clear();
            this.TxtNombre.Clear();
            this.TipoPerfil.SelectedItem = _perfilSeleccione;
            tabla = _usuarioRep.recuperar();
            cargarGrilla(this.DgvCursos, tabla);
        }
        public void cargarGrilla(DataGridView grilla, DataTable tabla)
        {
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grilla.Rows.Add(tabla.Rows[i]["id_usuario"],
                    tabla.Rows[i]["usuario"],
                    tabla.Rows[i]["email"]);
            }
         }
    }
}

