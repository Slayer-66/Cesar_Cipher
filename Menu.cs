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
            string system1 = "** 1. Open file ot decrypt.         **";
            string system2 = "** 2. Open file to encrypt.         **";
            string system3 = "** 3. Decrypting xor                **";
            string system4 = "** 4. Encrypting xor                **";
            string system5 = "** 5. Exit                          **";

            Console.Clear();
            foreach (char letters_system in system0) //System0
            {
                Console.Write(letters_system);
                Thread.Sleep(tempo);
            }
            Console.WriteLine();
            foreach (char letters_user in system1) //System1
            {
                Console.Write(letters_user);
                Thread.Sleep(tempo);
            }
            Console.WriteLine();
            foreach (char letters_system in system2) //System2
            {
                Console.Write(letters_system);
                Thread.Sleep(tempo);
            }
            Console.WriteLine();
            foreach (char letters_user in system3) //System3
            {
                Console.Write(letters_user);
                Thread.Sleep(tempo);
            }
            Console.WriteLine();
            foreach (char letters_user in system4) //System4
            {
                Console.Write(letters_user);
                Thread.Sleep(tempo);
            }
            Console.WriteLine();
            foreach (char letters_user in system5) //System5
            {
                Console.Write(letters_user);
                Thread.Sleep(tempo);
            }
            Console.WriteLine();
        }
    }
}
