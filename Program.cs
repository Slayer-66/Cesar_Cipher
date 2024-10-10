﻿using System;
using System.Diagnostics;
using System.IO;
using System.IO.Enumeration;



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


    static void copy_my_file(String sourceFilename)
    {
        String destinationFilename = "C:\\Users\\psowa\\OneDrive\\Desktop\\Do zaszyfrowania\\testfile.txt";

        using (StreamReader sourcefile = new StreamReader(sourceFilename))
        {
            using (StreamWriter destinationfile = new StreamWriter(destinationFilename))
            {
                string text;
                while ((text = sourcefile.ReadLine()) != null)
                {
                    destinationfile.WriteLine(text);
                }
                destinationfile.Close();
                sourcefile.Close();
            }
        }


    }

    static void Main(string[] args)
    {

        do
        {
            main_menu_show();

            int wybor = int.Parse(Console.ReadLine());   //Wybor uzytkownika 1-3
            Console.Clear();
            string path = "C:\\Users\\psowa\\OneDrive\\Desktop\\Do zaszyfrowania\\";
            int key;
            bool is_validate = false;
            string fileName = "";

            switch (wybor)
            {
                case 1:///decryption
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            Console.Write("Podaj nazwę pliku: ");
                            fileName = Console.ReadLine();  // Zapisanie nazwy pliku w pamieci
                            fileName = Path.Combine(path + fileName);  //Sciezka pliku
                            is_validate = fileName.Contains(".enc.txt");  //Sprawdzanie rozszeren pliku na konkretnej sciezce

                            if (is_validate)
                            {
                                if (File.Exists(fileName))
                                {
                                    break;
                                }
                                is_validate = false;
                                Console.WriteLine("Plik nie istnieje");
                                continue;

                            }
                            Console.WriteLine("Bledne rozszerzenie");
                        }
                        if (!is_validate)
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
                            copy_my_file(fileName);
                            Console.WriteLine("Dziekuje");
                            Thread.Sleep(1000);
                        }
                        break;
                    }
                case 2://encryption
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            Console.Write("Podaj nazwę pliku: ");
                            fileName = Console.ReadLine();  // Zapisanie nazwy pliku w pamieci
                            fileName = Path.Combine(path + fileName);  //Sciezka pliku
                            is_validate = fileName.Contains(".txt") && !fileName.Contains(".enc.txt");


                            if (is_validate)
                            {
                                if (File.Exists(fileName))
                                {
                                    break;
                                }
                                is_validate = false;
                                Console.WriteLine("Plik nie istnieje");
                                continue;

                            }
                            Console.WriteLine("Podaj prawidlowe rozszerzenie!");
                        }

                        if (!is_validate)
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