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

namespace BTS_3k2_2020.Pantallas.Perfiles2
{
    public partial class FrmPerfilesV2 : Form
    {
        private PerfilesServicio _perfilesServicio;
        private FrmMenuV2 frmMenuV2;
        private Perfil perfil;
        private PerfilesRepositorio _perfilesRep;
        private DataTable tabla;

        public FrmPerfilesV2(FrmMenuV2 frmMenuV2)
        {
            this.frmMenuV2 = frmMenuV2;
            _perfilesRep = new PerfilesRepositorio();
            InitializeComponent();
        }

        private void btnBuscarPerfil_Click(object sender, EventArgs e)
        {
            ConsultarPerfiles();
        }


        private bool ValidarDatos()
        {
            var nombrePerfil = txtNombre.Text;
            var idPerfil = txtID.Text;

            if (nombrePerfil == "" && idPerfil.ToString() == "")
            {
                return false;
            }

            return true;
        }

        public void ConsultarPerfiles()
        {
            var nombrePerfil = txtNombre.Text;
            var idPerfil = txtID.Text;

            if (ValidarDatos())
            {
                _perfilesServicio = new PerfilesServicio();
                var perfiles = _perfilesServicio.ConsultarPerfil(nombrePerfil, idPerfil);
                ActualizarGrilla(perfiles);
            }
            else
            {
                MessageBox.Show("No ingresa Nombre ni ID");
            }

            
        }

        private void ActualizarGrilla(List<Perfil> perfiles)
        {
            dgvPerfiles.Rows.Clear();
            foreach (var perfil in perfiles)
            {
                var fila = new string[] {
                    perfil.Id.ToString(),
                    perfil.Nombre
                };
                dgvPerfiles.Rows.Add(fila);
            }
        }

        private void FrmPerfilesV2_Load(object sender, EventArgs e)
        {
            _perfilesServicio = new PerfilesServicio();
            ActualizarGrilla(_perfilesServicio.ObtenerTodos());
        }

        private void SalirFrmListadoPerfiles_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            
            var nombrePerfil = txtNombre.Text;
            var idPerfil = txtID.Text;

            if (ValidarDatos())
            {
                
                var perfiles = _perfilesServicio.ConsultarPerfilExacto(nombrePerfil, idPerfil);
                ActualizarGrilla(perfiles);
                if(perfiles.Count != 0)
                {
                    MessageBox.Show("El nombre y/o ID de perfil se encuentran en uso");
                }
                else
                {
                    if (nombrePerfil == "")
                    {
                        MessageBox.Show("Ingrese nombre de perfil");
                    } else
                    {
                        if(idPerfil != "")
                        {
                            MessageBox.Show("No existe posibilidad de agregar un perfil con un ID especifico, esa opcion está desactivada. " +
                                "Para habilitarla por favor ponte en contacto con el administrador de base de datos.");
                        }
                        var perfil = new Perfil();
                        perfil.Nombre = nombrePerfil;
                        if (_perfilesServicio.RegistrarPerfil(perfil) == 1)
                        {
                            MessageBox.Show("Se agrego el perfil correctamente");
                            ActualizarGrilla(_perfilesServicio.ObtenerTodos());
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Ingrese Nombre y/o ID");
            }
        }


        public void agregarNuevoPerfil()
        {
            var idPerfil = txtID.Text;
            perfil.Nombre = txtNombre.Text;
            perfil.Id = Convert.ToInt64(idPerfil.ToString());
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var perfil = new Perfil();

            {
                if(dgvPerfiles.SelectedRows.Count == 1)
                {
                    perfil.Id = Convert.ToInt32(dgvPerfiles.SelectedRows[0].Cells[0].Value.ToString());
                    if(_perfilesServicio.EliminarPerfil(perfil) == 1)
                    {
                        MessageBox.Show("Se elimino el ID " + perfil.Id+" correctamente");
                        var perfiles = _perfilesServicio.ObtenerTodos();
                        ActualizarGrilla(perfiles);
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione una celda");
                }
            }
        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            var perfil = new Perfil();

            {
                if (dgvPerfiles.SelectedRows.Count == 1)
                {
                    perfil.Id = Convert.ToInt32(dgvPerfiles.SelectedRows[0].Cells[0].Value.ToString());
                    new FrmModificarPerfil(perfil.Id).Show();
                    

                }
                else
                {
                    MessageBox.Show("Seleccione una celda");
                }
            }
        }

        private void dgvPerfiles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBoxRefrescar_Click(object sender, EventArgs e)
        {
            this.dgvPerfiles.Rows.Clear();
            this.txtNombre.Clear();
            this.txtID.Clear();
            var tabla = new DataTable();
            tabla = _perfilesRep.recuperarPerfiles();
            cargarGrilla(this.dgvPerfiles, tabla);
        }

        public void cargarGrilla(DataGridView grilla, DataTable tabla)
        {
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grilla.Rows.Add(tabla.Rows[i]["Id_perfil"],
                    tabla.Rows[i]["nombre"]);
            }
        }

        private void txtID_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void ChkIncluirInactivos_CheckedChanged(object sender, EventArgs e)
        {
            if (this.ChkIncluirInactivos.Checked)
            {
                this.dgvPerfiles.Rows.Clear();
                tabla = _perfilesRep.recuperarPerfInac();
                cargarGrilla(dgvPerfiles, tabla);
            }
            else
            {
                this.dgvPerfiles.Rows.Clear();
                tabla = _perfilesRep.recuperarPerfiles();
                cargarGrilla(dgvPerfiles, tabla);
            }
        }
    }
}
