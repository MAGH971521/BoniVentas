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
        
        public string Seller { get; set; }
        
        public DateTime Log { get; set; }
        
        public string Product { get; set; }
        public int Units { get; set; }
    }
}
