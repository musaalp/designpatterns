namespace StrategyDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileName = "sampleImaeg.jpeg";

            var strategyContext = new ImageStore();

            strategyContext.Store(fileName, new JpegCompressor(), new BlackAndWhiteFilter());

            strategyContext.Store(fileName, new BmpCompressor(), new BrightnessFilter());
        }
    }
}
