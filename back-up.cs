using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        LoginClasse lc = new LoginClasse();
        private void BtnLogin_Click(object sender, EventArgs e)
        {


            

                if (lc.verifypassword(txtpasswordshow.Text.Trim()))
            {
                hidepanel.Visible = false;
                txtpasswordshow.Visible = false;
                label1.Visible = false;
                BtnLogin.Visible = false;

            }
                else
            {
                MessageBox.Show("Password incorrecte");
            
            }



          
        }

        private void close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("voullez vous fermer cette fenetre", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes) { this.Close(); Application.OpenForms[1].Show(); }
        }

        private bool mouseDown = false;
        private Point lastLocation;
        private void panel1_MouseUp(object sender, MouseEventArgs e) { mouseDown = false; this.Cursor = Cursors.Default; }
        private void panel1_MouseDown(object sender, MouseEventArgs e) { mouseDown = true; lastLocation = e.Location; this.Cursor = Cursors.Hand; }
        private void panel1_MouseMove(object sender, MouseEventArgs e) { if (mouseDown) { int x = (this.Location.X - lastLocation.X) + e.X; int y = (this.Location.Y - lastLocation.Y) + e.Y; this.Location = new Point(x, y); } }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close(); Application.OpenForms[1].Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        database db = new database();



        private void panel3_Click(object sender, EventArgs e)
        {
            try { OpenFileDialog op = new OpenFileDialog(); op.Filter = "Backup File(*.bak) | *.bak"; op.Title = "select backup File"; if (op.ShowDialog() == DialogResult.OK) { progressBar1.Value = 70; lb_progress.Text = "70 %"; db.OpenCnx(); string req = "alter database [" + db.cn.Database + "] set offline with rollback immediate RESTORE DATABASE [" + db.cn.Database + "] FROM DISK = N'" + op.FileName + "'WITH FILE = 1, NOUNLOAD, STATS = 5 alter database [" + db.cn.Database + "] set online with rollback immediate "; SqlCommand cmd = new SqlCommand(req, db.cn); cmd.ExecuteNonQuery(); db.cn.Close(); progressBar1.Value = 100; lb_progress.Text = "les informations de la base de donne est bien Restaurer ...."; } } catch (Exception ex) { MessageBox.Show(ex.Message); } finally { db.cn.Close(); }
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            try { if (txt_foder_backup.Text == "") { MessageBox.Show("choisi le Chemin de deplacement de cette Sauvegarde"); button1.BackColor = Color.Gray; return; } progressBar1.Value = 70; lb_progress.Text = "70 %"; db.OpenCnx(); string backupName = "\\db_OIP_STOCK" + "_" + DateTime.Now.ToString("ddMMyyyy_HH.mm.ss") + ".bak"; string req = "BACKUP DATABASE [" + db.cn.Database + "] TO DISK = N'" + txt_foder_backup.Text + backupName + "'"; db.cmd = new SqlCommand(req, db.cn); db.cmd.ExecuteNonQuery(); db.CloseIfOpen(); lb_progress.Text = "Sauvegarde est bien fait ...."; progressBar1.Value = 100; } catch (Exception ex) { MessageBox.Show(ex.Message); db.CloseIfOpen(); }


           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fd = new FolderBrowserDialog(); if (fd.ShowDialog() == DialogResult.OK) { txt_foder_backup.Text = fd.SelectedPath; }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if ( lc.verifypassword(txtPassword.Text.Trim())!=true   )
            {
                MessageBox.Show("Password incorrecte");
                return;
            }
            


            if (  bunifuMaterialTextbox1.Text.Length < 8)
            {
                MessageBox.Show("mot de passe doit miniment contienne 8 chiffre");
                return;

            }
            if (bunifuMaterialTextbox1.Text != bunifuMaterialTextbox3.Text)
            {
                MessageBox.Show("les deux mot de passe ne sont pas   identiques   ");
                return;
            }


            db.OpenCnx();
            db.cmd = new SqlCommand("select * from login ", db.cn);
            db.dr = db.cmd.ExecuteReader();


            while (db.dr.Read())
            {
                 

                    db.dr.Close();
                    db.cmd = new SqlCommand("update login set password=@password  Where username='admin'", db.cn);
                    db.cmd.Parameters.Clear();

                    db.cmd.Parameters.AddWithValue("@password", bunifuMaterialTextbox3.Text);
                    //--- dr
                    db.cmd.ExecuteNonQuery();
                    db.CloseIfOpen();
                    MessageBox.Show("mot de passe est bien changer");
                    return;
                 
               


            }
            db.CloseIfOpen();
        }




        placeholder p = new placeholder();


        private void txtPassword_Enter(object sender, EventArgs e)
        {
            p.enter(txtPassword, "Ancien mot  de passe", "white", "black");
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            p.leave(txtPassword, "Ancien mot  de passe", "black", "white");
        }

        private void bunifuMaterialTextbox1_Enter(object sender, EventArgs e)
        {
            p.enter(bunifuMaterialTextbox1, "Nouveau mot  de passe", "white", "black");
        }

        private void bunifuMaterialTextbox1_Leave(object sender, EventArgs e)
        {
            p.leave(bunifuMaterialTextbox1, "Nouveau mot  de passe", "black", "white");
        }

        private void bunifuMaterialTextbox3_Enter(object sender, EventArgs e)
        {
            p.enter(bunifuMaterialTextbox3, "Repeté mot  de passe", "white", "black");
        }

        private void bunifuMaterialTextbox3_Leave(object sender, EventArgs e)
        {
            p.leave(bunifuMaterialTextbox3, "Repeté mot  de passe", "black", "white");
        }
    }
}
