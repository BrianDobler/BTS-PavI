using BTS_3k2_2020.LogicaDeNegocio;
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

namespace BTS_3k2_2020.Pantallas.Objetivos
{
    public partial class FrmObjetivos : Form
    {
        private ObjetivosServicio _objetivosServicio = new ObjetivosServicio();
        private FrmMenuV2 frmMenuV2;
        private DataTable tabla;
        private ObjetivosRepositorio _objetivosRepositorio;

        public FrmObjetivos(FrmMenuV2 frmMenuV2)
        {
            _objetivosRepositorio = new ObjetivosRepositorio();
            tabla = new DataTable();
            this.frmMenuV2 = frmMenuV2;
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                ConsultarObjetivos();
            }
            else
            {
                MessageBox.Show("Introduzca ID o nombre corto o nombre largo");
            }
        }

        private bool ValidarDatos()
        {
            var idobjetivo =txtID.Text.ToString();
            var nombreCorto = txtNombreCorto.Text.ToString();
            var nombreLargo = txtNombreLargo.Text.ToString();

            if (string.IsNullOrEmpty(idobjetivo) && string.IsNullOrEmpty(nombreCorto) && string.IsNullOrEmpty(nombreLargo))
            {
                return false;
            }

            return true;
        }

        public void ConsultarObjetivos()
        {

            var idObjetivo = txtID.Text;
            var nombreCorto = txtNombreCorto.Text;
            var nombreLargo = txtNombreLargo.Text;

            if (ValidarDatos())
            {
                var _objetivosServicio = new ObjetivosServicio();
                
                var objetivos = _objetivosServicio.ConsultarObjetivo(idObjetivo, nombreCorto, nombreLargo);
                ActualizarGrilla(objetivos);
            }
            else
            {
                MessageBox.Show("Ingresar ID o Nombre Corto o Nombre Largo");
            }
        }

        private void ActualizarGrilla(List<Objetivo> objetivos)
        {
            dgvObjetivos.Rows.Clear();
            foreach (var objetivo in objetivos)
            {
                var fila = new string[] {
                    objetivo.Id.ToString(),
                    objetivo.NombreCorto,
                    objetivo.NombreLargo
                };
                dgvObjetivos.Rows.Add(fila);
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminarObjetivo_Click(object sender, EventArgs e)
        {

            var objetivo = new Objetivo();

            {
                if (dgvObjetivos.SelectedRows.Count == 1)
                {
                    objetivo.Id = Convert.ToInt32(dgvObjetivos.SelectedRows[0].Cells[0].Value.ToString());
                    if (_objetivosServicio.EliminarObjetivo(objetivo) == 1)
                    {
                        MessageBox.Show("Se elimino el ID " + objetivo.Id + " correctamente");
                        var objetivos = _objetivosServicio.ObtenerTodos();
                        ActualizarGrilla(objetivos);
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione una celda");
                }
            }
        }

        private void btnAgregarObjetivo_Click(object sender, EventArgs e)
        {
            
            var id_objetivo = txtID.Text;
            var nombre_corto = txtNombreCorto.Text;
            var nombre_largo = txtNombreLargo.Text;

            if (ValidarDatos())
            {
                _objetivosServicio = new ObjetivosServicio();
                var objetivos = _objetivosServicio.ConsultarObjetivo(id_objetivo,"","");
                ActualizarGrilla(objetivos);
                if (objetivos.Count != 0)
                {
                    MessageBox.Show("El nombre del objetivo ya se encuentran en uso");
                }
                else
                {
                    if (nombre_corto == "")
                    {
                        MessageBox.Show("Ingrese nombre corto valido");
                    }
                    else
                    {
                        var objetivo = new Objetivo();
                        objetivo.Id = Convert.ToInt32(id_objetivo);
                        objetivo.NombreCorto = nombre_corto;
                        objetivo.NombreLargo = nombre_largo;
                        if (_objetivosServicio.RegistrarObjetivo(objetivo) == 1)
                        {
                            MessageBox.Show("Se agrego el perfil correctamente");
                            ActualizarGrilla(_objetivosServicio.ObtenerTodos());
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Ingrese nombre y/o id");
            }
            
        }

        private void btnModificarObjetivo_Click(object sender, EventArgs e)
        {
            var objetivo = new Objetivo();

            {
                if (dgvObjetivos.SelectedRows.Count == 1)
                {
                    objetivo.Id = Convert.ToInt32(dgvObjetivos.SelectedRows[0].Cells[0].Value.ToString());
                    new FrmModificarObjetivo(objetivo.Id).Show();
                }
                else
                {
                    MessageBox.Show("Seleccione un objetivo","",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
        }

        private void FrmObjetivos_Load(object sender, EventArgs e)
        {
            ActualizarGrilla(_objetivosServicio.ObtenerTodos());
        }

        private void pictureBoxRefrescar_Click(object sender, EventArgs e)
        {
            this.dgvObjetivos.Rows.Clear();
            this.txtID.Clear();
            this.txtNombreLargo.Clear();
            tabla = _objetivosRepositorio.RecuperarObjetivos();
            cargarGrilla(this.dgvObjetivos, tabla);
        }

        public void cargarGrilla(DataGridView grilla, DataTable tabla)
        {
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grilla.Rows.Add(tabla.Rows[i]["id_objetivo"],
                    tabla.Rows[i]["nombre_corto"],
                    tabla.Rows[i]["nombre_largo"]);
            }
        }
    }
}
