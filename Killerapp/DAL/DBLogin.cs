using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DAL
{
    public class DBLogin : ConnectionStr
    {
        
        SqlConnection conn = new SqlConnection(connectionstring);

        private bool openConnection()
        {
            bool result = true;

            try
            {
                conn.Open();
            }
            catch (DataException dex)
            {
                result = false;
            }
            return result;
        }

        public string getEmail(string uimail)
        {
            openConnection();
            string mail = "SELECT email FROM Account WHERE email=@uimail";
            SqlCommand sqlcmd = new SqlCommand(mail, conn);
            sqlcmd.Parameters.AddWithValue("@uimail", uimail);

            string email = "";
            using (sqlcmd)
            {
                using(var reader = sqlcmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        email = reader[0].ToString();
                    }
                    
                }
            }
            conn.Close();

            return email;
        }

        public string getPassword(string uipwd)
        {
            openConnection();
            string credentials = "SELECT password FROM Account WHERE password=@uipwd";
            SqlCommand sqlcmd = new SqlCommand(credentials, conn);
            sqlcmd.Parameters.AddWithValue("@uipwd", uipwd);
            
            string password = "";
            using (sqlcmd)
            {
                using (var reader = sqlcmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        password = reader[0].ToString();
                    }
                    

                }
            }
            conn.Close();

            return password;
        }

    }
}