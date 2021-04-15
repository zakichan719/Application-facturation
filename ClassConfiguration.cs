using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace facturation
{
   public class ClassConfiguration :database
    {

        public bool VerifierIfExist()
        {
            OpenCnx();
            cmd = new SqlCommand("select * from societe ", cn);
          

            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                
                    CloseIfOpen();
                    return true;
               
               
            }
            CloseIfOpen();
            return false;
        }



        public void ajouter (string societeName, string AbrvName,string REF_syntax, string RC, string i_F, string ICE, string SiegeSocial, string Telephone, string path)
        {







            OpenCnx();

            cmd = new SqlCommand("insert into societe values(@idS,@societeName,@AbrvName,@REF_syntax,@RC,@i_F,@ICE,@SiegeSocial,@Telephone,(SELECT * FROM OPENROWSET(BULK N'" + path + "', SINGLE_BLOB) as T1))", cn);
            cmd.Parameters.Clear();
           
            cmd.Parameters.AddWithValue("@idS", 1);
            cmd.Parameters.AddWithValue("@societeName", societeName);
            cmd.Parameters.AddWithValue("@AbrvName", AbrvName);
            cmd.Parameters.AddWithValue("@REF_syntax", REF_syntax);
            cmd.Parameters.AddWithValue("@RC", RC);
            cmd.Parameters.AddWithValue("@i_F", i_F);
            cmd.Parameters.AddWithValue("@ICE", ICE);
            cmd.Parameters.AddWithValue("@SiegeSocial", SiegeSocial);
            cmd.Parameters.AddWithValue("@Telephone", Telephone);
            

            cmd.ExecuteNonQuery();
            CloseIfOpen();

        }

 
        public void Modifie(bool remplire, string societeName, string AbrvName, string REF_syntax, string RC, string i_F, string ICE, string SiegeSocial, string Telephone, string path)
        {

            



            OpenCnx();
            if (remplire)
            {
                cmd = new SqlCommand("update societe set  societeName=@societeName,AbrvName=@AbrvName,REF_syntax=@REF_syntax,RC=@RC,i_F=@i_F,ICE=@ICE,SiegeSocial=@SiegeSocial, Telephone=@Telephone  where  idS=@idS  ", cn);
            }
            else
            {
                cmd = new SqlCommand("update societe set  societeName=@societeName,AbrvName=@AbrvName,REF_syntax=@REF_syntax,RC=@RC,i_F=@i_F,ICE=@ICE,SiegeSocial=@SiegeSocial, Telephone=@Telephone,  (SELECT * FROM OPENROWSET(BULK N'" + path + "', SINGLE_BLOB) as T1)   where  idS=@idS  ", cn);
            }
           
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@idS", 1);
            cmd.Parameters.AddWithValue("@societeName", societeName);
            cmd.Parameters.AddWithValue("@AbrvName", AbrvName);
            cmd.Parameters.AddWithValue("@REF_syntax", REF_syntax);
            cmd.Parameters.AddWithValue("@RC", RC);
            cmd.Parameters.AddWithValue("@i_F", i_F);
            cmd.Parameters.AddWithValue("@ICE", ICE);
            cmd.Parameters.AddWithValue("@SiegeSocial", SiegeSocial);
            cmd.Parameters.AddWithValue("@Telephone", Telephone);
            

            cmd.ExecuteNonQuery();
            CloseIfOpen();

        }

        public void ajouterModifie(bool remplire ,string societeName, string AbrvName, string REF_syntax, string RC, string i_F, string ICE, string SiegeSocial, string Telephone, string path)
        {
            if (VerifierIfExist())
            {
                Modifie(remplire ,societeName, AbrvName, REF_syntax, RC, i_F, ICE, SiegeSocial, Telephone, path);

            }
            else
            {
                ajouter(societeName, AbrvName, REF_syntax, RC, i_F, ICE, SiegeSocial, Telephone, path);
            }


        }

       





    }
}
