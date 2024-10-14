using Cesar_Cipher;
using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.IO;
using System.IO.Enumeration;
using System.Runtime.InteropServices;
using System.Text;
using System.Xml;



namespace CesarCipher
{
    class CesarEncryption
    {      
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sourceFileName">file to process</param>
        /// <param name="key">cesar key value</param>
        /// <param name="encrypt">set as true for ecryption false for decryption</param>
        static void DataXorEncryptOrDecrypt(string sourceFileName, int key, bool encrypt)
        {
            string destinationFileName = "";
            if (encrypt)
            {
                destinationFileName = sourceFileName.Replace(".txt", ".xor.txt");
            }
            else
            {
                destinationFileName = sourceFileName.Replace(".xor.txt", ".txt");
            }
            using (StreamReader sourceFile = new(sourceFileName))
            {
                using (StreamWriter destinationFile = new(destinationFileName))
                {
                    string readLine;
                    while ((readLine = sourceFile.ReadLine()) != null)
                    {
                        StringBuilder writeLine = new();
                        foreach (char letter in readLine)
                        {
                            char writeLetter = (char)(letter ^ key);
                            writeLine.Append(writeLetter.ToString());

                        }
                        destinationFile.WriteLine(writeLine);
                    }
                }
            }
        }

        static void DataEncryptOrDecrypt(string sourceFileName, int key, bool encrypt)
        {
            string destinationFileName = "";
            if (encrypt)
            {
                destinationFileName = sourceFileName.Replace(".txt", ".enc.txt");
            }
            else
            {
                destinationFileName = sourceFileName.Replace(".enc.txt", ".txt");
                key *= -1;
            }

            using (StreamReader sourceFile = new(sourceFileName))
            {
                using (StreamWriter destinationFile = new(destinationFileName))
                {
                    string readLine;
                    while ((readLine = sourceFile.ReadLine()) != null)
                    {
                        StringBuilder writeLine = new();
                        foreach (char letter in readLine)
                        {
                            char writeLetter = letter;
                            if (letter >= 'a' && letter <= 'z')
                            {
                                char v = (char)((((letter - 'a' + key + 26) % 26) + 'a'));
                                writeLetter = (char)v;
                            }
                            else if (letter >= 'A' && letter <= 'Z')
                            {
                                char v = (char)((((letter - 'A' + key + 26) % 26) + 'A'));
                                writeLetter = (char)v;
                            }
                            writeLine.Append(writeLetter.ToString());
                        }
                        destinationFile.WriteLine(writeLine);
                    }
                    destinationFile.Close();
                    sourceFile.Close();
                }
            }

        }

