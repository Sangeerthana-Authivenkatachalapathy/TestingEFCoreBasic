using EFCoreBasic.Data;
using Microsoft.EntityFrameworkCore;

namespace EFCoreBasic
{
    public class Program
    {
        static void Main(string[] args)
        {
            SaveData();
            FetchData();
            Console.WriteLine("Hello, World! TestingEFCoreBaasics");
        }
        static void SaveData()
        {
            using (var dbContext = new AppDbContext())

            {

                var newProduct = new Product { Name = "New Product", price = 9 };

                dbContext.Products.Add(newProduct);

                dbContext.SaveChanges();

            }
        }
        static void FetchData()
        {
            using (var dbContext = new AppDbContext())

            {

                var products = dbContext.Products.ToList(); // Retrieve all products 



                // Display the products 

                foreach (var product in products)

                {

                    Console.WriteLine($"Product ID: {product.ProductId}, Name: {product.Name}, Price: {product.Price}");

                }

            }
        }
    }
}
