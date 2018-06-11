using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DAL
{
    public class DBRegister : ConnectionStr
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

        public void Insert(string email, string password, string voornaam, string achternaam)
        {
            openConnection();

            string sql = "INSERT Account(email, password, voornaam, achternaam)" +
                " VALUES(@email, @password, @voornaam, @achternaam)";
            SqlCommand sqlcmd = new SqlCommand(sql, conn);
            sqlcmd.Parameters.AddWithValue("@email", email);
            sqlcmd.Parameters.AddWithValue("@password", password);
            sqlcmd.Parameters.AddWithValue("@voornaam", voornaam);
            sqlcmd.Parameters.AddWithValue("@achternaam", achternaam);
            sqlcmd.ExecuteNonQuery();

            conn.Close();
        }
    }
}
