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

        [BsonRef("product")]
        public Product Product { get; set; }

        [BsonRef("description")]
        public RecipeDescription[] Description { get; set; }
    }

    public class RecipeDescription
    {
        [BsonRef("product")]
        public Product Product { get; set; }
        public float Units { get; set; }
    }
}
