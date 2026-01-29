using System;
using System.Text;

namespace Quirks.Cryptography
{
    [Obsolete("SHA1 is cryptographically broken and should not be used for security purposes! Use SHA256 instead.")]
    public static class SHA1
    {
        /// <summary>Hashes the input string</summary>
        public static string Hash(string input) => Hash(Encoding.UTF8.GetBytes(input));

        /// <summary>Hashes the input bytes</summary>
        public static string Hash(byte[] input)
        {
            using (var sha1 = System.Security.Cryptography.SHA1.Create())
            {
                return CryptoUtils.BytesToHex(sha1.ComputeHash(input));
            }
        }

        /// <summary>Hashes the input bytes</summary>
        public static byte[] HashBytes(byte[] input)
        {
            using (var sha1 = System.Security.Cryptography.SHA1.Create())
            {
                return sha1.ComputeHash(input);
            }
        }

        public static bool Verify(string input, string expectedHash) => Hash(input) == expectedHash;
    }
}
