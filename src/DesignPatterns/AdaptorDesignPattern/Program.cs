namespace AdaptorDesignPattern
{
    class Program
    {
        //Convert the interface of a class into another interface clients expect. Adapter lets classes work together that couldn't otherwise because of incompatible interfaces.
        static void Main(string[] args)
        {
            ICardReaderAdapter reader = new XBankCardReaderAdapter();
            var result = reader.ReadCardData();
            System.Console.WriteLine(result);
        }
    }
}
