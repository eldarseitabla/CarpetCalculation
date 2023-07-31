using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Carpet;

namespace CarpetCalculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order carpetOrder = new Order();
            do
            {
                carpetOrder.Initialize();
                carpetOrder.InputDetails();
                carpetOrder.CalculateCost();

                Console.WriteLine($"Total Carpet Cost is {carpetOrder.TotalCost}");

                Console.Write("Do you require another Calculation? (yes/no): ");
                carpetOrder.IsRepeatOrder = Console.ReadLine().ToLower() == "yes";
            } while (carpetOrder.IsRepeatOrder);
        }
    }
}
