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
    public partial class FrmHistorialEstudianteTutoria : Form
    {
        public FrmHistorialEstudianteTutoria()
        {
            InitializeComponent();
        }
        public void MostrarTablaHistorialEstudiante()
        {
            N_Ficha oFicha = new N_Ficha();
            FrmMantFicha F = new FrmMantFicha();
           // MessageBox.Show(cGuardarDatos.IdEstudiante);

            TablaHistorial.DataSource = oFicha.ListingHistorialEstudiante(cGuardarDatos.IdEstudiante);
        }
        private void FrmHistorialEstudianteTutoria_Load(object sender, EventArgs e)
        {
            
            MostrarTablaHistorialEstudiante();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }

        private void TablaHistorial_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmFicha F = new FrmFicha();
            cGuardarDatos.FechaHistorial= TablaHistorial.Rows[e.RowIndex].Cells["Fecha"].Value.ToString();
            cGuardarDatos.DesHistorial = F.DesEncriptar(TablaHistorial.Rows[e.RowIndex].Cells["Descripcion"].Value.ToString());
            cGuardarDatos.TipoTutoriaHistorial = TablaHistorial.Rows[e.RowIndex].Cells["TipoTutoria"].Value.ToString();

        }
    }
}
