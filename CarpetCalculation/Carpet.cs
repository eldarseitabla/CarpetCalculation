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
        public decimal SquareMetres { get; private set; }
        public decimal PricePerSqMetre { get; private set; }
        public decimal TotalCost { get; private set; }
        public bool IsExistingCustomer { get; private set; }
        public int DeliveryCharge { get; private set; }
        public string DeliveryZone { get; private set; }
        public bool IsRepeatOrder { get; set; }

        public void Initialize()
        {
            SquareMetres = 0;
            PricePerSqMetre = 0;
            TotalCost = 0;
            IsExistingCustomer = false;
            DeliveryCharge = 0;
            DeliveryZone = string.Empty;
        }

        public void InputDetails()
        {
            Console.Write("Please enter number of square metres: ");
            SquareMetres = decimal.Parse(Console.ReadLine());

            Console.Write("Please enter price per square metre: ");
            PricePerSqMetre = decimal.Parse(Console.ReadLine());

            Console.Write("Are you an existing customer? (yes/no): ");
            IsExistingCustomer = Console.ReadLine().ToLower() == "yes";

            Console.Write($"Please enter delivery zone ({ZONESD}/{ZONEND}): ");
            DeliveryZone = Console.ReadLine().ToUpper();
        }

        public void CalculateCost()
        {
            TotalCost = SquareMetres * PricePerSqMetre;

            if (IsExistingCustomer)
            {
                TotalCost *= DISCOUNT;
            }

            if (TotalCost <= THRESHOLD && DeliveryZone == ZONEND)
            {
                TotalCost += ZONENDCHARGE;
                DeliveryCharge = ZONENDCHARGE;
            }
            else if (TotalCost <= THRESHOLD && DeliveryZone == ZONESD)
            {
                TotalCost += ZONESDCHARGE;
                DeliveryCharge = ZONESDCHARGE;
            }

            TotalCost += DeliveryCharge;
        }
    }
}
