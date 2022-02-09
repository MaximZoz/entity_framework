using System;
using System.Data.Entity;

namespace ConsoleApplication3
{
    public class BlockDbContext : DbContext
    {
        public BlockDbContext() : base("mssql")
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<General> Generals { get; set; }
    }

    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Login { get; set; }
    }

    public class General
    {
        public Guid Id { get; set; }

        public string Comment { get; set; }
        public string Rating { get; set; }
        public User User { get; set; }
        public Product Product { get; set; }
    }


    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
    }
}