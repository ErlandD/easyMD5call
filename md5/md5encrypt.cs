using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace md5
{
    public class md5encrypt
    {
        public static String encrypt(String input)
        {
            MD5 hash = MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hashCompute = hash.ComputeHash(inputBytes);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hashCompute.Length; i++) { sb.Append(hashCompute[i].ToString("X2")); }
            return sb.ToString();
        }
    }
}
