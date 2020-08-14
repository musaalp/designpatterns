namespace ObserverDesignPattern
{
    /// <summary>
    /// concreate observer
    /// </summary>
    public class TankOperator : IOperator
    {
        public string Name { get; set; }

        public TankOperator(string name)
        {
            Name = name;
        }

        public void Update(HeadQuarters headQuarters)
        {
            System.Console.WriteLine($"[{ Name}], {headQuarters.Information}");
        }
    }
}
