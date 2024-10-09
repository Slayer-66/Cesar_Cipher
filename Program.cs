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

        int wybor = int.Parse(Console.ReadLine());   //Wybor uzytkownika 1-3
        Console.Clear();

        int key;

        switch (wybor)
        {
            case 1:
                {
                    for (int i = 0; i < 3; i++)
                    {
                        Console.Write("Podaj nazwę pliku: ");
                        string fileName = Console.ReadLine();  // Zapisanie nazwy pliku w pamieci
                        bool is_validate = fileName.Contains(".enc.txt");


                        if (is_validate)
                        {
                            break;

                        }
                        Console.WriteLine("Bledne rozszerzenie");
                    }

                    for (int i = 0; i < 3; i++)
                    {
                        Console.WriteLine();

                        Console.Write("Podaj wartość klucza: ");
                        key = int.Parse(Console.ReadLine());     //Zapisanie klucza w pamieci

                        if (key > 0 && key < 26)
                        {
                            break;
                        }
                        Console.Write("Podaj wartosc klucza od 1-25");
                    }


                    break;
                }
            case 2:
                {
                    Console.Write("Podaj nazwę pliku: ");

                    for (int i = 0; i < 3; i++)
                    {
                        string fileName = Console.ReadLine();  // Zapisanie nazwy pliku w pamieci
                        bool isValidate = fileName.Contains(".txt") && !fileName.Contains(".enc.txt");

                        if (isValidate)
                        {
                            break;
                        }
                        Console.Write("Podaj prawidlowe rozszerzenie: ");
                    }
                    Console.Write("Podaj wartość klucza: ");

                    for (int i = 0; i < 3; i++)
                    {
                        key = int.Parse(Console.ReadLine());     //Zapisanie klucza w pamieci

                        if (key > 0 && key < 26)
                        {
                            break;
                        }
                        Console.Write("Podaj wartosc klucza od 1-25: ");
                    }
                    break;
                }
            case 3:
                {
                    Environment.Exit(0);
                    break;
                }
            default:
                {
                    Console.Write("To nie jest prawidlowa opcja ");
                    break;
                }
        }

        /*




                string not_encrypted_file = Path.Combine(path + not_encrypted);


                if (File.Exists(not_encrypted_file))
                {









                    /*
                    using (StreamReader sr = File.OpenText(not_encrypted_file))   //Pokazywanie zawartosci plikow
                    {
                        string zawartosc = sr.ReadToEnd();
                        Console.WriteLine(zawartosc);
                    }

                    */
    }





}