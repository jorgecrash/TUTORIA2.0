using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Reflection;

namespace CapaPresentacion
{
    public partial class FrmMain : Form
    {

        private DataSet aDatos;
        public DataSet Datos
        {
            get { return aDatos; }
        }
        public FrmMain()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;

        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
           
        }
        public void selectedBotons(Bunifu.Framework.UI.BunifuFlatButton sender)
        {

            btnEstudiantes.Textcolor = Color.WhiteSmoke;


            sender.selected = true;

            if (sender.selected)
            {
                sender.Textcolor = Color.FromArgb(98, 195, 140);
            }
        }
        private void btnEstudiantes_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmEstudiante());
        }
        private void btnDocentes_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmDocente());
        }
        //METODO PARA ABRIR FORM DENTRO DE PANEL-----------------------------------------------------
        private void AbrirFormEnPanel(object formHijo)
        {
            if (this.Wrapper.Controls.Count > 0)
                this.Wrapper.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;            
            this.Wrapper.Controls.Add(fh);
            this.Wrapper.Tag = fh;
            fh.Show();
        }
        /*private Form FormActive = null;
        private void AbrirFormulriosEnWrapper(Form FormHijo)
        {
            if (FormActive != null)
                FormActive.Close();
            FormActive = FormHijo;
            FormHijo.TopLevel = false;
            FormHijo.Dock = DockStyle.Fill;
            Wrapper.Controls.Add(FormHijo);
            Wrapper.Tag = FormHijo;
            FormHijo.BringToFront();
            FormHijo.Show();

        }*/
        private void Salir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = new DialogResult();
            Form mensaje = new FrmInformation("¿Desea cerrar sesión?");
            resultado = mensaje.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                Application.Exit();
                this.Hide();
            }
        }

        private void btnFicha_Click(object sender, EventArgs e)
        {
            if (this.Wrapper.Controls.Count > 0)
                this.Wrapper.Controls.RemoveAt(0);
            FrmFicha fh = new FrmFicha();
           // Form fh = new FrmFicha() as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.Wrapper.Controls.Add(fh);
            this.Wrapper.Tag = fh;
            
            fh.Log = labelUsuario.Text;
            cGuardarDatos.user = labelUsuario.Text;
            fh.Show();
            //AbrirFormEnPanel();
        }
        private void btnTutoria_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmTutoria());
        }

        private void btnTutorados_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmRegistro());
        }

        public DataSet EjecutarSelect(string pConsulta)
        {//-- Método para ejecutar consultas del tipo SELECT

            using (SqlConnection conexion = new SqlConnection("Server=.;Integrated Security=yes; Database=Tutorias"))
            {
                conexion.Open();
                SqlDataAdapter a = new SqlDataAdapter();
                using (SqlCommand cmd = new SqlCommand(pConsulta, conexion)) ;
                a.SelectCommand = new SqlCommand(pConsulta, conexion);
                aDatos = new DataSet();
                // aAdaptador.Fill(aDatos);
                a.Fill(aDatos);
                conexion.Close();
            }
            return aDatos;
        }
        public string ValorAtributo(string pNombreCampo)
        {//-- Recupera el valor de un atributo del dataset
            if (Datos.Tables[0].Rows.Count > 0)
            {
                return Datos.Tables[0].Rows[0][pNombreCampo].ToString();
            }
            else
                return "";
        }
        public string validarcategoria(String pusuario)
        {
            string Datos;
            string Consulta = "select * from Logins where  Usuario='" + pusuario + "'";
            EjecutarSelect(Consulta);
            Datos = ValorAtributo("CategoriaLogin");
            return Datos;
        }
        public bool ValidarAcceso()
        {
            bool categoria = false;
            if (labelCategoria.Text == "Estudiante")
            {
                categoria = true;
            }
            /*if (labelCategoria.Text == "Contratado")
            {
                categoria = true;
            }*/
            return categoria;
        }

        private void Sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Wrapper_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Minimized_Click(object sender, EventArgs e)
        {

        }

        private void Maximize_Click(object sender, EventArgs e)
        {

        }

        private void Minimized_Click_1(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
            else if (WindowState == FormWindowState.Minimized)
            {
                WindowState = FormWindowState.Normal;
            }
        }

        //METODO PARA ARRASTRAR EL FORMULARIO---------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //-------------------MAXIMIZE,MINIMIZE,CERRAR-----------------------
        int lx, ly;
        int sw, sh;

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
            btnNormal.Visible = false;
            btnMaximized.Visible = true;
        }

        private void Maximized_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            btnMaximized.Visible = false;
            btnNormal.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
        //METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO  TIEMPO DE EJECUCION ----------------------------------------------------------
        private int tolerance = 15;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }

        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));

            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);

            region.Exclude(sizeGripRectangle);
            this.Panel_Principal.Region = region;
            this.Invalidate();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Wrapper_Paint_1(object sender, PaintEventArgs e)
        {

        }

        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {

            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(55, 61, 69));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);

            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }
        //_____________________________METODO PARA MEJORAR Y OPTMIZAR LAS IMAGENES(EVITAR PARPADEO AL VECTORIZAR)____________________
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

    }
}
