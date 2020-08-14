namespace CommandDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var databaseCommander = new DatabaseCommander();
            var userOperations = new UserOperations();

            var createUserCommand = new CreateUserCommand(userOperations);
            var updateUserCommand = new UpdateUserCommand(userOperations);
            var deleteUserCommand = new DeleteUserCommand(userOperations);

            databaseCommander.Execute(createUserCommand);
            databaseCommander.Execute(updateUserCommand);
            databaseCommander.Execute(deleteUserCommand);
        }
    }
}
