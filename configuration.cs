using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace facturation
{
    public partial class configuration : Form
    {
        public configuration()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("voullez vous fermer cette fenetre", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes) { this.Close(); Application.OpenForms[1].Show(); }

        }

        private void minimaze_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        ClassConfiguration cc = new ClassConfiguration();
        database db = new database();
        byte[] b;
        string path = "";
        bool remplire = false;
        public void afficher()
        {

            if (cc.VerifierIfExist())
            {

                db.OpenCnx();

                db.cmd = new SqlCommand("select brand from societe", db.cn);
                if (db.cmd.ExecuteScalar().ToString()!="")
                {
                    b = (byte[])db.cmd.ExecuteScalar();
                    MemoryStream m = new MemoryStream(b);
                    Image Image = Image.FromStream(m);
                    picture.Image = Image;
                }
               

                db.CloseIfOpen();

                db.OpenCnx();
                db.cmd = new SqlCommand("select * from societe", db.cn);

                db.dr = db.cmd.ExecuteReader();
           
                while (db.dr.Read())
                {

                     
                   
                   


                    txt_NomSociete.Text = db.dr[1].ToString();
                    txt_abrv.Text = db.dr[2].ToString();
                    txtRC.Text = db.dr[4].ToString();
                    txtIF.Text = db.dr[5].ToString();
                    txtICE.Text = db.dr[6].ToString();
                    txtSiegeSocial.Text = db.dr[7].ToString();
                    txt_telephone.Text = db.dr[8].ToString();



                    txt_Ref.Text = "                   Chaine de reference";

                    txt_Ref.Items.Clear();
                    txt_Ref.Items.Add(txt_abrv.Text + "-" + "F" + DateTime.Today.Year.ToString() + "-000001");
                    txt_Ref.Items.Add("F" + DateTime.Today.Year.ToString() + "-000001");


                    remplire = true;



                    /*
idS int primary key  ,
societeName nvarchar(50),
AbrvName nvarchar(50),
REF_syntax nvarchar(50),
RC nvarchar(50),
i_F nvarchar(50),
ICE nvarchar(50),
SiegeSocial nvarchar(max),
Telephone nvarchar(50),
brand  varbinary(max)
                     
                     */




                }
                db.CloseIfOpen();




            }

        }


  
        private void configuration_Load(object sender, EventArgs e)
        {

            afficher();
        }

        
       

       
        


        private void btnAjouter_Click(object sender, EventArgs e)
        {
            

            if (txt_Ref.Text == "" ||txt_Ref.Text == "                   Chaine de reference" ||
                txt_NomSociete.Text == "Nom de Societe" || txt_NomSociete.Text == "" ||
            
            txtRC.Text == "" || txtRC.Text == "RC" ||
            txtIF.Text == "" || txtIF.Text == "IF" ||
            txtICE.Text == "" || txtICE.Text == "ICE" ||
            txtSiegeSocial.Text == "" || txtSiegeSocial.Text == "Siege Social" ||
            txt_telephone.Text == "" ||  txt_telephone.Text == "Telephone")
            {
                MessageBox.Show("Entrer Tout Les Donnes");
                return;
            }

               if (txt_Ref.Text != "                   Chaine de reference" && txt_Ref.Text != "Abriviation-(F ou D)Annee-000001" && txt_Ref.Text != "(F ou D)-Annee-000001"
               && txt_Ref.Text != txt_abrv.Text + "-" + "F" + DateTime.Today.Year.ToString() + "-000001" &&
               txt_Ref.Text != "F" + DateTime.Today.Year.ToString() + "-000001")
            {
                MessageBox.Show("reference non valide");
                return;
            }

            //add picture
            if (path != ""|| remplire)
            {



                //FileStream s = new FileStream(path, FileMode.Open, FileAccess.Read);
                //BinaryReader brs = new BinaryReader(s);
                // p = brs.ReadBytes((int)s.Length);
                string typeref = "";
                int count = 0;
                foreach (char c in txt_Ref.Text)
                {
                    if (c=='-')
                    {
                        count++;
                    }
                }

                if (count==2)
                {
                    typeref = "refAbv";
                }
                else if(count == 1)


                {
                    typeref = "refnormal";
                }

                cc.ajouterModifie(remplire,txt_NomSociete.Text, txt_abrv.Text, typeref, txtRC.Text, txtIF.Text, txtICE.Text, txtSiegeSocial.Text, txt_telephone.Text, path);
                MessageBox.Show("les donneés est bien sauvgarder");
                remplire = true;
            }
            else
            {
                MessageBox.Show("veiller  ajouter une photo");

                return;
            }


            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txt_abrv.Text == ""|| txt_abrv.Text == "Abriviation Nom de Societe")
            {
                MessageBox.Show("ajouter abréviation de nom de la societe");
                return;

            }
            else
            {
                txt_Ref.Items.Clear();
                txt_Ref.Items.Add(txt_abrv.Text + "-" + "F" + DateTime.Today.Year.ToString() + "-000001");
                txt_Ref.Items.Add("F" + DateTime.Today.Year.ToString() + "-000001");
            }


         


        }

        placeholder p = new placeholder();

        

        private void txt_NomSociete_Leave(object sender, EventArgs e)
        {
            p.leave(txt_NomSociete, "Nom de Societe", "black", "white");
        }

        private void txt_NomSociete_Enter(object sender, EventArgs e)
        {
            p.enter(txt_NomSociete, "Nom de Societe", "white", "black");
        }
       
        private void txt_telephone_Leave(object sender, EventArgs e)
        {
            p.leave(txt_telephone, "Telephone", "black", "white");
        }

        private void txt_telephone_Enter(object sender, EventArgs e)
        {
            p.enter(txt_telephone, "Telephone", "white", "black");
        }

        private void txt_abrv_Enter(object sender, EventArgs e)
        {
            p.enter(txt_abrv, "Abriviation Nom de Societe", "white", "black");
        }

        private void txt_abrv_Leave(object sender, EventArgs e)
        {
            p.leave(txt_abrv, "Abriviation Nom de Societe", "black", "white");
        }

        private void txt_Ref_Leave(object sender, EventArgs e)
        {
            p.leave(txt_Ref, "                   Chaine de reference", "black", "white");

           
        }

        private void txt_Ref_Enter(object sender, EventArgs e)
        {
            p.enter(txt_Ref, "                   Chaine de reference", "white", "black");
        }

        private void txtRC_Enter(object sender, EventArgs e)
        {
            p.enter(txtRC, "RC", "white", "black");
        }

        private void txtRC_Leave(object sender, EventArgs e)
        {
            p.leave(txtRC, "RC", "black", "white");
        }

        private void txtIF_Enter(object sender, EventArgs e)
        {
            p.enter(txtIF, "IF", "white", "black");
        }

        private void txtIF_Leave(object sender, EventArgs e)
        {
            p.leave(txtIF, "IF", "black", "white");
        }

        private void txtICE_Enter(object sender, EventArgs e)
        {
            p.enter(txtICE, "ICE", "white", "black");
        }

        private void txtICE_Leave(object sender, EventArgs e)
        {
            p.leave(txtICE, "ICE", "black", "white");
        }

        private void txtSiegeSocial_Enter(object sender, EventArgs e)
        {
            p.enter(txtSiegeSocial, "Siege Social", "white", "black");
        }

        private void txtSiegeSocial_Leave(object sender, EventArgs e)
        {
            p.leave(txtSiegeSocial, "Siege Social", "black", "white");
        }

        private void picture_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            o.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (o.ShowDialog() == DialogResult.OK)
            {
                path = o.FileName.ToString();
                picture.ImageLocation = path;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
             this.Close(); Application.OpenForms[1].Show(); 
        }
    }
}
