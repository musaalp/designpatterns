using System;

namespace CommandDesignPattern
{
    public class UserOperations
    {
        public void CreateUser() => Console.WriteLine("User created");
        public void UpdateUser() => Console.WriteLine("User updated");
        public void DeleteUser() => Console.WriteLine("User deleted");
    }
}
