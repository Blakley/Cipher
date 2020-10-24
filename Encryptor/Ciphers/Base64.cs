using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryptor
{
    class Base64
    {
        public string EncryptBase64(string message)
        {
            byte[] data = System.Text.ASCIIEncoding.ASCII.GetBytes(message);
            string cipher = Convert.ToBase64String(data);
            return cipher;
        }
    }
}
