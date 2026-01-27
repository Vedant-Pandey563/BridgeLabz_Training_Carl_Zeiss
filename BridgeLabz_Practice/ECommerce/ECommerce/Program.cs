namespace ECommerce
{
    public class Product
    {
        public int ProductID { get; }
        public string ProductName { get; }
        public double Price { get; }

        public Product (int productID,string name, double price )
        {
            this.ProductID = productID;
            this.ProductName = name;
            this.Price = price;
        }
    }

    public class Order

    {
        public int OrderID { get; }
        private List<Product> products;

        public Order(int orderID)
        {
            this.OrderID = orderID;
            this.products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public double GetTotal()
        {
            double total = 0;
            foreach (var product in products)
            {
                total += product.Price;
            }
            return total;
        }

        public void ShowOrderDetails()
        {
            Console.WriteLine($"Order ID: {OrderID}");
            foreach (var product in products)
            {
                Console.WriteLine($"- {product.ProductName} : {product.Price}");
            }
            Console.WriteLine($"Total Order Value : {GetTotal()}");
        }

    }

    public class Customer
    {
        public string Name { get; }
        private List<Order> orders;
        private static int orderCounter = 1;

        public Customer(string name)
        {
            this.orders = new List<Order>();
            this.Name = name;
        }

        public Order PlaceOrder ()
        {
            Order order = new Order(orderCounter++);
            orders.Add(order);
            return order;
        }

        public void ViewOrders()
        {
            Console.WriteLine($"Orders placed by {Name}");
            foreach (var order in orders)
            {
                order.ShowOrderDetails();
                Console.WriteLine();
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Product pen = new Product(1, "Pen", 32);
            Product pencil = new Product(2, "Pencil", 11);
            Product compass = new Product(3, "Compass", 67);

            Customer A = new Customer("A");
           
            Order order1 = A.PlaceOrder();

            order1.AddProduct(pen);
            order1.AddProduct(pencil);

            Order order2 = A.PlaceOrder();
            order2.AddProduct(compass);

            A.ViewOrders();
        }
    }
}
