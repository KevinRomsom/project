using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DBDrinksIndex : ConnectionStr
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

        public List<string> Drink()
        {
            List<string> drink = new List<string>();

            openConnection();
            string query = "SELECT * FROM Product";
            SqlCommand sqlcmd = new SqlCommand(query, conn);

            int count = 0;
            using (sqlcmd)
            {
                using(var reader = sqlcmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        drink.Add(reader[count].ToString());
                        count++;
                    }
                }
            }
            conn.Close();


            return drink;
        }
    }
}
