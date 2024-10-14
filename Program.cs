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
        public static void Main(string[] args)
        {

            do
            {
                Menu.MainMenuShow();

                int choice = int.Parse(Console.ReadLine());   //Users choice 1-5
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
                                Console.Write("Type file name: ");
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
                                    Console.WriteLine("File doesn't exist");
                                    continue;

                                }
                                Console.WriteLine("Uncorrect extension");
                            }
                            if (!isValidate)
                            {
                                break;
                            }

                            isValidate = false;

                            for (int i = 0; i < 3; i++)
                            {
                                Console.WriteLine();
                                Console.Write("Type value of the key: ");
                                key = int.Parse(Console.ReadLine());     //Zapisanie klucza w pamieci

                                if (key > 0 && key < 26)
                                {
                                    isValidate = true;
                                    break;
                                }
                                Console.Write("Type value of the key between 1-25");
                            }

                            if (isValidate)
                            {
                                EncryptOrDecrypt.DataEncryptOrDecrypt(fileName, key, false);
                                Console.WriteLine("Thank you");
                                Thread.Sleep(1000);
                            }
                            break;
                        }
                    case 2://encryption
                        {
                            for (int i = 0; i < 3; i++)
                            {
                                Console.Write("Type file name: ");
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
                                    Console.WriteLine("File doesn't exist");
                                    continue;

                                }
                                Console.WriteLine("Uncorrect extension");
                            }

                            if (!isValidate)
                            {
                                break;
                            }

                            isValidate = false;
                            for (int i = 0; i < 3; i++)
                            {
                                Console.Write("Type value of the key: ");
                                key = int.Parse(Console.ReadLine());     //Zapisanie klucza w pamieci

                                if (key > 0 && key < 26)
                                {
                                    isValidate = true;
                                    break;
                                }
                                Console.WriteLine("Type value of the key between 1-25!");
                            }

                            if (isValidate)
                            {
                                EncryptOrDecrypt.DataEncryptOrDecrypt(fileName, key, true);
                                Console.WriteLine("Thank you");
                                Thread.Sleep(1000);
                            }
                            break;
                        }
                    case 3: //decryption xor
                        {
                            for (int i = 0; i < 3; i++)
                            {
                                Console.Write("Type xor file name: ");
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
                                    Console.WriteLine("File doesn't exist");
                                    continue;
                                }
                                Console.WriteLine("Uncorrect extension");
                            }

                            if (!isValidate)
                            {
                                break;
                            }

                            isValidate = false;

                            for (int i = 0; i < 3; i++)
                            {
                                Console.Write("Type of the key: ");
                                key = int.Parse(Console.ReadLine());     //Zapisanie klucza w pamieci

                                if (key > 0 && key < 26)
                                {
                                    isValidate = true;
                                    break;
                                }
                                Console.WriteLine("Type value of the key between 1-25!");
                            }
                            if (isValidate)
                            {
                                XorEncryptOrDecrypt.DataXorEncryptOrDecrypt(fileName, key, false);
                            }
                            break;
                        }
                    case 4: //encryption xor
                        {
                            for (int i = 0; i < 3; i++)
                            {
                                Console.Write("Type file name: ");
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
                                    Console.WriteLine("File doesn't exist");
                                    continue;

                                }
                                Console.WriteLine("Uncorrect extension");
                            }

                            if (!isValidate)
                            {
                                break;
                            }

                            isValidate = false;

                            for (int i = 0; i < 3; i++)
                            {
                                Console.Write("Type value of the key: ");
                                key = int.Parse(Console.ReadLine());     //Zapisanie klucza w pamieci

                                if (key > 0 && key < 26)
                                {
                                    isValidate = true;
                                    break;
                                }
                                Console.WriteLine("Type value of the key between 1-25!");
                            }
                            if (isValidate)
                            {
                                XorEncryptOrDecrypt.DataXorEncryptOrDecrypt(fileName, key, true);
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
                            Console.Write("Uncorrect option");
                            break;
                        }
                }
            } while (true);
        }
    }
}