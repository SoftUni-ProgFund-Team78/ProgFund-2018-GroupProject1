// CONFIRMED from StanZash
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rectangular
{
    class Program
    {
        static void Main(string[] args)
        {
            // Take width and height of the rectangle from the console
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            //Print rectangle area
            Console.WriteLine("{0:0.00}", width * height);
        }
    }
}
