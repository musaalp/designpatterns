namespace CommandDesignPattern
{
    public class DatabaseCommander
    {
        public void Execute(params ICommand[] commands)
        {
            foreach (var command in commands)
            {
                command.Execute();
            }
        }
    }
}
