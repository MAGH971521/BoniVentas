using LiteDB;
using ShopModule.Classes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopModule.Classes.Controllers
{
    class CategoryController
    {
        public void Add(Category category)
        {
            using (LiteDatabase db = new LiteDatabase("my.db"))
            {
                var col = db.GetCollection<Category>("brands");
                col.Insert(category);
            }
        }

        public void AddItems(Category[] categories)
        {
            using (LiteDatabase db = new LiteDatabase("my.db"))
            {
                var col = db.GetCollection<Category>("brands");
                col.Insert(categories);
            }
        }

        public void Delete(Category category)
        {
            using (LiteDatabase db = new LiteDatabase("my.db"))
            {
                var col = db.GetCollection<Category>("brands");
                col.Delete(category.Id);
            }
        }

        public List<Category> Select(Query query)
        {
            using (LiteDatabase db = new LiteDatabase("my.db"))
            {
                var col = db.GetCollection<Category>("brands");
                return col.Find(query).ToList();
            }
        }

        public void Update(Category category)
        {
            using (LiteDatabase db = new LiteDatabase("my.db"))
            {
                var col = db.GetCollection<Category>("brands");
                col.Update(category);
            }
        }
    }
}
