namespace CommandDesignPattern
{
    public class DeleteUserCommand : ICommand
    {
        private readonly UserOperations _userOperations;

        public DeleteUserCommand(UserOperations userOperations)
        {
            _userOperations = userOperations;
        }

        public void Execute()
        {
            _userOperations.DeleteUser();
        }
    }
}
