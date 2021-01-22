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


namespace BTS_3k2_2020.Pantallas.Asignaciones
{
    public partial class FrmAsigXSueldo : Form
    {
        SueldoAsignacionRepositorio oSAsignacion = new SueldoAsignacionRepositorio();
        DataTable tabla = new DataTable();
        int filas = -1;
        public FrmAsigXSueldo()
        {
            InitializeComponent();
        }

        private void CerrarFormulario()
        {
            //FrmMenuV2 fds = new FrmMenuV2();
            this.Dispose();
            //fds.Show();
        }

        private void FrmAsigXSueldo_FormClosing(object sender, FormClosingEventArgs e)
        {
            CerrarFormulario();
        }

        private void FrmAsigXSueldo_Load(object sender, EventArgs e)
        {
            this.ckbFecha.Checked = false;
            this.dtpFecha.Enabled = false;
            tabla = oSAsignacion.recuperarAsignacionesPorSueldos();
            cargarGrilla(this.descSueldos, tabla);

            if (this.descSueldos.Rows.Count == 1)
            {

                MessageBox.Show("No hay información almacenada para mostrar", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                filas = 0;
            }
        }
        public void cargarGrilla(DataGridView grilla, DataTable tabla)
        {
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grilla.Rows.Add(tabla.Rows[i]["usuario"],
                    tabla.Rows[i]["n_asignacion"],
                    tabla.Rows[i]["fecha"],
                    tabla.Rows[i]["monto"],
                    tabla.Rows[i]["cantidad"]);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //if ((!(this.ckbFecha.Checked)) && string.IsNullOrEmpty(this.txtNombreUsuario.Text) && string.IsNullOrEmpty(this.txtNombreAsignacion.Text)
            //    && string.IsNullOrEmpty(this.txtMonto.Text) && string.IsNullOrEmpty(this.txtCantidad2.Text))
            //{
            //    MessageBox.Show("No se ingresaron datos para realizar la busqueda", "Error ingreso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else
            //{
            //    if (this.dtpFecha.Enabled)
            //    {
            //        this.descSueldos.Rows.Clear();
            //        tabla = oSAsignacion.recuperarAsignacionesPorSueldosFiltradas(this.txtNombreUsuario.Text, this.txtNombreAsignacion.Text, this.txtMonto.Text, this.txtCantidad2.Text, this.dtpFecha.Value, bandera: true);
            //        cargarGrilla(this.descSueldos, tabla);
            //    }
            //    else
            //    {
            //        this.descSueldos.Rows.Clear();
            //        tabla = oSAsignacion.recuperarAsignacionesPorSueldosFiltradas(this.txtNombreUsuario.Text, this.txtNombreAsignacion.Text, this.txtMonto.Text, this.txtCantidad2.Text, this.dtpFecha.Value);
            //        cargarGrilla(this.descSueldos, tabla);
            //    }

            //    if (this.descSueldos.Rows.Count == 1)
            //    {
            //        MessageBox.Show("No se encontraron coincidencias", "Buscar sueldo por asignación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        tabla = oSAsignacion.recuperarAsignacionesPorSueldos();
            //        this.cargarGrilla(descSueldos, tabla);
            //    }
            //}
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            if (filas == 0)
            {
                this.descSueldos.Rows.Clear();
                this.txtMonto.Clear();
                this.txtNombreUsuario.Clear();
                this.txtNombreAsignacion.Clear();
                this.txtCantidad2.Clear();
                this.txtMonto.Clear();
                this.dtpFecha.Value = DateTime.Today;
                tabla = oSAsignacion.recuperarAsignacionesPorSueldos();
                this.txtNombreUsuario.Focus();
            }
            else
            {
                this.descSueldos.Rows.Clear();
                this.txtMonto.Clear();
                this.txtNombreUsuario.Clear();
                this.txtNombreAsignacion.Clear();
                this.txtCantidad2.Clear();
                this.txtMonto.Clear();
                this.dtpFecha.Value = DateTime.Today;
                tabla = oSAsignacion.recuperarAsignacionesPorSueldos();
                cargarGrilla(this.descSueldos, tabla);
                this.txtNombreUsuario.Focus();
            }
        }

        private void ckbFecha_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbFecha.Checked)
            {
                this.dtpFecha.Enabled = true;
            }
            if (!ckbFecha.Checked)
            {
                this.dtpFecha.Enabled = false;
            }
        }
        //METODO PARA ARRASTRAR EL FORMULARIO---------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void FrmAsigXSueldo_MouseMove(object sender, MouseEventArgs e)
        {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            
        }
        private void dtbAsigSueld_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscarDescuento_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCantidad2.Text) && string.IsNullOrEmpty(txtNombreAsignacion.Text) && string.IsNullOrEmpty(txtNombreUsuario.Text)
                && string.IsNullOrEmpty(txtMonto.Text) && !dtpFecha.Enabled)
            {
                MessageBox.Show("Debe ingresar al menos un dato", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                this.descSueldos.Rows.Clear();
                var cant = this.txtCantidad2.Text;
                var usu = this.txtNombreUsuario.Text;
                var desc = this.txtNombreAsignacion.Text;
                var monto = this.txtMonto.Text;
                var fecha = dtpFecha.Value;
                var banFech = 0;
                if (this.dtpFecha.Enabled)
                    banFech = 1;
                tabla = oSAsignacion.recuperarAsignacionesPorSueldosFiltradas(usu, desc, monto, cant, fecha, banFech);

                cargarGrilla(descSueldos, tabla);
            }
            //if ((!(this.ckbFecha.Checked)) && string.IsNullOrEmpty(this.txtNombreUsuario.Text) && string.IsNullOrEmpty(this.txtNombreAsignacion.Text)
            //  && string.IsNullOrEmpty(this.txtMonto.Text) && string.IsNullOrEmpty(this.txtCantidad2.Text))
            //{
            //    MessageBox.Show("No se ingresaron datos para realizar la busqueda", "Error ingreso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else
            //{
            //    if (this.dtpFecha.Enabled)
            //    {
            //        this.descSueldos.Rows.Clear();
            //        tabla = oSAsignacion.recuperarAsignacionesPorSueldosFiltradas(this.txtNombreUsuario.Text, this.txtNombreAsignacion.Text, this.txtMonto.Text, this.txtCantidad2.Text, this.dtpFecha.Value, bandera: true);
            //        cargarGrilla(this.descSueldos, tabla);
            //    }
            //    else
            //    {
            //        this.descSueldos.Rows.Clear();
            //        tabla = oSAsignacion.recuperarAsignacionesPorSueldosFiltradas(this.txtNombreUsuario.Text, this.txtNombreAsignacion.Text, this.txtMonto.Text, this.txtCantidad2.Text, this.dtpFecha.Value);
            //        cargarGrilla(this.descSueldos, tabla);
            //    }

            //    if (this.descSueldos.Rows.Count == 1)
            //    {
            //        MessageBox.Show("No se encontraron coincidencias", "Buscar sueldo por asignación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        tabla = oSAsignacion.recuperarAsignacionesPorSueldos();
            //        this.cargarGrilla(descSueldos, tabla);
            //    }
            //}
        }

        private void pictureBoxRefrescar_Click(object sender, EventArgs e)
        {
            if (filas == 0)
            {
                this.descSueldos.Rows.Clear();
                this.txtMonto.Clear();
                this.txtNombreUsuario.Clear();
                this.txtNombreAsignacion.Clear();
                this.txtCantidad2.Clear();
                this.txtMonto.Clear();
                this.dtpFecha.Value = DateTime.Today;
                tabla = oSAsignacion.recuperarAsignacionesPorSueldos();
                this.txtNombreUsuario.Focus();
            }
            else
            {
                this.descSueldos.Rows.Clear();
                this.txtMonto.Clear();
                this.txtNombreUsuario.Clear();
                this.txtNombreAsignacion.Clear();
                this.txtCantidad2.Clear();
                this.txtMonto.Clear();
                this.dtpFecha.Value = DateTime.Today;
                tabla = oSAsignacion.recuperarAsignacionesPorSueldos();
                cargarGrilla(this.descSueldos, tabla);
                this.txtNombreUsuario.Focus();
            }
        }

        private void SalirFrmModificarDescuentos_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
