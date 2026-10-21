using System;
using System.Collections.Generic;
using System.Text;

namespace LabWork10
{
    public static class PasswordValidator
    {
        public static bool IsValid(string password)
        {
            if (string.IsNullOrEmpty(password) || password.Length < 8)
                return false;

            bool hasDigit = false;
            bool hasLatin = false;

            foreach (char c in password)
            {
                if (c >= '0' && c <= '9')
                    hasDigit = true;
                else if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
                    hasLatin = true;

                if (hasDigit && hasLatin)
                    return true;
            }

            return false;
        }
    }

}
