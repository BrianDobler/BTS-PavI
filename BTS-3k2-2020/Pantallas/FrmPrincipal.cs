using BTS_3k2_2020.Modelos;

using BTS_3k2_2020.Pantallas.Cursos;
using BTS_3k2_2020.Pantallas.Usuarios;
using BTS_3k2_2020.Servicios;
using System;
using System.Drawing.Text;
using System.Windows.Forms;

namespace BTS_3k2_2020.Pantallas
{
    public partial class FrmPrincipal : Form
    {
        private Usuario _usuario;
       // private FrmLogin _login;
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        //public FrmPrincipal(FrmLogin frm)
       // {
         //   InitializeComponent();
         //   _login = frm; 
       // }


        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            //new FrmLogin().ShowDialog();
            //this._usuario = UsuarioServicio.UsuarioLogueado;
            this.lblUsuario.Text = this._usuario.Nombre;

        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //var formularioUsuarios = new FrmUsuarios(this);
            //formularioUsuarios.Show();
            //this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listadoDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formularioUsuarios = new FrmUsuarios(this);
            formularioUsuarios.Show();
            this.Hide();
        }



        private void descuentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDescuentos fd = new FrmDescuentos();
            fd.Show();
            this.Hide();
        }
        

        private void listadoDeCursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formularioCursos = new ListadoCursos(this);
            formularioCursos.Show();
            this.Hide();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)

        {
            //var formularioCategorias = new FrmCategoria(this);
            //formularioCategorias.Show();
            //var formularioPerfiles = new FrmPerfiles(this);
            //formularioPerfiles.Show();


        }

        private void perfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void perfilToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void gestiónDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    } 
}