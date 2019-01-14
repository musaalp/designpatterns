namespace DecoratorDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var coffee = new SugarDecorator(new AromaDecorator(new MilkDecorator(new Coffee())));
            coffee.Cook();
        }
    }
}
