namespace CommandDesignPattern
{
    public class DatabaseCommander
    {
        public void Execute(ICommand command)
        {
            command.Execute();
        }
    }
}
