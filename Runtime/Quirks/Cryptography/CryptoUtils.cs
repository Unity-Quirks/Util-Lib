using System;
using System.Runtime.CompilerServices;
using System.Text;

namespace Quirks.Cryptography
{
    internal static class CryptoUtils
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string BytesToHex(byte[] bytes)
        {
            StringBuilder sb = new StringBuilder(bytes.Length * 2);
            foreach(byte b in bytes)
            {
                sb.Append(b.ToString("x2"));
            }

            return sb.ToString();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte[] HexToBytes(string hex)
        {
            if (hex.Length % 2 != 0)
                throw new ArgumentException("Hex string must have even length");

            byte[] bytes = new byte[hex.Length / 2];
            for (int i = 0; i < bytes.Length; i++)
            {
                bytes[i] = Convert.ToByte(hex.Substring(i * 2, 2), 16);
            }

            return bytes;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string Base64Encode(byte[] bytes) => Convert.ToBase64String(bytes);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte[] Base64Decode(string base64) => Convert.FromBase64String(base64);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string Base64UrlEncode(byte[] bytes)
        {
            string base64 = Convert.ToBase64String(bytes);
            return base64.Replace('+', '-').Replace('/', '_').TrimEnd('=');
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte[] Base64UrlDecode(string base64Url)
        {
            string base64 = base64Url.Replace('-', '+').Replace('_', '/');
            switch(base64.Length % 4)
            {
                case 2: base64 += "=="; break;
                case 3: base64 += "="; break;
            }

            return Convert.FromBase64String(base64);
        }
    }
}
