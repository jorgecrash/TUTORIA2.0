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
    public partial class FrmDocente : Form
    {
        N_Docente oDocente = new N_Docente();
        public FrmDocente()
        {
            InitializeComponent();
            MostrarTablaDocente();
            OcultarMoverAncharColumnas();
        }

        public void OcultarMoverAncharColumnas()
        {
            TablaDocente.Columns[0].DisplayIndex = 8;
            TablaDocente.Columns[1].DisplayIndex = 8;

        }
        public void MostrarTablaDocente()
        {
            N_Docente oDocente = new N_Docente();
            TablaDocente.DataSource = oDocente.ListingDocente();
        }
        public void BuscarDocente(string search)
        {
            N_Docente oDocente = new N_Docente();
            TablaDocente.DataSource = oDocente.SearchingDocente(search);

        }
        public void textBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarDocente(textBuscar.Text);
        }
        private void btnNuevoDocente_Click(object sender, EventArgs e)
        {
            FrmMantDocente frm = new FrmMantDocente();
            frm.ShowDialog();
            frm.Update = false;
            MostrarTablaDocente();
            //  ShowTotal();
        }
        private void TablaDocente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (TablaDocente.Rows[e.RowIndex].Cells["eliminar"].Selected)
            {
                Form message = new FrmInformation("¿ESTAS SEGURO DE ELIMINAR EL DOCENTE?");
                DialogResult result = message.ShowDialog();

                if (result == DialogResult.OK)
                {
                    string delete = TablaDocente.Rows[e.RowIndex].Cells[2].Value.ToString();
                    oDocente.DeletingDocente(delete);
                    FrmSuccess.confirmacionForm("ELIMINADO");
                    MostrarTablaDocente();
                    // ShowTotal();
                }
            }
            else if (TablaDocente.Rows[e.RowIndex].Cells["editar"].Selected)
            {
                FrmMantDocente frm = new FrmMantDocente();
                frm.Update = true;
                frm.textCodigo.Text = TablaDocente.Rows[e.RowIndex].Cells["IdDocente"].Value.ToString();
                frm.textNombres.Text = TablaDocente.Rows[e.RowIndex].Cells["Nombres"].Value.ToString();
                frm.textApellidos.Text = TablaDocente.Rows[e.RowIndex].Cells["Apellidos"].Value.ToString();
                frm.textTitulo.Text = TablaDocente.Rows[e.RowIndex].Cells["TituloAcademico"].Value.ToString();
                frm.comboBoxFacultad.Text = TablaDocente.Rows[e.RowIndex].Cells["Facultad"].Value.ToString();
                frm.comboBoxEscuela.Text = TablaDocente.Rows[e.RowIndex].Cells["EscuelaProfesional"].Value.ToString();
                frm.comboBoxCategoria.Text = TablaDocente.Rows[e.RowIndex].Cells["Categoria"].Value.ToString();

                frm.ShowDialog();
                MostrarTablaDocente();
                //ShowTotal();
            }
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Click(object sender, EventArgs e)
        {

        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
