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

namespace BTS_3k2_2020.Pantallas.Asignaciones
{
    public partial class FrmAsignaciones : Form
    {

        //private Asignacion oDescuento;
        private AsignacionesRepositorio oAsignacionRep;
        private DataTable tabla;
        private FrmMenuV2 frmMenuV2;
        public FrmAsignaciones()
        {
            //oAsignacion = new Asignacion();
            oAsignacionRep= new AsignacionesRepositorio();
            tabla = new DataTable();
            frmMenuV2 = frmMenuV2;
            InitializeComponent();
        }

        

        private void FrmAsignaciones_Load(object sender, EventArgs e)
        {
            tabla = oAsignacionRep.recuperarAsignaciones();
            cargarGrilla(this.dtbAsginaciones, tabla);

            if (this.dtbAsginaciones.Rows.Count == 1)
            {
                MessageBox.Show("No hay asignaciones almacenados", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void cargarGrilla(DataGridView grilla, DataTable tabla)
        {
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grilla.Rows.Add(tabla.Rows[i]["id_asignacion"],
                    tabla.Rows[i]["n_asignacion"],
                    tabla.Rows[i]["monto"]);
            }
        }

        private void btnBuscaAsignacion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtNombre.Text) && string.IsNullOrEmpty(this.txtMonto.Text))
            {
                MessageBox.Show("No ingresaron todos los datos.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtNombre.Focus();
            }
            else
            {
                if (!(string.IsNullOrEmpty(this.txtNombre.Text)) && !(string.IsNullOrEmpty(this.txtMonto.Text)))
                {

                    //oDescuento.NombreDescuento = this.txtNombre.Text;
                    //oDescuento.MontoDescuento = Convert.ToInt32(this.txtMonto.Text);
                    //tabla = oDescuentoRep.recuperarDescuentosFiltrados();
                    this.dtbAsginaciones.Rows.Clear();
                    tabla = oAsignacionRep.recuperarAsignacionesFiltradas(this.txtNombre.Text, this.txtMonto.Text);
                    this.cargarGrilla(dtbAsginaciones, tabla);
                }
                if (string.IsNullOrEmpty(this.txtMonto.Text))
                {
                    this.dtbAsginaciones.Rows.Clear();
                    tabla = oAsignacionRep.recuperarAsignacionesPorNombre(this.txtNombre.Text);
                    this.cargarGrilla(dtbAsginaciones, tabla);
                }
                if (string.IsNullOrEmpty(this.txtNombre.Text))
                {
                    this.dtbAsginaciones.Rows.Clear();
                    tabla = oAsignacionRep.recuperarAsignacionesPorMonto(this.txtMonto.Text);
                    this.cargarGrilla(dtbAsginaciones, tabla);
                }

                if (this.dtbAsginaciones.Rows.Count == 1)
                {
                    MessageBox.Show("No se encontraron coincidencias", "Buscar asignación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tabla = oAsignacionRep.recuperarAsignaciones();
                    this.cargarGrilla(dtbAsginaciones, tabla);
                }
            }
        }

        private void btnAgregrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtNombre.Text) || string.IsNullOrEmpty(this.txtMonto.Text))
            {
                MessageBox.Show("No se ingresaron todos los datos.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtNombre.Focus();
            }
            else
            {
                //this.dtbAsginaciones.Rows.Clear();
                //tabla = oAsignacionRep.recuperarAsignaciones();

                //int idAsig = tabla.Rows.Count + 1;
                oAsignacionRep.agregarAsignacion(this.txtNombre.Text, this.txtMonto.Text);

                MessageBox.Show("Se añadio con exito", "Agregar asignación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.dtbAsginaciones.Rows.Clear();
                tabla = oAsignacionRep.recuperarAsignaciones();
                cargarGrilla(this.dtbAsginaciones, tabla);
            }
        }

        private void BtnElimAsignacion_Click(object sender, EventArgs e)
        {
            if (this.dtbAsginaciones.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe Seleccionar la asignación que desea eliminar", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);

            }
            else
            {
                DialogResult confirm = MessageBox.Show("¿ESTA SEGURO QUE DESEA ELIMINAR?", "Eliminar asignacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {

                    var id_desc = Convert.ToInt32(dtbAsginaciones.CurrentRow.Cells[0].Value);
                    var tablaEstaAsignado = oAsignacionRep.estaAsignado(id_desc);
                    if (Convert.ToInt32(tablaEstaAsignado.Rows.Count) == 0)
                    {
                        var idAsig = (int)dtbAsginaciones.CurrentRow.Cells[0].Value;
                        oAsignacionRep.eliminarAsignacion(idAsig);
                        this.dtbAsginaciones.Rows.Clear();
                        tabla = oAsignacionRep.recuperarAsignaciones();
                        cargarGrilla(this.dtbAsginaciones, tabla);
                        MessageBox.Show("¡Eliminado con exito!", "Eliminar asignacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("¡No se puede eliminar una asignacion que ya esta asignado a un sueldo!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                        
                }
            }
        }

        private void pictureBoxRefrescar_Click(object sender, EventArgs e)
        {
            this.dtbAsginaciones.Rows.Clear();
            this.txtMonto.Clear();
            this.txtNombre.Clear();
            tabla = oAsignacionRep.recuperarAsignaciones();
            cargarGrilla(this.dtbAsginaciones, tabla);
        }

        private void SalirFrmAsignaciones_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModifcarAsignacion_Click(object sender, EventArgs e)
        {
            if (this.dtbAsginaciones.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe Seleccionar la asignación que desea eliminar", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);

            }
            else
            {
                var id_desc = (int)dtbAsginaciones.CurrentRow.Cells[0].Value;
                var nom = dtbAsginaciones.CurrentRow.Cells[1].Value.ToString();
                var mon = dtbAsginaciones.CurrentRow.Cells[2].Value.ToString();

                FrmModificarAsignacion formularioModificar = new FrmModificarAsignacion(id_desc, nom, mon);
                formularioModificar.ShowDialog();
            }
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            var id_desc = (int)dtbAsginaciones.CurrentRow.Cells[0].Value;
            var nom = dtbAsginaciones.CurrentRow.Cells[1].Value.ToString();
            var mon = dtbAsginaciones.CurrentRow.Cells[2].Value.ToString();
            FrmAsignarAsignacion formularioAsignar = new FrmAsignarAsignacion(id_desc, nom, mon);
            formularioAsignar.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAsigXSueldo fp = new FrmAsigXSueldo();
            fp.ShowDialog();
        }
    }
}
