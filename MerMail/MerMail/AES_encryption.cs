using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MerMail
{
    // this is just a simple homemade AES encryption
    class encryptionSession
    {
        // This is the key for decryption. Is defined from the constructor
        private byte[] keysequence;
        // Our constructor. 
        // The argument for the constructor is a string.
        // Strings are good for you!
        public encryptionSession(string key)
        {
            keysequence = new byte[key.Length];
            int i = 0;
            foreach (char c in key)
            {
                keysequence[i++] = Convert.ToByte(c);
            }
        }
        public string encrypt(string raw)
        {
            int i = 0;
            char[] rtn = new char[raw.Length];
            foreach (char c in raw)
            {
                rtn[i] = Convert.ToChar(Convert.ToByte(Convert.ToByte(c) + keysequence[i % keysequence.Length]));
                i++;
            }
            return new string(rtn);
        }
        public string decrypt(string enc)
        {
            int i = 0;
            char[] rtn = new char[enc.Length];
            foreach (char c in enc)
            {
                rtn[i] = Convert.ToChar(Convert.ToByte(Convert.ToByte(c) - keysequence[i % keysequence.Length]));
                i++;
            }
            return new string(rtn);
        }



    }
}
