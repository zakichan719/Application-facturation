using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace facturation
{
    public partial class back_up : Form
    {
        public back_up()
        {
            InitializeComponent();
        }

        private void minimaze_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void back_up_Load(object sender, EventArgs e)
        {
               
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            hidepanel.Visible = false;
        }

        private void close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("voullez vous fermer cette fenetre", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes) { this.Close(); Application.OpenForms[1].Show(); }
        }
    }
}
