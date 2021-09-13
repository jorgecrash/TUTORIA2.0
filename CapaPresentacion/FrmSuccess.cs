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
    public partial class FrmSuccess : Form
    {
        public FrmSuccess(string mensaje)
        {
            InitializeComponent();
            label1.Text = mensaje;
        }

        private void FrmSuccess_Load(object sender, EventArgs e)
        {
           // esclarecerForm.ShowAsyc(this);
        }
        public static void confirmacionForm(string mensaje)
        {
            FrmSuccess frm = new FrmSuccess(mensaje);
            frm.ShowDialog();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
