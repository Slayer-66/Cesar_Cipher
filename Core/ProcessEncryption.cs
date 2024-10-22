using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cesar_Cipher
{
    public static class ProcessEncryption
    {
        public static void ProcessCesarEncryption(string fileName, int key)
        {
            IEncrypt cesarEncrypt = new CesarCipherEncrypt();
            cesarEncrypt.Encrypt(fileName, key);
        }

        public static void ProcessCesarDecryption(string fileName, int key)
        {
            IDecrypt cesarDecrypt = new CesarCipherDecrypt();
            cesarDecrypt.Decrypt(fileName, key);
        }

        public static void ProcessXorEncryption(string fileName, int key)
        {
            IEncrypt xorEncrypt = new XorEncrypt();
            xorEncrypt.Encrypt(fileName, key);
        }

        public static void ProcessXorDecryption(string fileName, int key)
        {
            IDecrypt xorDecrypt = new XorDecrypt();
            xorDecrypt.Decrypt(fileName, key);
        }
    }
}
