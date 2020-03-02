namespace StrategyDesignPattern
{
    // concreate strategy type
    public class JpegCompressor : ICompressor
    {
        public void Compress(string fileName)
        {
            System.Console.WriteLine("Using jpeg compressor");
        }
    }
}
