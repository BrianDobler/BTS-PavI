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
using System.Runtime.InteropServices;

namespace BTS_3k2_2020.Pantallas.Asignaciones
{
    public partial class FrmAsignarAsignacion : Form
    {
        DataTable tabla = new DataTable();
        SueldoAsignacionRepositorio oSueldoAsigRep = new SueldoAsignacionRepositorio();
        AsignacionesRepositorio oAsignacionRep = new AsignacionesRepositorio();
        DescuentosRepositorio oDescuentosRep = new DescuentosRepositorio();
        public FrmAsignarAsignacion(int idAsig, string nomAsig, string montoAsig)
        {
            InitializeComponent();
            this.txtNombreAsig.Text = nomAsig;
            this.txtMontoAsig.Text = montoAsig;
            this.txtIdAsig.Text = idAsig.ToString();
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

        private void FrmAsignarAsignacion_Load(object sender, EventArgs e)
        {
            
            
            //provisional hasta tener la clase de sueldo

            tabla = oDescuentosRep.recuperarSueldos();
            cargarGrilla(this.dtbAsignarDesc, tabla);

            if (this.dtbAsignarDesc.Rows.Count == 1)
            {
               MessageBox.Show("No hay descuentos almacenados", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
               this.txtCantidadMasked.Focus();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
           
        }
    

        private void SalirFrmModificarDescuentos_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardarModDesc_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardarAsigAsignac_Click(object sender, EventArgs e)
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
                var tabla = oSueldoAsigRep.recuperarAsignacionesPorSueldosParaAsignar((int)this.dtbAsignarDesc.CurrentRow.Cells[0].Value, this.dtbAsignarDesc.CurrentRow.Cells[2].Value.ToString(),
                Convert.ToInt32(this.txtIdAsig.Text));
                if (tabla.Rows.Count > 0)
                MessageBox.Show("El sueldo seleccionado ya tiene un descuento asignado");
                else
                {
                    oAsignacionRep.asignarAsignacion((int)this.dtbAsignarDesc.CurrentRow.Cells[0].Value, this.dtbAsignarDesc.CurrentRow.Cells[2].Value.ToString(),
                    Convert.ToInt32(this.txtIdAsig.Text), Convert.ToInt32(this.txtCantidadMasked.Text), this.txtMontoAsig.Text);
                    rtd = 1;
                }
                if (rtd == 1)
                     MessageBox.Show("Asignación asignado con exito, para ver los cambios realizados dirijase a la opcion de Asignaciones p/ Sueldo.", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //METODO PARA ARRASTRAR EL FORMULARIO---------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void FrmAsignarAsignacion_MouseMove(object sender, MouseEventArgs e)
        {
              ReleaseCapture();
              SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void label9_Click(object sender, EventArgs e)
        {

        }

    }
}


