using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cesar_Cipher
{
    public static class InputHelper
    {
        public static (int choice, string fileName, int key) GetParameters()
        {
            int choice = 0;
            while (choice < 1 || choice > 5)
            {
                if (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 5)
                {
                    Console.WriteLine("Invalid option. Please enter a number between 1 and 5.");
                }
            }
            if (choice == 5)
            {
                Environment.Exit(0);
            }
            string fileName = FileHelper.GetValidFileName(FileHelper.txtExtension, true);
            if (fileName == null) return (0, null, 0);

            int key = KeyHelper.GetValidKey();
            if (key == -1) return (0, null, 0);

            return (choice, fileName, key);
        }
    }
}