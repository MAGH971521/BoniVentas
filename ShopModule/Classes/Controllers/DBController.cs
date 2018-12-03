using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LiteDB;
using ShopModule.Classes.Models;

namespace ShopModule.Classes.Controllers
{
    class DBController
    {
        private LiteDatabase myDB;
        public DBController(string name="my.db")
        {
            myDB = new LiteDatabase(name);
        }
    }
}
