namespace El1teSpr1ntTrack.Core.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public string ImageUrl { get; set; }
        public string Category { get; set; }

        public Product(int id, string name, string description, decimal price, int stockQuantity, string imageUrl, string category)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
            StockQuantity = stockQuantity;
            ImageUrl = imageUrl;
            Category = category;
        }
    }


}
