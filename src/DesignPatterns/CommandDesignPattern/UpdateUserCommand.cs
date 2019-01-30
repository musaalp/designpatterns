namespace CommandDesignPattern
{
    public class UpdateUserCommand : ICommand
    {
        private readonly UserOperations _userOperations;

        public UpdateUserCommand(UserOperations userOperations)
        {
            _userOperations = userOperations;
        }

        public void Execute()
        {
            _userOperations.UpdateUser();
        }
    }
}
