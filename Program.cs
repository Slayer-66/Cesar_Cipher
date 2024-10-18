using System;

namespace Cesar_Cipher
{
    class CesarEncryption
    {
        public static void Main(string[] args)
        {
            InputHelper inputHelper = new();

            CesarEncrypter cesarEncrypter = new CesarEncrypter(inputHelper);
            do
            {
                var (choice, fileName, key) = cesarEncrypter.GetParameters();

                switch (choice)
                {
                    case 1:
                        {
                            IDecrypt decryptor = EncryptionFactory.GetDecrypt(choice);
                            decryptor.Decrypt(fileName, key);
                            break;
                        }
                    case 2:
                        {
                            IEncrypt encryptor = EncryptionFactory.GetEncrypt(choice);
                            encryptor.Encrypt(fileName, key);
                            break;
                        }
                    case 3:
                        {
                            IDecrypt decryptor = EncryptionFactory.GetDecrypt(choice);
                            decryptor.Decrypt(fileName, key);
                            break;
                        }
                    case 4:
                        {
                            IEncrypt encryptor = EncryptionFactory.GetEncrypt(choice);
                            encryptor.Encrypt(fileName, key);
                            break;
                        }
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
            while (true);
        }
    }
}