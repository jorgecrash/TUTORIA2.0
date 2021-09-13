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
    public partial class FrmFicha : Form
    {
        
        N_Ficha oFicha = new N_Ficha();
        public string Log;
        public FrmFicha()
        {
            InitializeComponent();
            //string a = af.labelUsuario.Text;
            
        }
        public void OcultarMoverAncharColumnas()
        {
            TablaFicha.Columns[0].DisplayIndex = 13;
            TablaFicha.Columns[1].DisplayIndex = 13;

        }
        public void MostrarTablaFicha()
        {
            N_Ficha oFicha = new N_Ficha();
            TablaFicha.DataSource = oFicha.ListingFichas(Log);
        }
        public void BuscarFicha(string search)
        {
            N_Ficha oFicha = new N_Ficha();
            TablaFicha.DataSource = oFicha.SearchingFichas(search);

        }
        private void textBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarFicha(textBuscar.Text);
            if (textBuscar.Text == "")
            {
                MostrarTablaFicha();
            }
        }
        private void btnAgregarFicha_Click(object sender, EventArgs e)
        {
            FrmMantFicha frm = new FrmMantFicha();
            frm.ShowDialog();
            frm.Update = false;
            MostrarTablaFicha();
        }
        public string DesEncriptar(string _cadenaAdesencriptar)
        {
            string result = string.Empty;
            byte[] decryted = Convert.FromBase64String(_cadenaAdesencriptar);
            //result = System.Text.Encoding.Unicode.GetString(decryted, 0, decryted.ToArray().Length);
            result = System.Text.Encoding.Unicode.GetString(decryted);
            return result;
        }
        private void TablaFicha_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (TablaFicha.Rows[e.RowIndex].Cells["eliminar"].Selected)
            {
                Form message = new FrmInformation("¿ESTAS SEGURO DE ELIMINAR LA FICHA DE TUTORIA?");
                DialogResult result = message.ShowDialog();

                if (result == DialogResult.OK)
                {
                    string delete = TablaFicha.Rows[e.RowIndex].Cells[2].Value.ToString();
                    oFicha.DeletingFicha(delete);
                    FrmSuccess.confirmacionForm("ELIMINADO");
                    MostrarTablaFicha();
                    // ShowTotal();
                }
            }
            else if (TablaFicha.Rows[e.RowIndex].Cells["editar"].Selected)
            {
                FrmMantFicha frm = new FrmMantFicha();
                frm.Update = true;
                //frm.textId.Text = TablaFicha.Rows[e.RowIndex].Cells["IdFichaTutoria"].Value.ToString();
                frm.textIdTutoria.Text = TablaFicha.Rows[e.RowIndex].Cells["IdTutoria"].Value.ToString();
                frm.textIdEstudiante.Text = TablaFicha.Rows[e.RowIndex].Cells["IdEstudiante"].Value.ToString();
                frm.textNroCelular.Text = TablaFicha.Rows[e.RowIndex].Cells["NroCelular"].Value.ToString();
                frm.textDireccion.Text = TablaFicha.Rows[e.RowIndex].Cells["Direccion"].Value.ToString();
                frm.textEmail.Text = TablaFicha.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                frm.textPersonaReferencia.Text = TablaFicha.Rows[e.RowIndex].Cells["PersonaReferencia"].Value.ToString();
                frm.textCelularReferencia.Text = TablaFicha.Rows[e.RowIndex].Cells["CelularReferencia"].Value.ToString();
                frm.dtpFecha.Text = TablaFicha.Rows[e.RowIndex].Cells["Fecha"].Value.ToString();
                frm.comboBoxTipoTutoria.Text = TablaFicha.Rows[e.RowIndex].Cells["TipoTutoria"].Value.ToString();
                frm.richTextBoxDescripcion.Text = DesEncriptar(TablaFicha.Rows[e.RowIndex].Cells["Descripcion"].Value.ToString());


                frm.ShowDialog();
                MostrarTablaFicha();
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

        private void FrmFicha_Load(object sender, EventArgs e)
        {
            MostrarTablaFicha();
            OcultarMoverAncharColumnas();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}