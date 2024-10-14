using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cesar_Cipher
{
    class Menu
    {
        private static string prefix = "** ";
        private static string postfix = " **";

        private const int menuLength = 40;

        public static void MainMenuShow()
        {
            string[] menuItems = new string[]
            {
                "Cesar Cipher",
                "1. Open file to decrypt.",
                "2. Open file to encrypt.",
                "3. Decrypting xor",
                "4. Encrypting xor",
                "5. Exit",
            };
            Console.Clear();

            foreach (var item in menuItems)
            {
                PrintMenuLine(item);
            }
        }
        private static void PrintMenuLine(string text)
        {
            int lenghtMenu = menuLength - prefix.Length - postfix.Length;
            string formattedText = string.Format("{0}{1}{2}", prefix, text.PadRight(lenghtMenu), postfix);

            foreach (char letter in formattedText)
            {
                Console.Write(letter);
                Thread.Sleep(1);
            }
            Console.WriteLine();
        }
    }
}
