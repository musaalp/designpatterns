using Strategy.AnotherSample;

namespace StrategyDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //sample 1
            var client = new ChatClientContext(new AESEncryptor());
            client.Send("Hello world");

            //sample 2
            var fileName = "sampleImaeg.jpeg";

            var strategyContext = new ImageStore();

            strategyContext.Store(fileName, new JpegCompressor(), new BlackAndWhiteFilter());

            strategyContext.Store(fileName, new BmpCompressor(), new BrightnessFilter());
        }
    }
}
