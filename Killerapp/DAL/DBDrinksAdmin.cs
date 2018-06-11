using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DBDrinksAdmin : ConnectionStr
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

        public void InsertDrinks(string naam, string merk, string soort, string categorie, 
        string beschrijving, double prijs, string imagelink)
        {
            openConnection();

            string sql = "INSERT Product(categorie, merk, soort, naam, beschrijving, prijs, foto" +
                "VALUES(@categorie, @merk, @soort, @naam, @beschrijving, @prijs, @foto)";
            SqlCommand sqlcmd = new SqlCommand(sql, conn);
            sqlcmd.Parameters.AddWithValue("@categorie", categorie);
            sqlcmd.Parameters.AddWithValue("@merk", merk);
            sqlcmd.Parameters.AddWithValue("@soort", soort);
            sqlcmd.Parameters.AddWithValue("@naam", naam);
            sqlcmd.Parameters.AddWithValue("@beschrijving", beschrijving);
            sqlcmd.Parameters.AddWithValue("@prijs", prijs);
            sqlcmd.Parameters.AddWithValue("@foto", imagelink);
            sqlcmd.ExecuteNonQuery();

            conn.Close();
        }
    }
}
