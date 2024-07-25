using System;

namespace PetStore
{
    public class Program
    {
        static void Main(string[] args)
        {
            string userInput = string.Empty;

            Console.WriteLine("Press 1 to add a product");
            Console.WriteLine("Type 'exit' to quit");

            userInput = Console.ReadLine();

            while (userInput.ToLower() != "exit")
            {
                DogLeash product = new DogLeash();

                Console.Write("Enter Product Name: ");
                product.Name = Console.ReadLine();

                Console.Write("Enter Product Description: ");
                product.Description = Console.ReadLine();

                Console.Write("Enter Product Material: ");
                product.Material = Console.ReadLine();

                Console.WriteLine($"Product Name: {product.Name}, Description: {product.Description}, Material: {product.Material}");

                Console.WriteLine("Press 1 to add a product. ");
                Console.WriteLine("Type 'exit' to quit");

                userInput = Console.ReadLine();
            }
        }
    }
}
