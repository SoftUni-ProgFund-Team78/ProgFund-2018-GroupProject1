using System;

namespace MilestoKM
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read number of miles from the Console
            double miles = double.Parse(Console.ReadLine());
            //One mile is equal to 1.60934km
            double km = miles * 1.60934;
            //Print the result formatted to the second digit using f2 or 0.00
            Console.WriteLine($"{km:f2}");
        }
    }
}
