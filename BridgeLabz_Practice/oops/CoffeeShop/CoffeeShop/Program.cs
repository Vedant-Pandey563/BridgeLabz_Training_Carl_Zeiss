using System;
namespace CoffeeShop
{

    class CoffeeShop
    {
        public string CustomerName { get; set; }
        public string CoffeeType { get; set; }
        public int Quantity { get; set; }
        public double TotalPrice { get; private set; }

        public CoffeeShop()
        {
            CustomerName = "Guest";
            CoffeeType = "Regular";
            Quantity = 1;
            TotalPrice = CalculatePrice();
        }

        public CoffeeShop(string customerName, string coffeeType, int quantity)
        {
            CustomerName = customerName;
            CoffeeType = coffeeType;
            Quantity = quantity;
            TotalPrice = CalculatePrice();
        }

        public CoffeeShop(CoffeeShop previousOrder)
        {
            CustomerName = previousOrder.CustomerName;
            CoffeeType = previousOrder.CoffeeType;
            Quantity = previousOrder.Quantity;
            TotalPrice = previousOrder.TotalPrice;
        }

        private double CalculatePrice()
        {
            double pricePerCup = CoffeeType.ToLower() switch
            {
                "latte" => 5.0,
                "espresso" => 4.0,
                "cappuccino" => 4.5,
                _ => 3.0
            };
            return pricePerCup * Quantity;
        }


        public void DisplayOrder()
        {
            Console.WriteLine($"Customer: {CustomerName}");
            Console.WriteLine($"Coffee Type: {CoffeeType}");
            Console.WriteLine($"Quantity: {Quantity}");
            Console.WriteLine($"Total Price: ${TotalPrice}");
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                CoffeeShop order1 = new CoffeeShop();
                Console.WriteLine("Order 1:");
                order1.DisplayOrder();

                CoffeeShop order2 = new CoffeeShop("Alice", "Latte", 3);
                Console.WriteLine("\nOrder 2:");
                order2.DisplayOrder();

                CoffeeShop order3 = new CoffeeShop(order2);
                Console.WriteLine("\nOrder 3 (Copy of Order 2):");
                order3.DisplayOrder();

            }
        }
    }
}
