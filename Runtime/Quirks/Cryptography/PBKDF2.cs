using System;
using System.Security.Cryptography;
using System.Text;

namespace Quirks.Cryptography
{
    public static class PBKDF2
    {
        /// <summary>Hashes the Input with use of a salt</summary>
        public static string Hash(string input, string salt)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(salt);
            return BitConverter.ToString(new Rfc2898DeriveBytes(input, bytes, 10000).GetBytes(20)).Replace("-", string.Empty);
        }

        /// <summary>Hashes the Input with use of a salt</summary>
        public static string Hash(string input, int salt)
        {
            byte[] bytes = BitConverter.GetBytes(salt);
            return BitConverter.ToString(new Rfc2898DeriveBytes(input, bytes, 10000).GetBytes(20)).Replace("-", string.Empty);
        }
    }
}
