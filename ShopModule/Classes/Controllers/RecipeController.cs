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
                var col = db.GetCollection<Recipe>("recipes");
                col.Insert(recipe);
            }
        }

        public void AddItems(Recipe[] recipes)
        {
            using (LiteDatabase db = new LiteDatabase("my.db"))
            {
                var col = db.GetCollection<Recipe>("recipes");
                col.Insert(recipes);
            }
        }

        public int Count(Query query)
        {
            using (LiteDatabase db = new LiteDatabase("my.db"))
            {
                var col = db.GetCollection<Recipe>("recipes");
                return col.Find(query).Count();
            }
        }

        public void Delete(Recipe recipe)
        {
            using (LiteDatabase db = new LiteDatabase("my.db"))
            {
                var col = db.GetCollection<Recipe>("recipes");
                col.Delete(recipe.Id);
            }
        }

        public List<Recipe> Select(Query query)
        {
            using (LiteDatabase db = new LiteDatabase("my.db"))
            {
                var col = db.GetCollection<Recipe>("recipes");
                return col.Find(query).ToList();
            }
        }

        public void Update(Recipe recipe)
        {
            using (LiteDatabase db = new LiteDatabase("my.db"))
            {
                var col = db.GetCollection<Recipe>("recipes");
                col.Update(recipe);
            }
        }
    }
}
