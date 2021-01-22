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

namespace BTS_3k2_2020.Pantallas.Descuentos
{

    public partial class FrmDescXSueldocs : Form
    {
        //DescuentosRepositorio oDescuentoRep = new DescuentosRepositorio();
        SueldoDescuentosRepositorio oSDescuento = new SueldoDescuentosRepositorio();
        DataTable tabla = new DataTable();
        int filas = -1;
        
        public FrmDescXSueldocs()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        private void CerrarFormulario()
        {
            FrmMenuV2 fds = new FrmMenuV2();
            this.Dispose();
            fds.Show();
        }

        private void FrmDescXSueldocs_FormClosing(object sender, FormClosingEventArgs e)
        {
            CerrarFormulario();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            CerrarFormulario();
        }

        private void FrmDescXSueldocs_Load(object sender, EventArgs e)
        {
            this.dtpFecha.Enabled = false;
            this.ckbFecha.Checked = false;
            tabla = oSDescuento.recuperarDescuentosPorSueldos();
            cargarGrilla(this.dtbDescSueld, tabla);

            if (this.dtbDescSueld.Rows.Count == 1)
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
                    tabla.Rows[i]["n_descuento"],
                    tabla.Rows[i]["fecha"],
                    tabla.Rows[i]["monto"],
                    tabla.Rows[i]["cantidad"]);
            }
        }

        /*private void btnBuscar_Click(object sender, EventArgs e)
        {
            if ((!(this.ckbFecha.Checked)) && string.IsNullOrEmpty(this.txtNombreUsuario.Text) && string.IsNullOrEmpty(this.txtNombreDescuento.Text)
                && string.IsNullOrEmpty(this.txtMonto.Text) && string.IsNullOrEmpty(this.txtCantidad2.Text))
            {
                MessageBox.Show("No se ingresaron datos para realizar la busqueda", "Error ingreso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (this.dtpFecha.Enabled)
                {
                    this.dtbDescSueld.Rows.Clear();
                    tabla = oSDescuento.recuperarDescuentosPorSueldosFiltrados(this.txtNombreUsuario.Text, this.txtNombreDescuento.Text, this.txtMonto.Text, this.txtCantidad2.Text, this.dtpFecha.Value, bandera: true);
                    cargarGrilla(this.dtbDescSueld, tabla);
                }
                else
                {
                    this.dtbDescSueld.Rows.Clear();
                    tabla = oSDescuento.recuperarDescuentosPorSueldosFiltrados(this.txtNombreUsuario.Text, this.txtNombreDescuento.Text, this.txtMonto.Text, this.txtCantidad2.Text, this.dtpFecha.Value);
                    cargarGrilla(this.dtbDescSueld, tabla);
                }

                if (this.dtbDescSueld.Rows.Count == 1)
                {
                    MessageBox.Show("No se encontraron coincidencias", "Buscar sueldo por descuento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tabla = oSDescuento.recuperarDescuentosPorSueldos();
                    this.cargarGrilla(dtbDescSueld, tabla);
                }
            }
        }*/



        //METODO PARA ARRASTRAR EL FORMULARIO---------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void FrmDescXSueldocs_MouseMove(object sender, MouseEventArgs e)
        {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0); 
        }

        private void ckbFecha_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void btnBuscarDescXSueldo_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCheckbox1_OnChange(object sender, EventArgs e)
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

        private void pictureBoxRefrescar_Click(object sender, EventArgs e)
        {
             if (filas == 0)
            {
                this.dtbDescSueld.Rows.Clear();
                this.txtMonto.Clear();
                this.txtNombreUsuario.Clear();
                this.txtNombreDescuento.Clear();
                this.txtCantidad2.Clear();
                this.txtMonto.Clear();
                this.dtpFecha.Value = DateTime.Today;
                tabla = oSDescuento.recuperarDescuentosPorSueldos();
                this.txtNombreUsuario.Focus();
            }
            else
            {
                this.dtbDescSueld.Rows.Clear();
                this.txtMonto.Clear();
                this.txtNombreUsuario.Clear();
                this.txtNombreDescuento.Clear();
                this.txtCantidad2.Clear();
                this.txtMonto.Clear();
                this.dtpFecha.Value = DateTime.Today;
                tabla = oSDescuento.recuperarDescuentosPorSueldos();
                cargarGrilla(this.dtbDescSueld, tabla);
                this.txtNombreUsuario.Focus();
            }
        }

        private void SalirFrmModificarDescuentos_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmDescXSueldocs_Load_1(object sender, EventArgs e)
        {
            this.ckbFecha.Checked = false;
            this.dtpFecha.Enabled = false;
            tabla = oSDescuento.recuperarDescuentosPorSueldos();
            cargarGrilla(this.dtbDescSueld, tabla);

            if (this.dtbDescSueld.Rows.Count == 1)
            {

                MessageBox.Show("No hay información almacenada para mostrar", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                filas = 0;
            }
        }

        private void btnBuscarDescuento_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCantidad2.Text) && string.IsNullOrEmpty(txtNombreDescuento.Text) && string.IsNullOrEmpty(txtNombreUsuario.Text) 
                && string.IsNullOrEmpty(txtMonto.Text) && !dtpFecha.Enabled)
            {
                MessageBox.Show("Debe ingresar al menos un dato", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                this.dtbDescSueld.Rows.Clear();
                var cant = this.txtCantidad2.Text;
                var usu = this.txtNombreUsuario.Text;
                var desc = this.txtNombreDescuento.Text;
                var monto = this.txtMonto.Text;
                var fecha = dtpFecha.Value;
                var banFech = 0;
                if (this.dtpFecha.Enabled)
                    banFech = 1;
                tabla = oSDescuento.recuperarDescuentosPorSueldosFiltrados(usu,desc,monto,cant,fecha,banFech);
                
                cargarGrilla(dtbDescSueld, tabla);
            }
        }

        private void dtbDescSueld_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
