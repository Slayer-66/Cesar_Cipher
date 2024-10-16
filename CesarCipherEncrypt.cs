using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cesar_Cipher
{
    public class CesarCipherEncrypt : Iencrypt
    {
        public void Encrypt(string sourceFileName, int key)
        {
            string destinationFileName;

                destinationFileName = sourceFileName.Replace(".txt", ".enc.txt");

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
