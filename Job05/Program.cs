// Paul Stefanik, September 9th, 2014, Job #05
// This program is used to find the cost of grass, using the numeric variables length and width

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Job05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            // Declare Variables
            double costpersm;                               // Cost per square metre
            double length;                                  // Length
            double width;                                   // Width
            double area;                                    // Area
            double totalcost;                               // Total cost

            // Assign Values
            costpersm = 12.99;                              // Cost per square metre
            length = 20;                                    // Length
            width = 16;                                     // Width
            area = 320;                                     // Area

            // Calculate total area
            area = length * width;

            // Calculate total cost
            totalcost = length + width + area;

            // Output Information*
            Console.WriteLine("The total cost of the grass: " + totalcost);
            Console.WriteLine();
        }
    }
}
