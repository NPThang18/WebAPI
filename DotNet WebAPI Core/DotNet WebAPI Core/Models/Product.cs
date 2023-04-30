namespace DotNet_WebAPI_Core.Models
{
    public class Product
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="key"></param>
        /// <param name="name"></param>
        /// <param name="price"></param>
        public Product(Guid key, string name, int price)
        {
            this.Key = key;
            this.Name = name;
            this.Price = price;
        }
        /// <summary>
        /// Product key
        /// </summary>
        public Guid Key { get; set; }
        /// <summary>
        /// Product name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Product Price
        /// </summary>
        public int Price { get; set; }
    }
}
