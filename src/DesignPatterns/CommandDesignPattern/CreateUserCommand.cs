namespace CommandDesignPattern
{
    public class CreateUserCommand : ICommand
    {
        private readonly UserOperations _userOperations;

        public CreateUserCommand(UserOperations userOperations)
        {
            _userOperations = userOperations;
        }

        public void Execute()
        {
            _userOperations.CreateUser();
        }
    }
}
