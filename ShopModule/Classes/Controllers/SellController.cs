using LiteDB;
using ShopModule.Classes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopModule.Classes.Controllers
{
    class SellController
    {
        public void Add(Sell sell)
        {
            using (LiteDatabase db = new LiteDatabase("my.db"))
            {
                var col = db.GetCollection<Sell>("sell");
                col.Insert(sell);
            }
        }

        public void AddItems(Sell[] sells)
        {
            using (LiteDatabase db = new LiteDatabase("my.db"))
            {
                var col = db.GetCollection<Sell>("sell");
                col.Insert(sells);
            }
        }

        public void Delete(Sell sell)
        {
            using (LiteDatabase db = new LiteDatabase("my.db"))
            {
                var col = db.GetCollection<Sell>("sell");
                col.Delete(sell.Id);
            }
        }

        public List<Sell> Select(Query query)
        {
            using (LiteDatabase db = new LiteDatabase("my.db"))
            {
                var col = db.GetCollection<Sell>("sell");
                return col.Find(query).ToList();
            }
        }

        public void Update(Sell sell)
        {
            using (LiteDatabase db = new LiteDatabase("my.db"))
            {
                var col = db.GetCollection<Sell>("sell");
                col.Update(sell);
            }
        }
    }
}
