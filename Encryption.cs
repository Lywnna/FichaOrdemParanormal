using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FichaOrdemParanormal
{
    internal static class Encryption
    {
        public static string Encrypt(string rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {

                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF32.GetBytes(rawData));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                    builder.Append(bytes[i].ToString("x2"));
                return builder.ToString();
            }
        }
        public static string Encode(string rawData) 
        {
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(rawData));
        }
        public static string Decode(string rawData) 
        {
            return Encoding.UTF8.GetString(Convert.FromBase64String(rawData));
        }
    }
}
