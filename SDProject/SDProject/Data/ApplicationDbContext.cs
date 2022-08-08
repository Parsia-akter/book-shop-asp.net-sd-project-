using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using SDProject.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SDProject.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Category> Category { set; get; }
        public DbSet<Product> Product { set; get; }
        public DbSet<About> About { set; get; }
        public DbSet<Customer> Customer { set; get; }

        public DbSet<User> User { set; get; }
        public DbSet<SliderImages> SliderImages { set; get; }
        public DbSet<Contact> Contact { set; get; }
        public DbSet<Review> Review { set; get; }

        public DbSet<ApplicationUsercs> ApplicationUsercs { set; get; }
        public DbSet<Review1> Review1 { set; get; }
        public DbSet<Order> Order { set; get; }
        public DbSet<OrderDetails> OrderDetails { set; get; }
      // public DbSet<Text> PractiseTable { set; get; }
        public DbSet<Test1> Test1 { set; get; }
        public DbSet<Try> Try { set; get; }
        public DbSet<ReviewTest> ReviewTest { set; get; }
        //public DbSet<Try> Try1 { set; get; }
        public DbSet<Order1> Order1 { set; get; }
        public DbSet<OrderDetails1> OrderDetails1 { set; get; }
        public DbSet<Order2> Order2 { set; get; }
        public DbSet<OrderDetails2> OrderDetails2 { set; get; }



    }
}
