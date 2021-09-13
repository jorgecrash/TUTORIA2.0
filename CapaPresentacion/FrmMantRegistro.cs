using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidades;

namespace CapaPresentacion
{
    public partial class FrmMantRegistro : Form
    {
        public bool Update = false;
        E_Registro entities = new E_Registro();
        N_Registro business = new N_Registro();
        public FrmMantRegistro()
        {
            InitializeComponent();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (textIdEstudiante.Text == "")
            {
                MessageBox.Show("Seleccionar un Estudiante");
            }
            else if (textIdTutoria.Text == "")
            {

                MessageBox.Show("Seleccionar Tutoria");

            }
            else
            {
                if (Update == false)
                {
                    try
                    {
                        entities.IdTutoria = textIdTutoria.Text;
                        entities.IdEstudiante = textIdEstudiante.Text;

                        business.CreatingTutorado(entities);
                        FrmSuccess.confirmacionForm("TUTORADO GUARDADO");
                        Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo guardar la categoria " + ex);
                    }
                }
                if (Update == true)
                {
                    try
                    {
                        entities.IdTutoria = textIdTutoria.Text;
                        entities.IdEstudiante = textIdEstudiante.Text;

                        business.UpdatingTutorado(entities);

                        //     successView.confirmForm("PRODUCTO EDITADO");
                        FrmSuccess.confirmacionForm("TUTORADO EDITADO");
                        Close();

                        Update = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo editar la categoria " + ex);
                    }
                }
            }
        }
        public void ListarEstudianteRegistrar()
        {
            N_Registro oTutorado = new N_Registro();
            dgvEstudianteRegistrarTutoria.DataSource = oTutorado.ListingLISTAREGISTROESTUDIANTETUTORIA();
        }
        public void ListarDocenteRegistrar()
        {
            N_Registro oTutorado = new N_Registro();
            dgvRegistroDocenteTutoria.DataSource = oTutorado.ListingLISTAREGISTRODOCENTETUTORIA();
        }

        private void FrmMantRegistro_Load(object sender, EventArgs e)
        {
            ListarEstudianteRegistrar();
            ListarDocenteRegistrar();
            MejorarTablaListarDocenteRegistrar();
            MejorarTablaListarEstudianteRegistrar();
        }

        private void dgvRegistroDocenteTutoria_MouseClick(object sender, MouseEventArgs e)
        {
            //evento
            
        }
        public void MejorarTablaListarDocenteRegistrar()
        {
            dgvRegistroDocenteTutoria.Columns[0].Width = 50;
            dgvRegistroDocenteTutoria.Columns[1].Width = 160;
            dgvRegistroDocenteTutoria.Columns[2].Width = 106;
            dgvRegistroDocenteTutoria.ClearSelection();
        }
        public void MejorarTablaListarEstudianteRegistrar()
        {
            dgvEstudianteRegistrarTutoria .Columns[0].Width = 70;
            dgvEstudianteRegistrarTutoria.Columns[1].Width = 250;

            dgvEstudianteRegistrarTutoria.ClearSelection();
        }
        private void dgvRegistroDocenteTutoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvEstudianteRegistrarTutoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textIdEstudiante.Text = dgvEstudianteRegistrarTutoria.Rows[e.RowIndex].Cells["IdEstudiante"].Value.ToString();
        }

        private void dgvRegistroDocenteTutoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textIdTutoria.Text = dgvRegistroDocenteTutoria.Rows[e.RowIndex].Cells["IdTutoria"].Value.ToString();
        }
        public void BuscarREGISTROTUTOR(string search)
        {

            dgvRegistroDocenteTutoria.DataSource = business.SearchingREGISTRO_TUTOR(search);

        }
        public void BuscarREGISTROESTUDIANTE(string search)
        {

           dgvEstudianteRegistrarTutoria.DataSource = business.SearchingREGISTRO_ESTUDIANTE(search);

        }
        private void txtBuscarTutoriaDocente_TextChanged(object sender, EventArgs e)
        {
            BuscarREGISTROTUTOR(txtBuscarTutoriaDocente.Text);
        }

        private void txtBuscarTutoriaEstudiante_TextChanged(object sender, EventArgs e)
        {
            BuscarREGISTROESTUDIANTE(txtBuscarTutoriaEstudiante.Text);
        }
    }
}
