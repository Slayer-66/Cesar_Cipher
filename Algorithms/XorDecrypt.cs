﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cesar_Cipher;

namespace Cesar_Cipher
{
    public class XorDecrypt : IDecrypt
    {
        public int Choice => 3;
        public void Decrypt(string sourceFileName, int key)
        {
            string destinationFileName = sourceFileName.Replace(FileHelper.xorTxtExtension, FileHelper.txtExtension);

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
                    destinationFile.Close();
                    sourceFile.Close();
                }
            }
        }
    }
}