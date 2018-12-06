using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopModule.Classes.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        
        public string Product { get; set; }
        public string Ingredient { get; set; }
        public float Units { get; set; }
    }
}
