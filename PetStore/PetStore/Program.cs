namespace PetStore
{
    public class Program
    {
        static void Main(string[] args)
        {
            ProductLogic productLogic = new ProductLogic();

            Console.WriteLine("Press 1 to add a dog leash product.");
            Console.WriteLine("Press 2 to view a dog leash.");
            Console.WriteLine("Press 8 to view all products. ");
            Console.WriteLine("Press 9 to view all IN STOCK products.");
            Console.WriteLine("Press 10 to view all OUT OF STOCK products.");
            Console.WriteLine("Type 'exit' to quit");

            string userInput = Console.ReadLine();

            while (!string.Equals(userInput.ToLower(), "exit"))
            {
                try
                {
                    // Could replace the if/else block with switch/case.
                    if (string.Equals(userInput, "1"))
                    {
                        DogLeash leash = new DogLeash();

                        Console.Write("Enter Product Name: ");
                        leash.Name = Console.ReadLine();

                        Console.Write("Enter Product Description: ");
                        leash.Description = Console.ReadLine();

                        Console.Write("Enter Product Material: ");
                        leash.Material = Console.ReadLine();

                        productLogic.AddProduct(leash);
                        Console.WriteLine(leash.ToString());
                    }
                    else if (string.Equals(userInput, "2"))
                    {
                        Console.Write("Enter Product Name: ");

                        DogLeash leash = productLogic.GetDogLeashByName(Console.ReadLine());

                        if (leash != null)
                        {
                            Console.WriteLine(); // Add some spacing between menu and output for clarity.

                            Console.WriteLine(leash.ToString());
                            Console.WriteLine($"Price = {leash.Price}, Discounted Price: {leash.Price.DiscountThisPrice()}");

                            Console.WriteLine(); // Add some spacing between menu and output for clarity.
                        }
                        else
                            Console.WriteLine("No product found with that name.");
                    }
                    else if (string.Equals(userInput, "8"))
                    {
                        Console.WriteLine(); // Add some spacing between menu and output for clarity.

                        List<Product> products = productLogic.GetAllProducts();

                        foreach (Product product in products)
                        {
                            Console.WriteLine(product.ToString());
                        }

                        Console.WriteLine(); // Add some spacing between menu and output for clarity.
                    }
                    else if (string.Equals(userInput, "9"))
                    {
                        List<string> products = productLogic.GetOnlyInStockProducts();

                        Console.WriteLine(); // Add some spacing between menu and output for clarity.
                        Console.WriteLine("Products in Stock:");

                        foreach (Product p in productLogic.GetAllProducts())
                        {
                            foreach (string prodName in products)
                            {
                                if (string.Equals(p.Name, prodName))
                                {
                                    Console.WriteLine(p.ToString());
                                }
                            }
                        }

                        Console.WriteLine(); // Add some spacing between menu and output for clarity.
                    }
                    else if (string.Equals(userInput, "10"))
                    {
                        List<string> products = productLogic.GetOutOfStockProducts();

                        Console.WriteLine(); // Add some spacing between menu and output for clarity.
                        Console.WriteLine("Products Out of Stock:");

                        foreach (Product p in productLogic.GetAllProducts())
                        {
                            foreach (string prodName in products)
                            {
                                if (string.Equals(p.Name, prodName))
                                {
                                    Console.WriteLine(p.ToString());
                                }
                            }
                        }

                        Console.WriteLine(); // Add some spacing between menu and output for clarity.
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("An exception was caught!");
#if DEBUG
                    Console.WriteLine(e.Message);
#endif
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey();
                }
                finally
                {
                    Console.WriteLine("Press 1 to add a dog leash product.");
                    Console.WriteLine("Press 2 to view a dog leash.");
                    Console.WriteLine("Press 8 to view all products. ");
                    Console.WriteLine("Press 9 to view all IN STOCK products.");
                    Console.WriteLine("Press 10 to view all OUT OF STOCK products.");
                    Console.WriteLine("Type 'exit' to quit");

                    userInput = Console.ReadLine();
                }
            }
        }
    }
}
