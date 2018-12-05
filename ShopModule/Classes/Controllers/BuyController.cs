using LiteDB;
using ShopModule.Classes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopModule.Classes.Controllers
{
    class BuyController
    {
        public void Add(Buy buy)
        {
            using (LiteDatabase db = new LiteDatabase("my.db"))
            {
                var col = db.GetCollection<Buy>("buy");
                col.Insert(buy);
            }
        }

        public void AddItems(Buy[] buys)
        {
            using (LiteDatabase db = new LiteDatabase("my.db"))
            {
                var col = db.GetCollection<Buy>("buy");
                col.Insert(buys);
            }
        }

        public int Count(Query query)
        {
            using (LiteDatabase db = new LiteDatabase("my.db"))
            {
                var col = db.GetCollection<Buy>("buy");
                return col.Find(query).Count();
            }
        }

        public void Delete(Buy buy)
        {
            using (LiteDatabase db = new LiteDatabase("my.db"))
            {
                var col = db.GetCollection<Buy>("buy");
                col.Delete(buy.Id);
            }
        }

        public List<Buy> Select(Query query)
        {
            using (LiteDatabase db = new LiteDatabase("my.db"))
            {
                var col = db.GetCollection<Buy>("buy");
                return col.Find(query).ToList();
            }
        }

        public void Update(Buy buy)
        {
            using (LiteDatabase db = new LiteDatabase("my.db"))
            {
                var col = db.GetCollection<Buy>("buy");
                col.Update(buy);
            }
        }
    }
}
