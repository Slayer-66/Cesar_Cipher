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

                int choice = InputHelper.GetValidChoice();
                Console.Clear();

                switch (choice)
                {
                    case 1: // Decryption 
                        ProcessEncryption.ProcessCesarDecryption();
                        break;
                    case 2: // Encryption 
                        ProcessEncryption.ProcessCesarEncryption();
                        break;
                    case 3: // Decryption xor
                        ProcessEncryption.ProcessXorDecryption();
                        break;
                    case 4: // Encryption xor
                        ProcessEncryption.ProcessXorEncryption();
                        break;
                    case 5: // Exit
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Uncorrect option");
                        break;
                }
            } while (true);
        }        
    }
}
