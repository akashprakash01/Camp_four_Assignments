using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductInventory.Model
{
    public class Product
    {
        // these fields sotre the actual data of the product
        private int productId;
        private string name;
        private double price;
        private int stockQuantity;


        //constructor
        public Product()
        {
            
        }
        //parameterized constructor
        public Product(int _productId, string _name, double _price, int _stockQuantity)
        {
            this.productId = _productId;
            this.name = _name;
            this.price = _price;
            this.stockQuantity = _stockQuantity;
        }

        //Encapsulation
        public int ProductId 
            {
            get
            { return productId; }
            set
            {
                if (value < 0)
                    Console.WriteLine("Product Id should be positive");
                else
                    productId = value;
            }
            }
        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    Console.WriteLine("Product Name should not be empty");
                else
                    name = value;
            }
        }
        public double Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                    Console.WriteLine("Price must be greater than 0");
                else
                    price = value;
            }
        }

        public int StockQuantity
        {
            get { return stockQuantity; }
            set { stockQuantity = value; }
        }

        public bool AddStock()
        {
            stockQuantity++;
            Console.WriteLine($"Stock updated for the product {name}");
            return true;
        }

        public bool Sell()
        {
            if (stockQuantity <= 0)
            {
                Console.WriteLine("Product Out of Stock");
                return false;
            }

            else 
            {
                stockQuantity--;
                Console.WriteLine($"One stock has been sold for the product {name}");
                return true;
            }      
        }

        public override string? ToString()
        {
            return $"ProductId: {ProductId}, Product Name: {name}, Quantity: {stockQuantity} Price: {price}";
        }
    }
}
