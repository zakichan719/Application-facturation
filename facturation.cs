using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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

            txt_Ref.Text = ""; txt_type.Text = ""; txt_ICE_Destinateur.Text = ""; txt_Destinateur.Text = "";
        }
        public void viderDD()
        {

           txtQuantite.Text = ""; txtPrixUnitaire.Text = ""; txtDescription.Text = "";  ;
        }



        private void facturation_Load(object sender, EventArgs e)
        {
            fd.comboREF(txt_reff);
             
            DataGridFD.Columns[0].Visible = false;
            
            DataGridDetail.Columns[0].Visible = false;
            DataGridDetail.Columns[1].Visible = false;
            DataGridDetail.Columns[2].Visible = false;
            DataGridDetail.Columns[4].Width = 200;
            fd.AfficherFD(DataGridFD);
          
            viderFD();
        }

        private void btnAjouterDF_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_type.Text == "" || (txt_type.Text != "FACTURE" && txt_type.Text == "DEVIS"))
                {
                    MessageBox.Show("Choisir type de document FACTURE ou bien DEVIS");
                    txt_type.Text = "FACTURE";
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


                if (txt_Ref.Text == "")
                {
                    MessageBox.Show("Clicke sur button REF pour generer la  référence ");
                    button1.BackColor = Color.MediumBlue;
                    return;

                }

                if (txt_Ref.Text != REF)
                {
                    MessageBox.Show("Reference n' pas valide");
                    return;

                }

                if (txt_Ref.Text == "" || txt_type.Text == "" || txt_ICE_Destinateur.Text == "" || txt_ICE_Destinateur.Text == "")
                {
                    MessageBox.Show("completer tout les donnés");
                    return;
                }



                fd.AjouterFD(txt_Ref.Text, txt_type.Text, txt_date.Value, txt_Destinateur.Text, txt_ICE_Destinateur.Text, 1);
                MessageBox.Show(txt_type.Text + " est bien enregister ");
                fd.AfficherFD(DataGridFD);
                fd.comboREF(txt_reff);
                viderFD();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }



           
        }



        private void txt_type_SelectedIndexChanged(object sender, EventArgs e)
        {
           
             
        }


        string REF;
        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_type.Text.Trim() == ""|| (txt_type.Text != "FACTURE" && txt_type.Text != "DEVIS"))
            {
                MessageBox.Show("Choisir type de document FACTURE ou bien DEVIS");
                txt_type.Text = "FACTURE";
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
            try
            {
                fd.AfficherDetail(DataGridDetail, int.Parse(DataGridFD.CurrentRow.Cells[0].Value.ToString()));

                iddFD = int.Parse(DataGridFD.CurrentRow.Cells[0].Value.ToString());

                REFF = DataGridFD.CurrentRow.Cells[2].Value.ToString();

                fd.GetTotalByID(iddFD, lblSousTotal, lblTVA, lblTotal, lblsous_totalToWords);


                //--------------


                txt_type.Text = DataGridFD.CurrentRow.Cells[1].Value.ToString();
                //  txt_Ref.Text = DataGridFD.CurrentRow.Cells[2].Value.ToString();
                txt_date.Value = DateTime.Parse(DataGridFD.CurrentRow.Cells[3].Value.ToString());
                txt_Destinateur.Text = DataGridFD.CurrentRow.Cells[4].Value.ToString();
                txt_ICE_Destinateur.Text = DataGridFD.CurrentRow.Cells[5].Value.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

           



        }

        private void btn_ajouterD_Click(object sender, EventArgs e)
        {
             
                if (txtQuantite.Text == "" || txtPrixUnitaire.Text == "" || txtDescription.Text == "")
                {
                    MessageBox.Show("completer tout les donnés");
                    return;
                }

                if (txtQuantite.Text == "0")
                {
                    MessageBox.Show("Quantite non valide");
                    return;
                }

                if (txtPrixUnitaire.Text == "0")
                {
                    MessageBox.Show(" Prix Unitaire non valide");
                    return;
                }

                if (iddFD == -1)
                {
                    MessageBox.Show(" aucun document a lié a ce detail ");

                    return;

                }
                else
                {
                    if (MessageBox.Show("  Est ce que les information ajouter liee avec le document de reference " + REFF + "  ?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        fd.ajouterDetail(float.Parse(txtQuantite.Text), float.Parse(txtPrixUnitaire.Text), txtDescription.Text, iddFD);
                        MessageBox.Show(" les donnés est bien enregister ");
                        fd.AfficherDetail(DataGridDetail, iddFD);
                        fd.GetTotalByID(iddFD, lblSousTotal, lblTVA, lblTotal, lblsous_totalToWords);
                        viderDD();
                    }
                }



     
           
          
        }

        private void btnImprimer_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_reff.Items.Count == 0)
                {
                    return;
                }
                if (txt_reff.SelectedItem == null)
                {
                    MessageBox.Show("selectionne un reference");
                    txt_reff.Text = txt_reff.Items[0].ToString();
                    return;
                }


                  

                imprimer i = new imprimer(fd.GETIDBYREF(txt_reff.SelectedItem.ToString()));
                this.Hide();
                i.Show();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

          



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
             this.Close(); Application.OpenForms[1].Show(); 
        }

        private void btnModifierDF_Click(object sender, EventArgs e)
        {
            try
            {
                if ( txt_type.Text == "" || txt_ICE_Destinateur.Text == "" || txt_ICE_Destinateur.Text == "")
                {
                    MessageBox.Show("completer tout les donnés");
                    return;
                }

                if (iddFD == -1)
                {
                    MessageBox.Show("selectionne un document pour la modifier");

                    return;

                }

                if (MessageBox.Show(" voullez vous modifier  " + txt_type.Text + " de reference " + REFF + "  ?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (txt_Ref.Text != "" && txt_Ref.Text != REFF)
                    {
                        MessageBox.Show("Reference ne peut pa changer");
                        txt_Ref.Text = REFF;

                        return;

                    }




                    fd.ModiffierFD(iddFD, txt_type.Text, txt_date.Value, txt_Destinateur.Text, txt_ICE_Destinateur.Text);
                    MessageBox.Show(txt_type.Text + " est bien modifier ");
                    fd.AfficherFD(DataGridFD);

                    viderFD();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }






            

           
        }

        private void btnSupprimerDF_Click(object sender, EventArgs e)
        {
            try
            {
                if (iddFD == -1)
                {
                    MessageBox.Show("selectionne un document pour la supprimer");

                    return;

                }


                if (MessageBox.Show(" voullez vous supprimer  " + txt_type.Text + " de reference " + REFF + "  ?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    fd.SupprimerFD(iddFD);
                    MessageBox.Show(txt_type.Text + " est bien supprimer  ");
                    fd.comboREF(txt_reff);
                    fd.AfficherFD(DataGridFD);
                    fd.AfficherDetail(DataGridDetail, iddFD);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


           
        }
      
        
        private void btn_modifierD_Click(object sender, EventArgs e)
        {

            try
            {

                if (txtQuantite.Text == "" || txtPrixUnitaire.Text == "" || txtDescription.Text == "")
                {
                    MessageBox.Show("completer tout les donnés");
                    return;
                }

                if (iddd == -1)
                {
                    MessageBox.Show(" selectionné ligne pour la supprimer ");

                    return;

                }



                if (iddFD == -1)
                {
                    MessageBox.Show(" aucun document a lié a ce detail ");

                    return;

                }
                else
                {
                    if (MessageBox.Show("  Est ce que les information modifier liee avec le document de reference " + REFF + "  ?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        fd.ModifierDetail(iddd, idfkk, float.Parse(lblSousTotal.Text), totalLign, float.Parse(txtQuantite.Text), float.Parse(txtPrixUnitaire.Text), txtDescription.Text);
                        MessageBox.Show(" les donnés est bien modifier ");
                        fd.AfficherDetail(DataGridDetail, iddFD);
                        fd.GetTotalByID(iddFD, lblSousTotal, lblTVA, lblTotal, lblsous_totalToWords);
                        viderDD();
                        iddd = -1;
                    }
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


           
        }
        float totalLign=-1;

        private void btnRechercherDF_Click(object sender, EventArgs e)
        {
            try
            {


                if (txt_reff.Items.Count == 0)
                {
                    return;
                }
                if (txt_reff.Text.Trim() == "")
                {
                    MessageBox.Show("selectionne un reference");
                    txt_reff.Text = txt_reff.Items[0].ToString();
                    return;
                }


                fd.RechercherFD(txt_reff.SelectedItem.ToString(), DataGridFD);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           


        }
        int idTT = -1, idfkk = -1, iddd=-1;

        private void txtQuantite_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtPrixUnitaire_KeyPress(object sender, KeyPressEventArgs e)
       {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar); if (txtPrixUnitaire.Text.Contains(".") == false && txtPrixUnitaire.Text.Contains(",") == false && txtPrixUnitaire.Text != "") { if (e.KeyChar == ',') { e.Handled = char.IsControl(e.KeyChar); } if (e.KeyChar == '.') { e.Handled = char.IsControl(e.KeyChar); } }
        }

        private void txtPrixUnitaire_Leave(object sender, EventArgs e)
        {
            if (txtPrixUnitaire.Text.Contains(".")) { txtPrixUnitaire.Text = txtPrixUnitaire.Text.Replace('.', ','); }
        }

       
        private bool mouseDown = false;
        private Point lastLocation;
        private void panel1_MouseUp(object sender, MouseEventArgs e) { mouseDown = false; this.Cursor = Cursors.Default; }
        private void panel1_MouseDown(object sender, MouseEventArgs e) { mouseDown = true; lastLocation = e.Location; this.Cursor = Cursors.Hand; }
        private void panel1_MouseMove(object sender, MouseEventArgs e) { if (mouseDown) { int x = (this.Location.X - lastLocation.X) + e.X; int y = (this.Location.Y - lastLocation.Y) + e.Y; this.Location = new Point(x, y); } }

        private void button2_Click(object sender, EventArgs e)
        {
             
        }

        private void DataGridDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                iddd = int.Parse(DataGridDetail.CurrentRow.Cells[0].Value.ToString());
                idfkk = int.Parse(DataGridDetail.CurrentRow.Cells[2].Value.ToString());
                idTT = int.Parse(DataGridDetail.CurrentRow.Cells[1].Value.ToString());
                totalLign = float.Parse(DataGridDetail.CurrentRow.Cells[6].Value.ToString());
                txtQuantite.Text = DataGridDetail.CurrentRow.Cells[3].Value.ToString();
                txtPrixUnitaire.Text = DataGridDetail.CurrentRow.Cells[5].Value.ToString();
                txtDescription.Text = DataGridDetail.CurrentRow.Cells[4].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

           
         


        }

        private void btn_SupprimerD_Click(object sender, EventArgs e)
        {
            try
            {
                if (iddFD == -1)
                {
                    MessageBox.Show(" aucun document a lié a ce detail ");

                    return;

                }

                if (iddd == -1)
                {
                    MessageBox.Show(" selectionné ligne pour la supprimer ");

                    return;

                }

                if (MessageBox.Show(" vous etres sure de supprimer cette lign " + REFF + "  ?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    fd.SupprimerDetail(iddd, idfkk, totalLign, float.Parse(lblSousTotal.Text));


                    MessageBox.Show(" les donnés est bien supprimer ");
                    fd.AfficherDetail(DataGridDetail, iddFD);
                    fd.GetTotalByID(iddFD, lblSousTotal, lblTVA, lblTotal, lblsous_totalToWords);
                    viderDD();
                    iddd = -1;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


           

        }
    }


    
}
