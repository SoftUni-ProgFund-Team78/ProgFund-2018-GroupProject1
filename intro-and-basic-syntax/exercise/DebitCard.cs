// CONFIRMED from StanZash
using System;

namespace DebitCard
{
    class Program
    {
        static void Main(string[] args)
        {
            //Take cards numbers from the console
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());
            //Print formatted numbers
            Console.WriteLine($"{num1:d4} {num2:d4} {num3:d4} {num4:d4}");
        }
    }
}
