using System.Text;

namespace Quirks.Cryptography
{
    public static class MD5
    {
        /// <summary>Hashes the Input with use of a salt</summary>
        public static string Hash(string input)
        {
            using(System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] bytes = md5.ComputeHash(Encoding.UTF8.GetBytes(input));

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    sb.Append(bytes[i].ToString("x2"));
                }

                return sb.ToString();
            }
        }
    }
}
