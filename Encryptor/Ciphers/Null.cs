using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryptor
{
    class Null
    {
        public string EncryptNull(string message)
        {
            string cipher = "";
            Boolean found = false;
            for (int i = 0; i < message.Length; i++)
            {
                // Set found variable to false whenever we find 
                // whitespace, meaning that encoded character for 
                // new word is not found 
                if (message[i] == ' ')
                {
                    found = false;
                    continue;
                }
                if (!found)
                {
                    if (message[i] >= 'A' && message[i] <= 'Z')
                    {
                        cipher += (char)(message[i] + 32);
                        found = true;
                    }
                    else if (message[i] >= 'a' && message[i] <= 'z')
                    {
                        cipher += (char)message[i];
                        found = true;
                    }
                }
            }

            return cipher;
        }

    }
}
