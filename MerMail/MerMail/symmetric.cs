﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

// This whole Symmetric thing is mostly from MSDN references and
// written into a class, so it's much easier to put into our project
namespace MerMail
{
    class Symmetric
    {
        // Generate a new symmetric key
        public static string generateKey()
        {
            using (TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider())
            {
                tdes.GenerateKey();
                return ASCIIEncoding.ASCII.GetString(tdes.Key);
            }
        }

        // Encrypt rawdata with symmetric key specified
        public static string EncryptString(string key, string rawdata)
        {
            TripleDESCryptoServiceProvider TDES = new TripleDESCryptoServiceProvider();
            byte[] data = UTF8Encoding.UTF8.GetBytes(rawdata);
            TDES.Key = ASCIIEncoding.ASCII.GetBytes(key);
            TDES.Mode = CipherMode.ECB;
            TDES.Padding = PaddingMode.PKCS7;
            ICryptoTransform cTransform = TDES.CreateEncryptor();
            byte[] resultArray =
              cTransform.TransformFinalBlock(data, 0,
              data.Length);
            TDES.Clear();
            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }

        // Decrypt encrypted data with symmetric key specified
        public static string DecryptString(string key, string crypteddata)
        {
            TripleDESCryptoServiceProvider TDES = new TripleDESCryptoServiceProvider();
            byte[] data = Convert.FromBase64String(crypteddata);
            TDES.KeySize = 192;
            TDES.Key = ASCIIEncoding.ASCII.GetBytes(key);
            TDES.Mode = CipherMode.ECB;
            TDES.Padding = PaddingMode.PKCS7;
            ICryptoTransform cTransform = TDES.CreateDecryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(
                         data, 0, data.Length);
            TDES.Clear();
            return UTF8Encoding.UTF8.GetString(resultArray);
        }
    }
}
