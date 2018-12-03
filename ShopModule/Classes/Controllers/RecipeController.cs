using LiteDB;
using ShopModule.Classes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopModule.Classes.Controllers
{
    class RecipeController
    {
        public void Add(Recipe  recipe)
        {
            using (LiteDatabase db = new LiteDatabase("my.db"))
            {
                var col = db.GetCollection<Recipe>("brands");
                col.Insert(recipe);
            }
        }

        public void AddItems(Recipe[] recipes)
        {
            using (LiteDatabase db = new LiteDatabase("my.db"))
            {
                var col = db.GetCollection<Recipe>("brands");
                col.Insert(recipes);
            }
        }

        public void Delete(Recipe recipe)
        {
            using (LiteDatabase db = new LiteDatabase("my.db"))
            {
                var col = db.GetCollection<Recipe>("brands");
                col.Delete(recipe.Id);
            }
        }

        public List<Recipe> Select(Query query)
        {
            using (LiteDatabase db = new LiteDatabase("my.db"))
            {
                var col = db.GetCollection<Recipe>("brands");
                return col.Find(query).ToList();
            }
        }

        public void Update(Recipe recipe)
        {
            using (LiteDatabase db = new LiteDatabase("my.db"))
            {
                var col = db.GetCollection<Recipe>("brands");
                col.Update(recipe);
            }
        }
    }
}
