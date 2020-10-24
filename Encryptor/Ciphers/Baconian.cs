using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryptor
{

    class Baconian
    {

        Dictionary<char, string> table = new Dictionary<char, string>()
        {
            {'A',"aaaaa"}, {'B',"aaaab"}, {'C',"aaaba"}, {'D',"aaabb"}, {'E',"aabaa"},
            {'F',"aabab"}, {'G',"aabba"}, {'H',"aabbb"}, {'I',"abaaa"}, {'J',"abaab"},
            {'K',"ababa"}, {'L',"ababb"}, {'M',"abbaa"}, {'N',"abbab"}, {'O',"abbba"},
            {'P',"abbbb"}, {'Q',"baaaa"}, {'R',"baaab"}, {'S',"baaba"}, {'T',"baabb"},
            {'U',"babaa"}, {'V',"babab"}, {'W',"babba"}, {'X',"babbb"}, {'Y',"bbaaa"}, 
            {'Z',"bbaab"}
        };


        public string EncryptBaconian(string message)
        {
            string cipher = "";
            foreach (char letter in message.ToUpper())
            {
                if (letter != ' ')
                    cipher += table[letter];
                else
                    cipher += ' ';
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
