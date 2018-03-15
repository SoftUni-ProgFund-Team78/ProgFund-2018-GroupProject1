using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace characters
{
    class Program
    {
        static void Main(string[] args)
        {
            // Take the character's name from the console as string
            string name = Console.ReadLine();

            // In th next 4 lines, we take values from the console for character stats, all as integer numbers
            int currentHealth = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());

            // In the next three lines we print the character's name and his stats in an easy to understand format
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Health: |{0}{1}|", new string('|', currentHealth), new string('.', maxHealth - currentHealth));
            Console.WriteLine("Energy: |{0}{1}|", new string('|', currentEnergy), new string('.', maxEnergy - currentEnergy));

        }
    }
}
