using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NetAPI_VSC.Models;

namespace NetEcApi.Data
{
    public class DataContext: DbContext
    {
         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["NetApiDbConnection"].ConnectionString);
        }

        public DbSet<SingleProduct> Product { get; set; }
        // public DbSet<Coupon> Coupon { get; set; }
        // public DbSet<User> User { get; set; }
        // public DbSet<Review> Review { get; set; }
        // public DbSet<Order> Order { get; set; }
    }
}

