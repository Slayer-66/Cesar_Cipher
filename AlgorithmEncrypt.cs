﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cesar_Cipher
{
    public abstract class AlgorithmEncrypt
    {
     public abstract void EncryptOrDecrypt(string sourceFileName, int key, bool encrypt);
    }
}