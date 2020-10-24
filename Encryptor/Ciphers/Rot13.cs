using System.Text;

namespace Encryptor
{
    class Rot13
    {
        public string EncryptRot13(string message)
        {
            int s = 13;
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < message.Length; i++)
            {
                if (char.IsUpper(message[i])) {
                    char ch = (char)(((int)message[i] +
                                    s - 65) % 26 + 65);
                    result.Append(ch);
                }
                else {
                    char ch = (char)(((int)message[i] +
                                    s - 97) % 26 + 97);
                    result.Append(ch);
                }
            }


            string cipher_final = LetterCase(message, result.ToString());
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
