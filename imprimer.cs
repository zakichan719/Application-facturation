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
    public partial class imprimer : Form
    {
        int iddFD;
        public imprimer(int iddFD)
        {
            this.iddFD = iddFD;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
               this.DataTable1TableAdapter.Fill(this.DataSetF.DataTable1,(short)iddFD);
               this.reportViewer1.RefreshReport();




            
        }

      

         

        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close(); Application.OpenForms[2].Show();
        }

        private void minimaze_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close(); Application.OpenForms[2].Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
