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
                "1. Otwórz plik do deszyfrowania.",
                "2. Otwórz plik do szyfrowania.",
                "3. Deszyfrowanie xor",
                "4. Szyfrowanie xor",
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
            string formattedText = string.Format("{0}{1}{2}", prefix, text.PadRight(menuLength - prefix.Length - postfix.Length), postfix);

            foreach (char letter in formattedText)
            {
                Console.Write(letter);
                Thread.Sleep(1);
            }
            Console.WriteLine();
        }
    }
}
