using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cesar_Cipher
{
    public static class KeyHelper
    {
        public static int GetValidKey()
        {
            int key = 0;
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter a value for the key (1-25): ");
                if (int.TryParse(Console.ReadLine(), out key) && key >= 1 && key <= 25)
                {
                    return key;
                }
                Console.WriteLine("Please enter a value between 1 and 25.");
            }
            return -1;
        }
    }
}