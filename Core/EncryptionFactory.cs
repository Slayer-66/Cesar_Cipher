namespace Cesar_Cipher
{
    public class EncryptionFactory
    {
        private readonly Dictionary<int, IEncrypt> _encryptors;
        private readonly Dictionary<int, IDecrypt> _decryptors;
        public EncryptionFactory(IEnumerable<IEncrypt> encryptors, IEnumerable<IDecrypt> decryptors)
        {
            _encryptors = encryptors.ToDictionary(e => e.Choice);
            _decryptors = decryptors.ToDictionary(d => d.Choice);
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