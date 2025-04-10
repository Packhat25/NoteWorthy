using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Threading.Tasks;

namespace NoteWorthy
{
    public static class Utilities
    {
        public static string GetOrdinal(int number)
        {
            if (number <= 0) return number.ToString(); 

            int lastDigit = number % 10;
            int lastTwoDigits = number % 100;

            if (lastTwoDigits >= 11 && lastTwoDigits <= 13)
            {
                return number + "th";
            }

            return number + (lastDigit switch
            {
                1 => "st",
                2 => "nd",
                3 => "rd",
                _ => "th"
            });
        }
        public static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hashBytes = sha256.ComputeHash(bytes);

                StringBuilder builder = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    builder.Append(b.ToString("x2")); 
                }
                return builder.ToString();
            }
        }
        public static int OrdinalToInt(string ordinal)
        {
            if (string.IsNullOrEmpty(ordinal))
                return 0;

            string numberPart = new string(ordinal.TakeWhile(char.IsDigit).ToArray());

            if (int.TryParse(numberPart, out int result))
                return result;

            return 0;
        }
    }    
}
