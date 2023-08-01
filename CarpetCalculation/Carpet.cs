using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carpet
{
    internal class Order
    {
        // Constants
        private const decimal DISCOUNT = 0.95M;
        private const int THRESHOLD = 200;
        private const int ZONENDCHARGE = 5;
        private const int ZONESDCHARGE = 10;
        private const string ZONESD = "SD";
        private const string ZONEND = "ND";

        // Properties
        // { get; private set; } This is a common pattern when you want to
        // make a property read-only to the outside world but still be able to
        // modify it within the class.
        public decimal squareMetres { get; private set; }
        public decimal pricePerSqMetre { get; private set; }
        public decimal totalCost { get; private set; }
        public bool isExistingCustomer { get; private set; }
        public int deliveryCharge { get; private set; }
        public string deliveryZone { get; private set; }
        public bool IsRepeatOrder { get; set; }

        public void Initialize()
        {
            squareMetres = 0;
            pricePerSqMetre = 0;
            totalCost = 0;
            isExistingCustomer = false;
            deliveryCharge = 0;
            deliveryZone = string.Empty;
        }

        public void InputDetails()
        {
            Console.Write("Please enter number of square metres: ");
            squareMetres = decimal.Parse(Console.ReadLine());

            Console.Write("Please enter price per square metre: ");
            pricePerSqMetre = decimal.Parse(Console.ReadLine());

            Console.Write("Are you an existing customer? (yes/no): ");
            isExistingCustomer = Console.ReadLine().ToLower() == "yes";

            Console.Write($"Please enter delivery zone ({ZONESD}/{ZONEND}): ");
            deliveryZone = Console.ReadLine().ToUpper();
        }

        public void CalculateCost()
        {
            totalCost = squareMetres * pricePerSqMetre;

            if (isExistingCustomer)
            {
                totalCost *= DISCOUNT;
            }

            if (totalCost <= THRESHOLD && deliveryZone == ZONEND)
            {
                totalCost += ZONENDCHARGE;
                deliveryCharge = ZONENDCHARGE;
            }
            else if (totalCost <= THRESHOLD && deliveryZone == ZONESD)
            {
                totalCost += ZONESDCHARGE;
                deliveryCharge = ZONESDCHARGE;
            }

            totalCost += deliveryCharge;
        }
    }
}
