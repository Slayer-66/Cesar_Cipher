using System;
using System.Diagnostics;



class cesar_encryption
{
    public static void main_menu_show()
    {
        int tempo = 5;
        string path = "C:\\Users\\psowa\\OneDrive\\Desktop\\Do zaszyfrowania\\";

        string system1 = "** Cesar Cipher                     **";
        string system2 = "** 1. Otwórz plik do deszyfrowania. **";
        string system3 = "** 2. Otwórz plik do szyfrowania.   **";
        string system4 = "** 3. Exit                          **";

        foreach (char letters_system in system1) //System
        {
            Console.Write(letters_system);
            Thread.Sleep(tempo);
        }
        Console.WriteLine();
        foreach (char letters_user in system2) //User
        {
            Console.Write(letters_user);
            Thread.Sleep(tempo);
        }
        Console.WriteLine();
        foreach (char letters_system in system3) //System1
        {
            Console.Write(letters_system);
            Thread.Sleep(tempo);
        }
        Console.WriteLine();
        foreach (char letters_user in system4) //User1
        {
            Console.Write(letters_user);
            Thread.Sleep(tempo);
        }
        Console.WriteLine();
    }


    static void Main(string[] args)
    {
        main_menu_show();
    }
}