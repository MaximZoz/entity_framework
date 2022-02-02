using System;
using System.Data.Entity;

namespace ConsoleApplication3
{
    public class BlockDbContext : DbContext
    {
        public BlockDbContext() : base("mssql")
        {
        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }

    public class Post
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime? Published { get; set; }
    }

    public class Comment
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string Text { get; set; }
        public virtual Post Post { get; set; }
    }
}