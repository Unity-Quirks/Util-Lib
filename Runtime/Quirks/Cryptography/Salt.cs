using System;
using System.Security.Cryptography;

namespace Quirks.Cryptography
{
    public static class Salt
    {
        public static byte[] Generate(int size = 16)
        {
            if (size < 8)
                throw new ArgumentException("Salt size should be at least 8 bytes", nameof(size));

            byte[] salt = new byte[size];
            using(var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }

            return salt;
        }

        public static string GenerateHex(int size = 16) => CryptoUtils.BytesToHex(Generate(size));
    }
}
