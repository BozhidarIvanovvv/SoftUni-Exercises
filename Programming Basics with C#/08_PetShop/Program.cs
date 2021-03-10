using System;

namespace _08_PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double dogsCount = double.Parse(Console.ReadLine());
            double otherAnimalsCount = double.Parse(Console.ReadLine());

            double dogFoodPrice = 2.50;
            double otherAnimalsPrice = 4.00;

            double sum = 0;
            sum += (dogFoodPrice * dogsCount) + (otherAnimalsPrice * otherAnimalsCount);

            Console.WriteLine($"{sum} lv.");
        }
    }
}
