using ProductInventory.Model;

namespace ProductInventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------Product Inventory----------");
            // Create a Product object and initialize its properties
            Product IPhone = new Product();
            IPhone.ProductId = 1;
            IPhone.Name = "IPhone16";
            IPhone.StockQuantity = 0;
            IPhone.Price = 80000;

            // Display  product details
            Console.WriteLine(IPhone.ToString());

            // calling adding stock function and then Displaying product details
            IPhone.AddStock();
            Console.WriteLine(IPhone.ToString());

            // calling sell  function  and then Displaying product details
            IPhone.Sell();
            Console.WriteLine(IPhone.ToString());


            Console.ReadKey();
        }
    }
}
