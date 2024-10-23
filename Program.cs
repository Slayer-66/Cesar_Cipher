using Microsoft.Extensions.DependencyInjection;
using System;
using System.Security.Authentication.ExtendedProtection;
using Cesar_Cipher;

namespace Cesar_Cipher
{
    public class CesarEncryption
    {
        public static void Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();

            serviceCollection.AddSingleton<IEncrypt, CesarCipherEncrypt>();
            serviceCollection.AddSingleton<IEncrypt, XorEncrypt>();
            serviceCollection.AddSingleton<IDecrypt, CesarCipherDecrypt>();
            serviceCollection.AddSingleton<IDecrypt, XorDecrypt>();

            serviceCollection.AddSingleton<EncryptionFactory>();

            var serviceProvider = serviceCollection.BuildServiceProvider();

            var factory = serviceProvider.GetService<EncryptionFactory>();
            InputHelper inputHelper = new();
            CesarEncrypter cesarEncrypter = new CesarEncrypter(inputHelper);

            while (true)
            {
                var (choice, fileName, key) = cesarEncrypter.GetParameters();

                switch (choice)
                {
                    case 1:
                    case 3:
                        {
                            IDecrypt decryptor = factory.GetDecrypt(choice);
                            decryptor.Decrypt(fileName, key);
                            break;
                        }
                    case 2:
                    case 4:
                        {
                            IEncrypt encryptor = factory.GetEncrypt(choice);
                            encryptor.Encrypt(fileName, key);
                            break;
                        }
                    case 5:
                        {
                            Environment.Exit(0);
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