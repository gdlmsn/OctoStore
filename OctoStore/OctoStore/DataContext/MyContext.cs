using Microsoft.EntityFrameworkCore;
using OctoStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OctoStore.DataContext
{
    public class MyContext:DbContext
    {
        public  MyContext(DbContextOptions<MyContext>options): base(options)
        {

        }

        public DbSet<CartItem> CartItem { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderLine> OrderLine { get; set; }
        public DbSet<Picture> Picture { get; set; }
        public DbSet<SubCategory> SubCategory { get; set; }





    }
}
