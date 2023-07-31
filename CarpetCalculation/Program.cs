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
            Order order = new Order();
            do
            {
                order.Initialize();
                order.InputDetails();
                order.CalculateCost();

                Console.WriteLine($"Total Carpet Cost is {order.TotalCost}");

                Console.Write("Do you require another Calculation? (yes/no): ");
                order.IsRepeatOrder = Console.ReadLine().ToLower() == "yes";
            } while (order.IsRepeatOrder);
        }
    }
}
