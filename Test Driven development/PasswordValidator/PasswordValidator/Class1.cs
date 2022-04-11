using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordValidator
{
    public class PassowrdValidatorClass
    {
        public string username;
        public string password;
        public int Validator()
        {
            if(password.Length == 0)
            {
                return 0;
            }
            else
            {
                if(password.Length < 8)
                {
                    return -1;
                }
                else if (!password.Any(char.IsUpper))
                {
                    return -2;
                }
                else if (!password.Any(char.IsLower))
                {
                    return -3;
                }
                else if (!password.Any(char.IsDigit))
                {
                    return -4;
                }
            }
            return 1;
        }
    }
}
