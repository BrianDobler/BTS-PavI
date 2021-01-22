using BTS_3k2_2020.Modelos;
using BTS_3k2_2020.Pantallas.Asignaciones;
using BTS_3k2_2020.Pantallas.Categorias;
using BTS_3k2_2020.Pantallas.Cursos;
using BTS_3k2_2020.Pantallas.Objetivos;
using BTS_3k2_2020.Pantallas.Perfiles2;
using BTS_3k2_2020.Pantallas.Sueldos;
using BTS_3k2_2020.Pantallas.Usuarios;
using BTS_3k2_2020.Pantallas.Reportes.RepAsignaciones;
using BTS_3k2_2020.Pantallas.Reportes.RepCategorias;
using BTS_3k2_2020.Pantallas.Reportes.RepCursos;
using BTS_3k2_2020.Pantallas.Reportes.RepDescuento;
using BTS_3k2_2020.Pantallas.Reportes.RepObjetivos;
using BTS_3k2_2020.Pantallas.Reportes.RepPerfiles;
using BTS_3k2_2020.Pantallas.Reportes.RepSueldos;
using BTS_3k2_2020.Pantallas.Reportes.RepUsuarios;
using BTS_3k2_2020.Servicios;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using BTS_3k2_2020.Pantallas.Reportes;
using BTS_3k2_2020.Pantallas.UsuariosXCursos;

namespace BTS_3k2_2020.Pantallas
{

    public partial class FrmMenuV2 : Form
    {
        
        public FrmMenuV2()
        {
            InitializeComponent();
            customizeDesing();
        }

        private void FrmMenuV2_Load(object sender, EventArgs e)
        {
            new CargaDeFormulario().ShowDialog();
            new FrmLogin().ShowDialog();
            lblUtn_Click(null, e);
            this._usuario = UsuarioServicio.UsuarioLogueado; //falta label para mostrar usuario en pantalla
            this.lblUsuario.Text = this._usuario.Nombre;
            this.lblPerfil.Text = this._usuario.Perfiles2;

        }
        private void FrmPantallaIncial_Load(object sender, EventArgs e)
        {
            lblUtn_Click(null, e);
        }
  

