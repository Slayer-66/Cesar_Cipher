using System;
using Cesar_Cipher;

namespace Cesar_Cipher
{
    public class CesarEncrypter
    {
        private readonly InputHelper _inputHelper;
        public CesarEncrypter(InputHelper inputHelper)
        {
            _inputHelper = inputHelper;
        }

        public (int choice, string fileName, int key) GetParameters()
        {
            var (choice, fileName, key) = _inputHelper.GetParameters();

            if (fileName == null || key == 0)
            {
                Console.Clear();
                Console.WriteLine("Error: Invalid input. Returning to menu...");
                Thread.Sleep(2000);
                return (0, null, 0);
            }

            return (choice, fileName, key);
        }
    }
}
