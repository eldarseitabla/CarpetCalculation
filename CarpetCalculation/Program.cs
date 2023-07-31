using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpetCalculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double noOfSqMetres, pricePerSqMetre, carpetCost = 0;

            const double DISCOUNT = 0.95;

            bool existingCust = false;

            Console.WriteLine("Please enter no of square metres?");

            // Assignment statement
            // Achieved type compatability
            noOfSqMetres = double.Parse(Console.ReadLine());

        }
    }
}
