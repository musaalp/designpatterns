using System;

namespace FactoryMethodDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var documents = new Document[2];

            documents[0] = new Resume();
            documents[1] = new Report();

            foreach (var document in documents)
            {
                Console.WriteLine($"-- {document.GetType().Name} --");

                foreach (var page in document.Pages)
                {
                    Console.WriteLine($" { page.GetType().Name}");
                }
                Console.WriteLine();
            }
        }
    }
}
