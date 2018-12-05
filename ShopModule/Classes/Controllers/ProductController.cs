using LiteDB;
using ShopModule.Classes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopModule.Classes.Controllers
{
    class ProductController
    {
        public void Add(Product product)
        {
            using (LiteDatabase db = new LiteDatabase("my.db"))
            {
                var col = db.GetCollection<Product>("products");
                col.Insert(product);
            }
        }

        public void AddItems(Product[] products)
        {
            using (LiteDatabase db = new LiteDatabase("my.db"))
            {
                var col = db.GetCollection<Product>("products");
                col.Insert(products);
            }
        }

        public int Count(Query query)
        {
            using (LiteDatabase db = new LiteDatabase("my.db"))
            {
                var col = db.GetCollection<Product>("products");
                return col.Find(query).Count();
            }
        }

        public void Delete(Product product)
        {
            using (LiteDatabase db = new LiteDatabase("my.db"))
            {
                var col = db.GetCollection<Product>("products");
                col.Delete(product.Id);
            }
        }

        public List<Product> Select(Query query)
        {
            using (LiteDatabase db = new LiteDatabase("my.db"))
            {
                var col = db.GetCollection<Product>("products");
                return col.Find(query).ToList();
            }
        }

        public void Update(Product product)
        {
            using (LiteDatabase db = new LiteDatabase("my.db"))
            {
                var col = db.GetCollection<Product>("products");
                col.Update(product);
            }
        }
    }
}
