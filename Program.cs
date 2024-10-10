using System;
using System.Diagnostics;
using System.IO.Enumeration;
using System.Security.Cryptography.X509Certificates;



class cesar_encryption
{
    public static void main_menu_show()
    {

        int tempo = 1;

        string system1 = "** Cesar Cipher                     **";
        string system2 = "** 1. Otwórz plik do deszyfrowania. **";
        string system3 = "** 2. Otwórz plik do szyfrowania.   **";
        string system4 = "** 3. Exit                          **";

        Console.Clear();
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

        do
        {
            main_menu_show();

            int wybor = int.Parse(Console.ReadLine());   //Wybor uzytkownika 1-3
            Console.Clear();

            int key;
            bool is_validate = false;
            string fileName; //Bez rozszerzenia
            string path = "C:\\Users\\psowa\\OneDrive\\Desktop\\Do zaszyfrowania\\";
            string endFile;
            bool valid_fileName = false;

            switch (wybor)
            {
                case 1:
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            Console.Write("Podaj nazwę pliku bez rozszerzenia: ");
                            fileName = Console.ReadLine();  // Zapisanie nazwy pliku w pamieci
                            string filesPath = Path.Combine(path + fileName + ".enc.txt");  //Sciezka pliku
                            filesPath.Contains(".enc.txt");  //Sprawdzanie rozszerzen pliku na konkretnej sciezce;

                            if (filesPath.Contains(".enc.txt"))
                            {
                                if (File.Exists(filesPath))
                                {
                                    valid_fileName = true;

                                    endFile = Path.Combine(fileName + ".txt");
                                    string endFilesPath = Path.Combine(path + endFile);

                                    using (StreamReader sr = new StreamReader(filesPath))
                                    {
                                        using (StreamWriter sw = new StreamWriter(endFilesPath))
                                        {
                                            string text;
                                            while ((text = sr.ReadLine()) != null)
                                            {
                                                sw.WriteLine(text);
                                            }
                                            sw.Close();
                                            sr.Close();
                                        }
                                    }
                                    break;
                                }
                                Console.WriteLine("Plik nie istnieje");
                            }
                        }

                        if (!valid_fileName)
                        {
                            break;
                        }

                        is_validate = false;
                        for (int i = 0; i < 3; i++)
                        {
                            Console.WriteLine();

                            Console.Write("Podaj wartość klucza: ");
                            key = int.Parse(Console.ReadLine());     //Zapisanie klucza w pamieci

                            if (key > 0 && key < 26)
                            {
                                is_validate = true;
                                break;
                            }
                            Console.Write("Podaj wartosc klucza od 1-25");
                        }

                        if (is_validate)
                        {
                            Console.WriteLine("Dziekuje");
                            Thread.Sleep(1000);
                        }
                        break;
                    }
                case 2:
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            Console.Write("Podaj nazwę pliku bez rozszerzenia: ");
                            fileName = Console.ReadLine();  // Zapisanie nazwy pliku w pamieci
                            string filesPath = Path.Combine(path + fileName + ".txt");  //Sciezka pliku
                            filesPath.Contains(".txt");

                            if (filesPath.Contains(".txt"))
                            {
                                if (File.Exists(filesPath))
                                {
                                    valid_fileName = true;
                                    endFile = Path.Combine(fileName + ".enc.txt");
                                    string endFilesPath = Path.Combine(path + endFile);

                                    using (StreamReader sr = new StreamReader(filesPath))
                                    {
                                        using (StreamWriter sw = new StreamWriter(endFilesPath))
                                        {
                                            string text;
                                            while ((text = sr.ReadLine()) != null)
                                            {
                                                sw.WriteLine(text);
                                            }
                                            sw.Close();
                                            sr.Close();
                                        }
                                    }
                                    break;
                                }
                                Console.WriteLine("Plik nie istnieje");
                            }
                        }

                        if (!valid_fileName)
                        {
                            break;
                        }

                        is_validate = false;
                        for (int i = 0; i < 3; i++)
                        {
                            Console.Write("Podaj wartość klucza: ");
                            key = int.Parse(Console.ReadLine());     //Zapisanie klucza w pamieci

                            if (key > 0 && key < 26)
                            {
                                is_validate = true;
                                break;
                            }
                            Console.WriteLine("Podaj wartosc klucza od 1-25!");
                        }

                        if (is_validate)
                        {
                            Console.WriteLine("Dziekuje");
                            Thread.Sleep(1000);
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
        } while (true);
    }
}