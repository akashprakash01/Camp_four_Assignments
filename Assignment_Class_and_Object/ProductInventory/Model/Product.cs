using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductInventory.Model
{
    public class Product
    {
        // these fields store the actual data of the product
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
                // validating the product id 
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
                // validating the product name
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
                // product price should be greater than zero
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
            // adding stock for product
            stockQuantity++;
            Console.WriteLine($"Stock updated for the product {name}");
            return true;
        }

        public bool Sell()
        {
            //if condition to check the product stock is available
            if (stockQuantity <= 0)
            {
                Console.WriteLine("Product Out of Stock");
                return false;
            }

            else 
            {
                // if stocck available reduce one stock from the existing stock
                stockQuantity--;
                Console.WriteLine($"One stock has been sold for the product {name}");
                return true;
            }      
        }

        //Overriding ToString() to display Product details
        public override string? ToString()
        {
            return $"ProductId: {ProductId}, Product Name: {name}, Quantity: {stockQuantity} Price: {price}";
        }
    }
}
