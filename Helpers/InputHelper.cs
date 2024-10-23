using System;

namespace Cesar_Cipher
{
    public class InputHelper
    {
        public (int choice, string fileName, int key) GetParameters()
        {
            Menu.MainMenuShow();
            int choice = GetChoice();

            string fileName = FileHelper.GetValidFileName(FileHelper.txtExtension, true);
            if (fileName == null)
            {
                Console.WriteLine("Invalid file name.");
                return (0, null, 0);
            }
            int key = KeyHelper.GetValidKey();
            if (key == -1)
            {
                Console.WriteLine("Invalid key.");
                return (0, null, 0);
            }

            return (choice, fileName, key);
        }

        private int GetChoice()
        {
            int choice = 0;
            while (choice < 1 || choice > 5)
            {
                if (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 5)
                {
                    Console.WriteLine("Invalid option. Please enter a number between 1 and 5.");
                }
                if (choice == 5)
                {
                    Environment.Exit(0);
                }
            }
            return choice;
        }
    }
}
