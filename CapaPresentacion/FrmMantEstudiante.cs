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
using System.Data.SqlClient;
using System.Configuration;

namespace CapaPresentacion
{
    public partial class FrmMantEstudiante : Form
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);
        public bool Update = false;
        public string IdEstudiante = "";
        E_Estudiante entities = new E_Estudiante();
        N_Estudiante business = new N_Estudiante();

        public FrmMantEstudiante()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Update == false)
            {
                try
                { 
                    entities.Nombres = textNombres.Text;
                    //   entities.IdEstudiante = Convert.ToInt32(textCodigo.Text);
                    entities.Apellidos = textApellidos.Text;
                    entities.EscuelaProfesional = textEscuela.Text;
                    entities.CodEP = txtIdEP.Text;
                   // entities.Estudiante = txtCodEstudiante.Text;
                    entities.AIngreso = txtIngreso.Text;
                    entities.SemestreActivo = txtSemestreActivo.Text;
                    business.CreatingStudents(entities);
                    FrmSuccess.confirmacionForm("ESTUDIANTE GUARDADO");
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
                    entities.CodEstudiante = IdEstudiante;
                    entities.Nombres = textNombres.Text;
                    // entities.IdEstudiante = Convert.ToInt32(textCodigo.Text);
                    entities.Apellidos = textApellidos.Text;
                    entities.EscuelaProfesional = textEscuela.Text;
                    entities.CodEP = txtIdEP.Text;
                    //entities.Estudiante = txtCodEstudiante.Text;
                    entities.AIngreso = txtIngreso.Text;
                    entities.SemestreActivo = txtSemestreActivo.Text;
                    business.UpdatingStudents(entities);

                    //     successView.confirmForm("PRODUCTO EDITADO");
                    FrmSuccess.confirmacionForm("ESTUDIANTE EDITADO");
                    Close();

                    Update = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo editar la categoria" + ex);
                }
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textNombres_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExportarCSV_Click(object sender, EventArgs e)
        {
            ofdInsertar.ShowDialog();
            lblUbicacionCSV.Text = ofdInsertar.FileName;//muestra el nombre del archivo en un label
            lblUbicacionCSV.Visible = true;
            DatosCSV(lblUbicacionCSV.Text);
        }

        private void DatosCSV(string file)// Metodo que permite seleccionar y leer un archivo csv
        {
            DataTable dt = new DataTable();// crea un objeto de una tabla para almacenar los datos
            string[] lines = System.IO.File.ReadAllLines(file);// arreglo que guarda las lineas dentro
                                                               // del archivo

            if (lines.Length > 0)//condicion que permite verificar si el archivo tiene datos
            {
                string firstline = lines[0];
                string[] titulo = firstline.Split(';');//permite separar los campos del archivo
                foreach (string cTitulo in titulo)
                {
                    dt.Columns.Add(new DataColumn(cTitulo));// crea las columnas con su respectivo titulo para
                                                            // mostrar en el gridview
                }

                for (int i = 1; i < lines.Length; i++)//ciclo permite verificar que lleguemos a la ultima linea
                                                      //dentro del archivo
                {
                    string[] valores = lines[i].Split(';');
                    DataRow dr = dt.NewRow();
                    int columN = 0;
                    foreach (string cTitulo in titulo)
                    {
                        dr[cTitulo] = valores[columN++];//almacena lo que tiene cada fila y columna
                    }
                    dt.Rows.Add(dr);//crea los files con los campos separados para mostrar como una tabla
                }
            }
            if (dt.Rows.Count > 0)//verifica si se crearon las filas
            {
                dgvDatosCSV.DataSource = dt;//imprime el data gridview
            }
        }

        private void btnGuardarDatosCSV_Click(object sender, EventArgs e)
        {
            SqlCommand agregar = new SqlCommand("insert into Estudiante values (@IdEstudiante,@Nombres,@Apellidos,@SemestreActivo,@EscuelaProfesional,@codigoEP,@AIngreso)", conexion);
            conexion.Open();
            try
            {
                foreach (DataGridViewRow row in dgvDatosCSV.Rows)
                {
                    agregar.Parameters.Clear();
                    agregar.Parameters.AddWithValue("@IdEstudiante", Convert.ToString(row.Cells[0].Value));
                    agregar.Parameters.AddWithValue("@Nombres", Convert.ToString(row.Cells[1].Value));
                    agregar.Parameters.AddWithValue("@Apellidos", Convert.ToString(row.Cells[2].Value));
                    agregar.Parameters.AddWithValue("@SemestreActivo", Convert.ToString(row.Cells[3].Value));
                    agregar.Parameters.AddWithValue("@EscuelaProfesional", Convert.ToString(row.Cells[4].Value));
                    agregar.Parameters.AddWithValue("@codigoEP", Convert.ToString(row.Cells[5].Value));
                    agregar.Parameters.AddWithValue("@AIngreso", Convert.ToString(row.Cells[6].Value));

                    agregar.ExecuteNonQuery();
                }
                MessageBox.Show("Datos Agregados");
            }
            catch (Exception ex)
            {
                // Qué ha sucedido
                var mensaje = "Error message: " + ex.Message;
                MessageBox.Show(mensaje);
            }
            finally
            {
                conexion.Close();
            }
        }

        private void FrmMantEstudiante_Load(object sender, EventArgs e)
        {
            dgvDatosCSV.AllowUserToAddRows = false;
        }
    }
}
