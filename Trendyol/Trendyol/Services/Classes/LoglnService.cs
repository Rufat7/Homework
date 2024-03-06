using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trendyol.Models;

namespace Trendyol.Services.Classes
{
    class LoglnService
    {

        public bool IsEmail(string login,DBContext dBContext)
        {
            var users = dBContext.Users.ToList();

            foreach (var user in users)
            {
                if (login == user.Email)
                {
                    return true;
                }
            }
            return false;           
        }


        public bool PasswordIsTrue(string password, DBContext dBContext,User currentUser)
        {

            if (BCrypt.Net.BCrypt.Verify(password,currentUser.Password))
            {
                return true;
            }
            
            return false;
        }



    }
}
