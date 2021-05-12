using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facturation
{
   public class database
    {
        
        // Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=C:\USERS\DELL\DOWNLOADS\FACTURATION\DATABASEF.MDF;User ID=useradmin ;Password=useradmin7199 ;
        public SqlConnection cn = new SqlConnection(@"data source = (LocalDB)\MSSQLLocalDB;attachdbfilename=|DataDirectory|\DatabaseF.mdf ;User ID=loginadmin ;Password=loginadmin7199 ;");
        public SqlCommand cmd;
        public SqlDataReader dr;

        
            public void CloseIfOpen()
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                if (dr != null)
                {
                    if (dr.IsClosed == false)
                    {
                        dr.Close();
                    }
                }
            }


            public void OpenCnx()
            {
                if (cn.State == ConnectionState.Closed)
                {
                    cn.Open();
                }

            }
         
    }
}
