using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using System.Xml;

namespace MerMail
{
    // This whole Asymmetric thing is inspired by an example from 
    // RSACryptoPad: http://www.codeproject.com/Articles/10877/Public-Key-RSA-Encryption-in-C-NET

    public class Asymmetric
    {
        // Our own structure for a private or public key
        public struct Key
        {
            public int bytestrength;
            public string data;
            public Key(int bs, string d)
            {
                bytestrength = bs;
                data = d;
                
            }
        }

        // generate new keys
        public static string generateKeys(int bitstrength)
        {
            RSACryptoServiceProvider RSAProvider = new RSACryptoServiceProvider(bitstrength);
            string publicAndPrivateKeys = "<BitStrength>" + bitstrength.ToString() + "</BitStrength>" + RSAProvider.ToXmlString(true);
            string justPublicKey = "<BitStrength>" + bitstrength.ToString() + "</BitStrength>" + RSAProvider.ToXmlString(false);
            string publicKeyPath = null;
            string privateKeyPath=MerMail.Program.saveFile("key.kez", "Save Public/Private Keys As", "Public/Private Keys Document( *.kez )", "*.kez", publicAndPrivateKeys,0,null);
            if (privateKeyPath!=null)
            {
                while (publicKeyPath==null)
                {
                    // We'll annoy you, until you saved the public key..
                    publicKeyPath=MerMail.Program.saveFile("publickey.pke", "Save Public Key As", "Public Key Document( *.pke )", "*.pke", justPublicKey,1,privateKeyPath);
                }

            }
            // Return string is used for the encryptForm, when making a new mail
            return publicKeyPath;
        }

        // make the key's string data to a new Key structure
        public static Key parseKeyXML(string data)
        {
            Key rtn = new Key(0, "");
            using (XmlReader reader = XmlReader.Create(new StringReader(data)))
            {
                reader.Read();
                if (reader.Name == "BitStrength")
                {
                    reader.Read();
                    rtn.bytestrength = Convert.ToInt16(reader.Value);
                    rtn.data = data.Substring(data.IndexOf("<RSAKeyValue>"), data.Length - data.IndexOf("<RSAKeyValue>"));
                }

            }
            return rtn;
        }

        // Encrypt input string with the public key specified
        // Copied from RSACryptoPad (edited a bit, so it
        // supports our key structure)
        public static string EncryptString(string inputString, Key key)
        {
            int dwKeySize = key.bytestrength;
            string xmlString = key.data;
            // TODO: Add Proper Exception Handlers
            RSACryptoServiceProvider rsaCryptoServiceProvider = new RSACryptoServiceProvider(dwKeySize);
            rsaCryptoServiceProvider.FromXmlString(xmlString);
            int keySize = dwKeySize / 8;
            byte[] bytes = Encoding.UTF32.GetBytes(inputString);
            // The hash function in use by the .NET RSACryptoServiceProvider here is SHA1
            // int maxLength = ( keySize ) - 2 - ( 2 * SHA1.Create().ComputeHash( rawBytes ).Length );
            int maxLength = keySize - 42;
            int dataLength = bytes.Length;
            int iterations = dataLength / maxLength;
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i <= iterations; i++)
            {
                byte[] tempBytes = new byte[(dataLength - maxLength * i > maxLength) ? maxLength : dataLength - maxLength * i];
                Buffer.BlockCopy(bytes, maxLength * i, tempBytes, 0, tempBytes.Length);
                byte[] encryptedBytes = rsaCryptoServiceProvider.Encrypt(tempBytes, true);
                // Be aware the RSACryptoServiceProvider reverses the order of encrypted bytes after encryption and before decryption.
                // If you do not require compatibility with Microsoft Cryptographic API (CAPI) and/or other vendors.
                // Comment out the next line and the corresponding one in the DecryptString function.
                Array.Reverse(encryptedBytes);
                // Why convert to base 64?
                // Because it is the largest power-of-two base printable using only ASCII characters
                stringBuilder.Append(Convert.ToBase64String(encryptedBytes));
            }
            return stringBuilder.ToString();
        }

        // Decrypt input string with the public key specified
        // Copied from RSACryptoPad (also edited a bit, so it
        // supports our key structure)
        public static string DecryptString(string inputString, Key key)
        {
            int dwKeySize = key.bytestrength;
            string xmlString = key.data;
            // TODO: Add Proper Exception Handlers
            RSACryptoServiceProvider rsaCryptoServiceProvider = new RSACryptoServiceProvider(dwKeySize);
            rsaCryptoServiceProvider.FromXmlString(xmlString);
            int base64BlockSize = ((dwKeySize / 8) % 3 != 0) ? (((dwKeySize / 8) / 3) * 4) + 4 : ((dwKeySize / 8) / 3) * 4;
            int iterations = inputString.Length / base64BlockSize;
            ArrayList arrayList = new ArrayList();
            for (int i = 0; i < iterations; i++)
            {
                byte[] encryptedBytes = Convert.FromBase64String(inputString.Substring(base64BlockSize * i, base64BlockSize));
                // Be aware the RSACryptoServiceProvider reverses the order of encrypted bytes after encryption and before decryption.
                // If you do not require compatibility with Microsoft Cryptographic API (CAPI) and/or other vendors.
                // Comment out the next line and the corresponding one in the EncryptString function.
                Array.Reverse(encryptedBytes);
                arrayList.AddRange(rsaCryptoServiceProvider.Decrypt(encryptedBytes, true));
            }
            return Encoding.UTF32.GetString(arrayList.ToArray(Type.GetType("System.Byte")) as byte[]);
        }

    }
}
