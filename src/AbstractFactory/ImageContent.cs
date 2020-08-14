namespace AbstractFactoryDesignPattern
{
    public class ImageContent : IContent
    {
        public object CreateContent()
        {
            return "Sample image content has been created.";
        }
    }
}
