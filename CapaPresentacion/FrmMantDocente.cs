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
    public partial class FrmMantDocente : Form
    {
        public bool Update = false;
        E_Docente entities = new E_Docente();
        N_Docente business = new N_Docente();

        public FrmMantDocente()
        {
            InitializeComponent();
        }
        private void FrmMantDocente_Load(object sender, EventArgs e)
        {

        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool validar()
        {
            bool ok = true;

            string name = textNombres.Text;
            string apellido = textApellidos.Text;
            string titulo = textTitulo.Text;
            string facultad = comboBoxFacultad.Text;
            string escuela = comboBoxEscuela.Text;
            string categoria = comboBoxCategoria.Text;

            string vacio = string.Empty;

            if (name == vacio) { ok = false; errorProvider1.SetError(textNombres, "Rellene el campo"); }
            if (apellido == vacio) { ok = false; errorProvider1.SetError(textApellidos, "Rellene el campo"); }
            if (titulo == vacio) { ok = false; errorProvider1.SetError(textTitulo, "Rellene el campo"); }
            if (facultad == vacio) { ok = false; errorProvider1.SetError(comboBoxFacultad, "Rellene el campo"); }
            if (escuela == vacio) { ok = false; errorProvider1.SetError(comboBoxEscuela, "Rellene el campo"); }
            if (categoria == vacio) { ok = false; errorProvider1.SetError(comboBoxCategoria, "Rellene el campo"); }

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

        void metod_validating_ComboBox(System.Windows.Forms.ComboBox pTextBox)
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (validar())
            {
                if (Update == false)
                {
                    try
                    {
                        entities.Nombres = textNombres.Text;
                        //   entities.IdEstudiante = Convert.ToInt32(textCodigo.Text);
                        entities.Apellidos = textApellidos.Text;
                        entities.TituloAcademico = textTitulo.Text;
                        entities.Facultad = comboBoxFacultad.Text;
                        entities.EscuelaProfesional = comboBoxEscuela.Text;
                        entities.Categoria = comboBoxCategoria.Text;

                        business.CreatingDocente(entities);
                        FrmSuccess.confirmacionForm("DOCENTE GUARDADO");
                        Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo guardar la categoria" + ex);
                    }
                }
                if (Update == true)
                {
                    try
                    {
                        entities.Nombres = textNombres.Text;
                        // entities.IdEstudiante = Convert.ToInt32(textCodigo.Text);
                        entities.Apellidos = textApellidos.Text;
                        entities.TituloAcademico = textTitulo.Text;
                        entities.Facultad = comboBoxFacultad.Text;
                        entities.EscuelaProfesional = comboBoxEscuela.Text;
                        entities.Categoria = comboBoxCategoria.Text;

                        business.UpdatingDocente(entities);

                        //     successView.confirmForm("PRODUCTO EDITADO");
                        FrmSuccess.confirmacionForm("DOCENTE EDITADO");
                        Close();

                        Update = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo editar la categoria" + ex);
                    }
                }
            }
            else
            {
                MessageBox.Show("Rellene todos los campos");
            }
            
        }


        private void textNombres_Validating(object sender, CancelEventArgs e)
        {
            metod_validating_TextBox(textNombres);
        }

        private void textApellidos_TextChanged(object sender, EventArgs e)
        {
            metod_validating_TextBox(textApellidos);
        }

        private void textTitulo_TextChanged(object sender, EventArgs e)
        {
            metod_validating_TextBox(textTitulo);
        }

        private void comboBoxFacultad_Validating(object sender, CancelEventArgs e)
        {
            metod_validating_ComboBox(comboBoxFacultad);
        }

        private void comboBoxEscuela_Validating(object sender, CancelEventArgs e)
        {
            metod_validating_ComboBox(comboBoxEscuela);
        }

        private void comboBoxCategoria_Validating(object sender, CancelEventArgs e)
        {
            metod_validating_ComboBox(comboBoxCategoria);
        }
    }
}
