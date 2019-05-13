using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaDomen.Entities
{
    public class Context : DbContext
    {
        public Context() : base("WCF_NewUsersDB") { }
        public DbSet<User> users { get; set; }
        public DbSet<Order> orders { get; set; }
        public DbSet<Role> roles { get; set; }
    }
}
