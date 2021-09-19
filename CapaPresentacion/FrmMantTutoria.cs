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
        public string IdTutoria = "";
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
            if (validar())
            {
                if (Update == false)
                {
                    try
                    {
                        entities.IdDocente = textIdDocente.Text;
                        entities.Horario = dtpFecha.Value.Date.ToString("dd/MM/yyyy") + "  " + dtpHora.Value.TimeOfDay.ToString();
                        business.CreatingTutoria(entities);
                        FrmSuccess.confirmacionForm("TUTOR REGISTRADO");
                        Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se peuede agregar");
                    }
                }
                if (Update == true)
                {
                    try
                    {
                        entities.IdTutoria = IdTutoria;
                        entities.IdDocente = textIdDocente.Text; ;
                        entities.Horario = dtpFecha.Value.Date.ToString("dd/MM/yyyy") + "  " + dtpHora.Value.TimeOfDay.ToString();


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
        private bool validar()
        {
            bool ok = true;

            string docente = textIdDocente.Text;

            string vacio = string.Empty;

            if (docente == vacio) { ok = false; errorProvider1.SetError(textIdDocente, "Este campo no puede estar vacio"); }


            return ok;
        }
        void metod_validating_TextBox(System.Windows.Forms.TextBox pTextBox)
        {
            string campo = pTextBox.Text;
            string vacio = string.Empty;
            if (campo == vacio)
            {
                errorProvider1.SetError(pTextBox, "Campo vacio");
            }
            else
            {
                errorProvider1.SetError(pTextBox, "");
            }
        }
        private void textIdDocente_Validating(object sender, CancelEventArgs e)
        {
            metod_validating_TextBox(textIdDocente);
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

