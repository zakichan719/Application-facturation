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
    public partial class facturation : Form
    {
        public facturation()
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

        ClassFD fd = new ClassFD();

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

       public void viderFD()
        {

            txt_Ref.Text = ""; txt_type.Text = ""; txt_ICE_Destinateur.Text = ""; txt_ICE_Destinateur.Text = "";
        }
        public void viderDD()
        {

           txtQuantite.Text = ""; txtPrixUnitaire.Text = ""; txtDescription.Text = "";  ;
        }



        private void facturation_Load(object sender, EventArgs e)
        {
            txt_type.Text = "FACTURE";
            DataGridFD.Columns[0].Visible = false;
            
            DataGridDetail.Columns[0].Visible = false;
            DataGridDetail.Columns[2].Width = 200;
            fd.AfficherFD(DataGridFD);
          
            viderFD();
        }

        private void btnAjouterDF_Click(object sender, EventArgs e)
        {

            if (txt_Ref.Text=="")
            {
                MessageBox.Show("Clicke sur button REF pour generer la  référence ");
                button1.BackColor = Color.MediumBlue;
                return;

            }

             if (txt_Ref.Text!= REF)
            {
                       MessageBox.Show("Reference n' pas valide");
                       return;

            }

            if (txt_Ref.Text==""||txt_type.Text==""||txt_ICE_Destinateur.Text==""||txt_ICE_Destinateur.Text=="")
            {
                MessageBox.Show("completer tout les donnés");
                return;
            }
                fd.AjouterFD(txt_Ref.Text,txt_type.Text,txt_date.Value,txt_Destinateur.Text,txt_ICE_Destinateur.Text,1);
                MessageBox.Show(txt_type.Text+" est bien enregister ");
                fd.AfficherFD(DataGridFD);

                viderFD();
        }

        private void txt_type_SelectedIndexChanged(object sender, EventArgs e)
        {
           
             
        }


        string REF;
        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_type.Text == "")
            {
                MessageBox.Show("Choisir type de document FACTURE ou bien DEVIS");
                return;
            }
            if (txt_type.Text == "FACTURE")
            {
                REF = fd.GenererReference("FACTURE");
                txt_Ref.Text = REF;


            }
            else if (txt_type.Text == "DEVIS")
            {
                REF = fd.GenererReference("DEVIS");
                txt_Ref.Text = REF;
                
            }
        }


        int iddFD = -1;
        string REFF = "";
        private void DataGridFD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fd.AfficherDetail(DataGridDetail, int.Parse(DataGridFD.CurrentRow.Cells[0].Value.ToString()  )  );

            iddFD = int.Parse(DataGridFD.CurrentRow.Cells[0].Value.ToString());

            REFF = DataGridFD.CurrentRow.Cells[2].Value.ToString();

            fd.GetTotalByID(iddFD, lblSousTotal, lblTVA, lblTotal, lblsous_totalToWords);
        }

        private void btn_ajouterD_Click(object sender, EventArgs e)
        {

            if (txtQuantite.Text == "" || txtPrixUnitaire.Text == "" || txtDescription.Text == "" )
            {
                MessageBox.Show("completer tout les donnés");
                return;
            }

            if (iddFD == -1)
            {
                MessageBox.Show(" aucun document a lié a ce detail ");
                
                return;

            }
            else
            {
                if (MessageBox.Show("  Est ce que les information ajouter liee avec le document de reference "+REFF+"  ?", "",MessageBoxButtons.YesNo)==DialogResult.Yes)
                {
                    fd.ajouterDetail(float.Parse(txtQuantite.Text),float.Parse(txtPrixUnitaire.Text) , txtDescription.Text, iddFD);
                    MessageBox.Show(" les donnés est bien enregister ");
                    fd.AfficherDetail(DataGridDetail, iddFD);
                    fd.GetTotalByID(iddFD,lblSousTotal,lblTVA,lblTotal,lblsous_totalToWords);
                    viderDD();
                }
            }
            
          
        }

        private void btnImprimer_Click(object sender, EventArgs e)
        {
            imprimer i = new imprimer(iddFD);
            this.Hide();
            i.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
             this.Close(); Application.OpenForms[1].Show(); 
        }
    }


    
}
