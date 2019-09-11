namespace ObserverDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var redFleetZone = new RedFleet("Soldier get ready!");

            redFleetZone.Attach(new PlatoonOperator("Platoon Operator 1"));
            redFleetZone.Attach(new PlatoonOperator("Platoon Operator 2"));

            redFleetZone.Information = "Take the position!";
            System.Console.WriteLine();

            redFleetZone.Attach(new TankOperator("Tank Operator 1"));
            redFleetZone.Attach(new TankOperator("Tank Operator 2"));
            redFleetZone.Attach(new TankOperator("Tank Operator 3"));

            redFleetZone.Information = "Keep waiting!";
            System.Console.WriteLine();

            redFleetZone.Information = "Fire!!!";
        }
    }
}
