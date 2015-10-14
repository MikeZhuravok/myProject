using MyProject.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MyProject.Models
{
    public class FashionDbContext : DbContext
    {
        public DbSet<Discount> Discounts { set; get; }
        public DbSet<Product> Products { set; get; }
        public DbSet<UserRole> UserRoles { set; get; }
        public DbSet<UserData> UsersData { set; get; }
        public DbSet<Total> Totals { set; get; }
    }
}