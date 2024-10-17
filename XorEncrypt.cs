using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cesar_Cipher
{
    public class XorEncrypt : IEncrypt
    {
        public void Encrypt(string sourceFileName, int key)
        {
            string destinationFileName = sourceFileName.Replace(FileHelper.txtExtension, FileHelper.xorTxtExtension);

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
