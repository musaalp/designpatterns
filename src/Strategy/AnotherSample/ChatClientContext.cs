namespace Strategy.AnotherSample
{

    // strategy context
    public class ChatClientContext
    {
        private readonly IEncrytor _encrytor;

        public ChatClientContext(IEncrytor encrytor)
        {
            _encrytor = encrytor;
        }

        public void Send(string message)
        {
            _encrytor.Encrypt(message);

            System.Console.WriteLine("Message has been sended");
        }
    }
}
