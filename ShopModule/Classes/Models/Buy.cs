using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopModule.Classes.Models
{
    public class Buy
    {
        public int Id { get; set; }

        [BsonRef("buyer")]
        public User Buyer { get; set; }
        [BsonRef("log")]
        public DateTime Log { get; set; }
        [BsonRef("description")]
        public BuyDescription[] Description { get; set; }
    }

    public class BuyDescription
    {
        [BsonRef("product")]
        public Product Product { get; set; }
        public int Units { get; set; }
        public float SubTotal { get; set; }
    }
}
