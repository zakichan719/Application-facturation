using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace facturation
{
    public class ClassFD : database
    {
        public ClassFD()
        {

        }

      
      
        bool init = true;
        public string GenererReference(string DF)
        {




            string Ref="";
            string abv = getABV();
            string gettypeReff = gettypeRef();
            OpenCnx();

            cmd = new SqlCommand("select max(idF),Type from factureDevis GROUP BY Type", cn);
            dr = cmd.ExecuteReader();
            

            while (dr.Read())
            {
                init = false;
                // LEX-F2021-000001
              
                if (gettypeReff == "refAbv")
                {
                    string Year = DateTime.Today.Year.ToString();
                    Ref = abv + "-" + DF.ToString().Substring(0, 1).ToUpper() + Year + "-" + string.Format("{0:D6}", int.Parse(dr[0].ToString()) + 1);
                    CloseIfOpen();
                    return Ref;
                }
                else  
                {
                    string Year = DateTime.Today.Year.ToString();
                    Ref = DF.ToString().Substring(0, 1).ToUpper() + Year + "-" + string.Format("{0:D6}", int.Parse(dr[0].ToString()   ) + 1);
                    CloseIfOpen();
                    return Ref;
                }
              



            }

            if (init)
            {

                if (gettypeReff == "refAbv")
                {
                   

                    string Year = DateTime.Today.Year.ToString();
                    Ref = abv + "-" + DF.ToString().Substring(0, 1).ToUpper() + Year + "-" + string.Format("{0:D6}", 1);
                    CloseIfOpen();
                    return Ref;
                }
                else
                {
                    string Year = DateTime.Today.Year.ToString();
                    Ref = DF.ToString().Substring(0, 1).ToUpper() + Year + "-" + string.Format("{0:D6}", 1);
                    CloseIfOpen();
                    return Ref;
                }

               
            }

             

            CloseIfOpen();
            return Ref;
         


            
        }
        public string getABV()
        {

            OpenCnx();

            cmd = new SqlCommand("select AbrvName from societe  where idS = 1 ", cn);

             
                string AbrvName = cmd.ExecuteScalar().ToString();
                CloseIfOpen();   
                return AbrvName;
             
            
           
        }

        public string gettypeRef()
        {

            OpenCnx();

            cmd = new SqlCommand("select REF_syntax from societe  where idS = 1  ", cn);

            
                string Type = cmd.ExecuteScalar().ToString();
                CloseIfOpen();
                return Type;
            

           
        }


        /*
                idF int primary key identity ,
                Reference nvarchar(50),
                Type nvarchar(50),
                Date_facture nvarchar(50), --date facture
                Destinateur nvarchar(50),
                ICE_Destinateur nvarchar(50),
                idS int foreign key references  societe(idS),
                ) 
        */
        public void AfficherFD (DataGridView dataGridViewFD)
        {
            OpenCnx();
            cmd = new SqlCommand("select * from factureDevis ", cn);

            dr = cmd.ExecuteReader();
            dataGridViewFD.Rows.Clear();
            while (dr.Read())
            {

                dataGridViewFD.Rows.Add(dr[0], dr[2], dr[1], dr[3], dr[4], dr[5]   );

            }
            CloseIfOpen();

        }


        public void AjouterFD(string Reference ,string Type , DateTime Date_facture  , string factureDestinateur , string ICE_Destinateur , int idS)
        {
            OpenCnx();
            cmd = new SqlCommand("insert into factureDevis values(@a,@b,@c,@d,@e,@f)", cn);

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@a", Reference);
            cmd.Parameters.AddWithValue("@b", Type);
            cmd.Parameters.AddWithValue("@c", Date_facture);
            cmd.Parameters.AddWithValue("@d", factureDestinateur);
            cmd.Parameters.AddWithValue("@e", ICE_Destinateur);
            cmd.Parameters.AddWithValue("@f", idS);

            cmd.ExecuteNonQuery();
            CloseIfOpen();
        }

        public void SupprimerFD(int iDFD)
        {
           
            int idT =  GetIdTotaleFromDetail(GetIdDetailFromFD(iDFD));


            OpenCnx();


            cmd = new SqlCommand("delete * from totale  where idT =@idT", cn);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@idT", idT);
            cmd.ExecuteNonQuery();

            cmd = new SqlCommand("delete * from detail  where idT =@idT", cn);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@idT", idT);
            cmd.ExecuteNonQuery();

            cmd = new SqlCommand("delete * from factureDevis  where idF =@idF ", cn);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@idF", iDFD);
            cmd.ExecuteNonQuery();

 
            CloseIfOpen();

   
 
        }


        public int GetIdTotaleFromDetail(int idDetail)
        {
                 idDetail = -1;
                 OpenCnx();  
                 cmd = new SqlCommand("select idT from detail", cn);
                 idDetail = (int)cmd.ExecuteScalar();
                 CloseIfOpen();
                 return idDetail;
        }

        public int GetIdDetailFromFD(int idFD)
        {
            idFD = -1;
            OpenCnx();
            cmd = new SqlCommand("select idT from detail", cn);
            idFD = (int)cmd.ExecuteScalar();
            CloseIfOpen();
            return idFD;
        }

 



        public void ModiffierFD(int idDF ,  string Type, DateTime Date_facture, string factureDestinateur, string ICE_Destinateur)
        {
            OpenCnx();
            cmd = new SqlCommand("update factureDevis set  Type=@Type,Date_facture=@Date_facture,Destinateur=@Destinateur,ICE_Destinateur=@ICE_Destinateur  Where @idDF=idDF  ", cn);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@idDF", idDF);
 
            cmd.Parameters.AddWithValue("@Type", Type);
            cmd.Parameters.AddWithValue("@Date_facture", Date_facture);
            cmd.Parameters.AddWithValue("@factureDestinateur", factureDestinateur);
            cmd.Parameters.AddWithValue("@ICE_Destinateur", ICE_Destinateur);

            cmd.ExecuteNonQuery();
            CloseIfOpen();


             
        }

        public void RechercherFD(string Reference, DataGridView dataGridViewFD)
        {
            OpenCnx();
            cmd = new SqlCommand("select * from factureDevis where Reference =@Reference ", cn);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Reference", Reference);

            dr = cmd.ExecuteReader();
            dataGridViewFD.Rows.Clear();


            while (dr.Read())
            {
                dataGridViewFD.Rows.Add(dr[0], dr[2], dr[1], dr[3], dr[4], dr[6]);

            }
            CloseIfOpen();
        }


      //-------------

        public void AfficherDetail(DataGridView dataGridViewDetail, int IDF)
        {
            OpenCnx();
            cmd = new SqlCommand("select* from detail where IDF_fk = @IDF_fk", cn);
            cmd.Parameters.Clear(); 
            cmd.Parameters.AddWithValue("@IDF_fk", IDF);


            dr = cmd.ExecuteReader();
            dataGridViewDetail.Rows.Clear();
            while (dr.Read())
            {
                //dr[5], dr[6]
                dataGridViewDetail.Rows.Add(dr[0], dr[1], dr[4], dr[2], dr[3]);

            }
            CloseIfOpen();
        }


        /*
         
        idd int primary key identity ,
        Quantite float,
        prix_unitaire float,
        Total_ligne AS Quantite * prix_unitaire ,
        description nvarchar(200),
        IDF_fk int foreign key references factureDevis(idF),
        idT int foreign key references totale(idT),
        
        */



        /*
       create table totale (
idT int primary key identity ,
sous_total float,
TVA AS (sous_total*0.2),
TOTALE  AS (sous_total + (sous_total*0.2)) ,
IDF_fk int foreign key references factureDevis(idF),
) 
        */

        public void GetTotalByID(int idDF,Label SousTotal, Label TVA , Label Total, Label sous_totalToWords)
        {
            OpenCnx();
            cmd = new SqlCommand("select sous_total,TVA,TOTALE,sous_totalToWords   from totale where IDF_fk = @IDF_fk", cn);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@IDF_fk", idDF);


            dr = cmd.ExecuteReader();
            
            while (dr.Read())
            {
                SousTotal.Text = dr[0].ToString();
                TVA.Text = dr[1].ToString();
                Total.Text = dr[2].ToString();
                sous_totalToWords.Text = dr[3].ToString();

                CloseIfOpen();
                return;
            }

            SousTotal.Text = "0";
            TVA.Text =       "0";
            Total.Text =     "0";
            sous_totalToWords.Text = "";

            CloseIfOpen();
        }


        public bool ExistTotal(int idDF)
        {
            
            OpenCnx();
            cmd = new SqlCommand("select idT from totale where IDF_fk = @IDF_fk", cn);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@IDF_fk", idDF);
            if (cmd.ExecuteScalar()!=null)
            {
                CloseIfOpen();
                return true;
            }


            CloseIfOpen();
            return false;





 

           
        }


        public float Get_SousTotal(int idDF,float Total_New_ligne)
        {

            OpenCnx();
            cmd = new SqlCommand("select SUM(Total_ligne) as sous_total    FROM detail where IDF_fk =@IDF_fk ", cn);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@IDF_fk", idDF);

            dr = cmd.ExecuteReader();
            
            while (dr.Read())
            {

                if (dr[0].ToString()!="")
                {
                    

                    float oldTotal = float.Parse(dr[0].ToString());
                    CloseIfOpen();
                    return oldTotal + Total_New_ligne;
                }
               
                 

            }


            CloseIfOpen();
            return Total_New_ligne;








        }

        public string Get_SousTotalWords(float SousTotal)
        {
            Translation t = new Translation();

           // t.English = Converter.ConvertNumberToWords(92520, Language.English);
              t.French =  Converter.ConvertNumberToWords(SousTotal, Language.French);
             
             

            return t.French.ToString();

        }


        public void ajouterDetail(float Quantite , float prix_unitaire , string description  ,int IDF_fk    )
        {
            int idtT = -1;
            bool found = ExistTotal(IDF_fk);
            float SousTotal = Get_SousTotal(IDF_fk, prix_unitaire* Quantite);
            float total = ((float)(SousTotal + (SousTotal * 0.2)));
            string sous_totalToWords = Get_SousTotalWords(total);

            OpenCnx();

            if (found)
            {
                cmd = new SqlCommand("update  totale set  sous_total=@sous_total , sous_totalToWords=@sous_totalToWords where IDF_fk=@IDF_fk ", cn);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@sous_total", SousTotal);
                cmd.Parameters.AddWithValue("@sous_totalToWords", sous_totalToWords);
                cmd.Parameters.AddWithValue("@IDF_fk", IDF_fk);
                cmd.ExecuteNonQuery();

            }
            else
            {
                cmd = new SqlCommand("insert into totale (sous_total,sous_totalToWords,IDF_fk) values(@sous_total,@sous_totalToWords,@IDF_fk)", cn);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@sous_total", SousTotal);
                cmd.Parameters.AddWithValue("@sous_totalToWords", sous_totalToWords);
                cmd.Parameters.AddWithValue("@IDF_fk", IDF_fk);
                cmd.ExecuteNonQuery();

            }
         
         

          
            cmd = new SqlCommand("select  idT from totale where IDF_fk=@IDF_fk ", cn);
            cmd.Parameters.AddWithValue("@IDF_fk", IDF_fk);
            if (cmd.ExecuteScalar() != null)
            { idtT = int.Parse(cmd.ExecuteScalar().ToString());   }


            cmd = new SqlCommand("insert into detail (Quantite,description,prix_unitaire,IDF_fk,idT) values(@Quantite,@description,@prix_unitaire,@IDF_fk,@idT)", cn);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Quantite", Quantite);
            cmd.Parameters.AddWithValue("@description", description);
            cmd.Parameters.AddWithValue("@prix_unitaire", prix_unitaire);
            cmd.Parameters.AddWithValue("@IDF_fk", IDF_fk);
            cmd.Parameters.AddWithValue("@idT", idtT);
            cmd.ExecuteNonQuery();




            CloseIfOpen();

          

        }




        public void SupprimerDetail(int idT)
        {
            OpenCnx();

            cmd = new SqlCommand("delete from totale where idT=@a", cn);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@a", idT);
            cmd.ExecuteNonQuery();


            cmd = new SqlCommand("delete from detail where idT=@a", cn);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@a", idT);
            cmd.ExecuteNonQuery();

            CloseIfOpen();
        }



    
        public void ModifierDetail(int idT,float sous_total, float Quantite, float prix_unitaire, string description)
        {
             
            OpenCnx();

            cmd = new SqlCommand("update totale set  sous_total=@sous_total Where @idT=idT  ", cn);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@sous_total", sous_total);
            cmd.Parameters.AddWithValue("@idT", idT);
            cmd.ExecuteNonQuery();
 
             
            cmd = new SqlCommand("update detail set  Quantite=@Quantite,prix_unitaire=@prix_unitaire,Total_ligne=@Total_ligne,description=@description  Where @idT=idT  ", cn);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Quantite", Quantite);
            cmd.Parameters.AddWithValue("@description", description);
            cmd.Parameters.AddWithValue("@prix_unitaire", prix_unitaire);
            cmd.Parameters.AddWithValue("@idT", idT);
            cmd.ExecuteNonQuery();




            CloseIfOpen();



        }
    }
}
