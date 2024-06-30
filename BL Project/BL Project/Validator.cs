using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BL_Project
{
    public class Validator
    {
        /// <summary>
        /// checks the user lenght, only lenght between 3 to 8 is the correct form and it should be only letters and numbers. unless it will bring an Error message
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool checkuser(string user)
        {
            if (user.Length < 3 || user.Length > 8)
            {
                return false;
            }
            Regex r = new Regex("^[Aa-z-Z0-9]{3,8}$");
            return r.IsMatch(user);

        }
        /// <summary>
        /// checks that the password is between 8 to 16 lenght 
        /// </summary>
        /// <param name="pass"></param>
        /// <returns></returns>
        public bool checkpass(string pass)
        {
            if (pass.Length < 8 || pass.Length > 16)
            {
                return false;
            }
            Regex r = new Regex("^[a-zA-Z0-9]{4,16}$");
            return r.IsMatch(pass);
        }
       
        /// <summary>
        /// check if the first name is between 2 to 8 lenght
        /// </summary>
        /// <param name="fname"></param>
        /// <returns></returns>
        public bool checkFirstName(string fname)
        {
            Regex r = new Regex("^[א-תa-zA-Z]{2,8}$");
            return r.IsMatch(fname);
        }

        /// <summary>
        /// check if the email is in the correct format 
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public bool checkEmail(string email)
        {
            Regex r = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
            return r.IsMatch(email);
        }
    }
}
