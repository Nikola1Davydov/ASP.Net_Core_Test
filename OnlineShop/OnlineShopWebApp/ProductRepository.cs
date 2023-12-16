using OnlineShopWebApp.Models;
using System.Text.Json;
using System.Linq;

namespace OnlineShopWebApp
{
    public class ProductRepository
    {
        private static Product[] ProductsFromJson()
        {
            string fileName = "MeineWarenFuerShop.json";
            string jsonString = System.IO.File.ReadAllText(fileName);
            Product[] products = JsonSerializer.Deserialize<Product[]>(jsonString);
            return products;
        }
        private static List<Product> products = new List<Product>(ProductsFromJson());

        public List<Product> GetAll()
        {
            return products;
        }

        public Product TryGetById(int id)
        {
            return products.FirstOrDefault(p => p.Id == id);
            //foreach (var product in products)
            //{
            //    if (product.Id == id)
            //    {
            //        return product;
            //    }
            //}
            //return null;
        }
    }
}
