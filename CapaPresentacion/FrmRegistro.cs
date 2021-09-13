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
    public partial class FrmRegistro : Form
    {
        N_Registro oTutorado = new N_Registro();
        public FrmRegistro()
        {
            InitializeComponent();
            MostrarTablaRegistro();
            OcultarMoverAncharColumnas();
           // TablaRegistro.Columns[0].Width = 10;
        }
        public void OcultarMoverAncharColumnas()
        {
            TablaRegistro.Columns[0].DisplayIndex = 10;//0
            TablaRegistro.Columns[1].DisplayIndex = 10;//1
          

        }
        public void MostrarTablaRegistro()
        {
            N_Registro oTutorado = new N_Registro();
            TablaRegistro.DataSource = oTutorado.ListingTutorados();
            
        }
        public void BuscarTutorado(string search)
        {
            N_Registro oTutorado = new N_Registro();
            TablaRegistro.DataSource = oTutorado.SearchingTutorados(search);

        }
        private void textBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarTutorado(textBuscar.Text);
        }

        private void btnRegistrarEstudianteATutoria_Click(object sender, EventArgs e)
        {
            FrmMantRegistro frm = new FrmMantRegistro();
            frm.ShowDialog();
            frm.Update = false;
            MostrarTablaRegistro();
        }

        private void TablaRegistro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (TablaRegistro.Rows[e.RowIndex].Cells["eliminar"].Selected)
            {
                Form message = new FrmInformation("¿ESTAS SEGURO DE ELIMINAR EL TUTORADO?");
                DialogResult result = message.ShowDialog();

                if (result == DialogResult.OK)
                {
                    string delete = TablaRegistro.Rows[e.RowIndex].Cells["IdEstudiante"].Value.ToString();
                    oTutorado.DeletingTutorado(delete);
                    FrmSuccess.confirmacionForm("ELIMINADO");
                    MostrarTablaRegistro();
                    // ShowTotal();
                }
            }
            else if (TablaRegistro.Rows[e.RowIndex].Cells["editar"].Selected)
            {
                FrmMantRegistro frm = new FrmMantRegistro();
                frm.Update = true;
                frm.textIdTutoria.Text = TablaRegistro.Rows[e.RowIndex].Cells["IdTutoria"].Value.ToString();
                frm.textIdEstudiante.Text = TablaRegistro.Rows[e.RowIndex].Cells["IdEstudiante"].Value.ToString();

                frm.ShowDialog();
                MostrarTablaRegistro();
                //ShowTotal();
            }
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

