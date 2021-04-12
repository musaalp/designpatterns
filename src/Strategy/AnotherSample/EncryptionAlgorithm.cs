namespace Strategy.AnotherSample
{
    public class EncryptionAlgorithm
    {
        public readonly IEncrytor _encrytor;

        public EncryptionAlgorithm(IEncrytor encrytor)
        {
            _encrytor = encrytor;
        }

        public void Encrypt(string message)
        {
            _encrytor.Encrypt(message);
        }
    }
}
