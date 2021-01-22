using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTS_3k2_2020.Modelos;
using BTS_3k2_2020.RespositoriosDAO;
using BTS_3k2_2020.Pantallas.Descuentos;

namespace BTS_3k2_2020.Pantallas
{
    public partial class FrmDescuentos : Form
    {
        
        private Descuento oDescuento;
        private DescuentosRepositorio oDescuentoRep;
        private DataTable tabla;
        private FrmMenuV2 frmMenuV2;

        public FrmDescuentos()
        {
            oDescuento = new Descuento();
            oDescuentoRep = new DescuentosRepositorio();
            tabla = new DataTable();
            frmMenuV2 = frmMenuV2;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //FrmPrincipal fp = new FrmPrincipal();
            //FrmMenu fp = new FrmMenu();
            //this.Dispose();
            //fp.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtNombre.Text) || string.IsNullOrEmpty(this.txtMonto.Text))
            {
                MessageBox.Show("No se ingresaron todos los datos.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtNombre.Focus();
            }
            else
            {
                this.dtbDescuentos.Rows.Clear();
                tabla = oDescuentoRep.recuperarDescuentosFiltrados(this.txtNombre.Text, this.txtMonto.Text);
                this.cargarGrilla(dtbDescuentos, tabla);
                
                if (this.dtbDescuentos.Rows.Count == 1)
                {   
                    MessageBox.Show("No se encontraron coincidencias", "Buscar descuento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tabla = oDescuentoRep.recuperarDescuentos();
                    this.cargarGrilla(dtbDescuentos, tabla);
                }
            }
        }

        public void cargarGrilla(DataGridView grilla, DataTable tabla)
        {
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grilla.Rows.Add(tabla.Rows[i]["id_descuento"],
                    tabla.Rows[i]["n_descuento"],
                    tabla.Rows[i]["monto"]);
            }
        }

        private void FrmDescuentos_Load(object sender, EventArgs e)
        {
         
            tabla = oDescuentoRep.recuperarDescuentos();
            cargarGrilla(this.dtbDescuentos, tabla);

            if (this.dtbDescuentos.Rows.Count == 1)
            {
                MessageBox.Show("No hay descuentos almacenados", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtNombre.Text) || string.IsNullOrEmpty(this.txtMonto.Text))
            {
                MessageBox.Show("No se ingresaron todos los datos.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtNombre.Focus();
            }
            else
            {
                //this.dtbDescuentos.Rows.Clear();
                //tabla = oDescuentoRep.recuperarDescuentos();

                //int idDesc = tabla.Rows.Count + 1;
                oDescuentoRep.agregarDescuento(this.txtNombre.Text, this.txtMonto.Text);

                MessageBox.Show("Se añadio con exito", "Agregar descuento", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.dtbDescuentos.Rows.Clear();
                tabla = oDescuentoRep.recuperarDescuentos();
                cargarGrilla(this.dtbDescuentos, tabla);
            }

        }


        private void btnRefrescar_Click_1(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.dtbDescuentos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe Seleccionar el descuento que desea eliminar", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);

            }
            else
            {
                DialogResult confirm = MessageBox.Show("¿ESTA SEGURO QUE DESEA ELIMINAR?", "Eliminar descuento", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(confirm == DialogResult.Yes)
                {
                    MessageBox.Show("¡Eliminado con exito!", "Eliminar descuento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    var id_desc = (int)dtbDescuentos.CurrentRow.Cells[0].Value;
                    oDescuentoRep.eliminarDescuento(id_desc);
                    this.dtbDescuentos.Rows.Clear();
                    tabla = oDescuentoRep.recuperarDescuentos();
                    cargarGrilla(this.dtbDescuentos, tabla);
                }
                

            }
        }

        


        private void SalirFrmDescuentos_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscarUsuario_Click(object sender, EventArgs e)
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
                    this.dtbDescuentos.Rows.Clear();
                    tabla = oDescuentoRep.recuperarDescuentosFiltrados(this.txtNombre.Text, this.txtMonto.Text);
                    this.cargarGrilla(dtbDescuentos, tabla);
                }
                if (string.IsNullOrEmpty(this.txtMonto.Text))
                {
                    this.dtbDescuentos.Rows.Clear();
                    tabla = oDescuentoRep.recuperarDescuentosPorNombre(this.txtNombre.Text);
                    this.cargarGrilla(dtbDescuentos, tabla);
                }
                if (string.IsNullOrEmpty(this.txtNombre.Text))
                {
                    this.dtbDescuentos.Rows.Clear();
                    tabla = oDescuentoRep.recuperarDescuentosPorMonto(this.txtMonto.Text);
                    this.cargarGrilla(dtbDescuentos, tabla);
                }

                if (this.dtbDescuentos.Rows.Count == 1)
                {
                    MessageBox.Show("No se encontraron coincidencias", "Buscar descuento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tabla = oDescuentoRep.recuperarDescuentos();
                    this.cargarGrilla(dtbDescuentos, tabla);
                }
            }
            //if (string.IsNullOrEmpty(this.txtNombre.Text) || string.IsNullOrEmpty(this.txtMonto.Text))
            //{
            //    MessageBox.Show("No se ingresaron todos los datos.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    this.txtNombre.Focus();
            //}
            //else
            //{
            //    this.dtbDescuentos.Rows.Clear();
            //    tabla = oDescuentoRep.recuperarDescuentosFiltrados(this.txtNombre.Text, this.txtMonto.Text);
            //    this.cargarGrilla(dtbDescuentos, tabla);

            //    if (this.dtbDescuentos.Rows.Count == 1)
            //    {
            //        MessageBox.Show("No se encontraron coincidencias", "Buscar descuento", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        tabla = oDescuentoRep.recuperarDescuentos();
            //        this.cargarGrilla(dtbDescuentos, tabla);
            //    }
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnModificarDesc_Click(object sender, EventArgs e)
        {
            if (this.dtbDescuentos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe Seleccionar el descuento que desea modificar", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);

            }
            else
            {
                var id_desc = (int)dtbDescuentos.CurrentRow.Cells[0].Value;
                var nom = dtbDescuentos.CurrentRow.Cells[1].Value.ToString();
                var mon = dtbDescuentos.CurrentRow.Cells[2].Value.ToString();
                FrmModificarDescuento formularioModificar = new FrmModificarDescuento(id_desc, nom, mon);
                formularioModificar.ShowDialog();
            }
    }

        private void BtnDarBaja_Click(object sender, EventArgs e)
        {

        }

        private void BtnElimDesc_Click(object sender, EventArgs e)
        {
            if (this.dtbDescuentos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe Seleccionar el descuento que desea eliminar", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);

            }
            else
            {
                DialogResult confirm = MessageBox.Show("¿ESTA SEGURO QUE DESEA ELIMINAR?", "Eliminar descuento", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {               
                    var id_desc = Convert.ToInt32(dtbDescuentos.CurrentRow.Cells[0].Value);
                    var tablaEstaAsignado = oDescuentoRep.estaAsignado(id_desc);
                    if (Convert.ToInt32(tablaEstaAsignado.Rows.Count) == 0)
                    {
                        oDescuentoRep.eliminarDescuento(id_desc);
                        this.dtbDescuentos.Rows.Clear();
                        tabla = oDescuentoRep.recuperarDescuentos();
                        cargarGrilla(this.dtbDescuentos, tabla);
                        MessageBox.Show("¡Eliminado con exito!", "Eliminar descuento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("¡No se puede eliminar un descuento que ya esta asignado a un sueldo!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
            }
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            var id_desc = (int)dtbDescuentos.CurrentRow.Cells[0].Value;
            var nom = dtbDescuentos.CurrentRow.Cells[1].Value.ToString();
            var mon = dtbDescuentos.CurrentRow.Cells[2].Value.ToString();
            FrmAsignarDescuento formularioAsignar = new FrmAsignarDescuento(id_desc, nom, mon);
            formularioAsignar.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmDescXSueldocs fp = new FrmDescXSueldocs();
            fp.ShowDialog();
        }

        private void pictureBoxRefrescar_Click(object sender, EventArgs e)
        {
            this.dtbDescuentos.Rows.Clear();
            this.txtMonto.Clear();
            this.txtNombre.Clear();
            tabla = oDescuentoRep.recuperarDescuentos();
            cargarGrilla(this.dtbDescuentos, tabla);
        }
    }
}

