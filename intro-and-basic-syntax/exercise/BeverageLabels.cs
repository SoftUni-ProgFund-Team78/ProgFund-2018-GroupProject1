// CONFIRMED from StanZash
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.BeverageLabels
{
    class Program
    {
        static void Main(string[] args)
        {
            // Take product's name
            string name = Console.ReadLine();
            // Take product's parameters
            int volume = int.Parse(Console.ReadLine());
            int energy = int.Parse(Console.ReadLine());
            int sugar = int.Parse(Console.ReadLine());
            //Calculate energy and sugar in product
            double energyContent = volume / 100.0 * energy;
            double sugarContent = volume / 100.0 * sugar;
            // Print results
            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{energyContent}kcal, {sugarContent}g sugars");


        }
    }
}
