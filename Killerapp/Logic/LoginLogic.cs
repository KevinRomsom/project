using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Models;

namespace Logic
{
    public class LoginLogic
    {
        DBLogin dallogin = new DBLogin();
        
        string dalmail = "";
        string dalpwd = "";
       

        

        string uimail = "";
        string uipwd = "";
       

        public bool checkLogin(User u)
        {
            //Hoofdletters opletten
            bool result = false;
            uimail = u.Email;
            uipwd = u.Password;
            dalmail = dallogin.getEmail(uimail);
            dalpwd = dallogin.getPassword(uipwd);
            if(uimail == dalmail && uipwd == dalpwd)
            {
                result = true;
            }

            return result;
        }

        public bool checkAdmin()
        {
            bool admin = false;
            string daladminstring = dallogin.getAdmin(uimail);

            if(daladminstring != "false" && daladminstring != "False")
            {
                admin = true;
            }

            return admin;

        }


    }
}
