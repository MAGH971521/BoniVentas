using LiteDB;
using ShopModule.Classes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopModule.Classes.Controllers
{
    class UnitController
    {
        public void Add(Unit unit)
        {
            using (LiteDatabase db = new LiteDatabase("my.db"))
            {
                var col = db.GetCollection<Unit>("brands");
                col.Insert(unit);
            }
        }

        public void AddItems(Unit[] units)
        {
            using (LiteDatabase db = new LiteDatabase("my.db"))
            {
                var col = db.GetCollection<Unit>("brands");
                col.Insert(units);
            }
        }

        public void Delete(Unit unit)
        {
            using (LiteDatabase db = new LiteDatabase("my.db"))
            {
                var col = db.GetCollection<Unit>("brands");
                col.Delete(unit.Id);
            }
        }

        public List<Unit> Select(Query query)
        {
            using (LiteDatabase db = new LiteDatabase("my.db"))
            {
                var col = db.GetCollection<Unit>("brands");
                return col.Find(query).ToList();
            }
        }

        public void Update(Unit unit)
        {
            using (LiteDatabase db = new LiteDatabase("my.db"))
            {
                var col = db.GetCollection<Unit>("brands");
                col.Update(unit);
            }
        }
    }
}
