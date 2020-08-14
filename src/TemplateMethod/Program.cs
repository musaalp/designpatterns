using System;

namespace TemplateMethodDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var task = new TransferMoneyTask();

            task.Execute();
        }
    }
}
