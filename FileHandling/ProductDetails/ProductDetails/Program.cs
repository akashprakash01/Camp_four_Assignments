using System;
using System.Collections.Generic;
using System.IO;

namespace ProductDetails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Collection to store product details in CSV format
            List<string> products = new List<string>();

            Console.WriteLine("--- Store Product Details ---");

            // Loop to read details of 10 products
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"\nEnter details for Product {i}");

                int productId;
                string productName;
                int productPrice;
                int productQuantity;

                // Read Product ID
                while (true)
                {
                    Console.Write("Enter Product Id: ");
                    if (int.TryParse(Console.ReadLine(), out productId))
                        break;
                    Console.WriteLine("Invalid Product Id");
                }

                // Read Product Name
                while (true)
                {
                    Console.Write("Enter Product Name: ");
                    productName = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(productName))
                        break;
                    Console.WriteLine("Invalid Product Name");
                }

                // Read Product Price
                while (true)
                {
                    Console.Write("Enter Product Price: ");
                    if (int.TryParse(Console.ReadLine(), out productPrice))
                        break;
                    Console.WriteLine("Invalid Product Price");
                }

                // Read Product Quantity
                while (true)
                {
                    Console.Write("Enter Product Quantity: ");
                    if (int.TryParse(Console.ReadLine(), out productQuantity))
                        break;
                    Console.WriteLine("Invalid Product Quantity");
                }

                // Creating CSV line and adding to collection
                string csvLine = $"{productId},{productName},{productPrice},{productQuantity}";
                products.Add(csvLine);
            }

            // File path
            string filePath = "product.csv";

            // Writing all product details to CSV file
            File.WriteAllLines(filePath, products);

            Console.WriteLine("\nProduct details successfully saved to product.csv");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
