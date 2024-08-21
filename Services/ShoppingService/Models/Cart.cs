using ShoppingService.Models;

namespace ShoppingService.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public required List<Product> Items { get; set; }
    }
}
