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

        private const int menuLength = 40; //Length of menu

        public static void MainMenuShow()
        {
            int tempo = 1;

            string system0 = "Cesar Cipher";
            string system1 = "1. Otwórz plik do deszyfrowania.";
            string system2 = "2. Otwórz plik do szyfrowania.";
            string system3 = "3. Deszyfrowanie xor";
            string system4 = "4. Szyfrowanie xor";
            string system5 = "5. Exit";

            Console.Clear();

            PrintMenuLine(system0);
            PrintMenuLine(system1);
            PrintMenuLine(system2);
            PrintMenuLine(system3);
            PrintMenuLine(system4);
            PrintMenuLine(system5);
        }

        private static void PrintMenuLine(string text)
        {
            string formattedText = prefix + text.PadRight(menuLength - prefix.Length - postfix.Length) + postfix;
            foreach (char letter in formattedText)
            {
                Console.Write(letter);
                Thread.Sleep(1);
            }
            Console.WriteLine();
        }
    }
}