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
    public partial class FrmWelcome : Form
    {
        public FrmWelcome()
        {
            InitializeComponent();
        }
        private void FrmWelcome_Load(object sender, EventArgs e)
        {
            //NombreUsuario.Text=Text.usu
            this.Opacity = 0.0;
            timer1.Start(); 

        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.05;
            ProgressBa.Value += 1;
            if (ProgressBa.Value == 100)
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.05;
            if (this.Opacity==0)
            {
                timer2.Stop();
                this.Close(); 
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        private void NombreUsuario_Click(object sender, EventArgs e)
        {

        }

        private void FrmWelcome_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaTransfarantPictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
