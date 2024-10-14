using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cesar_Cipher
{
   public static class Menu
    {
        public static void MainMenuShow()
        {
            int tempo = 1;

            string system0 = "** Cesar Cipher                     **";
            string system1 = "** 1. Otwórz plik do deszyfrowania. **";
            string system2 = "** 2. Otwórz plik do szyfrowania.   **";
            string system3 = "** 3. Deszyfrowanie xor             **";
            string system4 = "** 4. Szyfrowanie xor               **";
            string system5 = "** 5. Exit                          **";

            Console.Clear();
            foreach (char letters_system in system0) //System
            {
                Console.Write(letters_system);
                Thread.Sleep(tempo);
            }
            Console.WriteLine();
            foreach (char letters_user in system1) //User
            {
                Console.Write(letters_user);
                Thread.Sleep(tempo);
            }
            Console.WriteLine();
            foreach (char letters_system in system2) //System1
            {
                Console.Write(letters_system);
                Thread.Sleep(tempo);
            }
            Console.WriteLine();
            foreach (char letters_user in system3) //User1
            {
                Console.Write(letters_user);
                Thread.Sleep(tempo);
            }
            Console.WriteLine();
            foreach (char letters_user in system4) //User1
            {
                Console.Write(letters_user);
                Thread.Sleep(tempo);
            }
            Console.WriteLine();
            foreach (char letters_user in system5) //User1
            {
                Console.Write(letters_user);
                Thread.Sleep(tempo);
            }
            Console.WriteLine();
        }
    }
}
