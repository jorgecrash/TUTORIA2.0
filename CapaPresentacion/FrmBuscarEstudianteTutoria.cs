using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
   
    public partial class FrmBuscarEstudianteTutoria : Form
    {
        public string indice;
        public FrmBuscarEstudianteTutoria()
        {
            InitializeComponent();
        }
        public void MostrarTablaFicha()
        {
            N_Ficha oFicha = new N_Ficha();
            FrmFicha F = new FrmFicha();
            
            tablaBuscarTutoriaEstudiante.DataSource = oFicha.ListingEstudianteTutoria(cGuardarDatos.user);
        }

        public void Buscar_Estudiante_Tutoria()
        {
            N_Ficha oFicha = new N_Ficha();
            FrmFicha F = new FrmFicha();

            tablaBuscarTutoriaEstudiante.DataSource = oFicha.SearchingEstudiante_Tutoria(txtBuscarTutoriaEstudiante.text,cGuardarDatos.user);
        }
        private void FrmBuscarEstudianteTutoria_Load(object sender, EventArgs e)
        {
            
            //string L = F.TablaFicha.Rows[0].Cells[2].Value.ToString();
            MostrarTablaFicha();
           // MessageBox.Show(L);
        }

        private void txtBuscarTutoriaEstudiante_OnTextChange(object sender, EventArgs e)
        {
            Buscar_Estudiante_Tutoria();
            if(txtBuscarTutoriaEstudiante.text == "")
            {
                MostrarTablaFicha();
            }
            
        }

        private void tablaBuscarTutoriaEstudiante_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tablaBuscarTutoriaEstudiante_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            // frm.textNombres.Text = TablaDocente.Rows[e.RowIndex].Cells["Nombres"].Value.ToString();

            //t//his.Close();
            cGuardarDatos.IdEstudiante = tablaBuscarTutoriaEstudiante.Rows[e.RowIndex].Cells["IdEstudiante"].Value.ToString();
            cGuardarDatos.IdTutoria = tablaBuscarTutoriaEstudiante.Rows[e.RowIndex].Cells["IdTutoria"].Value.ToString();

        }

        private void tablaBuscarTutoriaEstudiante_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            cGuardarDatos.IdEstudiante = tablaBuscarTutoriaEstudiante.Rows[e.RowIndex].Cells["IdEstudiante"].Value.ToString();

            cGuardarDatos.IdTutoria = tablaBuscarTutoriaEstudiante.Rows[e.RowIndex].Cells["IdTutoria"].Value.ToString();
        }
        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
