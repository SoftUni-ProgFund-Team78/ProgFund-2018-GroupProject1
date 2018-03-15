// CONFIRMED from StanZash
using System;

namespace DebitCard
{
    class Program
    {
        static void Main(string[] args)
        {
            //Take cards numbers from the console
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());
            int number4 = int.Parse(Console.ReadLine());
            //Print formatted numbers
            Console.WriteLine($"{number1:d4} {number2:d4} {number3:d4} {number4:d4}");
        }
    }
}
