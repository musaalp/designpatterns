namespace StrategyDesignPattern
{
    // concreate strategy type
    public class BmpCompressor : ICompressor
    {
        public void Compress(string fileName)
        {
            System.Console.WriteLine("Using bmp compressor");
        }
    }
}
