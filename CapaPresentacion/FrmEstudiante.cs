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
    public partial class FrmEstudiante : Form
    {

        N_Estudiante oEstudiante = new N_Estudiante();
        public FrmEstudiante()
        {
            InitializeComponent();
            MostrarTablaEstudiante();
            OcultarMoverAncharColumnas();
        }
        //METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO  TIEMPO DE EJECUCION ----------------------------------------------------------
        private int tolerance = 15;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;
        public void PantallaOk()
        {
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        public void OcultarMoverAncharColumnas()
        {
            TablaEstudiante.Columns[0].DisplayIndex = 8;//0
            TablaEstudiante.Columns[1].DisplayIndex = 8;//1


        }
        public void MostrarTablaEstudiante()
        {
            N_Estudiante oEstudiante = new N_Estudiante();
            TablaEstudiante.DataSource = oEstudiante.ListingStudents();
        }
        public void BuscarEstudiante(string search)
        {
            N_Estudiante oEstudiante = new N_Estudiante();////////////////////////////OJO///////////-_-
            TablaEstudiante.DataSource = oEstudiante.SearchingStudents(search);

        }
        public void textBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarEstudiante(textBuscar.Text);
        }
        private void btnNuevoEstudiante_Click(object sender, EventArgs e)
        {
            FrmMantEstudiante frm = new FrmMantEstudiante();
            frm.ShowDialog();
            frm.Update = false;
            MostrarTablaEstudiante();
            //  ShowTotal();
        }
        private void TablaEstudiante_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (TablaEstudiante.Rows[e.RowIndex].Cells["eliminar"].Selected)
            {
                Form message = new FrmInformation("¿ESTAS SEGURO DE ELIMINAR EL ESTUDIANTE?");
                DialogResult result = message.ShowDialog();

                if (result == DialogResult.OK)
                {
                    string delete = TablaEstudiante.Rows[e.RowIndex].Cells["IdEstudiante"].Value.ToString();
                    oEstudiante.DeletingStudents(delete);
                    FrmSuccess.confirmacionForm("ELIMINADO");
                    MostrarTablaEstudiante();
                    // ShowTotal();
                }
            }
            else if (TablaEstudiante.Rows[e.RowIndex].Cells["editar"].Selected)
            {
                FrmMantEstudiante frm = new FrmMantEstudiante();
                frm.Update = true;
                frm.IdEstudiante= TablaEstudiante.Rows[e.RowIndex].Cells["IdEstudiante"].Value.ToString();
                frm.textNombres.Text = TablaEstudiante.Rows[e.RowIndex].Cells["Nombres"].Value.ToString();
                frm.textApellidos.Text = TablaEstudiante.Rows[e.RowIndex].Cells["Apellidos"].Value.ToString();
                frm.txtSemestreActivo.Text = TablaEstudiante.Rows[e.RowIndex].Cells["SemestreActivo"].Value.ToString();
                frm.textEscuela.Text = TablaEstudiante.Rows[e.RowIndex].Cells["EscuelaProfesional"].Value.ToString();
                frm.txtIdEP.Text = TablaEstudiante.Rows[e.RowIndex].Cells["codigoEP"].Value.ToString();
                frm.txtIngreso.Text = TablaEstudiante.Rows[e.RowIndex].Cells["AIngreso"].Value.ToString();

                frm.ShowDialog();
                MostrarTablaEstudiante();
                //ShowTotal();
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
