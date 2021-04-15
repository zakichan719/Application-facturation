using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace facturation
{
  public  class LoginClasse : database
    {
        
        int count;
        
        public int countUser()
        {   cn.Open();
            cmd = new SqlCommand("select count(*) from login ", cn);
            count = (int)cmd.ExecuteScalar();
            cn.Close();
            return count;
        }

        public bool FunctionActivation(string ActivationCode) 
        { 
            if (ActivationCode == "") 
            { return false; }
            
            if (ActivationCode.Length != 19 || ActivationCode.Substring(4, 1) != "-" && ActivationCode.Substring(9, 1) != "-" && ActivationCode.Substring(14, 1) != "-") 
            { return false; } 

            string d = DateTime.Today.Day.ToString();
            string d1 = (d.Length == 1) ? "0" : d.Substring(0, 1); 
            string d2 = (d.Length == 1) ? d : d.Substring(1, 1);

            if (ActivationCode.Substring(0, 1) + ActivationCode.Substring(3, 1) != d1 + d2)
            { return false; } 
            string m = DateTime.Today.Month.ToString();
            string m1 = (m.Length == 1) ? "0" : m.Substring(0, 1); string m2 = (m.Length == 1) ? m : m.Substring(1, 1); if (ActivationCode.Substring(5, 1) + ActivationCode.Substring(8, 1) != m1 + m2) { return false; } string y = DateTime.Today.Year.ToString();
            if (ActivationCode.Substring(10, 1) + ActivationCode.Substring(13, 1) != y.Substring(2, 1) + y.Substring(3, 1)) 
            { return false; }
            string versiontryOrFull = ActivationCode.Substring(15, 1);

            
                cn.Open();
                cmd = new SqlCommand("select * from t_function where idF = @a ", cn);
                cmd.Parameters.AddWithValue("@a", 99);
                dr = cmd.ExecuteReader();
                string col1="", col2="";
             


            if (dr.Read())  {col1 = dr[1].ToString() ;  col2 = dr[2].ToString();}

            CloseIfOpen();









            if (col1==""  && col2== "") { 



                if (versiontryOrFull == "0")
                {   
                        cn.Open();
                        cmd = new SqlCommand("insert into t_function values(@a,@b,@c)", cn);
                        cmd.Parameters.AddWithValue("@a", 99);
                        cmd.Parameters.AddWithValue("@b", DateTime.Today.ToString());
                        cmd.Parameters.AddWithValue("@c", "full");
                     
                        cmd.ExecuteNonQuery();
                    CloseIfOpen();
                    return true;
                
                } 
                else if (versiontryOrFull == "1")
                {
                    cn.Open();
                    cmd = new SqlCommand("insert into t_function values(@a,@b,@c)", cn);
                    cmd.Parameters.AddWithValue("@a", 99);
                    cmd.Parameters.AddWithValue("@b", DateTime.Today.AddDays(7).ToShortDateString() );
                    cmd.Parameters.AddWithValue("@c", "try");

                    cmd.ExecuteNonQuery();
                    CloseIfOpen();
                    return true;

                } 
                
                else {
                    CloseIfOpen();
                    return false;
                } 
            } 

                else 
            { 
                if (versiontryOrFull == "0") 

                {
                    cn.Open();
                    cmd = new SqlCommand("update t_function set column1 =@a  , column2= @b  where idF =99   ", cn);
                    cmd.Parameters.AddWithValue("@a", DateTime.Today.ToString());
                    cmd.Parameters.AddWithValue("@b", "full");
                    cmd.ExecuteNonQuery();
                    CloseIfOpen();
                    return true; 

                } 
                else if (versiontryOrFull == "1") 
                {
                    cn.Open();
                    cmd = new SqlCommand("update t_function set column1 =@a  , column2= @b  where idF =99   ", cn);
                    cmd.Parameters.AddWithValue("@a", DateTime.Today.AddDays(7).ToShortDateString() );
                    cmd.Parameters.AddWithValue("@b", "try");
                    cmd.ExecuteNonQuery();
                    CloseIfOpen();


                    return true; 
                } 
                else
                {
                    CloseIfOpen();
                    return false;
                } 
            }
        }




        public bool PeriodTry() { 
          

            cn.Open();
            cmd = new SqlCommand("select * from t_function where idF = @a ", cn);
            cmd.Parameters.AddWithValue("@a", 99);
            dr = cmd.ExecuteReader();
         



            if (dr.Read()) {
                
               
                if (dr[2].ToString() == "try")
                {

                    DateTime dv = DateTime.Parse(dr[1].ToString());
                    if (dv < DateTime.Today)
                    {
                        CloseIfOpen();
                        return false;
                    }
                    else
                    {
                        CloseIfOpen();
                        return true;
                    }
                       

                }
                else
                {
                    CloseIfOpen();
                    return true;
                }


            }

            CloseIfOpen();








            return false;
        }



     public void addUserAdmin()
        {
            cn.Open();

            

            cmd = new SqlCommand("insert into login values(@a,@b,@C)", cn);
            cmd.Parameters.AddWithValue("@a", 1);
            cmd.Parameters.AddWithValue("@b", "admin");
            cmd.Parameters.AddWithValue("@c", "admin");
            cmd.ExecuteNonQuery();


            cmd = new SqlCommand("insert into login values(@a,@b,@C)", cn);
            cmd.Parameters.AddWithValue("@a", 2);
            cmd.Parameters.AddWithValue("@b", "admin01");
            cmd.Parameters.AddWithValue("@c", "admin01");
            cmd.ExecuteNonQuery();


            CloseIfOpen();

        }




        public bool verifyUser(string user,string password)
        {
           
                cn.Open();
                cmd = new SqlCommand("select * from login ", cn);
                dr = cmd.ExecuteReader();

               
                while (dr.Read())
                {

                    if (dr[1].ToString() == user && dr[2].ToString() == password)
                    {
                    CloseIfOpen();
                    return true;
                    }
                       

                }

            CloseIfOpen();
            return false;
        }


       


        }


}
 
