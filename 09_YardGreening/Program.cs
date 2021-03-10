using System;
using System.Runtime.CompilerServices;

namespace _09_YardGreening
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceForOneMeter = 7.61;

            double meters = double.Parse(Console.ReadLine());

            double sum = meters * priceForOneMeter;

            double discount = sum * 0.18;

            double finalSum = sum - discount;

            Console.WriteLine($"The final price is: {finalSum} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
        }
    }
}
