using System;

namespace PetStore
{
    public class Program
    {
        static void Main(string[] args)
        {
            ProductLogic productLogic = new ProductLogic();

            Console.WriteLine("Press 1 to add a product");
            Console.WriteLine("Press 8 to view all products. ");
            Console.WriteLine("Type 'exit' to quit");

            string userInput = Console.ReadLine();

            while (userInput.ToLower() != "exit")
            {
                if (string.Equals(userInput, "1"))
                {
                    try
                    {
                        DogLeash product = new DogLeash();

                        Console.Write("Enter Product Name: ");
                        product.Name = Console.ReadLine();

                        Console.Write("Enter Product Description: ");
                        product.Description = Console.ReadLine();

                        Console.Write("Enter Product Material: ");
                        product.Material = Console.ReadLine();

                        productLogic.AddProduct(product);
                        Console.WriteLine(product.ToString());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("An exception was caught!");
                        Console.WriteLine(e.Message);
                        Console.WriteLine("Press any key to exit.");
                        Console.ReadKey();
                    }
                }
                else if (string.Equals(userInput, "8"))
                {
                    List<Product> products = productLogic.GetAllProducts();

                    foreach( Product product in products)
                    {
                        Console.WriteLine(product.ToString());
                    }
                }
                Console.WriteLine("Press 1 to add a product. ");
                Console.WriteLine("Press 8 to view all products. ");
                Console.WriteLine("Type 'exit' to quit");

                userInput = Console.ReadLine();
            }
        }
    }
}
