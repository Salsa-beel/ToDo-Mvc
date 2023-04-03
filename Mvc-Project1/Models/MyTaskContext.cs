using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Mvc_Project1.Data;

namespace Mvc_Project1.Models
{
    public class MyTaskContext : DbContext // responsible for creating database
    {
        public MyTaskContext(DbContextOptions<MyTaskContext> options)
            : base(options)
        {

        }

        //public MyTaskContext()
        //{

        //}

        public DbSet<MyTask> MyTask { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ContactUs> Contacts { get; set; }
        public DbSet<User> Users { get; set; }

        
    }

    //public class MyTaskContextContextFactory : IDesignTimeDbContextFactory<MyTaskContext>
    //{
    //    public MyTaskContext CreateDbContext(string[] args)
    //    {
    //        var optionsBuilder = new DbContextOptionsBuilder<MyTaskContext>();
    //        optionsBuilder.UseSqlServer("ToDoListWebsite");

    //        return new MyTaskContext(optionsBuilder.Options);
    //    }

    //}
}


