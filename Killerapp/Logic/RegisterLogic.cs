using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;


namespace Logic
{
    public class RegisterLogic
    {
        DBRegister dalregister;
        
        public void insertRegisterInfo(Register r)
        {
            dalregister = new DBRegister();

            string regmail = r.Email;
            string regvoornaam = r.Voornaam;
            string regachternaam = r.Achternaam;
            string regpwd = r.Password;

            dalregister.Insert(regmail, regpwd, regvoornaam, regachternaam);


        }

        public bool checkPassword(Register reg)
        {
            bool same = false;

            if(reg.Password == reg.PasswordRepeat)
            {
                same = true;
            }

            return same;
        }

         

    }
}
