using LiteDB;

namespace ShopModule.Classes.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [BsonRef("Brand")]
        public Brand Brand { get; set; }

        [BsonRef("Category")]
        public Category Category { get; set; }

        [BsonRef("Provider")]
        public Provider1 Provider { get; set; }

        [BsonRef("Unit")]
        public Unit Unit { get; set; }


        public float Stock { get; set; }
        public float Cost { get; set; }
        public float Price { get; set; }
    }
}
