using System.Text;

namespace Quirks.Cryptography
{
    public static class SHA512
    {
        /// <summary>Hashes the input string</summary>
        public static string Hash(string input) => Hash(Encoding.UTF8.GetBytes(input));

        /// <summary>Hashes the input bytes</summary>
        public static string Hash(byte[] input)
        {
            using (var sha512 = System.Security.Cryptography.SHA512.Create())
            {
                return CryptoUtils.BytesToHex(sha512.ComputeHash(input));
            }
        }

        /// <summary>Hashes the input bytes</summary>
        public static byte[] HashBytes(byte[] input)
        {
            using (var sha512 = System.Security.Cryptography.SHA512.Create())
            {
                return sha512.ComputeHash(input);
            }
        }

        public static bool Verify(string input, string expectedHash) => Hash(input) == expectedHash;
    }
}
