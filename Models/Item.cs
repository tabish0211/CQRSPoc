//public class Item
//{
//    public int Id { get; set; }
//    public required string? Name { get; set; }
//}

namespace CQRSWithMediatR.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
