using PizzeriaDomen.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaDomen.EntityFramework
{
    public class EFContext:DbContext
    {
        public EFContext() : base("DbConnection") { }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Order> Orders { get; set; }

    }
}
