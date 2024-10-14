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
    public static class XorEncryptOrDecrypt
    {
        public static void DataXorEncryptOrDecrypt(string sourceFileName, int key, bool encrypt)
        {
            string destinationFileName;
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
    }
}
