using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Killerapp
{
    public class DBLogin
    {
        const string _csConnectionString = @"Server=mssql.fhict.local;Database=dbi392873;User Id=dbi392873;Password=killerapp;";
        SqlConnection conn = new SqlConnection(_csConnectionString);

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

        public void getCredentials(string uimail, string uipwd)
        {
            openConnection();
            string credentials = "SELECT email, password FROM Account WHERE email=@uimail AND password=@uipwd";
            SqlCommand sqlcmd = new SqlCommand(credentials, conn);
            sqlcmd.Parameters.AddWithValue("@uimail", uimail);
            sqlcmd.Parameters.AddWithValue("@uipwd", uipwd);

            string email = "";
            string password = "";
            using (sqlcmd)
            {
                using(var reader = sqlcmd.ExecuteReader())
                {
                    email = reader.GetValue(0).ToString();
                    password = reader.GetValue(1).ToString();
                    
                }
            }
            conn.Close();
            //constructor dingen voor email + password
        }

        
    }
}