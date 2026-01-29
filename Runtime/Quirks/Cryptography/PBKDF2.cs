using System.Security.Cryptography;

namespace Quirks.Cryptography
{
    /// <summary>Password-Based Key Derivation Function 2</summary>
    public static class PBKDF2
    {
        // NOTE: Should be increased in the future. Average Computing Power increases over time. duhh :)
        /// <summary>Default interations for PBKDF2.</summary>
        public const int DefaultIterations = 100000;

        /// <summary>Default hash size in bytes</summary>
        public const int DefaultHashSize = 32; // 256 bits

        /// <summary>Default salt size in bytes</summary>
        public const int DefaultSaltSize = 16; // 128 bits

        /// <summary>Derives a key from a password using PBKDF2 with SHA256</summary>
        public static byte[] DeriveKey(string password, byte[] salt, int iterations = DefaultIterations, int hashSize = DefaultHashSize)
        {
            using(var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations, HashAlgorithmName.SHA256))
            {
                return pbkdf2.GetBytes(hashSize);
            }
        }

        /// <summary>Derives a key from a password using PBKDF2 with SHA512</summary>
        public static byte[] DeriveKeySHA512(string password, byte[] salt, int iterations = DefaultIterations, int hashSize = DefaultHashSize)
        {
            using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations, HashAlgorithmName.SHA512))
            {
                return pbkdf2.GetBytes(hashSize);
            }
        }

        /// <summary>Hashes a password with a randomly generated salt</summary>
        public static (string Hash, string Salt) HashPassword(string password, int iterations = DefaultIterations)
        {
            byte[] salt = Salt.Generate(DefaultSaltSize);
            byte[] hash = DeriveKey(password, salt, iterations);

            return (CryptoUtils.BytesToHex(hash), CryptoUtils.BytesToHex(salt));
        }

        /// <summary>Hashes a password with given salt</summary>
        public static string HashPassword(string password, string saltHex, int iterations = DefaultIterations)
        {
            byte[] salt = CryptoUtils.HexToBytes(saltHex);
            byte[] hash = DeriveKey(password, salt, iterations);
            return CryptoUtils.BytesToHex(hash);
        }

        /// <summary>Verifies a password against a stored hash and salt</summary>
        public static bool VerifyPassword(string password, string storedHash, string storedSalt, int iterations = DefaultIterations)
        {
            byte[] salt = CryptoUtils.HexToBytes(storedSalt);
            byte[] hash = DeriveKey(password, salt, iterations);

            return CryptoUtils.BytesToHex(hash) == storedHash;
        }
    }
}
