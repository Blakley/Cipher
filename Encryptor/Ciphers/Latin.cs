using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryptor
{
    class Latin
    {
        public string EncryptLain(string message)
        {
            string cipher = "";

            for (int i = 0; i < message.Length; i++)
                if (!char.IsLetter(message[i]) && message[i] != ' ')
                    return cipher; // invalid
 
            for (int i = 0; i < message.Length; i++)
            {
                if (message[i] >= 'A' && message[i] <= 'Z')
                {
                    cipher += (message[i] - 'A' + 1 + " ");
                }
                else if (message[i] >= 'a' && message[i] <= 'z')
                {
                    cipher += (message[i] - 'a' + 1 + " ");
                }
                if (message[i] == ' ')
                    cipher += message[i];
            }

            return cipher;
        }
    }
}
