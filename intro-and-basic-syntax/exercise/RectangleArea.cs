﻿using System;
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
            // We take the ractangle wigth and height in two lines, as floating point numbers
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            //We print the resulting ractangle area following the formula width * height
            Console.WriteLine("{0:0.00}", width * height);
        }
    }
}
