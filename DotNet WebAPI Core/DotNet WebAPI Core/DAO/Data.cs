using DotNet_WebAPI_Core.Models;

namespace DotNet_WebAPI_Core.DAO
{
    public class Data
    {
        public static List<Product> listProduct = new List<Product>()
        {
            new Product(Guid.NewGuid(), "Dell XPS", 28000),
            new Product(Guid.NewGuid(), "Macbook Air M2", 29000),
        };
    }
}
