using System;

namespace _06_ConcatenateData
{
    class Program
    {
        static void Main(string[] args)
        {
            string fisrtName = Console.ReadLine();
            string lastName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string town = Console.ReadLine();
            Console.WriteLine($"You are {fisrtName} {lastName}, a {age}-years old person from {town}.");
        }
    }
}
