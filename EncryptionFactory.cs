using Cesar_Cipher;

namespace Cesar_Cipher
{
    public class EncryptionFactory
    {
        private readonly Dictionary<int, IEncrypt> _encryptors;
        private readonly Dictionary<int, IDecrypt> _decryptors;
        public EncryptionFactory(
            IEncrypt cesarEncrypt,
            IDecrypt cesarDecrypt,
            IEncrypt xorEncrypt,
            IDecrypt xorDecrypt)
        {
            _encryptors = new Dictionary<int, IEncrypt>
        {
            { 2, cesarEncrypt },
            { 4, xorEncrypt }
        };

            _decryptors = new Dictionary<int, IDecrypt>
        {
            { 1, cesarDecrypt },
            { 3, xorDecrypt }
        };
        }

        public IEncrypt GetEncrypt(int choice)
        {
            return _encryptors.TryGetValue(choice, out var encryptor)
                ? encryptor
                : throw new ArgumentException("Error: Invalid choice for encryption.");
        }

        public IDecrypt GetDecrypt(int choice)
        {
            return _decryptors.TryGetValue(choice, out var decryptor)
                ? decryptor
                : throw new ArgumentException("Error: Invalid choice for decryption.");
        }
    }
}