        #region SubMenu ocutlo
        //Se OcultanSubMenu
        private void customizeDesing()
        {
            panelSubMenuGestionUsuarios.Visible = false;
            panelSubMenuCursos.Visible = false;
            panelSubMenuGestionSueldos.Visible = false;
            panelSubMenuReportes.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelSubMenuGestionUsuarios.Visible == true) 
                panelSubMenuGestionUsuarios.Visible = false;
            if (panelSubMenuCursos.Visible == true)
                panelSubMenuCursos.Visible = false;
            if (panelSubMenuGestionSueldos.Visible == true)
                panelSubMenuGestionSueldos.Visible = false;
            if (panelSubMenuReportes.Visible == true)
                panelSubMenuReportes.Visible = false;

        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btnGestionDeUsuarios_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuGestionUsuarios);
        }
        #region SUBFORMULARIOS
        //ABRIR SUBFORMULARIOS EN PANEL PRINCIPAL
        private void AbrirFormEnPanel(object Formhijo)
        {
            if (this.PanelPrincipalDeForm.Controls.Count > 0)
                this.PanelPrincipalDeForm.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelPrincipalDeForm.Controls.Add(fh);
            this.PanelPrincipalDeForm.Tag = fh;
            fh.Show();
        }
        #endregion
        private void btnListadoDeUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmUsuarios(this));
            /// Aca van las invocaciones a formularios
            //var formularioUsuarios = new FrmUsuarios(this);
            //formularioUsuarios.Show();
            // this.Hide();
            hideSubMenu();
        }

        private void btnConfigUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmUsuariosXCursos());
            //new FrmUsuariosXCursos().Show();
            /// Aca van las invocaciones a formularios
            hideSubMenu();
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            /// Aca van las invocaciones a formularios
            AbrirFormEnPanel(new FrmPerfilesV2(this));
            hideSubMenu();
        }

        private void btnCursos_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuCursos);
        }

        private void btnListadoCursos_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new CursosFrm(this));
            /// Aca van las invocaciones a formularios
            hideSubMenu();
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmCategoria(this));
            /// Aca van las invocaciones a formularios
            hideSubMenu();
        }

        private void btnObjetivosPorCurso_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmObjetivos(this));
            /// Aca van las invocaciones a formularios
            hideSubMenu();
        }

        private void btnUsuariosPorCurso_Click(object sender, EventArgs e)
        {
            /// Aca van las invocaciones a formularios
            hideSubMenu();
        }

        private void btnGestionDeSueldos_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuGestionSueldos);
        }

        private void btnSueldos_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmSueldos());
            /// Aca van las invocaciones a formularios
            hideSubMenu();
        }

        private void btnSueldosPorUsuarios_Click(object sender, EventArgs e)
        {
            /// Aca van las invocaciones a formularios
            hideSubMenu();
        }

        private void btnDescuentos_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmDescuentos());
            /// Aca van las invocaciones a formularios
            hideSubMenu();
        }

        private void btnAsignaciones_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmAsignaciones());
            /// Aca van las invocaciones a formularios
            hideSubMenu();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuReportes);
        }

        private void btnReporte1_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Informes());
            /// Aca van las invocaciones a formularios
            hideSubMenu();
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("USUARIO: Para una mejor experiencia a la hora visualizar cada ventana, por favor tenga en cuanta " +
                "maximizar la ventana princial.." +
                "                           " +
                "                           " +
                "                           " +
                "                           " +
                "           Muchas Gracias!", "Help", MessageBoxButtons.OK) == DialogResult.OK)
            {
                lblUtn_Click(null, e);
            }
            /// Aca van las invocaciones a formularios
            hideSubMenu();
        }


        #endregion 


        #region Funcionalidades del formulario
        //RESIZE METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO EN TIEMPO DE EJECUCION ----------------------------------------------------------
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;


        protected override void WndProc(ref Message m)
        {
        switch (m.Msg)
            {
            case WM_NCHITTEST:
                base.WndProc(ref m);
                var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                if (sizeGripRectangle.Contains(hitPoint))
                    m.Result = new IntPtr(HTBOTTOMRIGHT);
                break;
            default:
                base.WndProc(ref m);
                break;
            }
        }
    //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
    protected override void OnSizeChanged(EventArgs e)
    {
        base.OnSizeChanged(e);
        var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));

        sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);

        region.Exclude(sizeGripRectangle);
        this.panelContenedor.Region = region;
        this.Invalidate();
    }

        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR


        protected override void OnPaint(PaintEventArgs e)
        {
            
                SolidBrush blueBrush = new SolidBrush(Color.FromArgb(9, 22, 34));
                e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);

                base.OnPaint(e);
                ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
            
        }
        //METODO PARA ARRASTRAR EL FORMULARIO---------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelBarraSup_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de cerrar el programa?", "Alerta!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();

            }
        }
        //Capturar posicion y tamaño antes de maximizar para restaurar
        int lx, ly;
        int sw, sh;
        private object logoLogo;
        private object panelUser;

        public Usuario _usuario { get; private set; }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }
        
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
        }

        private void menuSideBarDespl_Click(object sender, EventArgs e)
        {
            if (menuVertical.Visible == false || menuVertical.Width == 60 )
            {
                menuVertical.Visible = true;
                menuVertical.Width = 250;
                panelSubMenuGestionUsuarios.Visible = false;
                panelSubMenuCursos.Visible = false;
                panelSubMenuGestionSueldos.Visible = false;
                panelSubMenuReportes.Visible = false;
                
            }
            else
                menuVertical.Width = 60;



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void doubleBitmapControl1_Click(object sender, EventArgs e)
        {

        }

        //mostrar fecha y hora del sistema

        private void HoraFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateAndTime.Now.ToLongTimeString();
            lblFecha.Text = DateAndTime.Now.ToString("dd MMMM, yyyy");
        }

        private void bunifuSeparator1_Load(object sender, EventArgs e)
        {

        }

        private void lblUtn_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmLogo(this));
        }

        private void panelPantallaPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnUtn_Click(object sender, EventArgs e)
        {
            lblUtn_Click(null, e);
        }

        private void lblFecha_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void modoOscuro()
        {
            menuVertical.BackColor = Color.FromArgb(222, 20, 60);
            panelBarraSup.BackColor = Color.FromArgb(9, 22, 34);
            lblPav.BackColor = Color.FromArgb(9, 22, 34);
            lblPav.ForeColor = Color.FromArgb(252, 252, 252);
            panelInferiorInfo.BackColor = Color.FromArgb(9, 22, 34);
            lblHora.ForeColor = Color.FromArgb(181, 207, 239);
            lblUtn.ForeColor = Color.FromArgb(181, 207, 239);
            label3.ForeColor = Color.FromArgb(181, 207, 239);
            txtNombre.ForeColor = Color.FromArgb(181, 207, 239);
            lblUsuario.ForeColor = Color.FromArgb(181, 207, 239);
            panelSubMenuGestionUsuarios.BackColor= Color.FromArgb(251, 191, 193);
            panelSubMenuCursos.BackColor = Color.FromArgb(251, 191, 193);
            panelSubMenuGestionSueldos.BackColor = Color.FromArgb(251, 191, 193);
            panelSubMenuReportes.BackColor = Color.FromArgb(251, 191, 193);

        }
        private void btnDarkMode_Click(object sender, EventArgs e)
        {
            btnLightMode.Visible = false;
            btnDarkMode.Visible = true;
            if (btnLightMode.Visible == true)
            {
                
                modoOscuro();

            }

            else
                modoClaro();

        }

        private void modoClaro()
        {
            menuVertical.BackColor = Color.FromArgb(97, 108, 136);
            panelBarraSup.BackColor = Color.FromArgb(167, 180, 205);
            lblPav.BackColor = Color.FromArgb(167, 180, 205);
            lblPav.ForeColor = Color.FromArgb(9, 22, 34);
            panelInferiorInfo.BackColor = Color.FromArgb(167, 180, 205);
            lblHora.ForeColor = Color.FromArgb(9, 22, 34);
            lblUtn.ForeColor = Color.FromArgb(9, 22, 34);
            label3.ForeColor = Color.FromArgb(9, 22, 34);
            txtNombre.ForeColor = Color.FromArgb(9, 22, 34);
            lblUsuario.ForeColor = Color.FromArgb(9, 22, 34);
            btnSueldos.BackColor = Color.FromArgb(167, 180, 205);
            panelSubMenuGestionUsuarios.BackColor = Color.FromArgb(167, 180, 205);
            panelSubMenuCursos.BackColor = Color.FromArgb(167, 180, 205);
            panelSubMenuGestionSueldos.BackColor = Color.FromArgb(167, 180, 205);
            panelSubMenuReportes.BackColor = Color.FromArgb(167, 180, 205);

        }

        private void btnLightMode_Click_1(object sender, EventArgs e)
        {
            btnLightMode.Visible = true;
            btnDarkMode.Visible = false;
            if (btnLightMode.Visible == true)
            {
                
                modoOscuro();
            }

            else
                modoClaro();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panelInferiorInfo_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}

