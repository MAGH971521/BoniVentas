using LiteDB;
using ShopModule.Classes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopModule.Classes.Controllers
{
    class ProviderController
    {
        public void Add(Provider1 provider)
        {
            using (LiteDatabase db = new LiteDatabase("my.db"))
            {
                var col = db.GetCollection<Provider1>("provider");
                col.Insert(provider);
            }
        }

        public void AddItems(Provider1[] providers)
        {
            using (LiteDatabase db = new LiteDatabase("my.db"))
            {
                var col = db.GetCollection<Provider1>("provider");
                col.Insert(providers);
            }
        }

        public int Count(Query query = null)
        {
            using (LiteDatabase db = new LiteDatabase("my.db"))
            {
                var col = db.GetCollection<Provider1>("provider");
                col.EnsureIndex(x => x.Id, true);
                return col.Find(query).Count();
            }
        }

        public void Delete(Provider1 provider)
        {
            using (LiteDatabase db = new LiteDatabase("my.db"))
            {
                var col = db.GetCollection<Provider1>("provider");
                col.Delete(provider.Id);
            }
        }

        public List<Provider1> Select(Query query)
        {
            using (LiteDatabase db = new LiteDatabase("my.db"))
            {
                var col = db.GetCollection<Provider1>("provider");
                return col.Find(query).ToList();
            }
        }

        public void Update(Provider1 provider)
        {
            using (LiteDatabase db = new LiteDatabase("my.db"))
            {
                var col = db.GetCollection<Provider1>("provider");
                col.Update(provider);
            }
        }
    }
}
