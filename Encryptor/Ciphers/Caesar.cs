using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryptor
{
    class Caesar
    {

        public string EncryptCaesar(string message, int shift)
        {
            string cipher = "";

            foreach (char letter in message)
            {
                if (char.IsUpper(letter))
                {
                    char c = (char)(((int)letter + shift - 65) % 26 + 65);
                    cipher += c;
                }
                else if (char.IsLower(letter))
                {
                    char c = (char)(((int)letter + shift - 97) % 26 + 97);
                    cipher += c;
                }
                else
                {
                    cipher += letter;
                }
            }

            string cipher_final = LetterCase(message, cipher);
            return cipher_final;
        }

        private string LetterCase(string message, string cipher)
        {
            int index = 0;
            string cipher_final = "";
            foreach (char letter in message)
            {
                char current_char = cipher[index];
                if (char.IsUpper(letter))
                {
                    cipher_final += char.ToUpper(current_char);
                }
                else if (char.IsLower(letter))
                {
                    cipher_final += char.ToLower(current_char);
                }
                else
                {
                    cipher_final += current_char;
                }
                index += 1;
            }

            return cipher_final;
        }

    }
}
