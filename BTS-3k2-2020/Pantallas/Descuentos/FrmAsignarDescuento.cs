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
    public partial class FrmAsignarDescuento : Form
    {
        //provisional hasta tener la clase de sueldo
        DescuentosRepositorio oDescuentoRep = new DescuentosRepositorio();
        SueldoDescuentosRepositorio oSueldoDescuentoRep = new SueldoDescuentosRepositorio();
        DataTable tabla = new DataTable();

        public FrmAsignarDescuento(int idDesc, string nomDesc, string montoDesc)
        {
            InitializeComponent();
            this.txtNombreDesc.Text = nomDesc;
            this.txtMontoDesc.Text = montoDesc;
            this.txtIdDesc.Text = idDesc.ToString();
            this.dtbAsignarDesc.Columns[0].Visible = false;


        }

        public void cargarGrilla(DataGridView grilla, DataTable tabla)
        {
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grilla.Rows.Add(tabla.Rows[i]["id_usuario"],
                    tabla.Rows[i]["usuario"],
                    tabla.Rows[i]["fecha"],
                    Convert.ToInt32(tabla.Rows[i]["sueldo_bruto"]));
            }
        }


        private void FrmAsignarDescuento_Load(object sender, EventArgs e)
        {
            //provisional hasta tener la clase de sueldo

            tabla = oDescuentoRep.recuperarSueldos();
            cargarGrilla(this.dtbAsignarDesc, tabla);

            if (this.dtbAsignarDesc.Rows.Count == 1)
            {
                MessageBox.Show("No hay descuentos almacenados", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            this.txtCantidadMasked.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtCantidadMasked.Text))
            {
                MessageBox.Show("Debe ingresar la cantidad", "Error ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtCantidadMasked.Focus();
            }
            else
            {


                //int idUsu = (int)this.dtbAsignarDesc.CurrentRow.Cells[0].Value;
                //DateTime fechaS = Convert.ToDateTime(this.dtbAsignarDesc.CurrentRow.Cells[2].Value);
                //int idDescSD = Convert.ToInt32(this.txtIdDesc.Text);
                //string montoSD = this.txtMontoDesc.Text.ToString();
                //string cant = this.txtCantidadMasked.Text.ToString();
                //oDescuentoRep.asignarDescuento(idUsu, fechaS, idDescSD, montoSD, cant);
                var rtd = -1;
                var tabla = oSueldoDescuentoRep.recuperarDescuentosPorSueldosParaAsignar((int)this.dtbAsignarDesc.CurrentRow.Cells[0].Value, this.dtbAsignarDesc.CurrentRow.Cells[2].Value.ToString(),
                    Convert.ToInt32(this.txtIdDesc.Text));
                if (tabla.Rows.Count > 0)
                    MessageBox.Show("El sueldo seleccionado ya tiene un descuento asignado");
                else
                {
                    oDescuentoRep.asignarDescuento((int)this.dtbAsignarDesc.CurrentRow.Cells[0].Value, this.dtbAsignarDesc.CurrentRow.Cells[2].Value.ToString(),
                    Convert.ToInt32(this.txtIdDesc.Text), Convert.ToInt32(this.txtCantidadMasked.Text), this.txtMontoDesc.Text);
                    rtd = 1;
                }
                if (rtd == 1)
                    MessageBox.Show("Descuento asignado con exito, para ver los cambios realizados dirijase a la opcion de Descuentos p/ Sueldo.", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }

        }

        private void SalirFrmModificarDescuentos_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //METODO PARA ARRASTRAR EL FORMULARIO---------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void FrmAsignarDescuento_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnGuardarModDesc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtCantidadMasked.Text))
            {
                MessageBox.Show("Debe ingresar la cantidad", "Error ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtCantidadMasked.Focus();
            }
            else
            {


                //int idUsu = (int)this.dtbAsignarDesc.CurrentRow.Cells[0].Value;
                //DateTime fechaS = Convert.ToDateTime(this.dtbAsignarDesc.CurrentRow.Cells[2].Value);
                //int idDescSD = Convert.ToInt32(this.txtIdDesc.Text);
                //string montoSD = this.txtMontoDesc.Text.ToString();
                //string cant = this.txtCantidadMasked.Text.ToString();
                //oDescuentoRep.asignarDescuento(idUsu, fechaS, idDescSD, montoSD, cant);
                var rtd = -1;
                var tabla = oSueldoDescuentoRep.recuperarDescuentosPorSueldosParaAsignar((int)this.dtbAsignarDesc.CurrentRow.Cells[0].Value, this.dtbAsignarDesc.CurrentRow.Cells[2].Value.ToString(),
                    Convert.ToInt32(this.txtIdDesc.Text));
                if (tabla.Rows.Count > 0)
                    MessageBox.Show("El sueldo seleccionado ya tiene un descuento asignado");
                else
                {
                    oDescuentoRep.asignarDescuento((int)this.dtbAsignarDesc.CurrentRow.Cells[0].Value, this.dtbAsignarDesc.CurrentRow.Cells[2].Value.ToString(),
                    Convert.ToInt32(this.txtIdDesc.Text), Convert.ToInt32(this.txtCantidadMasked.Text), this.txtMontoDesc.Text);
                    rtd = 1;
                }
                if (rtd == 1)
                    MessageBox.Show("Descuento asignado con exito, para ver los cambios realizados dirijase a la opcion de Descuentos p/ Sueldo.", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void FrmAsignarDescuento_Load_1(object sender, EventArgs e)
        {
            tabla = oDescuentoRep.recuperarSueldos();
            cargarGrilla(this.dtbAsignarDesc, tabla);

            if (this.dtbAsignarDesc.Rows.Count == 1)
            {
                MessageBox.Show("No hay descuentos almacenados", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            this.txtCantidadMasked.Focus();
        }
    }
}
