using LiteDB;
using ShopModule.Classes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopModule.Classes.Controllers
{
    class UserController
    {
        public void Add(User user)
        {
            using (LiteDatabase db = new LiteDatabase("my.db"))
            {
                var col = db.GetCollection<User>("users");
                col.EnsureIndex(x => x.Id, true);
                col.Insert(user);
            }
        }

        public void AddItems(User[] users)
        {
            using (LiteDatabase db = new LiteDatabase("my.db"))
            {
                var col = db.GetCollection<User>("users");
                col.EnsureIndex(x => x.Id, true);
                col.Insert(users);
            }
        }

        public int Count(Query query = null)
        {
            using (LiteDatabase db = new LiteDatabase("my.db"))
            {
                var col = db.GetCollection<User>("users");
                col.EnsureIndex(x => x.Id, true);
                return col.Find(query).Count();
            }
        }

        public void Delete(User user)
        {
            using (LiteDatabase db = new LiteDatabase("my.db"))
            {
                var col = db.GetCollection<User>("users");
                col.EnsureIndex(x => x.Id, true);
                col.Delete(user.Id);
            }
        }

        public int Max(Query query = null)
        {
            using (LiteDatabase db = new LiteDatabase("my.db"))
            {
                var col = db.GetCollection<User>("users");
                col.EnsureIndex(x => x.Id, true);
                return col.Find(query).Max().Id;
            }
        }

        public List<User> Select(Query query = null)
        {
            using (LiteDatabase db = new LiteDatabase("my.db"))
            {
                var col = db.GetCollection<User>("users");
                col.EnsureIndex(x => x.Id, true);
                return col.Find(query).ToList();
            }
        }

        public void Update(User user)
        {
            using (LiteDatabase db = new LiteDatabase("my.db"))
            {
                var col = db.GetCollection<User>("users");
                col.EnsureIndex(x => x.Id, true);
                col.Update(user);
            }
        }
    }
}
