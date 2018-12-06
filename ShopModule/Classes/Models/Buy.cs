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
        public string Buyer { get; set; }
        public DateTime Log { get; set; }
        public string[] Products { get; set; }
        public int Units { get; set; }
        public float SubTotal { get; set; }
    }
}
