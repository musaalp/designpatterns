namespace ObserverDesignPattern
{
    /// <summary>
    /// concreate observer
    /// </summary>
    public class PlatoonOperator : IOperator
    {
        public string Name { get; set; }

        public PlatoonOperator(string name)
        {
            Name = name;
        }

        public void Update(HeadQuarters headQuarters)
        {
            System.Console.WriteLine($"[{ Name}], {headQuarters.Information}");
        }
    }
}
