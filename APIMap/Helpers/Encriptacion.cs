﻿using System.Security.Cryptography;
using System.Text;

namespace APIMap.Helpers
{
	public class Encriptacion
	{
        public static string StringToSHA512(string str)
        {
            using (var sha512 = SHA512.Create())
            {
                var arreglo = Encoding.UTF8.GetBytes(str);
                var hash = sha512.ComputeHash(arreglo);
                return Convert.ToHexString(hash).ToLower();
            }
        }
    }
}
