using System.Collections.Generic;

namespace Encryptor
{
    class Atbash
    {
        Dictionary<char, char> table = new Dictionary<char, char>()
        {
            {'A', 'Z' }, {'B' , 'Y' }, {'C' , 'X' },
            { 'D' , 'W' }, {'E' , 'V' }, {'F' , 'U' },
            { 'G' , 'T' }, {'H' , 'S' }, {'I' , 'R' },
            { 'J' , 'Q' },{'K' , 'P' }, {'L' , 'O' },
            { 'M' , 'N' }, {'N' , 'M' }, {'O' , 'L' },
            {'P' , 'K' }, {'Q' , 'J' }, {'R' , 'I' }, {'S' , 'H' },
            { 'T' , 'G' }, {'U' , 'F' }, {'V' , 'E' }, {'W' , 'D' },
            { 'X' , 'C' }, {'Y' , 'B' }, {'Z' , 'A'}
        };

        public string EncryptAtbash(string message)
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
