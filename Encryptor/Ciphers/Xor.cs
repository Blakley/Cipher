using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryptor
{
    class Xor
    {
        // encrypts and decrypts
        public string EncryptXor(string message, string user_key)
        {
            string cipher = "";
            char key = user_key[0];
            int len = message.Length;

            for (int i = 0; i < len; i++)
                cipher += char.ToString((char)(message[i] ^ key));

            return cipher;
        }
    }
}
