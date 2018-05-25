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
        DBLogin dallogin;
        
        string dalmail = "";
        string dalpwd = "";
       

        

        string uimail = "";
        string uipwd = "";
       

        public bool checkLogin(User u)
        {
            bool result = false;
            dallogin = new DBLogin();
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


    }
}
