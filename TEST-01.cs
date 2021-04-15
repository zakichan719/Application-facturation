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
    public partial class TEST_01 : Form
    {
        public TEST_01()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string value = string.Format("{0:D5}", int.Parse(textBox1.Text));
            MessageBox.Show(value);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
