using Cesar_Cipher;
using System;
using System.IO;
using System.Threading;

namespace Cesar_Cipher
{
    class CesarEncryption
    {
        public static void Main(string[] args)
        {
            do
            {
                Menu.MainMenuShow(); //menu method

                var (choice, fileName, key) = InputHelper.GetParameters();
                
                switch (choice)
                {
                    case 1: // Decryption 
                        ProcessEncryption.ProcessCesarDecryption(fileName, key);
                        break;
                    case 2: // Encryption 
                        ProcessEncryption.ProcessCesarEncryption(fileName, key);
                        break;
                    case 3: // Decryption xor
                        ProcessEncryption.ProcessXorDecryption(fileName, key);
                        break;
                    case 4: // Encryption xor
                        ProcessEncryption.ProcessXorEncryption(fileName, key);
                        break;
                    default:
                        Console.WriteLine("Uncorrect option");
                        break;
                }
            } while (true);
        }
    }
}
