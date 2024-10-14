using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cesar_Cipher
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="sourceFileName">file to process</param>
    /// <param name="key">cesar key value</param>
    /// <param name="encrypt">set as true for ecryption false for decryption</param>
    public static class EncryptOrDecrypt
    {
        public static void DataEncryptOrDecrypt(string sourceFileName, int key, bool encrypt)
        {
            string destinationFileName;
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
    }
}
