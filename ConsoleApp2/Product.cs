using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ConsoleApp2
{
    internal class Product
    {
        public Product(string productName, double price, double discount)
        {
            ProductName = productName;
            Price = price;
            Discount = discount;
        }

        public Product()
        {
        }

        public Product(string productName, double price)
        {
            ProductName = productName;
            Price = price;
            Discount = 0;
        }

        List<Product> productsList = new List<Product>();

        private string ProductName;
        private double Price;
        private double Discount;

        public string GetProductName()
        {
          
            Console.WriteLine("Enter productName: ");
            string productName =Console.ReadLine();
            Product product = productsList.Find(p => p.ProductName.Equals(productName, StringComparison.OrdinalIgnoreCase));
            if (product != null)
            {
                double importTax = product.Price * 0.1;
                Console.WriteLine( $"The proudct is : {product.ProductName}, Price: {product.Price}, Discount: {product.Discount}");
            }
            else
            {
                Console.WriteLine("Product not found.");
            }

            return ProductName;
        }

        public void SetProductName(string value)
        {
            Console.WriteLine("Enter the name of the product to change: ");
            string productName = Console.ReadLine();
            Product product = productsList.Find(p => p.ProductName.Equals(productName, StringComparison.OrdinalIgnoreCase));

            if (product != null)
            {
                product.ProductName = value;
                Console.WriteLine($"Product name has been changed to: {product.ProductName}");
            }
            else
            {
                Console.WriteLine("Cannot set product name as the product was not found.");
            }
        }


        public double GetPrice()
        {
            Console.WriteLine("Enter the product name to find its price: ");
            string productName = Console.ReadLine();
            Product product = productsList.Find(p => p.ProductName.Equals(productName, StringComparison.OrdinalIgnoreCase));

            if (product != null)
            {
                Console.WriteLine($"The price of {product.ProductName} is: {product.Price}");
                return product.Price;
            }
            else
            {
                Console.WriteLine("Product not found.");
                return -1;
            }
        }

        public void SetPrice(double value)
        {
            Console.WriteLine("Enter the name of the product to change the price: ");
            string productName = Console.ReadLine();
            Product product = productsList.Find(p => p.ProductName.Equals(productName, StringComparison.OrdinalIgnoreCase));

            if (product != null)
            {
                if (value > 0)
                {
                    product.Price = value;
                    Console.WriteLine($"Price for {product.ProductName} has been set to: {product.Price}");
                }
                else
                {
                    Console.WriteLine("Price must be greater than 0.");
                }
            }
            else
            {
                Console.WriteLine("Cannot set price as the product was not found.");
            }
        }

        public double GetDiscount()
        {
            Console.WriteLine("Enter the product name to find its discount: ");
            string productName = Console.ReadLine();
            Product product = productsList.Find(p => p.ProductName.Equals(productName, StringComparison.OrdinalIgnoreCase));

            if (product != null)
            {
                Console.WriteLine($"The discount for {product.ProductName} is: {product.Discount}%");
                return product.Discount;
            }
            else
            {
                Console.WriteLine("Product not found.");
                return -1;
            }
        }

        public void SetDiscount(double value)
        {
            Console.WriteLine("Enter the name of the product to change the discount: ");
            string productName = Console.ReadLine();
            Product product = productsList.Find(p => p.ProductName.Equals(productName, StringComparison.OrdinalIgnoreCase));

            if (product != null)
            {
                if (value >= 0)
                {
                    product.Discount = value;
                    Console.WriteLine($"Discount for {product.ProductName} has been set to: {product.Discount}%");
                }
                else
                {
                    Console.WriteLine("Discount must be 0 or greater.");
                }
            }
            else
            {
                Console.WriteLine("Cannot set discount as the product was not found.");
            }
        }

        public void Input()
        {
            Product product = new Product();  
            Console.WriteLine("Enter product name: ");
            product.ProductName = Console.ReadLine();
            Console.WriteLine("Enter price: ");
            product.Price = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter discount: ");
            product.Discount = Double.Parse(Console.ReadLine());
            productsList.Add(product);  
        }

        public void GetImportTax(string productName)
        {
            
            Product product = productsList.Find(p => p.ProductName.Equals(productName, StringComparison.OrdinalIgnoreCase));

            if (product != null)
            {
                double importTax = product.Price * 0.1; 
                Console.WriteLine($"The import tax for {product.ProductName} is: {importTax}");
            }
            else
            {
                Console.WriteLine("Product not found.");
            }
        }

        private double GetImportTax1(Product product)
        {
            return product.Price * 0.1;
        }

        public void Display()
        {
            foreach (var prod in productsList)
            {
                Console.WriteLine($"Name: {prod.ProductName}, Price: {prod.Price}, Discount: {prod.Discount}, Import Tax: {GetImportTax1(prod)}");
            }
        }
    }
}
