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

namespace facturation
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }


        private bool mouseDown = false;
        private Point lastLocation;
        private void panel1_MouseUp(object sender, MouseEventArgs e){mouseDown = false; this.Cursor = Cursors.Default;}
        private void panel1_MouseDown(object sender, MouseEventArgs e) {mouseDown = true;lastLocation = e.Location;this.Cursor = Cursors.Hand;}
        private void panel1_MouseMove(object sender, MouseEventArgs e) {if (mouseDown){int x = (this.Location.X - lastLocation.X) + e.X; int y = (this.Location.Y - lastLocation.Y) + e.Y; this.Location = new Point(x, y); }}

        private void checkBox1_CheckedChanged(object sender, EventArgs e){ if (checkBox1.Checked) { if (txtPassword.Text != "password") { txtPassword.isPassword = false; } } else { if (txtPassword.Text != "password") { txtPassword.isPassword = true; } } }



        private void close_Click(object sender, EventArgs e) {if (MessageBox.Show("voullez vous quitter application ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes) { Application.Exit(); }}
        private void minimaze_Click(object sender, EventArgs e) { this.WindowState = FormWindowState.Minimized; }


        placeholder p = new placeholder();

        private void txtUserName_Leave(object sender, EventArgs e) { p.leave(txtUserName, "user name", "black", "white"); }
        private void txtUserName_Enter(object sender, EventArgs e) { p.enter(txtUserName, "user name", "white", "black"); }
        private void txtPassword_Enter(object sender, EventArgs e) { p.enter(txtPassword, "password", "white", "black"); if (txtPassword.Text != "password") { txtPassword.isPassword = true; checkBox1.Checked = false; } }
        private void txtPassword_Leave(object sender, EventArgs e) { p.leave(txtPassword, "password", "black", "white"); if (txtPassword.Text == "password") { txtPassword.isPassword = false; } }


        LoginClasse lc = new LoginClasse();


        private void login_Load(object sender, EventArgs e)
        {

       
            try
            {
                BtnLogin.Focus();
                  if (lc.countUser() == 0)
                { 
                    BtnLogin.Text = "active admin";
                    txtActivation.Visible = true;
                    label3.Visible = true;
                }
                else
                {
                    label3.Visible = false;
                    txtActivation.Visible = false;
                }

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
           
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {


                if (lc.countUser() == 0)
                {
                    string ac = txtActivation.Text.Trim();


                    if (lc.FunctionActivation(ac))
                    {

                        MessageBox.Show("activation est bien fait");
                        txtActivation.Text = "";
                        txtActivation.Visible = false;
                        label3.Visible = false;


                        lc.addUserAdmin();
                        BtnLogin.Text = "login";

                        return;

                    }
                    else
                    {
                        MessageBox.Show("licence key n'est pas valide");
                        return;
                    }


                }

                if (lc.PeriodTry() == false)
                {
                    MessageBox.Show("votre période d’essai est terminer");
                    BtnLogin.Text = "active admin";

                    txtActivation.Visible = true;
                    label3.Visible = true;
                    if (txtActivation.Text == "")
                    {
                        MessageBox.Show("entrer licence key ");
                        return;
                    }

                    if (lc.FunctionActivation(txtActivation.Text.Trim()))
                    {

                        MessageBox.Show("activation est bien fait");
                        txtActivation.Visible = false;
                        label3.Visible = false;
                        return;
                    }
                    else
                    {
                        MessageBox.Show("licence key n'est pas valide");
                        return;
                    }

                }

                //---


                if (txtUserName.Text == "user name" || txtPassword.Text == "password")
                {
                    MessageBox.Show("veillez entrer tout les donnes"); return;
                }
                this.Cursor = Cursors.WaitCursor;





                if (lc.verifyUser(txtUserName.Text.Trim(), txtPassword.Text.Trim()))
                {
                    menu m = new menu();
                    this.Hide();
                    m.Show();
                }
                else
                {
                    MessageBox.Show("le nom de utilisateur ou le  mot de passe est incorrect ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                this.Cursor = Cursors.Default;



            }
            catch (Exception ex)
            {
                lc.CloseIfOpen();
                MessageBox.Show(ex.Message);
            }



            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
