using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cesar_Cipher
{
    public interface IDecrypt
    {
        public int Choice { get; }
        public abstract void Decrypt(string sourceFileName, int key);
    }
}
