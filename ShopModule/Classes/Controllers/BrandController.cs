using LiteDB;
using ShopModule.Classes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopModule.Classes.Controllers
{
    class BrandController
    {
        public void Add(Brand brand)
        {
            using (LiteDatabase db = new LiteDatabase("my.db"))
            {
                var col = db.GetCollection<Brand>("brands");
                col.Insert(brand);
            }
        }

        public void AddItems(Brand[] brands)
        {
            using (LiteDatabase db = new LiteDatabase("my.db"))
            {
                var col = db.GetCollection<Brand>("brands");
                col.Insert(brands);
            }
        }

        public void Delete(Brand brand)
        {
            using (LiteDatabase db = new LiteDatabase("my.db"))
            {
                var col = db.GetCollection<Brand>("brands");
                col.Delete(brand.Id);
            }
        }

        public List<Brand> Select(Query query)
        {
            using (LiteDatabase db = new LiteDatabase("my.db"))
            {
                var col = db.GetCollection<Brand>("brands");
                return col.Find(query).ToList();
            }
        }

        public void Update(Brand brand)
        {
            using (LiteDatabase db = new LiteDatabase("my.db"))
            {
                var col = db.GetCollection<Brand>("brands");
                col.Update(brand);
            }
        }
    }
}
