using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cesar_Cipher
{
    public class ProcessEncryption
    {
        public static void ProcessCesarEncryption()
        {
            string fileName = FileHelper.GetValidFileName(".txt", true);
            if (fileName == null) return;

            int key = KeyHelper.GetValidKey();
            if (key == -1) return;

            Iencrypt cesarEncrypt = new CesarCipherEncrypt();
            cesarEncrypt.Encrypt(fileName, key);

            Console.WriteLine("Thank you");
            Thread.Sleep(1000);
        }
        public static void ProcessCesarDecryption()
        {
            string fileName = FileHelper.GetValidFileName(".enc.txt", true);
            if (fileName == null) return;

            int key = KeyHelper.GetValidKey();
            if (key == -1) return;

            Idecrypt cesarDecrypt = new CesarCipherDecrypt();
            cesarDecrypt.Decrypt(fileName, key);

            Console.WriteLine("Thank you");
            Thread.Sleep(1000);
        }
        public static void ProcessXorEncryption()
        {
            string fileName = FileHelper.GetValidFileName(".txt", true);
            if (fileName == null) return;

            int key = KeyHelper.GetValidKey();
            if (key == -1) return;

            Iencrypt xorEncrypt = new XorEncrypt();
            xorEncrypt.Encrypt(fileName, key);

            Console.WriteLine("Thank you");
            Thread.Sleep(1000);
        }
        public static void ProcessXorDecryption()
        {
            string fileName = FileHelper.GetValidFileName(".xor.txt", true);
            if (fileName == null) return;

            int key = KeyHelper.GetValidKey();
            if (key == -1) return;

            Idecrypt xorDecrypt = new XorDecrypt();
            xorDecrypt.Decrypt(fileName, key);

            Console.WriteLine("Thank you");
            Thread.Sleep(1000);
        }
    }
}
