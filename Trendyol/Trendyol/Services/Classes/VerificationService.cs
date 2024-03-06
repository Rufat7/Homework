using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Trendyol.Services.Classes
{
    class VerificationService
    {
        public bool IsNameValid(string name)
        {
            return Regex.IsMatch(name, @"^[a-zA-Z]");
        }
        public bool IsEmailameValid(string email)
        {
            return Regex.IsMatch(email, @"(([a-zA-Z0-9](\.|_)?)+([a-zA-Z0-9])+@([a-zA-Z0-9])+((\.)[a-zA-Z]{2,})+)");
        }
        public bool IsPasswordValid(string password)
        {
            return Regex.IsMatch(password, @"^[a-zA-Z0-9.]{8,}$");
        }

    }
}
