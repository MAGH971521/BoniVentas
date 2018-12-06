using LiteDB;

namespace ShopModule.Classes.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public string Category { get; set; }

        public Unit Unit { get; set; }
        
        public string Brand { get; set; }
        public bool IsCompost { get; set; }

        public int Min { get; set; }
        public int Max { get; set; }
        public float Stock { get; set; }
        public float Cost { get; set; }
        public float Price { get; set; }
    }
}
