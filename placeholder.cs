using System.Drawing;
using System.Windows.Forms;

namespace facturation
{

   
    public  class placeholder
    {
 

        public void enter(Control c, string text, string foreColor = "black", string backColor = "white")
        {
            if (c.Text == text)
            {
                c.Text = "";
            }
            //--
            if (foreColor.ToLower() == "black")
            {
                c.ForeColor = Color.FromArgb(0, 0, 64);  
            }
            else
                c.ForeColor = Color.White;
            //--
            if (backColor.ToLower() == "white")
            {
                c.BackColor = Color.White;
            }
            else
                c.BackColor = Color.FromArgb(0, 0, 64);



        }

        public void leave(Control c, string text, string foreColor = "white", string backColor = "black")
        {
            if (c.Text == "")
            {
                c.Text = text;
            }
            //--
            if (foreColor.ToLower() == "white")
            {
                c.ForeColor = Color.White;
            }
            else
                c.ForeColor = Color.FromArgb(0, 0, 64);
            //--
            if (backColor.ToLower() == "black")
            {
                c.BackColor = Color.FromArgb(0, 0, 64);
            }
            else
                c.BackColor = Color.White;


        }

    }
}