        public static void Main(string[] args)
        {

            do
            {
                Menu.MainMenuShow();

                int choice = int.Parse(Console.ReadLine());   //Wybor uzytkownika 1-5
                Console.Clear();
                string path = "C:\\Users\\psowa\\OneDrive\\Desktop\\Do zaszyfrowania\\";
                int key = 0;
                bool isValidate = false;
                string fileName = "";

                switch (choice)
                {
                    case 1:///decryption
                        {
                            for (int i = 0; i < 3; i++)
                            {
                                Console.Write("Podaj nazwę pliku: ");
                                fileName = Console.ReadLine();  // Zapisanie nazwy pliku w pamieci
                                fileName = Path.Combine(path + fileName);  //Sciezka pliku
                                isValidate = fileName.Contains(".enc.txt");  //Sprawdzanie rozszeren pliku na konkretnej sciezce

                                if (isValidate)
                                {
                                    if (File.Exists(fileName))
                                    {
                                        break;
                                    }
                                    isValidate = false;
                                    Console.WriteLine("Plik nie istnieje");
                                    continue;

                                }
                                Console.WriteLine("Bledne rozszerzenie");
                            }
                            if (!isValidate)
                            {
                                break;
                            }

                            isValidate = false;

                            for (int i = 0; i < 3; i++)
                            {
                                Console.WriteLine();
                                Console.Write("Podaj wartość klucza: ");
                                key = int.Parse(Console.ReadLine());     //Zapisanie klucza w pamieci

                                if (key > 0 && key < 26)
                                {
                                    isValidate = true;
                                    break;
                                }
                                Console.Write("Podaj wartosc klucza od 1-25");
                            }

                            if (isValidate)
                            {
                                DataEncryptOrDecrypt(fileName, key, false);
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
                                isValidate = fileName.Contains(".txt") && !fileName.Contains(".enc.txt");


                                if (isValidate)
                                {
                                    if (File.Exists(fileName))
                                    {
                                        break;
                                    }
                                    isValidate = false;
                                    Console.WriteLine("Plik nie istnieje");
                                    continue;

                                }
                                Console.WriteLine("Podaj prawidlowe rozszerzenie!");
                            }

                            if (!isValidate)
                            {
                                break;
                            }

                            isValidate = false;
                            for (int i = 0; i < 3; i++)
                            {
                                Console.Write("Podaj wartość klucza: ");
                                key = int.Parse(Console.ReadLine());     //Zapisanie klucza w pamieci

                                if (key > 0 && key < 26)
                                {
                                    isValidate = true;
                                    break;
                                }
                                Console.WriteLine("Podaj wartosc klucza od 1-25!");
                            }

                            if (isValidate)
                            {
                                DataEncryptOrDecrypt(fileName, key, true);
                                Console.WriteLine("Dziekuje");
                                Thread.Sleep(1000);
                            }
                            break;
                        }
                    case 3: //decryption xor
                        {
                            for (int i = 0; i < 3; i++)
                            {
                                Console.Write("Podaj nazwę pliku xor: ");
                                fileName = Console.ReadLine();  // Zapisanie nazwy pliku w pamieci
                                fileName = Path.Combine(path + fileName);  //Sciezka pliku
                                isValidate = fileName.Contains(".xor.txt");

                                if (isValidate)
                                {
                                    if (File.Exists(fileName))
                                    {
                                        break;
                                    }
                                    isValidate = false;
                                    Console.WriteLine("Plik nie istnieje");
                                    continue;
                                }
                                Console.WriteLine("Podaj prawidlowe rozszerzenie!");
                            }

                            if (!isValidate)
                            {
                                break;
                            }

                            isValidate = false;

                            for (int i = 0; i < 3; i++)
                            {
                                Console.Write("Podaj wartość klucza: ");
                                key = int.Parse(Console.ReadLine());     //Zapisanie klucza w pamieci

                                if (key > 0 && key < 26)
                                {
                                    isValidate = true;
                                    break;
                                }
                                Console.WriteLine("Podaj wartosc klucza od 1-25!");
                            }
                            if (isValidate)
                            {
                                DataXorEncryptOrDecrypt(fileName, key, false);
                            }
                            break;
                        }
                    case 4: //encryption xor
                        {
                            for (int i = 0; i < 3; i++)
                            {
                                Console.Write("Podaj nazwę pliku: ");
                                fileName = Console.ReadLine();  // Zapisanie nazwy pliku w pamieci
                                fileName = Path.Combine(path + fileName);  //Sciezka pliku
                                isValidate = fileName.Contains(".txt") && !fileName.Contains(".xor.txt");
                                isValidate = !fileName.Contains(".enc.txt");


                                if (isValidate)
                                {
                                    if (File.Exists(fileName))
                                    {
                                        break;
                                    }
                                    isValidate = false;
                                    Console.WriteLine("Plik nie istnieje");
                                    continue;

                                }
                                Console.WriteLine("Podaj prawidlowe rozszerzenie!");
                            }

                            if (!isValidate)
                            {
                                break;
                            }

                            isValidate = false;

                            for (int i = 0; i < 3; i++)
                            {
                                Console.Write("Podaj wartość klucza: ");
                                key = int.Parse(Console.ReadLine());     //Zapisanie klucza w pamieci

                                if (key > 0 && key < 26)
                                {
                                    isValidate = true;
                                    break;
                                }
                                Console.WriteLine("Podaj wartosc klucza od 1-25!");
                            }
                            if (isValidate)
                            {
                                DataXorEncryptOrDecrypt(fileName, key, true);
                            }
                            break;
                        }
                    case 5:
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
}