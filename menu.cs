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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }


        private bool mouseDown = false;
        private Point lastLocation;
        private void panel1_MouseUp(object sender, MouseEventArgs e) { mouseDown = false; this.Cursor = Cursors.Default; }
        private void panel1_MouseDown(object sender, MouseEventArgs e) { mouseDown = true; lastLocation = e.Location; this.Cursor = Cursors.Hand; }
        private void panel1_MouseMove(object sender, MouseEventArgs e) { if (mouseDown) { int x = (this.Location.X - lastLocation.X) + e.X; int y = (this.Location.Y - lastLocation.Y) + e.Y; this.Location = new Point(x, y); } }
        private void close_Click(object sender, EventArgs e) { if (MessageBox.Show("voullez vous quitter application ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes) { Application.Exit(); } }
        private void minimaze_Click(object sender, EventArgs e) { this.WindowState = FormWindowState.Minimized; }



        private void menu_Load(object sender, EventArgs e)
        {

        }

        private void btnFacture_MouseHover(object sender, EventArgs e)
        {
            btnFacture.BorderStyle = BorderStyle.Fixed3D;
        }

        private void BtnConfig_MouseHover(object sender, EventArgs e)
        {
            BtnConfig.BorderStyle = BorderStyle.Fixed3D;
        }

        private void BtnBackup_MouseHover(object sender, EventArgs e)
        {
            BtnBackup.BorderStyle = BorderStyle.Fixed3D;
        }

        private void BtnConfig_MouseLeave(object sender, EventArgs e)
        {
            BtnConfig.BorderStyle = BorderStyle.FixedSingle;
        }

        private void BtnBackup_MouseLeave(object sender, EventArgs e)
        {
            BtnBackup.BorderStyle = BorderStyle.FixedSingle;
        }

        private void btnFacture_MouseLeave(object sender, EventArgs e)
        {
            btnFacture.BorderStyle = BorderStyle.FixedSingle;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnFacture_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void BtnConfig_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void BtnBackup_Paint(object sender, PaintEventArgs e)
        {
          
        }
        ClassConfiguration cc = new ClassConfiguration();
        private void btnFacture_Click(object sender, EventArgs e)
        {
            if (cc.VerifierIfExist())
            {
                facturation f = new facturation();
                this.Hide();
                f.Show();
            }
            else
            {
                MessageBox.Show("!!");
            }

            
        }

        private void BtnConfig_Click(object sender, EventArgs e)
        {
            configuration c = new configuration();
            this.Hide();
            c.Show();
        }

        private void BtnBackup_Click(object sender, EventArgs e)
        {
            if (cc.VerifierIfExist())
            {
                back_up b = new back_up();
                this.Hide();
                b.Show();
            }
            else
            {
                MessageBox.Show("!!");
            }


            
        }
    }
}
