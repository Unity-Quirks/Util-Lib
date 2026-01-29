using System.Security.Cryptography;
using System.Text;

namespace Quirks.Cryptography
{
    /// <summary>Hash-based Message Authentication Code</summary>
    public static class HMAC
    {
        /// <summary>Creates an HMAC-SHA256 hash</summary>
        public static string SHA256(string input, string key) => SHA256(Encoding.UTF8.GetBytes(input), Encoding.UTF8.GetBytes(key));

        /// <summary>Creates an HMAC-SHA256 hash</summary>
        public static string SHA256(byte[] input, byte[] key)
        {
            using (var hmac = new HMACSHA256(key))
            {
                return CryptoUtils.BytesToHex(hmac.ComputeHash(input));
            }
        }

        /// <summary>Creates an HMAC-SHA512 hash</summary>
        public static string SHA512(string input, string key) => SHA512(Encoding.UTF8.GetBytes(input), Encoding.UTF8.GetBytes(key));

        /// <summary>Creates an HMAC-SHA512 hash</summary>
        public static string SHA512(byte[] input, byte[] key)
        {
            using (var hmac = new HMACSHA512(key))
            {
                return CryptoUtils.BytesToHex(hmac.ComputeHash(input));
            }
        }

        /// <summary>Verifies HMAC-SHA256</summary>
        public static bool VerifySHA256(string input, string key, string expectedHmac) => SHA256(input, key) == expectedHmac;

        /// <summary>Verifies HMAC-SHA512</summary>
        public static bool VerifySHA512(string input, string key, string expectedHmac) => SHA512(input, key) == expectedHmac;
    }
}
