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
            Console.WriteLine("Type 'exit' to quit");

            string userInput = Console.ReadLine();

            while (!string.Equals(userInput.ToLower(), "exit"))
            {
                try
                {
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
                    //else if (string.Equals(userInput, "2"))
                    //{
                    //    CatFood food = new CatFood();

                    //    Console.Write("Enter Product Name: ");
                    //    food.Name = Console.ReadLine();

                    //    Console.Write("Enter Product Description: ");
                    //    food.Description = Console.ReadLine();

                    //    Console.Write("Enter Product Weight(Lbs): ");

                    //    double weight = 0;
                    //    food.WeightPounds = double.TryParse(Console.ReadLine(), out weight) ? weight : 1;

                    //    Console.Write("Kitten Food? y / n: ");
                    //    string kfood = Console.ReadLine();

                    //    food.IsKittenFood = string.Equals( kfood, "y") ? true : false;

                    //    productLogic.AddProduct(food);
                    //    Console.WriteLine(food.ToString());
                    //}
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
                    Console.WriteLine("Type 'exit' to quit");

                    userInput = Console.ReadLine();
                }
            }
        }
    }
}
