using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cesar_Cipher;

namespace Cesar_Cipher
{
    public class CesarCipherDecrypt : IDecrypt
    {
        public void Decrypt(string sourceFileName, int key)
        {
            string destinationFileName = sourceFileName.Replace(FileHelper.encTxtExtension, FileHelper.txtExtension);
            key *= -1;

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
                                char v = (char)((letter - 'a' + key + 26) % 26 + 'a');
                                writeLetter = v;
                            }
                            else if (letter >= 'A' && letter <= 'Z')
                            {
                                char v = (char)((letter - 'A' + key + 26) % 26 + 'A');
                                writeLetter = v;
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
