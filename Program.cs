using Cesar_Cipher;
using System;
using System.IO;
using System.Threading;

namespace Cesar_Cipher
{
    class CesarEncryption
    {
        private static string path = "C:\\Users\\psowa\\OneDrive\\Desktop\\Do zaszyfrowania\\"; //path
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
                        ProcessCesarEncryption(false);
                        break;
                    case 2: // Encryption 
                        ProcessCesarEncryption(true);
                        break;
                    case 3: // Decryption xor
                        ProcessXorEncryption(false);
                        break;
                    case 4: // Encryption xor
                        ProcessXorEncryption(true);
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
        private static void ProcessCesarEncryption(bool encrypt)
        {
            string fileName = FileHelper.GetValidFileName(encrypt ? ".txt" : ".enc.txt", !encrypt);
            if (fileName == null) return;

            int key = KeyHelper.GetValidKey();
            if (key == -1) return;

            CesarCipher cesarCipher = new();
            cesarCipher.EncryptOrDecrypt(fileName, key, encrypt);

            Console.WriteLine("Operation completed.");
            Thread.Sleep(1000);
        }
        private static void ProcessXorEncryption(bool encrypt)
        {
            string fileName = FileHelper.GetValidFileName(encrypt ? ".txt" : ".xor.txt", !encrypt);
            if (fileName == null) return;

            int key = KeyHelper.GetValidKey();
            if (key == -1) return;

            XorEncrypt xorEncrypt = new();
            xorEncrypt.EncryptOrDecrypt(fileName, key, encrypt);

            Console.WriteLine("Operation completed.");
            Thread.Sleep(1000);
        }
    }
    public static class FileHelper
    {
        private static string path = "C:\\Users\\psowa\\OneDrive\\Desktop\\Do zaszyfrowania\\";

          //checking if user typed valid type of file and extension
        public static string GetValidFileName(string expectedExtension, bool shouldExist)
        {
            string fileName;
            bool isValidate = false;

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Type file name: ");
                fileName = Console.ReadLine();
                fileName = Path.Combine(path + fileName);

                isValidate = fileName.Contains(expectedExtension) && File.Exists(fileName) == shouldExist;
                if (isValidate) return fileName;

                Console.WriteLine("File doesn't exist or incorrect extension.");
            }
            return null;
        }
    }
      //cheching if user typed a valid choice
    public static class KeyHelper
    {
        public static int GetValidKey()
        {
            int key = 0;
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Type a value of the key (1-25): ");
                if (int.TryParse(Console.ReadLine(), out key) && key > 0 && key < 26)
                {
                    return key;
                }
                Console.WriteLine("Please enter a value between 1 and 25.");
            }
            return -1;
        }
    }
     //cheching if user typed a valid choice
    public static class InputHelper
    {
        public static int GetValidChoice()
        {
            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 5)
            {
                Console.WriteLine("Uncorrect option");
            }
            return choice;
        }
    }
}
