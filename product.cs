namespace Inventory.Models
{
    public class Product
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }

        // generate an override method for ToString which returns the product name and price
        public override string ToString()
        {
            return $"Product: {Name}, Price: {Price}";
        }
    }
}
