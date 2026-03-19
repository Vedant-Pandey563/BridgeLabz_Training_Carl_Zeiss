namespace Restuarant
{
    public class Restuarant
    {
        public string name;
        private string locaton;
        private string[] foodItems;

        public Restuarant(string name, string locaton, string[] foodItems)
        {
            this.name = name;
            this.locaton = locaton;
            this.foodItems = foodItems;
        }
        public void DisplayDetails()
        {
            Console.WriteLine($"Restuarant Name: {name}");
            Console.WriteLine($"Location: {locaton}");
            Console.WriteLine("Food Items:");
            foreach (string item in foodItems)
            {
                Console.WriteLine($"- {item}");
            }
        }

        public bool isFoodAvailable(string foodItem)
        {
            foreach (string item in foodItems)
            {
                if (item.Equals(foodItem, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }

    }
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] foodItems1 = { "Pizza", "Burger", "Pasta", "Salad" };
            string[] foodItems2 = { "Sushi", "Ramen", "Tempura", "Udon" };

            Restuarant restuarant1 = new Restuarant("Italian Delight", "New York", foodItems1);
            Restuarant restuarant2 = new Restuarant("Tokyo Treats", "Tokyo", foodItems2);

            Console.WriteLine("Resturant 1");
            restuarant1.DisplayDetails();
            Console.WriteLine("\nResturant 2");
            restuarant2.DisplayDetails();

            Console.WriteLine("\nChecking Food Availability:");
            Console.WriteLine($"Is 'Pasta' available in {restuarant1.name}? " + restuarant1.isFoodAvailable("Pasta"));
            Console.WriteLine($"Is 'Naan' available in {restuarant2.name}? " + restuarant2.isFoodAvailable("Naan"));
        }
    }
}
