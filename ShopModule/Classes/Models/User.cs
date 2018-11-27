using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopModule.Classes.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Pswd { get; set; }
        public string EmailAddress { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public UserType Type { get; set; }
    }
}
