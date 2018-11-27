using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopModule.Classes.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [BsonRef("brand")]
        public Brand Brand { get; set; }

        [BsonRef("category")]
        public Category Category { get; set; }

        [BsonRef("provider")]
        public Provider Provider { get; set; }

        [BsonRef("unit")]
        public Unit Unit { get; set; }


        public float Stock { get; set; }
        public float Cost { get; set; }
        public float Price { get; set; }
    }
}
