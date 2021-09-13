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
    public partial class FrmMantTutoria : Form
    {
        public bool Update = false;
        E_Tutoria entities = new E_Tutoria();
        N_Tutoria business = new N_Tutoria();
        public FrmMantTutoria()
        {
            InitializeComponent();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Update == false)
            {
                if (AlertasForms.ValidarTxtBoxFormulario(this, errorProvider1) == false)
                {
                    try
                    {
                        entities.IdTutoria = textId.Text;
                        entities.IdDocente = textIdDocente.Text;
                        entities.Horario = dtpFecha.Value.Date.ToString("dd/MM/yyyy") +"  "+ dtpHora.Value.TimeOfDay.ToString();
                        business.CreatingTutoria(entities);
                        FrmSuccess.confirmacionForm("TUTOR REGISTRADO");
                        Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo guardar Tutor ");
                    }
                }
            }
            if (Update == true)
            {
                if (AlertasForms.ValidarTxtBoxFormulario(this, errorProvider1) == false)
                {
                    try
                    {
                        entities.IdTutoria = textId.Text;
                        entities.IdDocente = textIdDocente.Text; ;
                        entities.Horario = dtpFecha.Value.Date.ToString("dd/MM/yyyy") +"  "+dtpHora.Value.TimeOfDay.ToString();


                        business.UpdatingTutoria(entities);

                        //     successView.confirmForm("PRODUCTO EDITADO");
                        FrmSuccess.confirmacionForm("TUTORIA EDITADA");
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

        private void FrmMantTutoria_Load(object sender, EventArgs e)
        {
            MostrarTablaTutoriaDocente();
        }
        public void MostrarTablaTutoriaDocente()
        {
            dgvDocenteTutoria.DataSource = business.ListingDocenteTutorias();
        }
        private void dgvDocenteTutoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textIdDocente.Text = dgvDocenteTutoria.Rows[e.RowIndex].Cells["IdDocente"].Value.ToString();
        }
        public void BuscarDocenteTutoria(string search)
        {
            dgvDocenteTutoria.DataSource = business.BuscarDocenteTutorias(search);
        }

        private void txtNomDocenteTutor_TextChanged(object sender, EventArgs e)
        {
            BuscarDocenteTutoria(txtNomDocenteTutor.Text);
        }

        private void textIdDocente_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void topFormulario_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

