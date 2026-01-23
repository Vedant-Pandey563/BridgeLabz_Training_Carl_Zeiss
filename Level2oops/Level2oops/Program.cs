using System;
namespace Level2oops
{
    class ProductInventory
    {
        public string productName;
        public double price;
        public static int totalProducts;//static variable

        public ProductInventory(string productName,double price)
        {
            this.productName = productName;
            this.price = price;
            totalProducts++;//incrementing static variable
        }
        
        public void DisplayProductDetails()
        {
            Console.WriteLine("Product Name : " +productName);
            Console.WriteLine("Price : " +price);
        }
        public static void DisplayTotalProducts()
        {
            Console.WriteLine("Total Products in Inventory : " +totalProducts);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductInventory prod1 = new ProductInventory("pen", 13);
            ProductInventory prod2 = new ProductInventory("pencil", 10);
            ProductInventory prod3 = new ProductInventory("book", 34.5);

            prod1.DisplayProductDetails();
            prod2.DisplayProductDetails();
            prod3.DisplayProductDetails();

            ProductInventory.DisplayTotalProducts();

        }
    }
}
