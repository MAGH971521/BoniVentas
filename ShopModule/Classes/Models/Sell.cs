using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopModule.Classes.Models
{
    public class Sell
    {
        public int Id { get; set; }

        [BsonRef("seller")]
        public User Seller { get; set; }

        [BsonRef("log")]
        public DateTime Log { get; set; }

        [BsonRef("description")]
        public SellDescription Description { get; set; }
    }

    public class SellDescription
    {
        [BsonRef("product")]
        public Product Product { get; set; }
        public int Units { get; set; }
        public float SubTotal { get; set; }
    }
}
