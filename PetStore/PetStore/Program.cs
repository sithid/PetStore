using System;
using System.ComponentModel.Design;

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
                            Console.WriteLine(leash.ToString());
                        else
                            Console.WriteLine("No product found with that name.");
                    }
                    else if (string.Equals(userInput, "8"))
                    {
                        List<Product> products = productLogic.GetAllProducts();

                        foreach (Product product in products)
                        {
                            Console.WriteLine(product.ToString());
                        }
                    }
                    else if (string.Equals(userInput, "9"))
                    {
                        List<string> products = productLogic.GetOnlyInStockProducts();

                        Console.WriteLine(); // Add some spacing between menu and output for clarity.
                        Console.WriteLine("Products in Stock:");

                        foreach (Product p in productLogic.GetAllProducts())
                        {
                            // I choose to do the output like this to gain access to all properties for a more verbose output.
                            // I could have simply looped the return of GetOnlyInStockProducts and printed the string but I wanted
                            // all of the additional information displayed with ToString.  For a customer, price is also as important as the name.
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
                            // I choose to do the output like this to gain access to all properties for a more verbose output.
                            // I could have simply looped the return of GetOnlyInStockProducts and printed the string but I wanted
                            // all of the additional information displayed with ToString.  For a customer, price is also as important as the name.
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
                    Console.WriteLine(e.Message);
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
