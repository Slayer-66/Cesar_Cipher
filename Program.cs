using System;
using Cesar_Cipher;
using Cesar_Cipher;

namespace Cesar_Cipher
{
    class CesarEncryption
    {
        public static void Main(string[] args)
        {
            InputHelper inputHelper = new();
            CesarEncrypter cesarEncrypter = new CesarEncrypter(inputHelper);

            var factory = new EncryptionFactory(
                new CesarCipherEncrypt(),
                new CesarCipherDecrypt(),
                new XorEncrypt(),
                new XorDecrypt()
            );

            while (true)
            {
                var (choice, fileName, key) = cesarEncrypter.GetParameters();

                switch (choice)
                {
                    case 1:
                        {
                            IDecrypt decryptor = factory.GetDecrypt(choice);
                            decryptor.Decrypt(fileName, key);
                            break;
                        }
                    case 2:
                        {
                            IEncrypt encryptor = factory.GetEncrypt(choice);
                            encryptor.Encrypt(fileName, key);
                            break;
                        }
                    case 3:
                        {
                            IDecrypt decryptor = factory.GetDecrypt(choice);
                            decryptor.Decrypt(fileName, key);
                            break;
                        }
                    case 4:
                        {
                            IEncrypt encryptor = factory.GetEncrypt(choice);
                            encryptor.Encrypt(fileName, key);
                            break;
                        }
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
        }
    }
}