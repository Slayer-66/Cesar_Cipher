using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cesar_Cipher
{
    interface Iencrypt
    {
        public abstract void Encrypt(string sourceFileName, int key);
    }
    interface Idecrypt
    {
        public abstract void Decrypt(string sourceFileName, int key);
    }
}