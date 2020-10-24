using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryptor { 
    class Polybius
    {
        public string EncryptPolybuis(string message)
        {
            string cipher = "";


            int row, col;

            for (int i = 0; i < message.Length; i++)
            {

                row = (int)Math.Floor((message[i] -'a') / 5.0) + 1;


                col = ((message[i] - 'a') % 5) + 1;

                if (message[i] == 'k')
                {
                    row -= 1;
                    col = 5 - col + 1;
                }
                else if (message[i] >= 'j')
                {
                    if (col == 1)
                    {
                        col = 6;
                        row -= 1;
                    }
                    col -= 1;
                }
                cipher += (row + "" + col);
            }

            return cipher;
        }
    }
}
