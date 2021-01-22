using BTS_3k2_2020.Pantallas.Reportes.EstAsignaciones;
using BTS_3k2_2020.Pantallas.Reportes.EstCategorias;
using BTS_3k2_2020.Pantallas.Reportes.EstCursos;
using BTS_3k2_2020.Pantallas.Reportes.EstDescuentos;
using BTS_3k2_2020.Pantallas.Reportes.EstObjetivos;
using BTS_3k2_2020.Pantallas.Reportes.EstPerfiles;
using BTS_3k2_2020.Pantallas.Reportes.EstSueldos;
using BTS_3k2_2020.Pantallas.Reportes.EstUsuarios;
using BTS_3k2_2020.Pantallas.Reportes.RepAsignaciones;
using BTS_3k2_2020.Pantallas.Reportes.RepCategorias;
using BTS_3k2_2020.Pantallas.Reportes.RepCursos;
using BTS_3k2_2020.Pantallas.Reportes.RepDescuento;
using BTS_3k2_2020.Pantallas.Reportes.RepObjetivos;
using BTS_3k2_2020.Pantallas.Reportes.RepPerfiles;
using BTS_3k2_2020.Pantallas.Reportes.RepSueldos;
using BTS_3k2_2020.Pantallas.Reportes.RepUsuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTS_3k2_2020.Pantallas.Reportes
{
    public partial class Informes : Form
    {
        public Informes()
        {
            InitializeComponent();
        }

        private void btnInfoAsginaciones_Click(object sender, EventArgs e)
        {
            var fr = new FrmListadoAsignaciones(this);
            fr.Show();
        }

        private void btnInfoDescuentos_Click(object sender, EventArgs e)
        {
            var fr = new FrmListadoDescuentos(this);
            fr.Show();
        }

        private void btnInfoSueldos_Click(object sender, EventArgs e)
        {
            var fr = new FrmListadoSueldos(this);
            fr.Show();
        }

        private void btnInfoObjetivos_Click(object sender, EventArgs e)
        {
            var fr = new FrmListadoObjetivos(this);
            fr.Show();
        }

        private void btnInfoCategorias_Click(object sender, EventArgs e)
        {
            var fr = new FrmListadoCategorias(this);
            fr.Show();
        }

        private void btnInfoCursos_Click(object sender, EventArgs e)
        {
            var fr = new FrmListadoCursos(this);
            fr.Show();
        }

        private void btnInfoPerfiles_Click(object sender, EventArgs e)
        {
            var fr = new FrmListadoPerfiles(this);
            fr.Show();
        }

        private void btnInfoUsuarios_Click(object sender, EventArgs e)
        {
            var fr = new FrmListadoUsuarios(this);
            fr.Show();
        }

        private void btnEstadUsuario_Click(object sender, EventArgs e)
        {
            var fr = new FrmEstUsuarios(this);
            fr.Show();
        }

        private void btnEstadPerfiles_Click(object sender, EventArgs e)
        {
            var fr = new FrmEstPerfiles(this);
            fr.Show();
        }

        private void btnEstadCursos_Click(object sender, EventArgs e)
        {
            var FR = new FrmEstCursos(this);
            FR.Show();
        }

        private void btnEstadCategorias_Click(object sender, EventArgs e)
        {
            var fr = new FrmEstCategorias(this);
            fr.Show();
        }

        private void btnEstadObjetivos_Click(object sender, EventArgs e)
        {
            var fr = new FrmEstObjetivos(this);
            fr.Show();
        }

        private void btnEstadSueldos_Click(object sender, EventArgs e)
        {
            var fr = new FrmEstSueldos(this);
            fr.Show();
        }

        private void btnEstadDescuentos_Click(object sender, EventArgs e)
        {
            var fr = new FrmEstDescuentos(this);
            fr.Show();
        }

        private void btnEstadAsignaciones_Click(object sender, EventArgs e)
        {
            var fr = new FrmEstAsignaciones(this);
            fr.Show();
        }
    }
}
