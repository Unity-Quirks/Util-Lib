using System;
using System.Text;

namespace Quirks.Cryptography
{
    public static class SHA256
    {
        /// <summary>Hashes the input string</summary>
        public static string Hash(string input) => Hash(Encoding.UTF8.GetBytes(input));

        /// <summary>Hashes the input bytes</summary>
        public static string Hash(byte[] input)
        {
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                return CryptoUtils.BytesToHex(sha256.ComputeHash(input));
            }
        }

        /// <summary>Hashes the input bytes</summary>
        public static byte[] HashBytes(byte[] input)
        {
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                return sha256.ComputeHash(input);
            }
        }

        /// <summary>Hashes the input string with salt</summary>
        public static string Hash(string input, string salt) => Hash(input + salt);

        /// <summary>Hashes the input bytes with salt</summary>
        public static string Hash(byte[] input, byte[] salt)
        {
            byte[] combined = new byte[input.Length + salt.Length];
            Buffer.BlockCopy(input, 0, combined, 0, input.Length);
            Buffer.BlockCopy(salt, 0, combined, input.Length, salt.Length);

            return Hash(combined);
        }

        /// <summary>Verifies if input matches hash</summary>
        public static bool Verify(string input, string expectedHash) => Hash(input) == expectedHash;

        /// <summary>Verifies if input with salt matches hash</summary>
        public static bool Verify(string input, string salt, string expectedHash) => Hash(input, salt) == expectedHash;
    }
}
