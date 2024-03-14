
using DemoApp;
using System;
using System.Collections.Generic;
using Inventory.Models;

/*
 * This is an app that demonstrates various usefule fuction in c-sharp
 */
internal class Program
{

    // Create a method that will return a product from a collection of products
    // Remove the unused GetProduct method
    private static Product? GetProduct(List<Product> products, int id)
    {
        foreach (Product product in products)
        {
            if (product.Id == id)
            {
                return product;
            }
        }
        return null;
    }

    /// <summary>
    /// The entry point of the program.
    /// </summary>
    /// <param name="args">The command-line arguments.</param>
    private static void Main(string[] args)
    {
        // create a new product
        Product product = new Product
        {
            Id = 1,
            Name = "Laptop",
            Price = 500.00m,
            CategoryId = 1
        };

        // display the product
        Console.WriteLine(product);

        // generate a welcome message
        string welcomeMessage = Util.GetWelcomeMessage();
        Console.WriteLine(welcomeMessage);
    }
}