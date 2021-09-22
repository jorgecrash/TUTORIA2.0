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
using System.Configuration;
using CapaEntidades.Cache;

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        public string usuario;
        public string clave;
        int m, mx, my;
        public Login()
        {
            InitializeComponent();
            //buttonIngresar.Focus();

        }
        FrmMain M = new FrmMain();
        FrmWelcome F = new FrmWelcome();
        public  bool logins(string user, string clav)
        {
            
            SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);
            try
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("SELECT * from Logins  WHERE Usuario=@Usuario AND Contraseña=@Contraseña", conexion);
                cmd.Parameters.AddWithValue("Usuario", user);
                cmd.Parameters.AddWithValue("Contraseña", clav);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    // this.Hide();
                    MessageBox.Show("Login exitoso.");
                    // FrmFicha F = new FrmFicha();
                    F.NombreUsuario.Text = dt.Rows[0][0].ToString();

                    M.labelUsuario.Text = txtusuario.Text;
                    M.labelCategoriaU.Text = dt.Rows[0][2].ToString();
                    conexion.Close();
                    return true;
                }
                else
                {
                    if (txtusuario.Text == "" && txtcontraseña.Text != "")
                    {
                        msgError("Llenar el campo usuario");
                        txtusuario.Focus();
                    }
                    else if (txtusuario.Text != "" && txtcontraseña.Text == "")
                    {
                        msgError("Llenar el campo contraseña");
                        txtcontraseña.Focus();
                    }
                    else if (txtusuario.Text == "" && txtcontraseña.Text == "")
                    {
                        msgError("Llenar ambos campos");
                        txtusuario.Focus();
                    }
                    else
                    {
                        msgError("Error Usuario i/o Contraseña");
                        txtusuario.Text = "";
                        txtcontraseña.Text = "";
                        txtusuario.Focus();
                    }
                   // conexion.Close();
                    return false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                conexion.Close();
                return false;

            }

        }

        private void msgError(string msg)
        {
            lblError.Text = msg;
            lblError.Visible = true;
        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {

        }
        public string obtenerusuario()
        {
            usuario = txtusuario.Text;
            return usuario;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta opción estara disponible muy pronto :v");
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            usuario = txtusuario.Text;
            clave = txtcontraseña.Text;
            bool v = logins(usuario,clave);
            if (v)
            {
               
                this.Hide();
                F.ShowDialog();
                M.ShowDialog();
            }
            
        }
        
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;
        }
        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void labelContraseña_Click(object sender, EventArgs e)
        {

        }

        private void txtusuario_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void labelUsuario_Click(object sender, EventArgs e)
        {

        }

        private void lblError_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }
        // metodo para aumatizar el cursor del texto al presionar enter
        private void txtusuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                usuario = txtusuario.Text;
                clave = txtcontraseña.Text;
                bool v = logins(usuario, clave);
                txtcontraseña.Focus();
            }
            else if (e.KeyChar == Convert.ToChar(Keys.Escape))
            {
                Application.Exit();
            }

        }
        private void txtcontraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                usuario = txtusuario.Text;
                clave = txtcontraseña.Text;
                bool v = logins(usuario, clave);
            }
            else if (e.KeyChar == Convert.ToChar(Keys.Escape))
            {
                Application.Exit();
            }
        }
    }
}
