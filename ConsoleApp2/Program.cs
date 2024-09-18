using ConsoleApp2;

internal class Lab2
{
    static void Main(string[] args)
    {
        Product product = new Product();
        int choice;
        do
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Input");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Get Import tax");
            Console.WriteLine("4. Find Product by Name");
            Console.WriteLine("5. Change Product Name");
            Console.WriteLine("6. Find Product Price");
            Console.WriteLine("7. Change Product Price");
            Console.WriteLine("8. Find Product Discount");
            Console.WriteLine("9. Change Product Discount");
            Console.WriteLine("10. Exit");
            Console.WriteLine("Enter selection: ");

            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    product.Input();
                    break;
                case 2:
                    product.Display();
                    break;
                case 3:
                    Console.WriteLine("Enter the name for the product to find import tax: ");
                    string ProductName = Console.ReadLine();
                    product.GetImportTax(ProductName);
                    break;
                case 4:
                    product.GetProductName(); 
                    break;
                case 5:
                    Console.WriteLine("Enter the new name for the product: ");
                    string newProductName = Console.ReadLine();
                    product.SetProductName(newProductName);
                    break;
                case 6:
                    product.GetPrice();
                    break;
                case 7:
                    Console.WriteLine("Enter new price of the product: ");
                    product.SetPrice(Double.Parse(Console.ReadLine()));
                    break;
                case 8:
                    product.GetDiscount();
                    break;
                case 9:
                    Console.WriteLine("Enter new discount for the product: ");
                    product.SetDiscount(Double.Parse(Console.ReadLine()));
                    break;
                case 10:
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

        } while (choice != 10);
    }
}
