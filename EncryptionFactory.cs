using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cesar_Cipher
{
    public class EncryptionFactory
    {
        public static IEncrypt GetEncrypt(int choice)
        {
            return choice switch
            {
                2 => new CesarCipherEncrypt(),
                4 => new XorEncrypt(),
                _ => throw new ArgumentException("Error")
            };
        }
        public static IDecrypt GetDecrypt(int choice)
        {
            return choice switch
            {
                1 => new CesarCipherDecrypt(),
                3 => new XorDecrypt(),
                _ => throw new ArgumentException("Error")
            };
        }
    }
}
