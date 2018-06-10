using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DBDrinksAdmin
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

        public void InsertDrinks(string naam, string merk, string soort, string categorie, 
        string beschrijving, double prijs, double korting, string imagelink)
        {
            openConnection();

            string sql = "INSERT Product(categorie, merk, soort, naam, beschrijving, prijs, korting, foto" +
                "VALUES(@categorie, @merk, @soort, @naam, @beschrijving, @prijs, @korting, @foto)";
            SqlCommand sqlcmd = new SqlCommand(sql, conn);
            sqlcmd.Parameters.AddWithValue("@categorie", categorie);
            sqlcmd.Parameters.AddWithValue("@merk", merk);
            sqlcmd.Parameters.AddWithValue("@soort", soort);
            sqlcmd.Parameters.AddWithValue("@naam", naam);
            sqlcmd.Parameters.AddWithValue("@beschrijving", beschrijving);
            sqlcmd.Parameters.AddWithValue("@prijs", prijs);
            sqlcmd.Parameters.AddWithValue("@korting", korting);
            sqlcmd.Parameters.AddWithValue("@foto", imagelink);
            sqlcmd.ExecuteNonQuery();
        }
    }
}
