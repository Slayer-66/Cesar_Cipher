namespace Cesar_Cipher
{
    public static class FileHelper
    {
        public const string txtExtension = ".txt";
        public const string encTxtExtension = ".enc.txt";
        public const string xorTxtExtension = ".xor.txt";
        public static string GetValidFileName(string expectedExtension, bool shouldExist)
        {
            string fileName;
            bool isValidate = false;

            Console.Clear();
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Type file name: ");
                fileName = Console.ReadLine();
                fileName = Path.Combine(Directory.GetCurrentDirectory(), fileName);

                isValidate = fileName.EndsWith(expectedExtension) && File.Exists(fileName) == shouldExist;
                if (isValidate) return fileName;

                Console.WriteLine("Invalid file name or extension.");
            }
            return null;
        }
    }
}
