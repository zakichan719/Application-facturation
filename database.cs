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
        public SqlConnection cn = new SqlConnection(@"data source = (LocalDB)\MSSQLLocalDB;attachdbfilename=|DataDirectory|\DatabaseF.mdf;Integrated Security=True");
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
